namespace CustomLauncher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnWpsOffice = new System.Windows.Forms.Button();
            this.btnTallyDev = new System.Windows.Forms.Button();
            this.btnTally = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnChrome = new System.Windows.Forms.Button();
            this.btnChatGPT = new System.Windows.Forms.Button();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.topPanel.Controls.Add(this.btnRestart);
            this.topPanel.Controls.Add(this.btnShutdown);
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(300, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(220, 5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(35, 30);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "\uE72C";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Location = new System.Drawing.Point(260, 5);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(35, 30);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.Text = "\uE7E8";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.BtnShutdown_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MV Solutions";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.mainPanel.Controls.Add(this.btnControlPanel);
            this.mainPanel.Controls.Add(this.btnNotepad);
            this.mainPanel.Controls.Add(this.btnWpsOffice);
            this.mainPanel.Controls.Add(this.btnChrome);
            this.mainPanel.Controls.Add(this.btnChatGPT);
            this.mainPanel.Controls.Add(this.btnTallyDev);
            this.mainPanel.Controls.Add(this.btnTally);
            this.mainPanel.Controls.Add(this.btnData);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(300, 410);
            this.mainPanel.TabIndex = 1;
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlPanel.FlatAppearance.BorderSize = 0;
            this.btnControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlPanel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnControlPanel.ForeColor = System.Drawing.Color.White;
            this.btnControlPanel.Location = new System.Drawing.Point(10, 250);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Size = new System.Drawing.Size(280, 50);
            this.btnControlPanel.TabIndex = 4;
            this.btnControlPanel.Text = "⚙️ Control Panel";
            this.btnControlPanel.UseVisualStyleBackColor = false;
            this.btnControlPanel.Click += new System.EventHandler(this.BtnControlPanel_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNotepad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotepad.FlatAppearance.BorderSize = 0;
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotepad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotepad.ForeColor = System.Drawing.Color.White;
            this.btnNotepad.Location = new System.Drawing.Point(10, 190);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(280, 50);
            this.btnNotepad.TabIndex = 3;
            this.btnNotepad.Text = "📄 Notepad";
            this.btnNotepad.UseVisualStyleBackColor = false;
            this.btnNotepad.Click += new System.EventHandler(this.BtnNotepad_Click);
            // 
            // btnWpsOffice
            // 
            this.btnWpsOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnWpsOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWpsOffice.FlatAppearance.BorderSize = 0;
            this.btnWpsOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWpsOffice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWpsOffice.ForeColor = System.Drawing.Color.White;
            this.btnWpsOffice.Location = new System.Drawing.Point(10, 130);
            this.btnWpsOffice.Name = "btnWpsOffice";
            this.btnWpsOffice.Size = new System.Drawing.Size(280, 50);
            this.btnWpsOffice.TabIndex = 2;
            this.btnWpsOffice.Text = "📝 WPS Office";
            this.btnWpsOffice.UseVisualStyleBackColor = false;
            this.btnWpsOffice.Click += new System.EventHandler(this.BtnWpsOffice_Click);
            // 
            // btnChrome
            // 
            this.btnChrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChrome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChrome.FlatAppearance.BorderSize = 0;
            this.btnChrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChrome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChrome.ForeColor = System.Drawing.Color.White;
            this.btnChrome.Location = new System.Drawing.Point(10, 130);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(280, 50);
            this.btnChrome.TabIndex = 2;
            this.btnChrome.Text = "🌐 Google Chrome";
            this.btnChrome.UseVisualStyleBackColor = false;
            this.btnChrome.Click += new System.EventHandler(this.BtnChrome_Click);
            // 
            // btnChatGPT
            // 
            this.btnChatGPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChatGPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChatGPT.FlatAppearance.BorderSize = 0;
            this.btnChatGPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatGPT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChatGPT.ForeColor = System.Drawing.Color.White;
            this.btnChatGPT.Location = new System.Drawing.Point(10, 130);
            this.btnChatGPT.Name = "btnChatGPT";
            this.btnChatGPT.Size = new System.Drawing.Size(280, 50);
            this.btnChatGPT.TabIndex = 2;
            this.btnChatGPT.Text = "🤖 ChatGPT";
            this.btnChatGPT.UseVisualStyleBackColor = false;
            this.btnChatGPT.Click += new System.EventHandler(this.BtnChatGPT_Click);
            // 
            // btnTallyDev
            // 
            this.btnTallyDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTallyDev.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTallyDev.FlatAppearance.BorderSize = 0;
            this.btnTallyDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTallyDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTallyDev.ForeColor = System.Drawing.Color.White;
            this.btnTallyDev.Location = new System.Drawing.Point(10, 70);
            this.btnTallyDev.Name = "btnTallyDev";
            this.btnTallyDev.Size = new System.Drawing.Size(280, 50);
            this.btnTallyDev.TabIndex = 1;
            this.btnTallyDev.Text = "📊 Start Tally Developer";
            this.btnTallyDev.UseVisualStyleBackColor = false;
            this.btnTallyDev.Click += new System.EventHandler(this.BtnTallyDev_Click);
            // 
            // btnTally
            // 
            this.btnTally.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTally.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTally.FlatAppearance.BorderSize = 0;
            this.btnTally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTally.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTally.ForeColor = System.Drawing.Color.White;
            this.btnTally.Location = new System.Drawing.Point(10, 10);
            this.btnTally.Name = "btnTally";
            this.btnTally.Size = new System.Drawing.Size(280, 50);
            this.btnTally.TabIndex = 0;
            this.btnTally.Text = "📊 Start Tally";
            this.btnTally.UseVisualStyleBackColor = false;
            this.btnTally.Click += new System.EventHandler(this.BtnTally_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Location = new System.Drawing.Point(10, 10);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(280, 50);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "📁 Data Folder";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 20;
            this.slideTimer.Tick += new System.EventHandler(this.SlideTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Launcher";
            this.TopMost = true;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnTally;
        private System.Windows.Forms.Button btnTallyDev;
        private System.Windows.Forms.Button btnWpsOffice;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnChrome;
        private System.Windows.Forms.Button btnChatGPT;
        private System.Windows.Forms.Timer slideTimer;
    }
}
