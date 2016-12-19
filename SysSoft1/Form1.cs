using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysSoft1
{
    public partial class Form1 : Form
    {
        private string InputData = "";
        private string InputQuery = "";
        private string OutputData = "";
        private List<Tuple<string, int>>[] = new List<Tuple<string, int>>[]();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void InputDataBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                InputData = openFileDialog1.FileName;
                textBox1.Text = InputData;
                sr.Close();
            }
        }

        private void InputQueriesBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                InputQuery = openFileDialog1.FileName;
                textBox2.Text = InputQuery;
                sr.Close();
            }
        }

        private void OutputBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                OutputData = openFileDialog1.FileName;
                textBox3.Text = OutputData;
                sr.Close();
            }
        }

        private void DoItBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
