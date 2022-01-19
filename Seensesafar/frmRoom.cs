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
    public partial class frmRoom : Form
    {
        SqlConnection con = new SqlConnection();
        DbConnection db = new DbConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public frmRoom()
        {
            InitializeComponent();
            con = new SqlConnection(db.ConnectionString());
            LoadHotels();
            LoadRecords();
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveroom_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = hotelIDlbl.Text;

                if (MessageBox.Show("Are You Sure want to Save the Room Details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (roomtypeTxt.Text == "")
                    {
                        MainClass.MSGBox("Please enter Room Type!!", "Error", "Error");
                        return;
                    }
                    else if (roomrentTxt.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Room Rent!!", "Error", "Error");
                        return;
                    }
                    else if (R_HotelName_DD.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Hotel Name!!", "Error", "Error");
                        return;
                    }
                    else if (hoteltype_Txt.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Hotel Type!!", "Error", "Error");
                        return;
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("sp_Insert_Room", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@hid", SqlDbType.Int).Value = hotelIDlbl.Text;
                        cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = roomtypeTxt.Text;
                        cmd.Parameters.AddWithValue("@rent", SqlDbType.Decimal).Value = roomrentTxt.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MainClass.MSGBox("Record has been Saved Successfully", "Success", "Success");
                        ClearControl();
                        LoadRecords();

                    }


                }
            }
            catch (Exception ex)
            {
                MainClass.MSGBox(ex.Message, "Error", "Error");
            }

        }

        public void ClearControl()
        {
            roomtypeTxt.Clear();
            roomrentTxt.Clear();
            R_HotelName_DD.SelectedIndex = -1;
            hoteltype_Txt.Clear();
        }

        public void LoadHotels()
        {
            R_HotelName_DD.Items.Clear();
            con.Open();
            cmd = new SqlCommand("Select * from tbl_Hotel", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                R_HotelName_DD.Items.Add(reader["Hotel_Name"].ToString());

            }
            reader.Close();
            con.Close();

        }
        public void LoadRecords()
        {
            int i = 0;
            Room_DGV.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("Select * from vwRoom", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                Room_DGV.Rows.Add(i,
                reader["Room_ID"].ToString(),
                reader["Room_Hotel_ID"].ToString(),
                reader["Room_Type"].ToString(),
                reader["Room_Rent_Per_Day"].ToString(),
                reader["Hotel_Name"].ToString(),
                reader["Hotel_Type"].ToString());
            }
            reader.Close();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void R_HotelName_DD_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from tbl_Hotel where Hotel_Name like '"+R_HotelName_DD.Text+"'";
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hotelIDlbl.Text = reader["Hotel_ID"].ToString();
                hoteltype_Txt.Text = reader["Hotel_Type"].ToString();
            }
            con.Close();
        }

        private void Room_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = Room_DGV.Columns[e.ColumnIndex].Name;

            if (colname == "Edit")
            {
                saveroom_Btn.Enabled = false;
                IDlbl.Text = Room_DGV[1, e.RowIndex].Value.ToString();
                hotelIDlbl.Text = Room_DGV[2, e.RowIndex].Value.ToString();
                roomtypeTxt.Text = Room_DGV[3, e.RowIndex].Value.ToString();
                roomrentTxt.Text = Room_DGV[4, e.RowIndex].Value.ToString();
                R_HotelName_DD.Text = Room_DGV[5, e.RowIndex].Value.ToString();
                hoteltype_Txt.Text = Room_DGV[6, e.RowIndex].Value.ToString();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("sp_Delete_Room", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Room_DGV[1, e.RowIndex].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MainClass.MSGBox("Room Deleted Successfully from the system", "Success", "Success");
                    LoadRecords();
                }
            }
        }

        private void Updateroom_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You want to update Room Details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("sp_Update_Room", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = IDlbl.Text;
                    cmd.Parameters.AddWithValue("@hid", SqlDbType.Int).Value = hotelIDlbl.Text;
                    cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = roomtypeTxt.Text;
                    cmd.Parameters.AddWithValue("@rent", SqlDbType.Decimal).Value = roomrentTxt.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MainClass.MSGBox("Record has been Saved Successfully", "Success", "Success");
                    ClearControl();
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MainClass.MSGBox(ex.Message, "ERROR", "ERROR");
            }
        }
    }
 }
