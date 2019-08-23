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

namespace PractisingForm
{
    public partial class Form2 : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maisha\Downloads\Semi8\C#\Final\Project\LatestVersion-2.0.1\LatestVersion1.0.2\NewVersion1.0.2\projectprob\PractisingForm\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CatagoryChittagong c = new CatagoryChittagong();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=1 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c.listBox7.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=2 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c.listBox8.Items.Add(row["RoomType"].ToString());

            }

            //type name3
            SqlDataAdapter aa3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=3 ", con);
            DataTable daa3 = new DataTable();

            aa3.Fill(daa3);
            foreach (DataRow row in daa3.Rows)
            {

                c.listBox9.Items.Add(row["RoomType"].ToString());

            }


            //type 1
            SqlDataAdapter aa = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=1 ", con);
            DataTable daa = new DataTable();

            aa.Fill(daa);
            foreach (DataRow row in daa.Rows)
            {

                c.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter bb = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=2 ", con);
            DataTable dbb = new DataTable();

            bb.Fill(dbb);
            foreach (DataRow row in dbb.Rows)
            {

                c.listBox2.Items.Add(row["Description"].ToString());

            }

            //type3
            SqlDataAdapter cc = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=3 ", con);
            DataTable dcc = new DataTable();

            cc.Fill(dcc);
            foreach (DataRow row in dcc.Rows)
            {

                c.listBox3.Items.Add(row["Description"].ToString());

            }


            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=1 AND RoomCatagory.Id=1 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c.listBox4.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=1 AND RoomCatagory.Id=2 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c.listBox5.Items.Add(row["RoomRent"].ToString());

            }

            SqlDataAdapter r3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=1 AND RoomCatagory.Id=3 ", con);
            DataTable drr3 = new DataTable();

            r3.Fill(drr3);
            foreach (DataRow row in drr3.Rows)
            {

                c.listBox6.Items.Add(row["RoomRent"].ToString());

            }

          





            c.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            CatagoryChittagong1 c = new CatagoryChittagong1();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=4 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c.listBox7.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=6 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c.listBox8.Items.Add(row["RoomType"].ToString());

            }

            //type name3
            SqlDataAdapter aa3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=8 ", con);
            DataTable daa3 = new DataTable();

            aa3.Fill(daa3);
            foreach (DataRow row in daa3.Rows)
            {

                c.listBox9.Items.Add(row["RoomType"].ToString());

            }


            //type 1
            SqlDataAdapter aa = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=4 ", con);
            DataTable daa = new DataTable();

            aa.Fill(daa);
            foreach (DataRow row in daa.Rows)
            {

                c.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter bb = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=6 ", con);
            DataTable dbb = new DataTable();

            bb.Fill(dbb);
            foreach (DataRow row in dbb.Rows)
            {

                c.listBox2.Items.Add(row["Description"].ToString());

            }

            //type3
            SqlDataAdapter cc = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=8 ", con);
            DataTable dcc = new DataTable();

            cc.Fill(dcc);
            foreach (DataRow row in dcc.Rows)
            {

                c.listBox3.Items.Add(row["Description"].ToString());

            }


            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=2 AND RoomCatagory.Id=4 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c.listBox4.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=2 AND RoomCatagory.Id=6 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c.listBox5.Items.Add(row["RoomRent"].ToString());

            }

            SqlDataAdapter r3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=2 AND RoomCatagory.Id=8 ", con);
            DataTable drr3 = new DataTable();

            r3.Fill(drr3);
            foreach (DataRow row in drr3.Rows)
            {

                c.listBox6.Items.Add(row["RoomRent"].ToString());

            }







            c.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatagoryChittagong2 c = new CatagoryChittagong2();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=9 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c.listBox7.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=10 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c.listBox8.Items.Add(row["RoomType"].ToString());

            }

            //type name3
            SqlDataAdapter aa3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=11 ", con);
            DataTable daa3 = new DataTable();

            aa3.Fill(daa3);
            foreach (DataRow row in daa3.Rows)
            {

                c.listBox9.Items.Add(row["RoomType"].ToString());

            }



            //type 1
            SqlDataAdapter aa = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=9 ", con);
            DataTable daa = new DataTable();

            aa.Fill(daa);
            foreach (DataRow row in daa.Rows)
            {

                c.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter bb = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=10 ", con);
            DataTable dbb = new DataTable();

            bb.Fill(dbb);
            foreach (DataRow row in dbb.Rows)
            {

                c.listBox2.Items.Add(row["Description"].ToString());

            }

            //type3
            SqlDataAdapter cc = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=11 ", con);
            DataTable dcc = new DataTable();

            cc.Fill(dcc);
            foreach (DataRow row in dcc.Rows)
            {

                c.listBox3.Items.Add(row["Description"].ToString());

            }


            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=3 AND RoomCatagory.Id=9 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c.listBox4.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=3 AND RoomCatagory.Id=10 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c.listBox5.Items.Add(row["RoomRent"].ToString());

            }

            SqlDataAdapter r3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=3 AND RoomCatagory.Id=11 ", con);
            DataTable drr3 = new DataTable();

            r3.Fill(drr3);
            foreach (DataRow row in drr3.Rows)
            {

                c.listBox6.Items.Add(row["RoomRent"].ToString());

            }







            c.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CatagoryChittagong3 c = new CatagoryChittagong3();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=12 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c.listBox7.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=13 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c.listBox3.Items.Add(row["RoomType"].ToString());

            }

           

            //type 1
            SqlDataAdapter aa = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=12 ", con);
            DataTable daa = new DataTable();

            aa.Fill(daa);
            foreach (DataRow row in daa.Rows)
            {

                c.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter bb = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=13 ", con);
            DataTable dbb = new DataTable();

            bb.Fill(dbb);
            foreach (DataRow row in dbb.Rows)
            {

                c.listBox2.Items.Add(row["Description"].ToString());

            }

       


            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=4 AND RoomCatagory.Id=12 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c.listBox4.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=4 AND RoomCatagory.Id=13 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c.listBox5.Items.Add(row["RoomRent"].ToString());

            }

           






            c.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }
    }
}
