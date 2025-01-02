namespace IsaacBot
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendMessageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.chkMultiCommand = new System.Windows.Forms.CheckBox();
            this.chkSpamControl = new System.Windows.Forms.CheckBox();
            this.chkMultiplier = new System.Windows.Forms.CheckBox();
            this.grpTwitch = new System.Windows.Forms.GroupBox();
            this.lblAuthCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.grpTwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendMessageTextBox);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Size = new System.Drawing.Size(572, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Chat Message";
            // 
            // sendMessageTextBox
            // 
            this.sendMessageTextBox.Location = new System.Drawing.Point(9, 26);
            this.sendMessageTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.sendMessageTextBox.Name = "sendMessageTextBox";
            this.sendMessageTextBox.Size = new System.Drawing.Size(547, 25);
            this.sendMessageTextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(212, 59);
            this.sendButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(138, 30);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(384, 163);
            this.consoleTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.Size = new System.Drawing.Size(588, 142);
            this.consoleTextBox.TabIndex = 1;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(381, 142);
            this.consoleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(156, 17);
            this.consoleLabel.TabIndex = 2;
            this.consoleLabel.Text = "Console Output";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.chkMultiCommand);
            this.grpSettings.Controls.Add(this.chkSpamControl);
            this.grpSettings.Controls.Add(this.chkMultiplier);
            this.grpSettings.Location = new System.Drawing.Point(605, 13);
            this.grpSettings.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpSettings.Size = new System.Drawing.Size(367, 122);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // chkMultiCommand
            // 
            this.chkMultiCommand.AutoSize = true;
            this.chkMultiCommand.Location = new System.Drawing.Point(9, 79);
            this.chkMultiCommand.Name = "chkMultiCommand";
            this.chkMultiCommand.Size = new System.Drawing.Size(174, 21);
            this.chkMultiCommand.TabIndex = 2;
            this.chkMultiCommand.Text = "Multi-Command";
            this.chkMultiCommand.UseVisualStyleBackColor = true;
            // 
            // chkSpamControl
            // 
            this.chkSpamControl.AutoSize = true;
            this.chkSpamControl.Location = new System.Drawing.Point(9, 52);
            this.chkSpamControl.Name = "chkSpamControl";
            this.chkSpamControl.Size = new System.Drawing.Size(156, 21);
            this.chkSpamControl.TabIndex = 1;
            this.chkSpamControl.Text = "Spam Control";
            this.chkSpamControl.UseVisualStyleBackColor = true;
            // 
            // chkMultiplier
            // 
            this.chkMultiplier.AutoSize = true;
            this.chkMultiplier.Location = new System.Drawing.Point(9, 25);
            this.chkMultiplier.Name = "chkMultiplier";
            this.chkMultiplier.Size = new System.Drawing.Size(136, 21);
            this.chkMultiplier.TabIndex = 0;
            this.chkMultiplier.Text = "Multiplier";
            this.chkMultiplier.UseVisualStyleBackColor = true;
            // 
            // grpTwitch
            // 
            this.grpTwitch.Controls.Add(this.lblAuthCode);
            this.grpTwitch.Controls.Add(this.textBox1);
            this.grpTwitch.Controls.Add(this.lblUserName);
            this.grpTwitch.Controls.Add(this.btnStart);
            this.grpTwitch.Controls.Add(this.textBox2);
            this.grpTwitch.Controls.Add(this.btnShowHide);
            this.grpTwitch.Controls.Add(this.txtChannel);
            this.grpTwitch.Controls.Add(this.lblChannel);
            this.grpTwitch.Location = new System.Drawing.Point(22, 142);
            this.grpTwitch.Name = "grpTwitch";
            this.grpTwitch.Size = new System.Drawing.Size(350, 163);
            this.grpTwitch.TabIndex = 5;
            this.grpTwitch.TabStop = false;
            this.grpTwitch.Text = "Twitch Connector";
            // 
            // lblAuthCode
            // 
            this.lblAuthCode.AutoSize = true;
            this.lblAuthCode.Location = new System.Drawing.Point(11, 131);
            this.lblAuthCode.Name = "lblAuthCode";
            this.lblAuthCode.Size = new System.Drawing.Size(102, 17);
            this.lblAuthCode.TabIndex = 13;
            this.lblAuthCode.Text = "Auth Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(209, 25);
            this.textBox1.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(11, 100);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 17);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "User Name";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 30);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(209, 25);
            this.textBox2.TabIndex = 11;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(207, 30);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(124, 30);
            this.btnShowHide.TabIndex = 7;
            this.btnShowHide.Text = "Show";
            this.btnShowHide.UseVisualStyleBackColor = true;
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(122, 66);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.PasswordChar = '*';
            this.txtChannel.Size = new System.Drawing.Size(209, 25);
            this.txtChannel.TabIndex = 8;
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(11, 69);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(85, 17);
            this.lblChannel.TabIndex = 9;
            this.lblChannel.Text = "Channel";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 327);
            this.Controls.Add(this.grpTwitch);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Upheaval TT (BRK)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "mainForm";
            this.Text = "Isaac Bot 2.0";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpTwitch.ResumeLayout(false);
            this.grpTwitch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendMessageTextBox;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.CheckBox chkMultiplier;
        private System.Windows.Forms.CheckBox chkMultiCommand;
        private System.Windows.Forms.CheckBox chkSpamControl;
        private System.Windows.Forms.GroupBox grpTwitch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblAuthCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox textBox2;
    }
}

