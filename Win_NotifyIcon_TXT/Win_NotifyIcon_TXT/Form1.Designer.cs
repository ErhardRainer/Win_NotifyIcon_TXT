namespace Win_NotifyIcon_TXT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.Datei = new System.Windows.Forms.Label();
            this.cmd_SelectFile = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "     private void trayIcon_MouseEnter(object sender, EventArgs e)";
            this.trayIcon.BalloonTipTitle = "twtwtrwtrwtr";
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Win_NotifyIcon_TXT";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseEnter);
            this.trayIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(79, 10);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(566, 20);
            this.txt_Path.TabIndex = 1;
            // 
            // Datei
            // 
            this.Datei.AutoSize = true;
            this.Datei.Location = new System.Drawing.Point(13, 13);
            this.Datei.Name = "Datei";
            this.Datei.Size = new System.Drawing.Size(32, 13);
            this.Datei.TabIndex = 2;
            this.Datei.Text = "Datei";
            // 
            // cmd_SelectFile
            // 
            this.cmd_SelectFile.Location = new System.Drawing.Point(651, 8);
            this.cmd_SelectFile.Name = "cmd_SelectFile";
            this.cmd_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.cmd_SelectFile.TabIndex = 3;
            this.cmd_SelectFile.Text = "File";
            this.cmd_SelectFile.UseVisualStyleBackColor = true;
            this.cmd_SelectFile.Click += new System.EventHandler(this.cmd_SelectFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 40);
            this.Controls.Add(this.cmd_SelectFile);
            this.Controls.Add(this.Datei);
            this.Controls.Add(this.txt_Path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Win_NotifyIcon_TXT";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label Datei;
        private System.Windows.Forms.Button cmd_SelectFile;
    }
}

