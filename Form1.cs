using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string path = "Untitled.txt";
        
        public string checkConnection()
        {
            string content = "Username: 007, Name: James Bond, Occupation: Assassin\nUsername: Stig, Name: The Stig, Occupation: Reckless Driver\nUsername: Beast, Name: Tendai Mtawarira, Occupation: Lock\nUsername: Speed Merchant, Name: Percy Tau, Occupation: Goalscorer";

            if (!File.Exists(path))
            {
                using (StreamWriter sr = File.CreateText(path))
                {
                    sr.WriteLine(content);
                }
            }
            else
                return "Already exist";
            return path + " is created";
        }
        public string readFile()
        {
            string s;
            string ss=" ";
            
            using (StreamReader sr = File.OpenText(path))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    ss += s;
                    listBox1.Items.Add(s);
                }
            }
            return ss;
        }
        
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkConnection());
            readFile();
        }
    }
}
