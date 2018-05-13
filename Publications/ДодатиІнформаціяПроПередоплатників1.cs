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
    public partial class ДодатиІнформаціяПроПередоплатників1 : Form
    {
        public ДодатиІнформаціяПроПередоплатників1()
        {
            InitializeComponent();
        }
        public ДодатиІнформаціяПроПередоплатників1(ІндексиНаселенихПунктів f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;

        }
        public string text1, text2, text3, text4, text5, text6, text7, text8, text9;

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

        private void ДодатиІнформаціяПроПередоплатників1_FormClosed(object sender, FormClosedEventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox2.Text;
            text3 = textBox3.Text;
            text4 = textBox4.Text;
            text5 = textBox5.Text;
            text6 = textBox6.Text;
            text7 = textBox7.Text;
            text8 = textBox8.Text;
            text9 = textBox9.Text;
        }
    }
}
