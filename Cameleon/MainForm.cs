using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace Cameleon
{
    public partial class MainForm : Form
    {
        Stopwatch watch = new Stopwatch();

        SqlConnection con;
        //string sqlcmdselect = "SELECT * from Points where Id=@Id";
        string sqlcmdinsert = "INSERT into Points(Id,Showtime,pozx,pozy,ClickTime) VALUES(@Id,@Showtime,@pozx,@pozy,@ClickTime)";
        string sqlcmdupdate = "UPDATE Points SET ClickTime=@ClickTime WHERE Id=@Id";

        private FoundDataSet1 pointsDataSet = null;
        private FoundDataSet1TableAdapters.PointsTableAdapter ta = null;

        string connectionString;
        bool click = false;
        int scr = 0,pointID=0;
        public MainForm()
        {
            InitializeComponent();
            ta = new FoundDataSet1TableAdapters.PointsTableAdapter();
            pointsDataSet = new FoundDataSet1();
            ta.Fill(pointsDataSet.Points);
            connectionString = Properties.Settings.Default.FoundConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {          
            cameleon.Hide();          
        }
        

        private void Start_btn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            watch.Start();
            Random rnd = new Random();
            timer.Interval = rnd.Next(1, 4) * 1000;
            timer.Start();
            click = false;
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            ta.Fill(pointsDataSet.Points);
            con.Close();
            watch.Stop();
            timer.Stop();
            cameleon.Hide();
        }

        private void Cameleon_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (click == false)
            {                
                cameleon.Hide();
                timer.Stop();
                timer.Interval = rnd.Next(1, 4) * 1000;
                timer.Start();
                scr++;
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlcmdupdate, con);
                cmd.Parameters.AddWithValue("@Id", pointID);
                cmd.Parameters.AddWithValue("@ClickTime", watch.ElapsedMilliseconds);
                cmd.ExecuteNonQuery();
                con.Close();
                score.Text=scr.ToString();
                click = true;
            }
        }

        private void ShowProgress_Click(object sender, EventArgs e)
        {
            con.Open();
            ta.Fill(pointsDataSet.Points);
            con.Close();
            watch.Stop();
            timer.Stop();
            cameleon.Hide();
            progressPicture.Image = mainPicture.Image;
            progressPicture.Image = new Bitmap(progressPicture.Width, progressPicture.Height);
            //progressPicture.Image = mainPicture.Image;
            DataTable dt = pointsDataSet.Tables["Points"];
            foreach (DataRow row in dt.Rows)
            {
                int x, y;
                int var = cameleon.Size.Width;
                Color clicked = Color.Green;
                DataColumn col = dt.Columns["pozx"]; x=Convert.ToInt32(row[col]);
                col = dt.Columns["pozy"]; y = Convert.ToInt32(row[col]);
                col = dt.Columns["ClickTime"];
                if (Convert.ToInt32(row[col])==0)
                    clicked = Color.Red;               
                for(int i = x; i <= x + var; i++)
                {
                    for(int j = y; j <= y + var; j++)
                    {
                        ((Bitmap)progressPicture.Image).SetPixel(i, j, clicked);                            
                    }
                }
            }
            //mainPicture.Hide();
            cameleon.Hide();
            progressPicture.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cameleon.Show();            
            Random rnd = new Random();
            int var = cameleon.Size.Width;
            int x = rnd.Next(0, 500-var);
            int y = rnd.Next(0, 500-var);
            pointID++;
            ids.Text = pointID.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcmdinsert, con);            
            cmd.Parameters.AddWithValue("@Id", pointID);
            cmd.Parameters.AddWithValue("@Showtime", watch.ElapsedMilliseconds);
            cmd.Parameters.AddWithValue("@pozx", x);
            cmd.Parameters.AddWithValue("@pozy", y);
            cmd.Parameters.AddWithValue("@ClickTime", 0);
            cmd.ExecuteNonQuery();
            con.Close();
            Bitmap btmap = new Bitmap(mainPicture.ClientSize.Width, mainPicture.Height);
            mainPicture.DrawToBitmap(btmap, mainPicture.ClientRectangle);
            cameleon.BackColor = btmap.GetPixel(x + var / 2, y + var / 2);
            cameleon.Location = new Point(x, y);
            click = false;
        }
    }
}
