using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVLProject2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String recv = (String)textBox1.Text;
            if (recv == "")
            {
                MessageBox.Show("请检查输入内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (recv == "河南理工")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("请检查输入内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
