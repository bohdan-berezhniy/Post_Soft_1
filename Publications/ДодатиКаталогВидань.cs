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
    public partial class ДодатиКаталогВидань : Form
    {
        public ДодатиКаталогВидань()
        {
            InitializeComponent();
        }
        public ДодатиКаталогВидань(КаталогВидань f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;

        }
        public string text1, text2, text3, text4, text5, text6;

        private void ДодатиКаталогВидань_FormClosed(object sender, FormClosedEventArgs e)
        {
            text1 = textBox1.Text;
            text2 = dateTimePicker1.Value.ToString("yyyyMMdd");
            text3 = dateTimePicker2.Value.ToString("yyyyMMdd");
            text4 = textBox4.Text;
            text5 = textBox5.Text;
            text6 = textBox6.Text;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ДодатиКаталогВидань_Load(object sender, EventArgs e)
        {

        }
    }
}
