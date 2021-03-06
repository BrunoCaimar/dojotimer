﻿namespace DojoTimer
{
    partial class OptionsForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.WorkingDirectoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ScriptInput = new System.Windows.Forms.TextBox();
            this.ShortcutInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondsInput = new System.Windows.Forms.TextBox();
            this.MinutesInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CommitScript = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ParticipantsInput = new System.Windows.Forms.TextBox();
            this.KeepTrackInput = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.formTitleBar1 = new DojoTimer.FormTitleBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(505, 482);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(178, 43);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = Mono.Unix.Catalog.GetString("Close");
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 410);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BrowseButton);
            this.tabPage1.Controls.Add(this.WorkingDirectoryInput);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ScriptInput);
            this.tabPage1.Controls.Add(this.ShortcutInput);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SecondsInput);
            this.tabPage1.Controls.Add(this.MinutesInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = Mono.Unix.Catalog.GetString("Options");
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.BackColor = System.Drawing.Color.White;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Location = new System.Drawing.Point(615, 93);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(42, 31);
            this.BrowseButton.TabIndex = 11;
            this.BrowseButton.Text = Mono.Unix.Catalog.GetString("...");
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // WorkingDirectoryInput
            // 
            this.WorkingDirectoryInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkingDirectoryInput.BackColor = System.Drawing.Color.White;
            this.WorkingDirectoryInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkingDirectoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingDirectoryInput.Location = new System.Drawing.Point(6, 93);
            this.WorkingDirectoryInput.Name = "WorkingDirectoryInput";
            this.WorkingDirectoryInput.Size = new System.Drawing.Size(603, 31);
            this.WorkingDirectoryInput.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = Mono.Unix.Catalog.GetString("Working Directory:");
            // 
            // ScriptInput
            // 
            this.ScriptInput.AcceptsReturn = true;
            this.ScriptInput.AcceptsTab = true;
            this.ScriptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptInput.Location = new System.Drawing.Point(6, 217);
            this.ScriptInput.Multiline = true;
            this.ScriptInput.Name = "ScriptInput";
            this.ScriptInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScriptInput.Size = new System.Drawing.Size(651, 152);
            this.ScriptInput.TabIndex = 16;
            // 
            // ShortcutInput
            // 
            this.ShortcutInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortcutInput.BackColor = System.Drawing.Color.White;
            this.ShortcutInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShortcutInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortcutInput.Location = new System.Drawing.Point(6, 155);
            this.ShortcutInput.Name = "ShortcutInput";
            this.ShortcutInput.ReadOnly = true;
            this.ShortcutInput.Size = new System.Drawing.Size(651, 31);
            this.ShortcutInput.TabIndex = 15;
            this.ShortcutInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortcutInput_KeyDown);
            this.ShortcutInput.Leave += new System.EventHandler(this.ShortcutInput_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = Mono.Unix.Catalog.GetString("Shortcut:");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = Mono.Unix.Catalog.GetString("Script:");
            // 
            // SecondsInput
            // 
            this.SecondsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsInput.Location = new System.Drawing.Point(96, 31);
            this.SecondsInput.Name = "SecondsInput";
            this.SecondsInput.Size = new System.Drawing.Size(84, 31);
            this.SecondsInput.TabIndex = 12;
            // 
            // MinutesInput
            // 
            this.MinutesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinutesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesInput.Location = new System.Drawing.Point(6, 31);
            this.MinutesInput.Name = "MinutesInput";
            this.MinutesInput.Size = new System.Drawing.Size(84, 31);
            this.MinutesInput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = Mono.Unix.Catalog.GetString("Time:");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CommitScript);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ParticipantsInput);
            this.tabPage2.Controls.Add(this.KeepTrackInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = Mono.Unix.Catalog.GetString("People");
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CommitScript
            // 
            this.CommitScript.AcceptsReturn = true;
            this.CommitScript.AcceptsTab = true;
            this.CommitScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommitScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitScript.Location = new System.Drawing.Point(8, 215);
            this.CommitScript.Multiline = true;
            this.CommitScript.Name = "CommitScript";
            this.CommitScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommitScript.Size = new System.Drawing.Size(646, 157);
            this.CommitScript.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = Mono.Unix.Catalog.GetString("Commit script:");
            // 
            // ParticipantsInput
            // 
            this.ParticipantsInput.AcceptsReturn = true;
            this.ParticipantsInput.AcceptsTab = true;
            this.ParticipantsInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticipantsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParticipantsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantsInput.Location = new System.Drawing.Point(6, 41);
            this.ParticipantsInput.Multiline = true;
            this.ParticipantsInput.Name = "ParticipantsInput";
            this.ParticipantsInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ParticipantsInput.Size = new System.Drawing.Size(646, 143);
            this.ParticipantsInput.TabIndex = 17;
            // 
            // KeepTrackInput
            // 
            this.KeepTrackInput.AutoSize = true;
            this.KeepTrackInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeepTrackInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeepTrackInput.Location = new System.Drawing.Point(6, 6);
            this.KeepTrackInput.Name = "KeepTrackInput";
            this.KeepTrackInput.Size = new System.Drawing.Size(318, 29);
            this.KeepTrackInput.TabIndex = 0;
            this.KeepTrackInput.Text = Mono.Unix.Catalog.GetString("Keep track of who participated");
            this.KeepTrackInput.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.White;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(321, 482);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(178, 43);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = Mono.Unix.Catalog.GetString("Reset");
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // formTitleBar1
            // 
            this.formTitleBar1.BackColor = System.Drawing.Color.White;
            this.formTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTitleBar1.ForeColor = System.Drawing.Color.Black;
            this.formTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.formTitleBar1.Name = "formTitleBar1";
            this.formTitleBar1.Size = new System.Drawing.Size(695, 60);
            this.formTitleBar1.TabIndex = 9;
            this.formTitleBar1.TitleDescription = Mono.Unix.Catalog.GetString("Change whatever you want. Then close me. That\'s it.");
            this.formTitleBar1.TitleIcon = "@";
            this.formTitleBar1.TitleText = Mono.Unix.Catalog.GetString("How should I behave?");
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 534);
            this.ControlBox = false;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.formTitleBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ScriptInput;
        private System.Windows.Forms.TextBox ShortcutInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondsInput;
        private System.Windows.Forms.TextBox MinutesInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ParticipantsInput;
        private System.Windows.Forms.CheckBox KeepTrackInput;
        private System.Windows.Forms.TextBox CommitScript;
        private System.Windows.Forms.Label label4;
        private FormTitleBar formTitleBar1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox WorkingDirectoryInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolder;

    }
}