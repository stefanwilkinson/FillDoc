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
using System.Data.Sql;

namespace _6CAttendance
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=xx.xxx.xxx.xx,1433;Initial Catalog=Roster;User ID=something;Password = something");
        SqlCommand command = new SqlCommand();
        int count = 0;
        Boolean go = false;
        String greeter = "";
        String[] greeting = new String[] {"Hello Cybersecurity Profressionals! Please sign in.\n",
                                          "We encourage using your student emails to sign in\n",
                                          "as that will be our primary way of contacting you.\n",
                                          "If you dont have one,",
                                          " any email suffices.\n",
                                          "Enjoy todays session and please no illegal hacking."};
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void SignIL_Click(object sender, EventArgs e)
        {
            if(emailValid())
            {
                reg("yes");
            }
            else
            {
                MessageBox.Show("Please enter a valid email");
            }
        }
        private void SignOL_Click(object sender, EventArgs e)
        {
            if (emailValid())
            {
                reg("no");
            }
            else
            {
                MessageBox.Show("Please enter a valid email");
            }
        }
        public Boolean emailValid()
        {
            if(EMT.Text.Contains("@"))
            {
                return true;
            }
            return false;
        }
        public void reg(String inp)
        {
            go = true;
            count = 0;
            connection.Open();
            if (inp.Equals("yes"))
            {
                command = new SqlCommand("INSERT INTO SignIn(Firstname,Lastname,Email,Time,Date,Comment) VALUES (@Firstname,@Lastname,@Email,@Time,@Date,@Comment)",connection);
                command.Parameters.AddWithValue("@Firstname", FNT.Text);
                command.Parameters.AddWithValue("@Lastname", LNT.Text);
                command.Parameters.AddWithValue("@Email", EMT.Text);
                command.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
                command.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
                command.Parameters.AddWithValue("@Comment", CMT.Text);
                command.ExecuteNonQuery();
                GreetL.Text = "Thanks for signing in " + FNT.Text + "\nPlease dont forget to sign out!";
            }
            else
            {
                command = new SqlCommand("INSERT INTO SignOut(Firstname,Lastname,Email,Time,Date,Comment) VALUES (@Firstname,@Lastname,@Email,@Time,@Date,@Comment)",connection);
                command.Parameters.AddWithValue("@Firstname", FNT.Text);
                command.Parameters.AddWithValue("@Lastname", LNT.Text);
                command.Parameters.AddWithValue("@Email", EMT.Text);
                command.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
                command.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
                command.Parameters.AddWithValue("@Comment", CMT.Text);
                command.ExecuteNonQuery();
                GreetL.Text = "Thanks for signing out " + FNT.Text ;
            }
            connection.Close();
            Front.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count % 2 == 0 && go == false && count <= greeting.Length * 2 - 2)
            {
                greeter = greeter + greeting[count/2];
                GreetL.Text = greeter;
            }
            count++;
            TT.Text = DateTime.Now.ToString();
            if (count == 5 && go == true)
            {
                Front.Visible = true;
                greeter = "";
                wipe();
            }
        }
        private void wipe()
        {
            count = 0;
            go = false;
            CMT.Text = "";
            FNT.Text = "";
            LNT.Text = "";
            EMT.Text = "";
            GreetL.Text = "";
        }
    }
}
