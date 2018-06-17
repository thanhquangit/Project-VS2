using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hiện thị hộp thông báo, nếu chọn Yes thì thoát, Chọn NO chương trình không thoát
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt Radio Red làm mặc định
            radioButton1.Checked = true;
            // Đặt con trỏ chuột tại vị trí text box đầu tiên
            textBox1.Focus();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox2.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);
        }
    }
}
