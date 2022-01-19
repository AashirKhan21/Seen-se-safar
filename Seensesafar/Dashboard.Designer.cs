
namespace Seensesafar
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rolelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Room_Btn = new System.Windows.Forms.Button();
            this.Booking_Btn = new System.Windows.Forms.Button();
            this.Users_Btn = new System.Windows.Forms.Button();
            this.Food_Btn = new System.Windows.Forms.Button();
            this.Travel_Btn = new System.Windows.Forms.Button();
            this.Hotel_Btn = new System.Windows.Forms.Button();
            this.Package_Btn = new System.Windows.Forms.Button();
            this.Dashboard_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Room_Btn);
            this.panel2.Controls.Add(this.Booking_Btn);
            this.panel2.Controls.Add(this.Users_Btn);
            this.panel2.Controls.Add(this.Food_Btn);
            this.panel2.Controls.Add(this.Travel_Btn);
            this.panel2.Controls.Add(this.Hotel_Btn);
            this.panel2.Controls.Add(this.Package_Btn);
            this.panel2.Controls.Add(this.Dashboard_Btn);
            this.panel2.Controls.Add(this.rolelbl);
            this.panel2.Controls.Add(this.namelbl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 858);
            this.panel2.TabIndex = 1;
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelbl.ForeColor = System.Drawing.Color.White;
            this.rolelbl.Location = new System.Drawing.Point(52, 169);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(139, 25);
            this.rolelbl.TabIndex = 3;
            this.rolelbl.Text = "System Admin";
            this.rolelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(86, 128);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(68, 25);
            this.namelbl.TabIndex = 2;
            this.namelbl.Text = "Aashir";
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 116);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(276, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 858);
            this.panel3.TabIndex = 2;
            // 
            // Room_Btn
            // 
            this.Room_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Room_Btn.FlatAppearance.BorderSize = 0;
            this.Room_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Btn.ForeColor = System.Drawing.Color.White;
            this.Room_Btn.Image = global::Seensesafar.Properties.Resources.Room;
            this.Room_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room_Btn.Location = new System.Drawing.Point(0, 434);
            this.Room_Btn.Name = "Room_Btn";
            this.Room_Btn.Size = new System.Drawing.Size(276, 63);
            this.Room_Btn.TabIndex = 11;
            this.Room_Btn.Text = " Room Details";
            this.Room_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Room_Btn.UseVisualStyleBackColor = true;
            this.Room_Btn.Click += new System.EventHandler(this.Room_Btn_Click);
            // 
            // Booking_Btn
            // 
            this.Booking_Btn.FlatAppearance.BorderSize = 0;
            this.Booking_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Booking_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Btn.ForeColor = System.Drawing.Color.White;
            this.Booking_Btn.Image = global::Seensesafar.Properties.Resources.Booking;
            this.Booking_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booking_Btn.Location = new System.Drawing.Point(3, 710);
            this.Booking_Btn.Name = "Booking_Btn";
            this.Booking_Btn.Size = new System.Drawing.Size(276, 63);
            this.Booking_Btn.TabIndex = 10;
            this.Booking_Btn.Text = " Booking";
            this.Booking_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Booking_Btn.UseVisualStyleBackColor = true;
            this.Booking_Btn.Click += new System.EventHandler(this.Booking_Btn_Click);
            // 
            // Users_Btn
            // 
            this.Users_Btn.FlatAppearance.BorderSize = 0;
            this.Users_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Btn.ForeColor = System.Drawing.Color.White;
            this.Users_Btn.Image = global::Seensesafar.Properties.Resources.userssetting;
            this.Users_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users_Btn.Location = new System.Drawing.Point(-3, 641);
            this.Users_Btn.Name = "Users_Btn";
            this.Users_Btn.Size = new System.Drawing.Size(276, 63);
            this.Users_Btn.TabIndex = 9;
            this.Users_Btn.Text = " Users";
            this.Users_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Users_Btn.UseVisualStyleBackColor = true;
            this.Users_Btn.Click += new System.EventHandler(this.Users_Btn_Click);
            // 
            // Food_Btn
            // 
            this.Food_Btn.FlatAppearance.BorderSize = 0;
            this.Food_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Btn.ForeColor = System.Drawing.Color.White;
            this.Food_Btn.Image = global::Seensesafar.Properties.Resources.Food;
            this.Food_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Food_Btn.Location = new System.Drawing.Point(3, 572);
            this.Food_Btn.Name = "Food_Btn";
            this.Food_Btn.Size = new System.Drawing.Size(273, 63);
            this.Food_Btn.TabIndex = 8;
            this.Food_Btn.Text = " Food Management";
            this.Food_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Food_Btn.UseVisualStyleBackColor = true;
            this.Food_Btn.Click += new System.EventHandler(this.Food_Btn_Click);
            // 
            // Travel_Btn
            // 
            this.Travel_Btn.FlatAppearance.BorderSize = 0;
            this.Travel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Travel_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Travel_Btn.ForeColor = System.Drawing.Color.White;
            this.Travel_Btn.Image = global::Seensesafar.Properties.Resources.Travel1;
            this.Travel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Travel_Btn.Location = new System.Drawing.Point(0, 503);
            this.Travel_Btn.Name = "Travel_Btn";
            this.Travel_Btn.Size = new System.Drawing.Size(276, 63);
            this.Travel_Btn.TabIndex = 7;
            this.Travel_Btn.Text = "Travel Management";
            this.Travel_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Travel_Btn.UseVisualStyleBackColor = true;
            this.Travel_Btn.Click += new System.EventHandler(this.Travel_Btn_Click);
            // 
            // Hotel_Btn
            // 
            this.Hotel_Btn.FlatAppearance.BorderSize = 0;
            this.Hotel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hotel_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotel_Btn.ForeColor = System.Drawing.Color.White;
            this.Hotel_Btn.Image = global::Seensesafar.Properties.Resources.Hotel;
            this.Hotel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hotel_Btn.Location = new System.Drawing.Point(0, 365);
            this.Hotel_Btn.Name = "Hotel_Btn";
            this.Hotel_Btn.Size = new System.Drawing.Size(276, 63);
            this.Hotel_Btn.TabIndex = 6;
            this.Hotel_Btn.Text = " Hotel Details";
            this.Hotel_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hotel_Btn.UseVisualStyleBackColor = true;
            this.Hotel_Btn.Click += new System.EventHandler(this.Hotel_Btn_Click);
            // 
            // Package_Btn
            // 
            this.Package_Btn.FlatAppearance.BorderSize = 0;
            this.Package_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Package_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Package_Btn.ForeColor = System.Drawing.Color.White;
            this.Package_Btn.Image = global::Seensesafar.Properties.Resources.Packages;
            this.Package_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Package_Btn.Location = new System.Drawing.Point(-3, 296);
            this.Package_Btn.Name = "Package_Btn";
            this.Package_Btn.Size = new System.Drawing.Size(279, 63);
            this.Package_Btn.TabIndex = 5;
            this.Package_Btn.Text = " Packages";
            this.Package_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Package_Btn.UseVisualStyleBackColor = true;
            this.Package_Btn.Click += new System.EventHandler(this.Package_Btn_Click);
            // 
            // Dashboard_Btn
            // 
            this.Dashboard_Btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_Btn.Font = new System.Drawing.Font("Simple Outline Pat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_Btn.Image = global::Seensesafar.Properties.Resources.DashBoardicon;
            this.Dashboard_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_Btn.Location = new System.Drawing.Point(0, 227);
            this.Dashboard_Btn.Name = "Dashboard_Btn";
            this.Dashboard_Btn.Size = new System.Drawing.Size(276, 63);
            this.Dashboard_Btn.TabIndex = 4;
            this.Dashboard_Btn.Text = " Dashboard";
            this.Dashboard_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard_Btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seensesafar.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(75, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Image = global::Seensesafar.Properties.Resources.logout__2_;
            this.logoutbtn.Location = new System.Drawing.Point(0, 0);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(191, 50);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 908);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Button Dashboard_Btn;
        private System.Windows.Forms.Button Travel_Btn;
        private System.Windows.Forms.Button Hotel_Btn;
        private System.Windows.Forms.Button Package_Btn;
        private System.Windows.Forms.Button Booking_Btn;
        private System.Windows.Forms.Button Users_Btn;
        private System.Windows.Forms.Button Food_Btn;
        private System.Windows.Forms.Button Room_Btn;
    }
}