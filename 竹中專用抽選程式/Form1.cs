using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 竹中專用抽選程式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsNum(string data)
        {
            int result;
            if (int.TryParse(data, out result))
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oout.Text = "";
            int num = 0,cn1=0,cn2=0,sn1=0,sn2=0;

            if(IsNum(nop.Text)) num = Convert.ToInt32(nop.Text);
            string[] CC = cn.Text.Split('-');
            if(IsNum(CC[0])) cn1 = Convert.ToInt32(CC[0]);
            if( CC.Length == 2) if (IsNum(CC[1])) cn2 = Convert.ToInt32(CC[1]);
            string[] SS = sn.Text.Split('-');
            if(IsNum(SS[0])) sn1 = Convert.ToInt32(SS[0]);
            if(SS.Length == 2) if (IsNum(SS[1])) sn2 = Convert.ToInt32(SS[1]);



            if (num == 0 || cn1 == 0 || cn1 > cn2  || sn1 == 0 || sn1 > sn2 )
            {
                MessageBox.Show("請照規則輸入");
            }
            else {

                bool[,] a= new bool[cn2, sn2];

                for (int i = 0; i < cn2; i++)
                {
                    for (int j = 0; j < sn2; j++)
                    {
                        a[i,j] = false;
                    }
                }
                 for (int i = 0; i < num; i++)
                {
                    Random rd = new Random(Guid.NewGuid().GetHashCode());
                    int cs = rd.Next(cn1,cn2+1);
                    int se = rd.Next(sn1, sn2 + 1);

                    while (a[cs-1,se-1]) {
                        cs = rd.Next(cn1, cn2 + 1);
                        se = rd.Next(sn1, sn2 + 1);
                    }
                    oout.Text += Convert.ToString(i + 1) + ": " + Convert.ToString(cs) + "班" + Convert.ToString(se) + "號" + Environment.NewLine;
                    a[cs - 1,se - 1] = true;
                }
            }
        }
    }
}
