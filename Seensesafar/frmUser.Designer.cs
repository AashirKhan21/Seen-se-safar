
namespace Seensesafar
{
    partial class frmUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.close_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.ContactTxt = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveuser_Btn = new System.Windows.Forms.Button();
            this.RoleDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RPswdTxt = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PswdTxt = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unameTxt = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTxt = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 60);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.close_Btn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1040, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(71, 60);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // close_Btn
            // 
            this.close_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_Btn.FlatAppearance.BorderSize = 0;
            this.close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Btn.Image = global::Seensesafar.Properties.Resources.Exiticon;
            this.close_Btn.Location = new System.Drawing.Point(4, 4);
            this.close_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(63, 52);
            this.close_Btn.TabIndex = 0;
            this.close_Btn.UseVisualStyleBackColor = true;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = " USER\'S SETTTINGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.metroTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 606);
            this.panel2.TabIndex = 4;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1111, 606);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1103, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREATE ACCOUNT";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1103, 564);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmailTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cancel_Btn);
            this.groupBox1.Controls.Add(this.ContactTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.saveuser_Btn);
            this.groupBox1.Controls.Add(this.RoleDD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RPswdTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PswdTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 564);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create an Account";
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.cancel_Btn.FlatAppearance.BorderSize = 2;
            this.cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Location = new System.Drawing.Point(592, 373);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(230, 59);
            this.cancel_Btn.TabIndex = 11;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = false;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // ContactTxt
            // 
            // 
            // 
            // 
            this.ContactTxt.CustomButton.Image = null;
            this.ContactTxt.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.ContactTxt.CustomButton.Name = "";
            this.ContactTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ContactTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ContactTxt.CustomButton.TabIndex = 1;
            this.ContactTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ContactTxt.CustomButton.UseSelectable = true;
            this.ContactTxt.CustomButton.Visible = false;
            this.ContactTxt.Lines = new string[0];
            this.ContactTxt.Location = new System.Drawing.Point(378, 328);
            this.ContactTxt.MaxLength = 32767;
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.PasswordChar = '\0';
            this.ContactTxt.PromptText = "Enter Contact Number";
            this.ContactTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ContactTxt.SelectedText = "";
            this.ContactTxt.SelectionLength = 0;
            this.ContactTxt.SelectionStart = 0;
            this.ContactTxt.ShortcutsEnabled = true;
            this.ContactTxt.Size = new System.Drawing.Size(446, 29);
            this.ContactTxt.TabIndex = 10;
            this.ContactTxt.UseSelectable = true;
            this.ContactTxt.WaterMark = "Enter Contact Number";
            this.ContactTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ContactTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(214, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact";
            // 
            // saveuser_Btn
            // 
            this.saveuser_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.saveuser_Btn.FlatAppearance.BorderSize = 2;
            this.saveuser_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveuser_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveuser_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveuser_Btn.ForeColor = System.Drawing.Color.White;
            this.saveuser_Btn.Location = new System.Drawing.Point(378, 373);
            this.saveuser_Btn.Name = "saveuser_Btn";
            this.saveuser_Btn.Size = new System.Drawing.Size(208, 59);
            this.saveuser_Btn.TabIndex = 8;
            this.saveuser_Btn.Text = "Save";
            this.saveuser_Btn.UseVisualStyleBackColor = false;
            this.saveuser_Btn.Click += new System.EventHandler(this.saveuser_Btn_Click);
            // 
            // RoleDD
            // 
            this.RoleDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleDD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDD.FormattingEnabled = true;
            this.RoleDD.Items.AddRange(new object[] {
            "System Administrator",
            "Customer"});
            this.RoleDD.Location = new System.Drawing.Point(378, 276);
            this.RoleDD.Name = "RoleDD";
            this.RoleDD.Size = new System.Drawing.Size(446, 31);
            this.RoleDD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(214, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role";
            // 
            // RPswdTxt
            // 
            // 
            // 
            // 
            this.RPswdTxt.CustomButton.Image = null;
            this.RPswdTxt.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.RPswdTxt.CustomButton.Name = "";
            this.RPswdTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.RPswdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RPswdTxt.CustomButton.TabIndex = 1;
            this.RPswdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RPswdTxt.CustomButton.UseSelectable = true;
            this.RPswdTxt.CustomButton.Visible = false;
            this.RPswdTxt.Lines = new string[0];
            this.RPswdTxt.Location = new System.Drawing.Point(378, 224);
            this.RPswdTxt.MaxLength = 32767;
            this.RPswdTxt.Name = "RPswdTxt";
            this.RPswdTxt.PasswordChar = '•';
            this.RPswdTxt.PromptText = "Re-Type Your Password";
            this.RPswdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RPswdTxt.SelectedText = "";
            this.RPswdTxt.SelectionLength = 0;
            this.RPswdTxt.SelectionStart = 0;
            this.RPswdTxt.ShortcutsEnabled = true;
            this.RPswdTxt.Size = new System.Drawing.Size(446, 29);
            this.RPswdTxt.TabIndex = 5;
            this.RPswdTxt.UseSelectable = true;
            this.RPswdTxt.WaterMark = "Re-Type Your Password";
            this.RPswdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RPswdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(214, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-Type Password";
            // 
            // PswdTxt
            // 
            // 
            // 
            // 
            this.PswdTxt.CustomButton.Image = null;
            this.PswdTxt.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.PswdTxt.CustomButton.Name = "";
            this.PswdTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.PswdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PswdTxt.CustomButton.TabIndex = 1;
            this.PswdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PswdTxt.CustomButton.UseSelectable = true;
            this.PswdTxt.CustomButton.Visible = false;
            this.PswdTxt.Lines = new string[0];
            this.PswdTxt.Location = new System.Drawing.Point(378, 164);
            this.PswdTxt.MaxLength = 32767;
            this.PswdTxt.Name = "PswdTxt";
            this.PswdTxt.PasswordChar = '•';
            this.PswdTxt.PromptText = "Enter Password";
            this.PswdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PswdTxt.SelectedText = "";
            this.PswdTxt.SelectionLength = 0;
            this.PswdTxt.SelectionStart = 0;
            this.PswdTxt.ShortcutsEnabled = true;
            this.PswdTxt.Size = new System.Drawing.Size(446, 29);
            this.PswdTxt.TabIndex = 3;
            this.PswdTxt.UseSelectable = true;
            this.PswdTxt.WaterMark = "Enter Password";
            this.PswdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PswdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(214, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // unameTxt
            // 
            // 
            // 
            // 
            this.unameTxt.CustomButton.Image = null;
            this.unameTxt.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.unameTxt.CustomButton.Name = "";
            this.unameTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.unameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unameTxt.CustomButton.TabIndex = 1;
            this.unameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unameTxt.CustomButton.UseSelectable = true;
            this.unameTxt.CustomButton.Visible = false;
            this.unameTxt.Lines = new string[0];
            this.unameTxt.Location = new System.Drawing.Point(380, 69);
            this.unameTxt.MaxLength = 32767;
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.PasswordChar = '\0';
            this.unameTxt.PromptText = "Enter Username";
            this.unameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unameTxt.SelectedText = "";
            this.unameTxt.SelectionLength = 0;
            this.unameTxt.SelectionStart = 0;
            this.unameTxt.ShortcutsEnabled = true;
            this.unameTxt.Size = new System.Drawing.Size(446, 29);
            this.unameTxt.TabIndex = 1;
            this.unameTxt.UseSelectable = true;
            this.unameTxt.WaterMark = "Enter Username";
            this.unameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(210, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // EmailTxt
            // 
            // 
            // 
            // 
            this.EmailTxt.CustomButton.Image = null;
            this.EmailTxt.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.EmailTxt.CustomButton.Name = "";
            this.EmailTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.EmailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailTxt.CustomButton.TabIndex = 1;
            this.EmailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailTxt.CustomButton.UseSelectable = true;
            this.EmailTxt.CustomButton.Visible = false;
            this.EmailTxt.Lines = new string[0];
            this.EmailTxt.Location = new System.Drawing.Point(378, 118);
            this.EmailTxt.MaxLength = 32767;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PasswordChar = '\0';
            this.EmailTxt.PromptText = "Enter Email Address";
            this.EmailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTxt.SelectedText = "";
            this.EmailTxt.SelectionLength = 0;
            this.EmailTxt.SelectionStart = 0;
            this.EmailTxt.ShortcutsEnabled = false;
            this.EmailTxt.Size = new System.Drawing.Size(446, 29);
            this.EmailTxt.TabIndex = 13;
            this.EmailTxt.UseSelectable = true;
            this.EmailTxt.WaterMark = "Enter Email Address";
            this.EmailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(210, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email Address";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1103, 564);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "ALL USERS";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.name,
            this.email,
            this.role,
            this.contact,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 564);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 47;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 85;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.role.HeaderText = "ROLE";
            this.role.MinimumWidth = 8;
            this.role.Name = "role";
            this.role.Width = 77;
            // 
            // contact
            // 
            this.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contact.HeaderText = "CONTACT";
            this.contact.MinimumWidth = 8;
            this.contact.Name = "contact";
            this.contact.Width = 113;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Seensesafar.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 666);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button close_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox RPswdTxt;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox PswdTxt;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox unameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RoleDD;
        public System.Windows.Forms.Button saveuser_Btn;
        private MetroFramework.Controls.MetroTextBox ContactTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancel_Btn;
        private MetroFramework.Controls.MetroTextBox EmailTxt;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}