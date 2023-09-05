namespace AsyncSocket
{
    partial class Form1
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
            this.btnAcceptIncomingAsync = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSenndAll = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcceptIncomingAsync
            // 
            this.btnAcceptIncomingAsync.Location = new System.Drawing.Point(67, 233);
            this.btnAcceptIncomingAsync.Name = "btnAcceptIncomingAsync";
            this.btnAcceptIncomingAsync.Size = new System.Drawing.Size(258, 29);
            this.btnAcceptIncomingAsync.TabIndex = 0;
            this.btnAcceptIncomingAsync.Text = "Accept Incoming Connections";
            this.btnAcceptIncomingAsync.UseVisualStyleBackColor = true;
            this.btnAcceptIncomingAsync.Click += new System.EventHandler(this.btnAcceptIncomingAsync_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(522, 235);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(141, 27);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "Message for client!";
            // 
            // btnSenndAll
            // 
            this.btnSenndAll.Location = new System.Drawing.Point(335, 233);
            this.btnSenndAll.Name = "btnSenndAll";
            this.btnSenndAll.Size = new System.Drawing.Size(94, 29);
            this.btnSenndAll.TabIndex = 2;
            this.btnSenndAll.Text = "Send All";
            this.btnSenndAll.UseVisualStyleBackColor = true;
            this.btnSenndAll.Click += new System.EventHandler(this.btnSenndAll_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(446, 237);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(70, 20);
            this.msg.TabIndex = 3;
            this.msg.Text = "Message:";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(67, 290);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(258, 29);
            this.btnStopServer.TabIndex = 4;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(13, 12);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(753, 215);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.btnSenndAll);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnAcceptIncomingAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAcceptIncomingAsync;
        private TextBox txtMessage;
        private Button btnSenndAll;
        private Label msg;
        private Button btnStopServer;
        private TextBox txtConsole;
    }
}