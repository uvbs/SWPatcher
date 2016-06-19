﻿namespace SWPatcher.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGame = new System.Windows.Forms.TabPage();
            this.groupBoxPatchExe = new System.Windows.Forms.GroupBox();
            this.checkBoxPatchExe = new System.Windows.Forms.CheckBox();
            this.groupBoxGameDirectory = new System.Windows.Forms.GroupBox();
            this.buttonGameChangeDirectory = new System.Windows.Forms.Button();
            this.textBoxGameDirectory = new System.Windows.Forms.TextBox();
            this.tabPagePatcher = new System.Windows.Forms.TabPage();
            this.groupBoxPatcherDirectory = new System.Windows.Forms.GroupBox();
            this.buttonPatcherChangeDirectory = new System.Windows.Forms.Button();
            this.textBoxPatcherDirectory = new System.Windows.Forms.TextBox();
            this.groupBoxRunas = new System.Windows.Forms.GroupBox();
            this.checkBoxRunas = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGame.SuspendLayout();
            this.groupBoxPatchExe.SuspendLayout();
            this.groupBoxGameDirectory.SuspendLayout();
            this.tabPagePatcher.SuspendLayout();
            this.groupBoxPatcherDirectory.SuspendLayout();
            this.groupBoxRunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Controls.Add(this.buttonApply, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonCancel, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonOk, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(320, 191);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(242, 163);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(161, 163);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(80, 163);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tabControl
            // 
            this.tableLayoutPanel.SetColumnSpan(this.tabControl, 4);
            this.tabControl.Controls.Add(this.tabPageGame);
            this.tabControl.Controls.Add(this.tabPagePatcher);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(314, 154);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageGame
            // 
            this.tabPageGame.Controls.Add(this.groupBoxPatchExe);
            this.tabPageGame.Controls.Add(this.groupBoxGameDirectory);
            this.tabPageGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageGame.Name = "tabPageGame";
            this.tabPageGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGame.Size = new System.Drawing.Size(306, 128);
            this.tabPageGame.TabIndex = 0;
            this.tabPageGame.Text = "Soulworker";
            this.tabPageGame.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatchExe
            // 
            this.groupBoxPatchExe.AutoSize = true;
            this.groupBoxPatchExe.Controls.Add(this.checkBoxPatchExe);
            this.groupBoxPatchExe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPatchExe.Location = new System.Drawing.Point(3, 64);
            this.groupBoxPatchExe.Name = "groupBoxPatchExe";
            this.groupBoxPatchExe.Size = new System.Drawing.Size(300, 61);
            this.groupBoxPatchExe.TabIndex = 2;
            this.groupBoxPatchExe.TabStop = false;
            this.groupBoxPatchExe.Text = "Patching .exe to support other unicode languages";
            // 
            // checkBoxPatchExe
            // 
            this.checkBoxPatchExe.AutoSize = true;
            this.checkBoxPatchExe.Location = new System.Drawing.Point(6, 25);
            this.checkBoxPatchExe.Name = "checkBoxPatchExe";
            this.checkBoxPatchExe.Size = new System.Drawing.Size(253, 17);
            this.checkBoxPatchExe.TabIndex = 2;
            this.checkBoxPatchExe.Text = "Yes, I am aware of the risks and want to patch it";
            this.checkBoxPatchExe.UseVisualStyleBackColor = true;
            this.checkBoxPatchExe.CheckedChanged += new System.EventHandler(this.checkBoxPatchExe_CheckedChanged);
            // 
            // groupBoxGameDirectory
            // 
            this.groupBoxGameDirectory.AutoSize = true;
            this.groupBoxGameDirectory.Controls.Add(this.buttonGameChangeDirectory);
            this.groupBoxGameDirectory.Controls.Add(this.textBoxGameDirectory);
            this.groupBoxGameDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGameDirectory.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGameDirectory.Name = "groupBoxGameDirectory";
            this.groupBoxGameDirectory.Size = new System.Drawing.Size(300, 61);
            this.groupBoxGameDirectory.TabIndex = 0;
            this.groupBoxGameDirectory.TabStop = false;
            this.groupBoxGameDirectory.Text = "Game location";
            // 
            // buttonGameChangeDirectory
            // 
            this.buttonGameChangeDirectory.Location = new System.Drawing.Point(219, 19);
            this.buttonGameChangeDirectory.Name = "buttonGameChangeDirectory";
            this.buttonGameChangeDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonGameChangeDirectory.TabIndex = 1;
            this.buttonGameChangeDirectory.Text = "Change";
            this.buttonGameChangeDirectory.UseVisualStyleBackColor = true;
            this.buttonGameChangeDirectory.Click += new System.EventHandler(this.buttonChangeDirectory_Click);
            // 
            // textBoxGameDirectory
            // 
            this.textBoxGameDirectory.Location = new System.Drawing.Point(6, 21);
            this.textBoxGameDirectory.Name = "textBoxGameDirectory";
            this.textBoxGameDirectory.ReadOnly = true;
            this.textBoxGameDirectory.Size = new System.Drawing.Size(207, 20);
            this.textBoxGameDirectory.TabIndex = 0;
            // 
            // tabPagePatcher
            // 
            this.tabPagePatcher.Controls.Add(this.groupBoxRunas);
            this.tabPagePatcher.Controls.Add(this.groupBoxPatcherDirectory);
            this.tabPagePatcher.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatcher.Name = "tabPagePatcher";
            this.tabPagePatcher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatcher.Size = new System.Drawing.Size(306, 128);
            this.tabPagePatcher.TabIndex = 1;
            this.tabPagePatcher.Text = "Patcher";
            this.tabPagePatcher.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatcherDirectory
            // 
            this.groupBoxPatcherDirectory.AutoSize = true;
            this.groupBoxPatcherDirectory.Controls.Add(this.buttonPatcherChangeDirectory);
            this.groupBoxPatcherDirectory.Controls.Add(this.textBoxPatcherDirectory);
            this.groupBoxPatcherDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPatcherDirectory.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatcherDirectory.Name = "groupBoxPatcherDirectory";
            this.groupBoxPatcherDirectory.Size = new System.Drawing.Size(300, 61);
            this.groupBoxPatcherDirectory.TabIndex = 2;
            this.groupBoxPatcherDirectory.TabStop = false;
            this.groupBoxPatcherDirectory.Text = "Patcher location";
            // 
            // buttonPatcherChangeDirectory
            // 
            this.buttonPatcherChangeDirectory.Location = new System.Drawing.Point(219, 19);
            this.buttonPatcherChangeDirectory.Name = "buttonPatcherChangeDirectory";
            this.buttonPatcherChangeDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonPatcherChangeDirectory.TabIndex = 1;
            this.buttonPatcherChangeDirectory.Text = "Change";
            this.buttonPatcherChangeDirectory.UseVisualStyleBackColor = true;
            // 
            // textBoxPatcherDirectory
            // 
            this.textBoxPatcherDirectory.Location = new System.Drawing.Point(6, 21);
            this.textBoxPatcherDirectory.Name = "textBoxPatcherDirectory";
            this.textBoxPatcherDirectory.ReadOnly = true;
            this.textBoxPatcherDirectory.Size = new System.Drawing.Size(207, 20);
            this.textBoxPatcherDirectory.TabIndex = 0;
            // 
            // groupBoxRunas
            // 
            this.groupBoxRunas.AutoSize = true;
            this.groupBoxRunas.Controls.Add(this.checkBoxRunas);
            this.groupBoxRunas.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRunas.Location = new System.Drawing.Point(3, 64);
            this.groupBoxRunas.Name = "groupBoxRunas";
            this.groupBoxRunas.Size = new System.Drawing.Size(300, 61);
            this.groupBoxRunas.TabIndex = 3;
            this.groupBoxRunas.TabStop = false;
            this.groupBoxRunas.Text = "Restart the patcher as admin on startup";
            // 
            // checkBoxRunas
            // 
            this.checkBoxRunas.AutoSize = true;
            this.checkBoxRunas.Location = new System.Drawing.Point(6, 25);
            this.checkBoxRunas.Name = "checkBoxRunas";
            this.checkBoxRunas.Size = new System.Drawing.Size(130, 17);
            this.checkBoxRunas.TabIndex = 2;
            this.checkBoxRunas.Text = "Run patcher as admin";
            this.checkBoxRunas.UseVisualStyleBackColor = true;
            this.checkBoxRunas.CheckedChanged += new System.EventHandler(this.checkBoxRunas_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 191);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageGame.ResumeLayout(false);
            this.tabPageGame.PerformLayout();
            this.groupBoxPatchExe.ResumeLayout(false);
            this.groupBoxPatchExe.PerformLayout();
            this.groupBoxGameDirectory.ResumeLayout(false);
            this.groupBoxGameDirectory.PerformLayout();
            this.tabPagePatcher.ResumeLayout(false);
            this.tabPagePatcher.PerformLayout();
            this.groupBoxPatcherDirectory.ResumeLayout(false);
            this.groupBoxPatcherDirectory.PerformLayout();
            this.groupBoxRunas.ResumeLayout(false);
            this.groupBoxRunas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGame;
        private System.Windows.Forms.GroupBox groupBoxGameDirectory;
        private System.Windows.Forms.Button buttonGameChangeDirectory;
        private System.Windows.Forms.TextBox textBoxGameDirectory;
        private System.Windows.Forms.GroupBox groupBoxPatchExe;
        private System.Windows.Forms.CheckBox checkBoxPatchExe;
        private System.Windows.Forms.TabPage tabPagePatcher;
        private System.Windows.Forms.GroupBox groupBoxRunas;
        private System.Windows.Forms.CheckBox checkBoxRunas;
        private System.Windows.Forms.GroupBox groupBoxPatcherDirectory;
        private System.Windows.Forms.Button buttonPatcherChangeDirectory;
        private System.Windows.Forms.TextBox textBoxPatcherDirectory;
    }
}