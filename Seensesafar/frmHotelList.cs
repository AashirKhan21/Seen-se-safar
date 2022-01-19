using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Seensesafar
{
    public partial class frmHotelList : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DbConnection db = new DbConnection();
        public frmHotelList()
        {
            InitializeComponent();
            con = new SqlConnection(db.ConnectionString());
            LoadRecords();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addnewHotel_Btn_Click(object sender, EventArgs e)
        {
            frmHotel Hotel = new frmHotel(this);
            Hotel.Updatehotel_Btn.Enabled = false;
            Hotel.ShowDialog();

        }

        public void LoadRecords()
        {
                int i = 0;
                Hotel_DGV.Rows.Clear();
                con.Open();
                cmd = new SqlCommand("sp_Get_Hotels", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                Hotel_DGV.Rows.Add(i,
                reader["Hotel_ID"].ToString(),
                reader["Hotel_Name"].ToString(),
                reader["Hotel_Type"].ToString(),
                reader["Hotel_Desc"].ToString(),
                reader["Hotel_Address"].ToString(),
                reader["Hotel_Contact"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                con.Close();
        }

        private void Hotel_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colname = Hotel_DGV.Columns[e.ColumnIndex].Name;

            if (colname == "Edit")
            {
                frmHotel frm = new frmHotel(this);
                frm.savehotel_Btn.Enabled = false;
                frm.IDlbl.Text = Hotel_DGV[1, e.RowIndex].Value.ToString();
                frm.hotelname_Txt.Text = Hotel_DGV[2, e.RowIndex].Value.ToString();
                frm.HotelType_DD.Text = Hotel_DGV[3, e.RowIndex].Value.ToString();
                frm.HotelDescriptionTxt.Text = Hotel_DGV[4, e.RowIndex].Value.ToString();
                frm.hoteladdressTxt.Text = Hotel_DGV[5, e.RowIndex].Value.ToString();
                frm.hotelContactTxt.Text = Hotel_DGV[6, e.RowIndex].Value.ToString();
                frm.savehotel_Btn.Enabled = false;
                frm.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("sp_Delete_Hotel", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Hotel_DGV[1, e.RowIndex].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MainClass.MSGBox("Hotel Deleted Successfully from the system", "Success", "Success");
                    LoadRecords();
                }
            }

        }
    }
}
