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
    public partial class CatagoryChittagong2 : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maisha\Downloads\Semi8\C#\Final\Project\LatestVersion-2.0.1\LatestVersion1.0.2\NewVersion1.0.2\projectprob\PractisingForm\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        public CatagoryChittagong2()
        {
            InitializeComponent();
        }

        private void CatagoryChittagong2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();

            SqlDataAdapter a = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName,Hotel.HotelAddress from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=1  ", con);
            DataTable da = new DataTable();

            a.Fill(da);
            foreach (DataRow row in da.Rows)
            {

                f2.listBox1.Items.Add(row["HotelAddress"].ToString());

            }

            SqlDataAdapter b = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName,Hotel.HotelAddress from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=2  ", con);
            DataTable db = new DataTable();

            b.Fill(db);
            foreach (DataRow row in db.Rows)
            {

                f2.listBox6.Items.Add(row["HotelAddress"].ToString());

            }
            SqlDataAdapter c = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName,Hotel.HotelAddress from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=3  ", con);
            DataTable dc = new DataTable();

            c.Fill(dc);
            foreach (DataRow row in dc.Rows)
            {

                f2.listBox9.Items.Add(row["HotelAddress"].ToString());

            }
            SqlDataAdapter d = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName,Hotel.HotelAddress from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=4 ", con);
            DataTable dd = new DataTable();

            d.Fill(dd);
            foreach (DataRow row in dd.Rows)
            {

                f2.listBox12.Items.Add(row["HotelAddress"].ToString());

            }
            SqlDataAdapter f = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=1  ", con);
            DataTable df = new DataTable();

            f.Fill(df);
            foreach (DataRow row in df.Rows)
            {

                f2.listBox2.Items.Add(row["HotelName"].ToString());

            }


            SqlDataAdapter g = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=2 ", con);
            DataTable dg = new DataTable();

            g.Fill(dg);
            foreach (DataRow row in dg.Rows)
            {

                f2.listBox5.Items.Add(row["HotelName"].ToString());

            }

            SqlDataAdapter h = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=3  ", con);
            DataTable dh = new DataTable();

            h.Fill(dh);
            foreach (DataRow row in dh.Rows)
            {

                f2.listBox8.Items.Add(row["HotelName"].ToString());

            }


            SqlDataAdapter i = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=4  ", con);
            DataTable di = new DataTable();

            i.Fill(di);
            foreach (DataRow row in di.Rows)
            {

                f2.listBox11.Items.Add(row["HotelName"].ToString());

            }


            //rating

            SqlDataAdapter j = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelRating,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=1 ", con);
            DataTable dj = new DataTable();

            j.Fill(dj);
            foreach (DataRow row in dj.Rows)
            {

                f2.listBox3.Items.Add(row["HotelRating"].ToString());

            }


            SqlDataAdapter k = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelRating,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=2 ", con);
            DataTable dk = new DataTable();

            k.Fill(dk);
            foreach (DataRow row in dk.Rows)
            {

                f2.listBox4.Items.Add(row["HotelRating"].ToString());

            }


            SqlDataAdapter l = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelRating,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=3  ", con);
            DataTable dl = new DataTable();

            l.Fill(dl);
            foreach (DataRow row in dl.Rows)
            {

                f2.listBox7.Items.Add(row["HotelRating"].ToString());

            }

            SqlDataAdapter m = new SqlDataAdapter("Select Place.Id,Hotel.PlaceId,Hotel.HotelRating,Hotel.HotelName from Place,Hotel Where Place.Id=Hotel.PlaceId AND Place.Id=1 AND Hotel.Id=4  ", con);
            DataTable dm = new DataTable();

            m.Fill(dm);
            foreach (DataRow row in dm.Rows)
            {

                f2.listBox10.Items.Add(row["HotelRating"].ToString());

            }


            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Reservation Please Call : 02-8829293 or email : hrs@gmail.com!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Reservation Please Call : 02-8829293 or email : hrs@gmail.com!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Reservation Please Call : 02-8829293 or email : hrs@gmail.com!");
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
