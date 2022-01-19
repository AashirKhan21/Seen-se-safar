
namespace Seensesafar
{
    partial class frmHotel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close_Btn = new System.Windows.Forms.Button();
            this.hotelname_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HotelDescriptionTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hotelContactTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.Updatehotel_Btn = new System.Windows.Forms.Button();
            this.savehotel_Btn = new System.Windows.Forms.Button();
            this.IDlbl = new System.Windows.Forms.Label();
            this.HotelType_DD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoteladdressTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 66);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "  HOTEL DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // close_Btn
            // 
            this.close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_Btn.FlatAppearance.BorderSize = 0;
            this.close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Btn.Image = global::Seensesafar.Properties.Resources.exit1;
            this.close_Btn.Location = new System.Drawing.Point(934, 0);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(60, 66);
            this.close_Btn.TabIndex = 0;
            this.close_Btn.UseVisualStyleBackColor = true;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // hotelname_Txt
            // 
            this.hotelname_Txt.Location = new System.Drawing.Point(212, 152);
            this.hotelname_Txt.Name = "hotelname_Txt";
            this.hotelname_Txt.Size = new System.Drawing.Size(732, 27);
            this.hotelname_Txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hotel Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // HotelDescriptionTxt
            // 
            this.HotelDescriptionTxt.Location = new System.Drawing.Point(212, 246);
            this.HotelDescriptionTxt.Multiline = true;
            this.HotelDescriptionTxt.Name = "HotelDescriptionTxt";
            this.HotelDescriptionTxt.Size = new System.Drawing.Size(732, 93);
            this.HotelDescriptionTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // hotelContactTxt
            // 
            this.hotelContactTxt.Location = new System.Drawing.Point(212, 361);
            this.hotelContactTxt.Name = "hotelContactTxt";
            this.hotelContactTxt.Size = new System.Drawing.Size(732, 27);
            this.hotelContactTxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact";
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.cancel_Btn.FlatAppearance.BorderSize = 2;
            this.cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Location = new System.Drawing.Point(557, 459);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(167, 48);
            this.cancel_Btn.TabIndex = 15;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = false;
            // 
            // Updatehotel_Btn
            // 
            this.Updatehotel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Updatehotel_Btn.FlatAppearance.BorderSize = 2;
            this.Updatehotel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatehotel_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatehotel_Btn.ForeColor = System.Drawing.Color.White;
            this.Updatehotel_Btn.Location = new System.Drawing.Point(384, 459);
            this.Updatehotel_Btn.Name = "Updatehotel_Btn";
            this.Updatehotel_Btn.Size = new System.Drawing.Size(167, 48);
            this.Updatehotel_Btn.TabIndex = 14;
            this.Updatehotel_Btn.Text = "Update";
            this.Updatehotel_Btn.UseVisualStyleBackColor = false;
            this.Updatehotel_Btn.Click += new System.EventHandler(this.Updatehotel_Btn_Click);
            // 
            // savehotel_Btn
            // 
            this.savehotel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.savehotel_Btn.FlatAppearance.BorderSize = 2;
            this.savehotel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savehotel_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savehotel_Btn.ForeColor = System.Drawing.Color.White;
            this.savehotel_Btn.Location = new System.Drawing.Point(211, 459);
            this.savehotel_Btn.Name = "savehotel_Btn";
            this.savehotel_Btn.Size = new System.Drawing.Size(167, 48);
            this.savehotel_Btn.TabIndex = 13;
            this.savehotel_Btn.Text = "Save";
            this.savehotel_Btn.UseVisualStyleBackColor = false;
            this.savehotel_Btn.Click += new System.EventHandler(this.savehotel_Btn_Click);
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(36, 69);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(49, 23);
            this.IDlbl.TabIndex = 16;
            this.IDlbl.Text = "lblID";
            this.IDlbl.Visible = false;
            // 
            // HotelType_DD
            // 
            this.HotelType_DD.FormattingEnabled = true;
            this.HotelType_DD.Items.AddRange(new object[] {
            "7 Star Hotel",
            "5 Star Hotel",
            "4 Star Hotel",
            "3 Star Hotel"});
            this.HotelType_DD.Location = new System.Drawing.Point(213, 197);
            this.HotelType_DD.Name = "HotelType_DD";
            this.HotelType_DD.Size = new System.Drawing.Size(732, 28);
            this.HotelType_DD.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address";
            // 
            // hoteladdressTxt
            // 
            this.hoteladdressTxt.Location = new System.Drawing.Point(212, 408);
            this.hoteladdressTxt.Name = "hoteladdressTxt";
            this.hoteladdressTxt.Size = new System.Drawing.Size(732, 27);
            this.hoteladdressTxt.TabIndex = 18;
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 542);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoteladdressTxt);
            this.Controls.Add(this.HotelType_DD);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.Updatehotel_Btn);
            this.Controls.Add(this.savehotel_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HotelDescriptionTxt);
            this.Controls.Add(this.hotelContactTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hotelname_Txt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_Btn;
        public System.Windows.Forms.TextBox hotelname_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox HotelDescriptionTxt;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox hotelContactTxt;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button savehotel_Btn;
        public System.Windows.Forms.Button cancel_Btn;
        public System.Windows.Forms.Button Updatehotel_Btn;
        public System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox hoteladdressTxt;
        public System.Windows.Forms.ComboBox HotelType_DD;
    }
}