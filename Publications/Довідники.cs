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
    public partial class Довідники : Form
    {
        public Довідники()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            КаталогВидань k = new КаталогВидань();
            k.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ІндексиНаселенихПунктів k = new ІндексиНаселенихПунктів();
            k.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ІнформаціяПроПередоплатника k = new ІнформаціяПроПередоплатника();
            k.Show();
            this.Close();
        }

     

        private void Довідники_Load(object sender, EventArgs e)
        {

        }
    }
}
