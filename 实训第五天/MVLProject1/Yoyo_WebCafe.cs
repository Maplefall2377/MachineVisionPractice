using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MVLProject1
{
    public partial class Yoyo_WebCafe : Form
    {
        public Yoyo_WebCafe()
        {
            InitializeComponent();
        }
        private bool validateInput(string userName, string userPwd)
        {
            if (userName.Equals(string.Empty))
            {
                MessageBox.Show("用户名不能为空", "提示信息", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                textBox1.Focus();//光标停放到登录名输入框
                return false;
            }
            if (userPwd.Equals(string.Empty))
            {//省略提示密码未输入信息或者只输入空格……
                MessageBox.Show("密码不能为空", "提示信息", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }
            if (userPwd.Length < 6)
            {//省略提示密码长度不能小于6位……
                MessageBox.Show("密码长度不能小于6位", "提示信息", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }
            //如果输入的符合要求则继续
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String userpwd = textBox2.Text;
            bool checkOut = validateInput(username, userpwd);
            if (checkOut)
            {
                if (username == "admin" && userpwd == "123456")
                    MessageBox.Show("登录成功!", "提示", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认取消登录？", "提示信息", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
