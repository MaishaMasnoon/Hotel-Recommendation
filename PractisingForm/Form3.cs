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
    public partial class Form3 : Form
    {
        
        DataClassesDataContext db = new DataClassesDataContext();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maisha\Downloads\Semi8\C#\Final\Project\LatestVersion-2.0.1\LatestVersion1.0.2\NewVersion1.0.2\projectprob\PractisingForm\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }

      
        
        //hotel view button  bt1
        private void button1_Click(object sender, EventArgs e)
        {

            CatagoryBandorban c = new CatagoryBandorban();
            this.Hide();
            //Type name 1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=14 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c.listBox5.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=15 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c.listBox6.Items.Add(row["RoomType"].ToString());

            }


            //type 1
            SqlDataAdapter aa = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=14 ", con);
            DataTable daa = new DataTable();

            aa.Fill(daa);
            foreach (DataRow row in daa.Rows)
            {

                c.listBox1.Items.Add(row["Description"].ToString());

            }
             //type2
            SqlDataAdapter bb = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=15 ", con);
            DataTable dbb = new DataTable();

            bb.Fill(dbb);
            foreach (DataRow row in dbb.Rows)
            {

                c.listBox4.Items.Add(row["Description"].ToString());

            }


            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=5 AND RoomCatagory.Id=14 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c.listBox2.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=5 AND RoomCatagory.Id=15 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c.listBox3.Items.Add(row["RoomRent"].ToString());

            }






            c.ShowDialog();
        }
        //btn1....over// +++++++



         //btn2......>>
        private void button2_Click(object sender, EventArgs e)
        {
            CatagoryBandorban1 c1 = new CatagoryBandorban1();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=16 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c1.listBox7.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=17 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c1.listBox8.Items.Add(row["RoomType"].ToString());

            }
            //type name3
            SqlDataAdapter aa3 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=19 ", con);
            DataTable daa3 = new DataTable();

            aa3.Fill(daa3);
            foreach (DataRow row in daa3.Rows)
            {

                c1.listBox9.Items.Add(row["RoomType"].ToString());

            }


            //type 1
            SqlDataAdapter aa = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=16 ", con);
            DataTable daa = new DataTable();

            aa.Fill(daa);
            foreach (DataRow row in daa.Rows)
            {

                c1.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter bb = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=17 ", con);
            DataTable dbb = new DataTable();

            bb.Fill(dbb);
            foreach (DataRow row in dbb.Rows)
            {

                c1.listBox4.Items.Add(row["Description"].ToString());

            }

            //type3
            SqlDataAdapter cc = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=19 ", con);
            DataTable dcc = new DataTable();

            cc.Fill(dcc);
            foreach (DataRow row in dcc.Rows)
            {

                c1.listBox6.Items.Add(row["Description"].ToString());

            }


            //rent

            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=6 AND RoomCatagory.Id=16 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c1.listBox2.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=6 AND RoomCatagory.Id=17 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c1.listBox3.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter rr2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=6 AND RoomCatagory.Id=19 ", con);
            DataTable dr2 = new DataTable();

            rr2.Fill(dr2);
            foreach (DataRow row in dr2.Rows)
            {

                c1.listBox5.Items.Add(row["RoomRent"].ToString());

            }



            c1.ShowDialog();
        }


        //hotel view button  bt3 >>

        private void button3_Click(object sender, EventArgs e)
        {
            CatagoryBandorban2 c2 = new CatagoryBandorban2();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=20 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c2.listBox5.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=21 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c2.listBox6.Items.Add(row["RoomType"].ToString());

            }

            //type 1
            SqlDataAdapter ee = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=20 ", con);
            DataTable dee = new DataTable();

            ee.Fill(dee);
            foreach (DataRow row in dee.Rows)
            {

                c2.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter ff = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=21 ", con);
            DataTable dff = new DataTable();

            ff.Fill(dff);
            foreach (DataRow row in dff.Rows)
            {

                c2.listBox4.Items.Add(row["Description"].ToString());

            }


            //rent>>


            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=7 AND RoomCatagory.Id=16 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c2.listBox2.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=7 AND RoomCatagory.Id=17 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {

                c2.listBox3.Items.Add(row["RoomRent"].ToString());

            }






            c2.ShowDialog();
        }


        //hotel view button  bt1>>
        private void button4_Click(object sender, EventArgs e)
        {
            CatagoryBandorban3 c3 = new CatagoryBandorban3();
            this.Hide();
            //type name1
            SqlDataAdapter aa1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=22 ", con);
            DataTable daa1 = new DataTable();

            aa1.Fill(daa1);
            foreach (DataRow row in daa1.Rows)
            {

                c3.listBox5.Items.Add(row["RoomType"].ToString());

            }

            //type name2
            SqlDataAdapter aa2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description,RoomCatagory.RoomType from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=24 ", con);
            DataTable daa2 = new DataTable();

            aa2.Fill(daa2);
            foreach (DataRow row in daa2.Rows)
            {

                c3.listBox6.Items.Add(row["RoomType"].ToString());

            }

            //type 1
            SqlDataAdapter ee = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=22 ", con);
            DataTable dee = new DataTable();

            ee.Fill(dee);
            foreach (DataRow row in dee.Rows)
            {

                c3.listBox1.Items.Add(row["Description"].ToString());

            }
            //type2
            SqlDataAdapter ff = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.Description from Hotel,RoomCatagory Where Hotel.Id=RoomCatagory.HotelId AND RoomCatagory.Id=24 ", con);
            DataTable dff = new DataTable();

            ff.Fill(dff);
            foreach (DataRow row in dff.Rows)
            {

                c3.listBox3.Items.Add(row["Description"].ToString());

            }



            //rent
            SqlDataAdapter r1 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=8 AND RoomCatagory.Id=22 ", con);
            DataTable drr1 = new DataTable();

            r1.Fill(drr1);
            foreach (DataRow row in drr1.Rows)
            {

                c3.listBox4.Items.Add(row["RoomRent"].ToString());

            }


            SqlDataAdapter r2 = new SqlDataAdapter("Select Hotel.Id,RoomCatagory.HotelId,RoomCatagory.Id,RoomCatagory.RoomRent from Hotel,RoomCatagory Where Hotel.Id=8 AND RoomCatagory.Id=24 ", con);
            DataTable drr2 = new DataTable();

            r2.Fill(drr2);
            foreach (DataRow row in drr2.Rows)
            {
               
                c3.listBox2.Items.Add(row["RoomRent"].ToString());

            }


            c3.ShowDialog();



         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
