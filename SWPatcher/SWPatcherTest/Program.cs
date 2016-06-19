﻿using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SWPatcher.Helpers;
using SWPatcher.Helpers.GlobalVar;
using System.Security.Principal;

namespace SWPatcher
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 0; i < args.Length; i++)
                MsgBox.Success(String.Format("args[{0}]={1}", i, args[i]));

            if (!IsRunAsAdministrator())
                Methods.RestartAsAdmin(new string[] { UserSettings.ConfigPath });
            else if (args.Length == 2)
                UserSettings.ConfigPath = args[1];

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            if (!Directory.Exists(UserSettings.PatcherPath))
                UserSettings.PatcherPath = "";
            Directory.SetCurrentDirectory(UserSettings.PatcherPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            var controller = new SingleInstanceController();
            controller.Run(args);
        }

        private static bool IsRunAsAdministrator()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Error.Log(e.ExceptionObject as Exception);
            MsgBox.Error(Error.ExeptionParser(e.ExceptionObject as Exception));

            Application.Exit();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Error.Log(e.Exception);
            MsgBox.Error(Error.ExeptionParser(e.Exception));

            Application.Exit();
        }

        private class SingleInstanceController : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
        {
            public SingleInstanceController()
            {
                this.IsSingleInstance = true;
                this.StartupNextInstance += new Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventHandler(SingleInstanceController_StartupNextInstance);
            }

            private void SingleInstanceController_StartupNextInstance(object sender, Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs e)
            {
                var mainForm = this.MainForm as SWPatcher.Forms.MainForm;
                mainForm.RestoreFromTray();
            }

            protected override void OnCreateMainForm()
            {
                this.MainForm = new SWPatcher.Forms.MainForm();
            }
        }
    }
}