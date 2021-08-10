
namespace Autentification
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
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.userControl11 = new Autentification.UserControl1();
            this.userControl21 = new Autentification.UserControl2();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(99)))));
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.btn_register.Location = new System.Drawing.Point(37, 24);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(173, 48);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(99)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.btn_login.Location = new System.Drawing.Point(272, 24);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(173, 48);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(56, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "You have already submited your vote";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(99)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.button3.Location = new System.Drawing.Point(148, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "New Vote";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(37, 109);
            this.userControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(408, 678);
            this.userControl11.TabIndex = 3;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(37, 109);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(408, 678);
            this.userControl21.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(482, 802);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}