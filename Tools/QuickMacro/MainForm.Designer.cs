namespace QuickMacro
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.playHotkeyBox = new ManagedWinapi.ShortcutBox();
            this.recHotkeyBox = new ManagedWinapi.ShortcutBox();
            this.recHotkey = new ManagedWinapi.Hotkey(this.components);
            this.playHotkey = new ManagedWinapi.Hotkey(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record/Pause Hotkey:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finish/Play Hotkey:";
            // 
            // hide
            // 
            this.hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hide.Location = new System.Drawing.Point(208, 64);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(75, 23);
            this.hide.TabIndex = 4;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // set
            // 
            this.set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set.Location = new System.Drawing.Point(127, 64);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(75, 23);
            this.set.TabIndex = 5;
            this.set.Text = "Set &Hotkeys";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // playHotkeyBox
            // 
            this.playHotkeyBox.Alt = false;
            this.playHotkeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.playHotkeyBox.Ctrl = false;
            this.playHotkeyBox.KeyCode = System.Windows.Forms.Keys.F4;
            this.playHotkeyBox.Location = new System.Drawing.Point(135, 38);
            this.playHotkeyBox.Name = "playHotkeyBox";
            this.playHotkeyBox.Shift = false;
            this.playHotkeyBox.Size = new System.Drawing.Size(148, 20);
            this.playHotkeyBox.TabIndex = 3;
            this.playHotkeyBox.Text = "Windows + F4";
            this.playHotkeyBox.WindowsKey = true;
            // 
            // recHotkeyBox
            // 
            this.recHotkeyBox.Alt = false;
            this.recHotkeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recHotkeyBox.Ctrl = false;
            this.recHotkeyBox.KeyCode = System.Windows.Forms.Keys.F3;
            this.recHotkeyBox.Location = new System.Drawing.Point(135, 12);
            this.recHotkeyBox.Name = "recHotkeyBox";
            this.recHotkeyBox.Shift = false;
            this.recHotkeyBox.Size = new System.Drawing.Size(148, 20);
            this.recHotkeyBox.TabIndex = 2;
            this.recHotkeyBox.Text = "Windows + F3";
            this.recHotkeyBox.WindowsKey = true;
            // 
            // recHotkey
            // 
            this.recHotkey.Alt = false;
            this.recHotkey.Ctrl = false;
            this.recHotkey.Enabled = false;
            this.recHotkey.KeyCode = System.Windows.Forms.Keys.None;
            this.recHotkey.Shift = false;
            this.recHotkey.WindowsKey = false;
            this.recHotkey.HotkeyPressed += new System.EventHandler(this.recHotkey_HotkeyPressed);
            // 
            // playHotkey
            // 
            this.playHotkey.Alt = false;
            this.playHotkey.Ctrl = false;
            this.playHotkey.Enabled = false;
            this.playHotkey.KeyCode = System.Windows.Forms.Keys.None;
            this.playHotkey.Shift = false;
            this.playHotkey.WindowsKey = false;
            this.playHotkey.HotkeyPressed += new System.EventHandler(this.playHotkey_HotkeyPressed);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.trayIcon.Text = "QuickMacro";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.toolStripSeparator1,
            this.recordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 54);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.configureToolStripMenuItem.Text = "Configure...";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.recordToolStripMenuItem.Text = "Exit";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.hide;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.hide;
            this.ClientSize = new System.Drawing.Size(295, 99);
            this.Controls.Add(this.set);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.playHotkeyBox);
            this.Controls.Add(this.recHotkeyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QuickMacro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ManagedWinapi.ShortcutBox recHotkeyBox;
        private ManagedWinapi.ShortcutBox playHotkeyBox;
        private System.Windows.Forms.Button hide;
        private ManagedWinapi.Hotkey recHotkey;
        private ManagedWinapi.Hotkey playHotkey;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;

    }
}

