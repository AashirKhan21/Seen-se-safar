using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seensesafar
{
    public partial class frmUser : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DbConnection db = new DbConnection();
        Dashboard frm;
        public frmUser(Dashboard ds)
        {
            InitializeComponent();
            con = new SqlConnection(db.ConnectionString());
            frm = ds;
            LoadRecords();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveuser_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (unameTxt.Text == "")
                {
                    MainClass.MSGBox("Please Enter Username!!", "Error", "Error");
                    return;
                }
                else if (EmailTxt.Text == "")
                {
                    MainClass.MSGBox("Please Enter Email Address!!", "Error", "Error");
                    return;
                }
                else if (PswdTxt.Text == "")
                {
                    MainClass.MSGBox("Please Enter Password!!", "Error", "Error");
                    return;
                }
                else if (PswdTxt.Text != RPswdTxt.Text)
                {
                    MainClass.MSGBox("Password did not match!!", "Error", "Error");
                    return;
                }
                else if (RoleDD.SelectedIndex == -1)
                {
                    MainClass.MSGBox("Please Select Role!!", "Error", "Error");
                    return;
                }
                else if (ContactTxt.Text == "")
                {
                    MainClass.MSGBox("Please Enter Contact Number!!", "Error", "Error");
                    return;
                }
                else
                {
                    con.Open();
                    string query = @"Insert into tbl_User (User_Name, User_Email, User_Password, User_Contact, User_Role) 
                                               Values(@uname, @uemail, @pswd, @ucontact, @urole)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uname", unameTxt.Text);
                    cmd.Parameters.AddWithValue("@uemail", EmailTxt.Text);
                    cmd.Parameters.AddWithValue("@pswd", PswdTxt.Text);
                    cmd.Parameters.AddWithValue("@urole", RoleDD.Text);
                    cmd.Parameters.AddWithValue("@ucontact", ContactTxt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MainClass.MSGBox(unameTxt.Text + " added to the System Successfully", "Success", "Success");
                    Clear();
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MainClass.MSGBox(ex.Message, "Error", "Error");
            }
        }

        private void Clear()
        {
            unameTxt.Clear();
            EmailTxt.Clear();
            PswdTxt.Clear();
            RPswdTxt.Clear();
            RoleDD.SelectedIndex = -1;
            ContactTxt.Clear();
            unameTxt.Focus();
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("sp_Get_Users", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i,
                    reader["User_ID"].ToString(),
                    reader["User_Name"].ToString(),
                    reader["User_Email"].ToString(),
                    reader["User_Role"].ToString(),
                    reader["User_Contact"].ToString());
            }
            reader.Close();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("sp_Delete_User", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", dataGridView1[1, e.RowIndex].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MainClass.MSGBox("User Deleted Successfully from the system", "Success", "Success");
                    LoadRecords();
                }
            }
        }
    }
}
