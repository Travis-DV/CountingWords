using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countingwords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTB_TextChanged(object sender, EventArgs e)
        {
            string[] words = inputTB.Text.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    count++;
                }
            }
            outputLB.Text = $"You have {count} words";
        }
    }
}
