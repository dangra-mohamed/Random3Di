using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_No_Generator
{
    public partial class DICL : Form
    {
        List<int> genValues =new List<int>();
        List<Players> PlayersList = new List<Players>();
        public DICL()
        {
            InitializeComponent();
            
            lstArray.Text = "";
            lstArray.MaximumSize = new Size(600, 0);
            lstArray.AutoSize = true;
            lblGenName.Text = "";
            this.WindowState = FormWindowState.Maximized;

            //int height = Screen.PrimaryScreen.Bounds.Height;
            //int width = Screen.PrimaryScreen.Bounds.Width;

            //WindowState = FormWindowState.Maximized;
            //MinimumSize = this.Size;
            //MaximumSize = this.Size;

            GetAllUsers();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "")
                MessageBox.Show("Please provide From and To value.");
            else if((Convert.ToInt32(txtTo.Text)) < (Convert.ToInt32(txtFrom.Text)))
                MessageBox.Show("From Value is greater than To value.");
            else if (Convert.ToInt32(txtTo.Text) > 39)
                MessageBox.Show("To Value should not be greater than 39.");
            else
            {
                if ((Convert.ToInt32(txtTo.Text)+ 1) - (Convert.ToInt32(txtFrom.Text)) != genValues.Count)
                {
                    Random rnd = new Random();
                    int value = 0;
                    do
                    {
                        value = rnd.Next(Convert.ToInt32(txtFrom.Text), Convert.ToInt32(txtTo.Text) + 1);

                        if (genValues.Count == 0)
                            break;

                    } while (genValues.Contains(value));

                    genValues.Add(value);

                    Players Pl = new Players();
                    Pl = PlayersList.Where(m => m.Id == value).FirstOrDefault();

                    lblGenNo.Text = value.ToString() + ".";
                    lblGenName.Text = "";
                    llblPlLink.ImageKey = Pl.Link;
                    llblPlLink.Text = Pl.Name;
                    lstArray.Text = "";
                    foreach (int a in genValues)
                    {
                        lstArray.Text += a.ToString() + " | ";
                    }
                    lstArray.ToString().TrimEnd('|');
                    if(Pl.Retained != "0")
                    {
                        lblGenName.Text = Pl.Name + " is " + Pl.Retained;
                    }
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            genValues.Clear();
            lstArray.Text = "";
            lblGenNo.Text = "No";
            lblGenName.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            llblPlLink.Text = "Player Name";
        }
        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            genValues.Clear();
            lstArray.Text = "";
            lblGenNo.Text = "No";
            lblGenName.Text = "";
            llblPlLink.Text = "Player Name";
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            genValues.Clear();
            lstArray.Text = "";
            lblGenNo.Text = "No";
            lblGenName.Text = "";
            llblPlLink.Text = "Player Name";
        }

        private void GetAllUsers()
        {
            PlayersList.Add(new Players(1, "Suresh Auti", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381084&clubId=1498", "0"));
            PlayersList.Add(new Players(2, "Pranav Kinage", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381078&clubId=1498", "0"));
            PlayersList.Add(new Players(3, "Pratiksh Singh", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381076&clubId=1498", "0"));
            PlayersList.Add(new Players(4, "Ravindra Dolas", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=414235&clubId=1498", "0"));
            PlayersList.Add(new Players(5, "Amit Singh", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=412830&clubId=1498", "0"));
            PlayersList.Add(new Players(6, "Prashant Patil", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381086&clubId=1498", "0"));
            PlayersList.Add(new Players(7, "Ramesh Kadam", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=604571&clubId=1498", "0"));
            PlayersList.Add(new Players(8, "Vivek Jain", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381097&clubId=1498", "0"));
            PlayersList.Add(new Players(9, "Mohamed Dangra", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381077&clubId=1498", "0"));
            PlayersList.Add(new Players(10, "Prasad Bhoite", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381133&clubId=1498", "0"));
            PlayersList.Add(new Players(11, "Nitin Bhattacharya", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381110&clubId=1498", "0"));
            PlayersList.Add(new Players(12, "Suhas More", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381092&clubId=1498", "0"));
            PlayersList.Add(new Players(13, "Aswini Patra", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=656150&clubId=1498", "0"));
            PlayersList.Add(new Players(14, "Ritesh Sahu", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381120&clubId=1498", "0"));
            PlayersList.Add(new Players(15, "Darshan Desai", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=653088&clubId=1498", "Owner of Kings"));
            PlayersList.Add(new Players(16, "Mridul Singh", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=486645&clubId=1498", "0"));
            PlayersList.Add(new Players(17, "Sreedhar Reddy", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381126&clubId=1498", "Owner of Indians"));
            PlayersList.Add(new Players(18, "Bhooshan V", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381119&clubId=1498", "Owner of Indians"));
            PlayersList.Add(new Players(19, "Shevin Varughese", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381138&clubId=1498", "Retained by Kings"));
            PlayersList.Add(new Players(20, "Mayur", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=957860&clubId=1498", "0"));
            PlayersList.Add(new Players(21, "Manoj Jangle", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=667390&clubId=1498", "0"));
            PlayersList.Add(new Players(22, "Nitin Patil", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381129&clubId=1498", "0"));
            PlayersList.Add(new Players(23, "Pankaj Patil", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381121&clubId=1498", "0"));
            PlayersList.Add(new Players(24, "Manoj Patil", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=990216&clubId=1498", "0"));
            PlayersList.Add(new Players(25, "Piyush Gandhi", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=414470&clubId=1498", "0"));
            PlayersList.Add(new Players(26, "Tamilanban", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381104&clubId=1498", "0"));
            PlayersList.Add(new Players(27, "Sanjay Dumbre", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381080&clubId=1498", "Owner of Kings"));
            PlayersList.Add(new Players(28, "Ritesh Shah", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381103&clubId=1498", "0"));
            PlayersList.Add(new Players(29, "Sahadev Rajpurohit", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381382&clubId=1498", "Owner of Kings"));
            PlayersList.Add(new Players(30, "Sameer N", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381136&clubId=1498", "Owner of Warriors"));
            PlayersList.Add(new Players(31, "Ayush S", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=990213&clubId=1498", "0"));
            PlayersList.Add(new Players(32, "Suraj Gharat", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381101&clubId=1498", "0"));
            PlayersList.Add(new Players(33, "Sagar Rajpure", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=990214&clubId=1498", "0"));
            PlayersList.Add(new Players(34, "Rajiv Desai Sir", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=434781&clubId=1498", "0"));
            PlayersList.Add(new Players(35, "Rajkumar", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=381139&clubId=1498", "0"));
            PlayersList.Add(new Players(36, "Sameer Kanade", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=434780&clubId=1498", "0"));
            PlayersList.Add(new Players(37, "Prabhakar Panda", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=1472590&clubId=1498", "0"));
            PlayersList.Add(new Players(38, "Rajesh V", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=1472586&clubId=1498", "0"));
            PlayersList.Add(new Players(39, "Bipin Gajbhiye", "https://cricclubs.com/3DiCL/viewPlayer.do?playerId=1472579&clubId=1498", "0"));

        }

        private void llblPlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((System.Windows.Forms.LinkLabel)sender).ImageKey);
        }

        private void lblGenNo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DICL_Load(object sender, EventArgs e)
        {
            lblGenName.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGenName_Click(object sender, EventArgs e)
        {

        }

        private void lstArray_Click(object sender, EventArgs e)
        {

        }
    }

    public class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public string Retained { get; set; }

        public Players()
        {

        }
        public Players(int ID, string Name, string Link, string retained)
        {
            this.Id = ID;
            this.Name = Name;
            this.Link = Link;
            this.Retained = retained;

        }
    }
}
