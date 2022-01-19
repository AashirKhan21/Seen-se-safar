
namespace Seensesafar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userTxt = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.pswdTxt = new MetroFramework.Controls.MetroTextBox();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.login_Btn = new System.Windows.Forms.Button();
            this.signuplbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // userTxt
            // 
            // 
            // 
            // 
            this.userTxt.CustomButton.Image = null;
            this.userTxt.CustomButton.Location = new System.Drawing.Point(391, 1);
            this.userTxt.CustomButton.Name = "";
            this.userTxt.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.userTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userTxt.CustomButton.TabIndex = 1;
            this.userTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userTxt.CustomButton.UseSelectable = true;
            this.userTxt.CustomButton.Visible = false;
            this.userTxt.DisplayIcon = true;
            this.userTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userTxt.Lines = new string[0];
            this.userTxt.Location = new System.Drawing.Point(23, 409);
            this.userTxt.MaxLength = 32767;
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.PromptText = "Username";
            this.userTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTxt.SelectedText = "";
            this.userTxt.SelectionLength = 0;
            this.userTxt.SelectionStart = 0;
            this.userTxt.ShortcutsEnabled = true;
            this.userTxt.Size = new System.Drawing.Size(425, 35);
            this.userTxt.TabIndex = 22;
            this.userTxt.UseSelectable = true;
            this.userTxt.WaterMark = "Username";
            this.userTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.exit_Btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 378);
            this.panel1.TabIndex = 21;
            // 
            // exit_Btn
            // 
            this.exit_Btn.BackColor = System.Drawing.Color.Red;
            this.exit_Btn.FlatAppearance.BorderSize = 0;
            this.exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Btn.ForeColor = System.Drawing.Color.White;
            this.exit_Btn.Location = new System.Drawing.Point(413, 23);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(46, 37);
            this.exit_Btn.TabIndex = 11;
            this.exit_Btn.Text = "X";
            this.exit_Btn.UseVisualStyleBackColor = false;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // pswdTxt
            // 
            // 
            // 
            // 
            this.pswdTxt.CustomButton.Image = null;
            this.pswdTxt.CustomButton.Location = new System.Drawing.Point(391, 1);
            this.pswdTxt.CustomButton.Name = "";
            this.pswdTxt.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pswdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pswdTxt.CustomButton.TabIndex = 1;
            this.pswdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pswdTxt.CustomButton.UseSelectable = true;
            this.pswdTxt.CustomButton.Visible = false;
            this.pswdTxt.DisplayIcon = true;
            this.pswdTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.pswdTxt.Lines = new string[0];
            this.pswdTxt.Location = new System.Drawing.Point(23, 462);
            this.pswdTxt.MaxLength = 32767;
            this.pswdTxt.Name = "pswdTxt";
            this.pswdTxt.PasswordChar = '•';
            this.pswdTxt.PromptText = "Password";
            this.pswdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pswdTxt.SelectedText = "";
            this.pswdTxt.SelectionLength = 0;
            this.pswdTxt.SelectionStart = 0;
            this.pswdTxt.ShortcutsEnabled = true;
            this.pswdTxt.Size = new System.Drawing.Size(425, 35);
            this.pswdTxt.TabIndex = 27;
            this.pswdTxt.UseSelectable = true;
            this.pswdTxt.WaterMark = "Password";
            this.pswdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pswdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cancel_Btn.FlatAppearance.BorderSize = 2;
            this.cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Location = new System.Drawing.Point(23, 573);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(425, 63);
            this.cancel_Btn.TabIndex = 25;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = false;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.login_Btn.FlatAppearance.BorderSize = 2;
            this.login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Btn.ForeColor = System.Drawing.Color.White;
            this.login_Btn.Location = new System.Drawing.Point(23, 513);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(425, 54);
            this.login_Btn.TabIndex = 24;
            this.login_Btn.Text = "Login";
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // signuplbl
            // 
            this.signuplbl.AutoSize = true;
            this.signuplbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuplbl.ForeColor = System.Drawing.Color.Black;
            this.signuplbl.Location = new System.Drawing.Point(74, 646);
            this.signuplbl.Name = "signuplbl";
            this.signuplbl.Size = new System.Drawing.Size(308, 23);
            this.signuplbl.TabIndex = 28;
            this.signuplbl.Text = "Don\'t have an account yet? Create one";
            this.signuplbl.Click += new System.EventHandler(this.signuplbl_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 687);
            this.Controls.Add(this.signuplbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pswdTxt);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.login_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox userTxt;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button exit_Btn;
        private MetroFramework.Controls.MetroTextBox pswdTxt;
        public System.Windows.Forms.Button cancel_Btn;
        public System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Label signuplbl;
    }
}