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
using System.Collections;

namespace Seensesafar
{
    public partial class frmHotel : Form
    {
        SqlConnection con = new SqlConnection();
        DbConnection db = new DbConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        frmHotelList frmHotelList;

        public frmHotel(frmHotelList FHList)
        {
            InitializeComponent();
            con = new SqlConnection(db.ConnectionString());
            frmHotelList = FHList;
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void savehotel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure want to Save the Hotel Details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (hotelname_Txt.Text == "")
                    {
                        MainClass.MSGBox("Please enter Hotel Name!!", "Error", "Error");
                        return;
                    }
                    else if (HotelType_DD.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Hotel Type!!", "Error", "Error");
                        return;
                    }
                    else if (HotelDescriptionTxt.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Hotel Description!!", "Error", "Error");
                        return;
                    }
                    else if (hotelContactTxt.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Hotel Contact!!", "Error", "Error");
                        return;
                    }
                    else if (hoteladdressTxt.Text == "")
                    {
                        MainClass.MSGBox("Please Enter Hotel Address!!", "Error", "Error");
                        return;
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("sp_Insert_Hotel", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = hotelname_Txt.Text;
                        cmd.Parameters.AddWithValue("@type", SqlDbType.VarChar).Value = HotelType_DD.Text;
                        cmd.Parameters.AddWithValue("@desc", SqlDbType.VarChar).Value = HotelDescriptionTxt.Text;
                        cmd.Parameters.AddWithValue("@contact", SqlDbType.NVarChar).Value = hotelContactTxt.Text;
                        cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = hoteladdressTxt.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MainClass.MSGBox("Record has been Saved Successfully", "Success", "Success");
                        ClearControls();
                        frmHotelList.LoadRecords();

                    }

                }

            }
            catch (Exception ex)
            {
                con.Close();
                MainClass.MSGBox(ex.Message, "ERROR", "ERROR");
            }
        }

        public void ClearControls()
        {
            hotelname_Txt.Clear();
            HotelType_DD.Text = "";
            HotelDescriptionTxt.Clear();
            hotelContactTxt.Clear();
            hotelname_Txt.Focus();
            savehotel_Btn.Enabled = true;
            Updatehotel_Btn.Enabled = false;
            
        }

        private void Updatehotel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You want to update Hotel Details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {


                    con.Open();
                    cmd = new SqlCommand("sp_Update_Hotel", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = IDlbl.Text;
                    cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = hotelname_Txt.Text;
                    cmd.Parameters.AddWithValue("@type", SqlDbType.VarChar).Value = HotelType_DD.Text;
                    cmd.Parameters.AddWithValue("@desc", SqlDbType.VarChar).Value = HotelDescriptionTxt.Text;
                    cmd.Parameters.AddWithValue("@contact", SqlDbType.NVarChar).Value = hotelContactTxt.Text;
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = hoteladdressTxt.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MainClass.MSGBox("Record has been Saved Successfully", "Success", "Success");
                    ClearControls();
                    frmHotelList.LoadRecords();
                    this.Dispose();
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
