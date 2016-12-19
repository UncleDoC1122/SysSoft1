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
        private List<List<Tuple<string, int>>> hashTable = new List<List<Tuple<string, int>>>();
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

        private int calcHashFunc(int value)
        {
            return (value % 1097);
        }

        private List<Tuple<string, int>> findInHashTable(List<List<Tuple<string, int>>> input, string findIt)
        {
            int hashCode = 0;
            List<Tuple<string, int>> output = new List<Tuple<string, int>>();
            for (int j = 0; j < findIt.Length; j++)
            {
                hashCode += Convert.ToInt32(findIt[j]);
            }

            hashCode = calcHashFunc(hashCode);

            bool flag = false;

            for (int i = 0; i < input.Count; i++)
            {
                List<Tuple<string, int>> tmp = input[i];
                if (tmp[0] != null && tmp[0].Item2 == hashCode)
                {
                    flag = true;
                    for (int k = 0; k < tmp.Count; k ++)
                    {
                        output.Add(tmp[k]);
                    }
                }
            }

            if (flag == false)
            {
                Tuple<string, int> outp = new Tuple<string, int>("Not Found", 0);
                output.Add(outp);
            }

            return output;
        }



        private void DoItBtn_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader fileReader = new System.IO.StreamReader(InputData);
            List<string> tempList = new List<string>();
            string line;
            while ((line = fileReader.ReadLine()) != null)
            {
                tempList.Add(line);
            }

            for (int i = 0; i < tempList.Count; i ++)
            {
                int tmpNum = 0;
                for (int j = 0; j < tempList[i].Length; j++)
                {
                    tmpNum += Convert.ToInt16(tempList[i][j]);
                }

                tmpNum = calcHashFunc(tmpNum);
                if (hashTable.Count == 0)
                {
                    List<Tuple<string, int>> tmp = new List<Tuple<string, int>>();
                    Tuple<string, int> tmpTup = new Tuple<string, int>(tempList[i], tmpNum);
                    tmp.Add(tmpTup);
                    hashTable.Add(tmp);
                }
                else
                {
                    bool flag = false;
                    for (int k = 0; k < hashTable.Count; k++)
                    {
                        List<Tuple<string, int>> tmp = hashTable[k];
                        if (tmpNum == tmp[0].Item2)
                        {
                            Tuple<string, int> tmpTup = new Tuple<string, int>(tempList[i], tmpNum);
                            tmp.Add(tmpTup);
                            hashTable[k] = tmp;
                            flag = true;
                        }

                    }

                    if (flag == false)
                    {
                        Tuple<string, int> tmpTup = new Tuple<string, int>(tempList[i], tmpNum);
                        List<Tuple<string, int>> tmp2 = new List<Tuple<string, int>>();
                        tmp2.Add(tmpTup);
                        hashTable.Add(tmp2);
                    }
                        
                    
                }
            }

            string testOut = "";

            //for (int i = 0; i < hashTable.Count; i ++)
            //{
            //    List<Tuple<string, int>> tmp = hashTable[i];
            //    for (int j = 0; j < tmp.Count; j ++)
            //    {
            //        testOut += tmp[j].Item1 + " | " + tmp[j].Item2 + "\n";
            //    }
            //}

            //MessageBox.Show(testOut);



            fileReader = new System.IO.StreamReader(InputQuery);
            tempList.Clear();

            while ((line = fileReader.ReadLine()) != null)
            {
                tempList.Add(line);
            }

            List<Tuple<string, int>> foundPairs = new List<Tuple<string, int>>();
            string output = "Found in HashTable\n";

            for (int i = 0; i < tempList.Count; i ++)
            {
                foundPairs = findInHashTable(hashTable, tempList[i]);
                for (int j = 0; j < foundPairs.Count; j ++)
                {
                    output += "\nValue:  " + foundPairs[j].Item1.ToString() + "  HashCode:  " + foundPairs[j].Item2.ToString();
                         
                }
            }

            MessageBox.Show(output);

        }
    }
}
