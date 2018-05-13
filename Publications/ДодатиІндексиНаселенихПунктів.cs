using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publications
{
    public partial class ДодатиІндексиНаселенихПунктів : Form
    {
        public ДодатиІндексиНаселенихПунктів()
        {
            InitializeComponent();
        }
        public ДодатиІндексиНаселенихПунктів(ІндексиНаселенихПунктів f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;

        }
        public string text1, text2, text3, text4;
        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ДодатиІндексиНаселенихПунктів_FormClosed(object sender, FormClosedEventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox4.Text;
            text3 = textBox5.Text;
            text4 = textBox6.Text;
        }
    }
}
