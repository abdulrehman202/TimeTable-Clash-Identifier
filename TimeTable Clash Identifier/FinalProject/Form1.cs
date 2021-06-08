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

namespace FinalProject
{
    public partial class Form1 : Form
    {
        SqlConnection cn;

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(Localdb)\abdulrehman;Initial Catalog=FinalProject;Integrated Security=True;MultipleActiveResultSets=true");
            cn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Open)
            {

                MessageBox.Show("Connected!");
                LoginPanel.Visible = true;
            }
            else MessageBox.Show("Connection Failed!");
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from LOGIN where Username='" + UsernameTB.Text + "' and Password='" + PasswordTB.Text + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            int count = 0;
            while (dr.Read())
                count++;
            dr.Close();

            if (count == 0) { MessageBox.Show("Invalid Username or Password!");}
            else
            {
                    
                LoginPanel.Visible = false;

                ClashCheckPanel.Visible = true;

                SqlCommand cmd1 = new SqlCommand("Select DISTINCT CourseName From Timetable", cn);
                var readTable = cmd1.ExecuteReader();

                while (readTable.Read()) {
                    Course1_CB.Items.Add(Convert.ToString(readTable["CourseName"]));
                    Course2_CB.Items.Add(Convert.ToString(readTable["CourseName"]));
                    Course3_CB.Items.Add(Convert.ToString(readTable["CourseName"]));
                }
            }
        }

        private void Calculus2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Course1_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BatchCB1.Text = "";
            SectionCB1.Text = "";
            
            BatchCB1.Items.Clear();
            SectionCB1.Items.Clear();
            SqlCommand cmd1 = new SqlCommand("Select DISTINCT BATCH from Timetable where CourseName='" + Course1_CB.Text + "'", cn);
            
            var readTable1 = cmd1.ExecuteReader();
            
            while (readTable1.Read())
            {
                BatchCB1.Items.Add(Convert.ToString(readTable1["BATCH"]));
            }
        }

        private void Course2_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BatchCB2.Text = "";
            SectionCB2.Text = "";
            
            BatchCB2.Items.Clear();
            SectionCB2.Items.Clear();
            SqlCommand cmd1 = new SqlCommand("Select DISTINCT BATCH from Timetable where CourseName='" + Course2_CB.Text + "'", cn);
          
            var readTable1 = cmd1.ExecuteReader();
          
            while (readTable1.Read() ) { 
                BatchCB2.Items.Add(Convert.ToString(readTable1["BATCH"]));
            }
        }

        private void Course3_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BatchCB3.Text = "";
            SectionCB3.Text = "";

            BatchCB3.Items.Clear();
            SectionCB3.Items.Clear();
            SqlCommand cmd1 = new SqlCommand("Select DISTINCT BATCH from Timetable where CourseName='" + Course3_CB.Text + "'", cn);
            var readTable1 = cmd1.ExecuteReader();
            
            while (readTable1.Read())
            {
                BatchCB3.Items.Add(Convert.ToString(readTable1["BATCH"]));
            }
          
        }
        
        private void CheckClashBTN_Click(object sender, EventArgs e)
        {

            string query_1 = "EXECUTE CheckClash @c1='" + Course1_CB.Text + "',@c2='" + Course2_CB.Text + "',@c3='" + Course3_CB.Text + "',";
            string query_2 = "@s1='"+SectionCB1.Text+"',@s2='"+SectionCB2.Text+"',@s3='"+SectionCB3.Text+"',";
            string query_3 = "@b1='" + BatchCB1.Text + "',@b2='" + BatchCB2.Text + "',@b3='" + BatchCB3.Text + "'";
            
            SqlCommand cmd = new SqlCommand(query_1+query_2+query_3, cn);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = cmd;
            DataTable DT = new DataTable();
            DA.Fill(DT);
            TimeTableClashGrid.DataSource = DT;

            if (TimeTableClashGrid.RowCount == 1)
            {
                string s = "Select * from Timetable where (CourseName='"+Course1_CB.Text+"' And BATCH='"+BatchCB1.Text+"' and Section='"+SectionCB1.Text+"')";
                string s1 = " OR (CourseName='"+Course2_CB.Text+"' And BATCH='"+BatchCB2.Text+"' and Section='"+SectionCB2.Text+"')";
                string s2 = " OR (CourseName='"+Course3_CB.Text+"' And BATCH='"+BatchCB3.Text+"' and Section='"+SectionCB3.Text+"')";
                TimeTableClashGrid.DataSource = null;
                SqlCommand cmd1 = new SqlCommand(s+s1+s2,cn);
                SqlDataAdapter D1 = new SqlDataAdapter();
                D1.SelectCommand = cmd1;
                DataTable DT1 = new DataTable();
                D1.Fill(DT1);
                TimeTableClashGrid.DataSource = DT1;
                TimeTableClashGrid.Visible = true;
                CongoLabel.Visible = true;
                CongoLabel.Text = "";
                Blink();
                SuggestBTN.Visible = true;
            }

            else
            {
                TimeTableClashGrid.Visible = true;
                SuggestBTN.Visible = true;
            }
                ClashCheckPanel.Visible = false;
                ClashPanel.Visible = true;
        }
        private async void Blink()
        {
            string text = "Congratulations! No Clash Found.";
            int c = 0;
            while (c<text.Length)
            {
                await Task.Delay(200);
                CongoLabel.Text += text[c];
                c++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TimeTableClashGrid.DataSource = null;
            ClashPanel.Visible = false;
            ClashCheckPanel.Visible = true;
            CongoLabel.Visible = false;
            TimeTableClashGrid.Visible = false;
            SuggestBTN.Visible = false;

            Course1_CB.Text = "";
            Course2_CB.Text = "";
            Course3_CB.Text = "";

            SectionCB1.Text = "";
            SectionCB2.Text = "";
            SectionCB3.Text = "";

            BatchCB1.Text = "";
            BatchCB2.Text = "";
            BatchCB3.Text = "";

            SectionCB1.Items.Clear();
            SectionCB2.Items.Clear();
            SectionCB3.Items.Clear();

            BatchCB1.Items.Clear();
            BatchCB2.Items.Clear();
            BatchCB3.Items.Clear();
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTB.TextLength == 3){
                UsernameTB.Text += '-';
                UsernameTB.Select();
                UsernameTB.Select(UsernameTB.Text.Length, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] course = new string[3];
            string str;
            course[2] = "";
            int j = 0;
            for (int i = 0; i < TimeTableClashGrid.RowCount - 1; i++) { 
            
                str = TimeTableClashGrid.Rows[i].Cells["CourseName"].Value.ToString();
                if (!Duplicate(str, course)){
                    course[j] = str;
                    j++;
                }
            }
            TimeTableClashGrid.DataSource = null;
            SqlCommand cmd = new SqlCommand("Execute Suggest '" + course[0] + "','" + course[1] + "','"+course[2]+"'", cn);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = cmd;
            DataTable DT = new DataTable();
            DA.Fill(DT);
            TimeTableClashGrid.DataSource = DT;
            SuggestBTN.Visible = false;
        }

        bool Duplicate(string str, string[] arr) {

            for (int a = 0; a < 3; a++){
                if (arr[a] == str)
                    return true;
            }

                return false;
        }

        private void ClashCheckPanel_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void BatchCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionCB1.Text = "";
            SectionCB1.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select distinct Section From Timetable where BATCH='"+BatchCB1.Text+"' AND CourseName='"+Course1_CB.Text+"'",cn);

            var readTable = cmd.ExecuteReader();

            while (readTable.Read())
            {
                SectionCB1.Items.Add(Convert.ToString(readTable["Section"]));
            }
        }

        private void BatchCB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionCB2.Text="";
            SectionCB2.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select distinct Section From Timetable where BATCH='" + BatchCB2.Text + "' AND CourseName='" + Course2_CB.Text + "'", cn);

            var readTable = cmd.ExecuteReader();

            while (readTable.Read())
            {
                SectionCB2.Items.Add(Convert.ToString(readTable["Section"]));
            }
        }

        private void BatchCB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionCB3.Text="";
            SectionCB3.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select distinct Section From Timetable where BATCH='" + BatchCB3.Text + "' AND CourseName='" + Course3_CB.Text + "'", cn);

            var readTable = cmd.ExecuteReader();

            while (readTable.Read())
            {
                SectionCB3.Items.Add(Convert.ToString(readTable["Section"]));
            }
        }
    }
}
