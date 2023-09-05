namespace TCPServer01
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
            this.tbConsoleOutput = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartlistening = new System.Windows.Forms.Button();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFindIPV4IP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Location = new System.Drawing.Point(0, 0);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.Size = new System.Drawing.Size(769, 349);
            this.tbConsoleOutput.TabIndex = 0;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(83, 355);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(229, 27);
            this.tbIPAddress.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(327, 355);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(125, 27);
            this.tbPort.TabIndex = 2;
            this.tbPort.Text = "23000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP/Port:";
            // 
            // btnStartlistening
            // 
            this.btnStartlistening.Location = new System.Drawing.Point(83, 400);
            this.btnStartlistening.Name = "btnStartlistening";
            this.btnStartlistening.Size = new System.Drawing.Size(229, 29);
            this.btnStartlistening.TabIndex = 4;
            this.btnStartlistening.Text = "Start listening";
            this.btnStartlistening.UseVisualStyleBackColor = true;
            this.btnStartlistening.Click += new System.EventHandler(this.btnStartlistening_Click);
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(570, 358);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(125, 27);
            this.tbPayload.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(601, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFindIPV4IP
            // 
            this.btnFindIPV4IP.Location = new System.Drawing.Point(327, 400);
            this.btnFindIPV4IP.Name = "btnFindIPV4IP";
            this.btnFindIPV4IP.Size = new System.Drawing.Size(94, 29);
            this.btnFindIPV4IP.TabIndex = 7;
            this.btnFindIPV4IP.Text = "find ip";
            this.btnFindIPV4IP.UseVisualStyleBackColor = true;
            this.btnFindIPV4IP.Click += new System.EventHandler(this.btnFindIPV4IP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindIPV4IP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbPayload);
            this.Controls.Add(this.btnStartlistening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.tbConsoleOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbConsoleOutput;
        private TextBox tbIPAddress;
        private TextBox tbPort;
        private Label label1;
        private Button btnStartlistening;
        private TextBox tbPayload;
        private Button btnSend;
        private Button btnFindIPV4IP;
    }
}