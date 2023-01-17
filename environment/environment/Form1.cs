using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace environment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 6;
            dataGridView1[0, 0].Value = "Версия винды";
            dataGridView1[0, 1].Value =  "64 bit OC";
            dataGridView1[0, 2].Value = "Имя ПК";
            dataGridView1[0, 3].Value = "число процесоров";
            dataGridView1[0, 4].Value = "Систем папка";
            dataGridView1[0, 5].Value = "Логические диски";

            dataGridView1[1, 0].Value = Environment.OSVersion;
            dataGridView1[1, 1].Value = Environment.Is64BitOperatingSystem;
            dataGridView1[1, 2].Value = Environment.MachineName;
            dataGridView1[1, 3].Value = Environment.ProcessorCount;
            dataGridView1[1, 4].Value = Environment.SystemDirectory;
            dataGridView1[1, 5].Value = Environment.GetLogicalDrives();
            string[] s = Environment.GetLogicalDrives();
            string str = "";
             for(int i=0; i<s.Length; i++ )
            {
                str += s[i]+" ";
            }
            dataGridView1[1, 5].Value = str;






        }
    }
}
