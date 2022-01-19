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
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnection db = new DbConnection();
        public string _pass, _user;


        public Dashboard()
        {
            InitializeComponent();
            con = new SqlConnection(db.ConnectionString());

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login frm = new Login();
                frm.Show();
            }

        }

        private void Hotel_Btn_Click(object sender, EventArgs e)
        {
            frmHotelList frmHotelList = new frmHotelList();
            frmHotelList.TopLevel = false;
            panel3.Controls.Add(frmHotelList);
            frmHotelList.BringToFront();
            frmHotelList.Show();
        }

        private void Package_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Travel_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Food_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Users_Btn_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser(this);
            frmUser.TopLevel = false;
            panel3.Controls.Add(frmUser);
            frmUser.BringToFront();
            frmUser.Show();
        }

        private void Room_Btn_Click(object sender, EventArgs e)
        {
            frmRoom frmRoom = new frmRoom();
            frmRoom.TopLevel = false;
            panel3.Controls.Add(frmRoom);
            frmRoom.BringToFront();
            frmRoom.Show();
        }

        private void Booking_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
