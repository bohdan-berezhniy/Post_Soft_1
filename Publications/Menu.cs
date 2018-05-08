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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ПроПрограму формаПроПрограму = new ПроПрограму();

         
            
            формаПроПрограму.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Довідники формаДовідники = new Довідники();
            this.Hide();
            формаДовідники.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ПрийняттяПредоплати формаПрийняттяПредоплати = new ПрийняттяПредоплати();
            this.Hide();
            формаПрийняттяПредоплати.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
