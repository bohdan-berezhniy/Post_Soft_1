using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publications
{
    public partial class Авторизація : Form
    {
        public Авторизація()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sqlSelect = "Select * from Login Where UserName ='" + textBoxUserName.Text.Trim() + "' and Password ='" + textBoxPass.Text.Trim() + "'";
            adapter.SelectCommand = new OleDbCommand(sqlSelect, connect);
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {
                if (textBoxUserName.Text.Trim() == "User1")
                {
                    frmMenu objFrmUser = new frmMenu();
                    this.Hide();
                    objFrmUser.Show();
                }
              
                

            }
            else
            {
                MessageBox.Show("Невірний логін, або пароль!");
            }


            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Авторизація_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=SQLOLEDB;Data Source= BEREZHNIY;Integrated Security=SSPI;Initial Catalog= publications";

        }
    }
}
