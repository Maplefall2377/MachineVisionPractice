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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String recv = textBox1.Text;
            if (recv == "")
            {
                MessageBox.Show("请输入要添加的文本内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            { 
                listBox1.Items.Add(recv); //向文本列表中添加输入的内容
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("列表为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);//从文本列表中删除选中的内容
            }
        }
    }
}
