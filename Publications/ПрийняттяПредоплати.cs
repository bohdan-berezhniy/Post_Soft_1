using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html;
using iTextSharp;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Publications
{
    public partial class ПрийняттяПредоплати : Form
    {
        public ПрийняттяПредоплати()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        bool print = false;
        int countM =1;
        private void ПрийняттяПредоплати_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  frmMenu d = new frmMenu();
           // d.Show();
        }

    

        private void ПрийняттяПредоплати_Load(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Close();
            connect.ConnectionString = "Provider=SQLOLEDB;Data Source= BEREZHNIY;Integrated Security=SSPI;Initial Catalog=publications";


           
            string sqlSelect = "Select * From КаталогВидань";
            try
            {
                connect.Open();
                adapter.SelectCommand = new OleDbCommand(sqlSelect, connect);
                adapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connect.Close();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Індекс.Items.Clear();
            Назва.Items.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) { 
            
                Індекс.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                Назва.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
                              
            }
           

        }

        private void Індекс_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Індекс.SelectedItem  != null) {
                string sqlSelect = "Select * From КаталогВидань WHERE ID =" + Індекс.SelectedItem.ToString();
                try
                {
                    connect.Open();
                    adapter.SelectCommand = new OleDbCommand(sqlSelect, connect);
                    adapter.SelectCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    connect.Close();
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Назва.Text =  dataGridView1.Rows[0].Cells[1].Value.ToString();
                ВартістьВидання.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                if (ВидПослуги.SelectedItem.ToString().Trim() == "Купівля" && Індекс.SelectedItem != null) {
                    if (КількістьКупівля.Text == "")
                    {
                        КількістьКупівля.Text = "1";
                    }
                    else
                    {
                        ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(КількістьКупівля.Text)).ToString();

                    }
                }
                if (ВидПослуги.SelectedItem.ToString().Trim() == "Передоплата" && Індекс.SelectedItem != null)
                {
                    if (Кількість.Text == "")
                    {
                        Кількість.Text = "1";
                    }
                    else
                    {
                        ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(Кількість.Text)* countM + 7).ToString() ;

                    }
                }


                int Y = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Substring(0, 4));
                int M = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Substring(5, 2));
                int D = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Substring(8, 2));
                
              //  MessageBox.Show(Y + "*" + M + "*" + D); 
                ДатаПочатку.MaxDate = new DateTime(Y, M, D);
                ДатаКінця.MaxDate = new DateTime(Y,M,D);
            }

        }

        private void ВидПослуги_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ВидПослуги.SelectedItem.ToString().Trim() == "Купівля")
            {
                КількістьКупівля.Visible = true;
                label20.Visible = true;
                ВидПередоплати.Enabled = false;
                ВартістьПослуги.Text = "0";
                groupBox3.Enabled = false;
            }
            else {
                ВидПередоплати.Enabled = true;
                ВартістьПослуги.Text = "7";
                groupBox3.Enabled = true;
                КількістьКупівля.Visible = false;
                label20.Visible = false;
            }
        }

        private void Назва_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Назва.SelectedItem != null)
            {
                string sqlSelect = "Select * From КаталогВидань WHERE Назва = " +"'"+ Назва.SelectedItem.ToString() + "'";
                try
                {
                    connect.Open();
                    adapter.SelectCommand = new OleDbCommand(sqlSelect, connect);
                    adapter.SelectCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    connect.Close();
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Індекс.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                ВартістьВидання.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                if (ВидПослуги.SelectedItem.ToString().Trim() == "Купівля" && Індекс.SelectedItem != null)
                {
                    if (КількістьКупівля.Text == "")
                    {
                        КількістьКупівля.Text = "1";
                    }
                    else
                    {
                        ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(КількістьКупівля.Text)).ToString();

                    }
                }
                if (ВидПослуги.SelectedItem.ToString().Trim() == "Передоплата" && Індекс.SelectedItem != null)
                {
                    if (Кількість.Text == "")
                    {
                        Кількість.Text = "1";
                    }
                    else
                    {
                        ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(Кількість.Text)* countM + 7).ToString();

                    }
                }
                int Y = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Substring(0, 4));
                int M = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Substring(5, 2));
                int D = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString().Substring(8, 2));

                //  MessageBox.Show(Y + "*" + M + "*" + D); 
                ДатаПочатку.MaxDate = new DateTime(Y, M, D);
                ДатаКінця.MaxDate = new DateTime(Y, M, D);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                radioButton6.Enabled = true;
                radioButton7.Enabled = true;
                radioButton8.Enabled = true;
                radioButton9.Enabled = true;
                radioButton10.Enabled = true;
                radioButton11.Enabled = true;
                radioButton12.Enabled = true;
            }
            else {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
                radioButton9.Enabled = false;
                radioButton10.Enabled = false;
                radioButton11.Enabled = false;
                radioButton12.Enabled = false;
            }                      
        }

        private void Додати_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flag = true;
            string a = "", b = "";
            double suma = 0;
            if (ВидПослуги.SelectedItem != null)
            {

                if (ВидПослуги.SelectedItem.ToString().Trim() == "Купівля")
                {
                    a = "Купівля";
                    b = "-";
                    flag = true;
                    if (Індекс.SelectedItem != null || Назва.SelectedItem != null)
                    {
                        flag = true;
                        if (КількістьКупівля.Text == "")
                        {
                            КількістьКупівля.Text = "1";
                        }
                        else
                        {
                            suma = Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(КількістьКупівля.Text);
                            ЗагальнаВартість.Text = suma.ToString();
                        }
                       
                    }
                    else {
                        flag = false;
                        MessageBox.Show("Виберіть видання!");
                    }
                    if (flag &&(
                       (Країна.Text != "") &&
                       (Прізвище.Text != "") &&
                       (Імя.Text != "") &&
                       (ПоБатькові.Text != "") &&
                       (НомерТелефону.Text != "") &&
                       (ПоштовийІндекс.Text != "") &&
                       (НаселенийПункт.Text != "") &&
                       (Область.Text != "") &&
                       (Вулиця.Text != "") &&
                       (Будинок.Text != "") &&
                       (Корпус.Text != "") &&
                       (Квартира.Text != "")))
                    {
                        flag = true;
                        
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Заповніть всі контактні данні!");
                    }

                }
            }
            else {
                flag = false;
                MessageBox.Show("Виберіть вид послуги!");
            }
            
                if (flag && ВидПослуги.SelectedItem.ToString().Trim() == "Передоплата") {
                    if (ВидПередоплати.SelectedItem != null)
                    {
                        a = "Передоплата";
                        b = ВидПередоплати.SelectedItem.ToString().Trim();
                        flag = true;
                    }
                    else {
                        flag = false;

                        MessageBox.Show("Виберіть вид передоплати!");
                    }
                    
                }
            if (flag && ВидПослуги.SelectedItem.ToString().Trim() == "Купівля") {
               //------------------------------------------------------------------------------------------
                string idPreroplaty ="";
                string idPreroplatnika = "";
                string sql = "INSERT INTO Передоплата(ДатаПочатку, ДатаКінця, КількістьКомплектів, Розбиття) VALUES('" + ДатаПочатку.Value.ToShortDateString() + "','" + ДатаКінця.Value.ToShortDateString() + "','" + КількістьКупівля.Text +   "','" +1+ "')";
                connect.Open();
                adapter.InsertCommand = new OleDbCommand(sql, connect);
                adapter.InsertCommand.ExecuteNonQuery();
                connect.Close();
                //---------------------------------------------------------------
                string sqlSelect = "INSERT INTO ІнформаціяПроПередоплатників(ПІП, Країна, ПоштовийІндекс, НаселенийПункт, Вулиця, Будинок, Корпус, Квартира, НомерТелефону) VALUES('" + Прізвище.Text + " "+Імя.Text +" "+ПоБатькові.Text +
              "','" + Країна.Text + "','" + ПоштовийІндекс.Text + "','" + НаселенийПункт.Text + "','" + Вулиця.Text + "','" + Будинок.Text + "','" + Корпус.Text + "','" + Квартира.Text + "','" + НомерТелефону.Text + "')";
                connect.Open();
                adapter.InsertCommand = new OleDbCommand(sqlSelect, connect);
                adapter.InsertCommand.ExecuteNonQuery();
                connect.Close();
               //-----------------------------------------------------------------------------
                     
                      string connectionString = "Data Source= BEREZHNIY;Integrated Security=SSPI;Initial Catalog=publications";
                      SqlConnection sqlCnn;
                      SqlCommand sqlCmd;
                      string sqls = "select Max(ID) from Передоплата";

                      sqlCnn = new SqlConnection(connectionString);
                      try
                      {
                          sqlCnn.Open();

                          sqlCmd = new SqlCommand(sqls, sqlCnn);
                          SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                          while (sqlReader.Read())
                          {
                                idPreroplaty =  sqlReader.GetValue(0).ToString();

                          }
                          sqlReader.Close();
                          sqlCmd.Dispose();
                          sqlCnn.Close();
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("Error");
                      }
                      sql = "select Max(ID) from ІнформаціяПроПередоплатників";
                      try
                      {
                          sqlCnn.Open();

                          sqlCmd = new SqlCommand(sql, sqlCnn);
                          SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                          while (sqlReader.Read())
                          {
                              idPreroplatnika = sqlReader.GetValue(0).ToString();
                          }


                          sqlReader.Close();
                          sqlCmd.Dispose();
                          sqlCnn.Close();
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("Error");
                      }
                       string POSLUGA = "INSERT INTO ПрийняттяПредоплати(Послуга, Видання, Передоплата, Платник) VALUES('" + 1 +  "','" + Індекс.SelectedItem + "','" + idPreroplaty + "','" + idPreroplatnika + "')";
                          try
                          {
                              connect.Open();
                              adapter.SelectCommand = new OleDbCommand(POSLUGA, connect);
                            
                              adapter.SelectCommand.ExecuteNonQuery();
                            
                         
                            
                              connect.Close();
                          }
                          catch (System.InvalidOperationException ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                          catch (System.Data.OleDb.OleDbException ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                print = true;
            }
            if (flag && ВидПослуги.SelectedItem.ToString().Trim() == "Передоплата")
            {
                string iidPreroplaty = "";
                string iidPreroplatnika = "";
                int rozbitya = 1;
                if (checkBox1.Checked == true) {
                    if (radioButton1.Checked == true) {
                        rozbitya = 1;
                    }
                    if (radioButton2.Checked == true)
                    {
                        rozbitya = 2;
                    }
                    if (radioButton3.Checked == true)
                    {
                        rozbitya = 3;
                    }
                    if (radioButton4.Checked == true)
                    {
                        rozbitya = 4;
                    }
                    if (radioButton5.Checked == true)
                    {
                        rozbitya = 5;
                    }
                    if (radioButton6.Checked == true)
                    {
                        rozbitya = 6;
                    }
                    if (radioButton7.Checked == true)
                    {
                        rozbitya = 7;
                    }
                    if (radioButton8.Checked == true)
                    {
                        rozbitya = 8;
                    }
                    if (radioButton9.Checked == true)
                    {
                        rozbitya = 9;
                    }
                    if (radioButton10.Checked == true)
                    {
                        rozbitya = 10;
                    }
                    if (radioButton11.Checked == true)
                    {
                        rozbitya = 11;
                    }
                    if (radioButton12.Checked == true)
                    {
                        rozbitya = 12;
                    }


                }
                string sql = "INSERT INTO Передоплата(ДатаПочатку, ДатаКінця, КількістьКомплектів, Розбиття) VALUES('" + ДатаПочатку.Value.ToShortDateString() + "','" + ДатаКінця.Value.ToShortDateString() + "','" + Кількість.Text + "','" + rozbitya + "')";
                connect.Open();
                adapter.InsertCommand = new OleDbCommand(sql, connect);
                adapter.InsertCommand.ExecuteNonQuery();
                connect.Close();
                //---------------------------------------------------------------
                string sqlSelect = "INSERT INTO ІнформаціяПроПередоплатників(ПІП, Країна, ПоштовийІндекс, НаселенийПункт, Вулиця, Будинок, Корпус, Квартира, НомерТелефону) VALUES('" + Прізвище.Text + " " + Імя.Text + " " + ПоБатькові.Text +
              "','" + Країна.Text + "','" + ПоштовийІндекс.Text + "','" + НаселенийПункт.Text + "','" + Вулиця.Text + "','" + Будинок.Text + "','" + Корпус.Text + "','" + Квартира.Text + "','" + НомерТелефону.Text + "')";
                connect.Open();
                adapter.InsertCommand = new OleDbCommand(sqlSelect, connect);
                adapter.InsertCommand.ExecuteNonQuery();
                connect.Close();
                //-----------------------------------------------------------------------------

                string connectionString = "Data Source= BEREZHNIY;Integrated Security=SSPI;Initial Catalog=publications";
                SqlConnection sqlCnn;
                SqlCommand sqlCmd;
                string sqls = "select Max(ID) from Передоплата";

                sqlCnn = new SqlConnection(connectionString);
                try
                {
                    sqlCnn.Open();

                    sqlCmd = new SqlCommand(sqls, sqlCnn);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        iidPreroplaty = sqlReader.GetValue(0).ToString();

                    }
                    sqlReader.Close();
                    sqlCmd.Dispose();
                    sqlCnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
                sql = "select Max(ID) from ІнформаціяПроПередоплатників";
                try
                {
                    sqlCnn.Open();

                    sqlCmd = new SqlCommand(sql, sqlCnn);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        iidPreroplatnika = sqlReader.GetValue(0).ToString();
                    }


                    sqlReader.Close();
                    sqlCmd.Dispose();
                    sqlCnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
                int posluagaId = 1;
                if (b == "Рік") {
                    posluagaId = 2;
                }
                if (b == "Півроку")
                {
                    posluagaId = 3;
                }
                string POSLUGA = "INSERT INTO ПрийняттяПредоплати(Послуга, Видання, Передоплата, Платник) VALUES('" + posluagaId + "','" + Індекс.SelectedItem + "','" + iidPreroplaty + "','" + iidPreroplatnika + "')";
                try
                {
                    connect.Open();
                    adapter.SelectCommand = new OleDbCommand(POSLUGA, connect);
                    adapter.SelectCommand.ExecuteNonQuery();
                    connect.Close();
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                print = true;



               
            }





            if (flag && print) {
                Друк.Enabled = true;
             
                while (0 <= dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.Columns.Remove(dataGridView1.Columns[dataGridView1.Columns.Count - 1]);
                }

                this.dataGridView1.Columns.Add("Індекс", "Індекс");
                this.dataGridView1.Columns.Add("НаселенийПункт", "Населений Пункт");
                this.dataGridView1.Columns.Add("Назва", "Назва");
                this.dataGridView1.Columns.Add("ЗагальнаВартість", "Загальна вартість");
                this.dataGridView1.Columns.Add("ПІП", "ПІП");

                dataGridView1.Rows[0].Cells[0].Value = Індекс.Text;
                dataGridView1.Rows[0].Cells[1].Value = НаселенийПункт.Text;
                dataGridView1.Rows[0].Cells[2].Value = Назва.SelectedItem;
                dataGridView1.Rows[0].Cells[3].Value = ЗагальнаВартість.Text;
                dataGridView1.Rows[0].Cells[4].Value = Прізвище.Text + " " + Імя.Text + " " + ПоБатькові.Text;
            }
            else {
                flag = false;
                MessageBox.Show("!!!!!!!!!!!!!");
            }
           
        }

        private void Кількість_MouseClick(object sender, MouseEventArgs e)
        {
            Кількість.Text = "";
        }

        private void КількістьКупівля_MouseClick(object sender, MouseEventArgs e)
        {
            КількістьКупівля.Text = "";
        }

        private void КількістьКупівля_KeyUp(object sender, KeyEventArgs e)
        {
            if (КількістьКупівля.Text == "")
            {
                КількістьКупівля.Text = "1";
            }
            else {
                ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(КількістьКупівля.Text)).ToString();

            }
        }

        private void ВидПередоплати_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string sqlSelect = "";
            int period = 0;
           
            if (ВидПередоплати.SelectedItem != null) {
                if (ВидПередоплати.SelectedItem.ToString().Trim() == "Рік") {
                    period = 12;
                }
                if (ВидПередоплати.SelectedItem.ToString().Trim() == "Півроку"){
                    period = 6;
                }
              

                int month = System.DateTime.Now.Month+1;
                string eend = (System.DateTime.Now.Year + 3).ToString() + "-" + 12 + "-" + 1;
                string bbegin = (System.DateTime.Now.Year -1).ToString() + "-" + 12 + "-" + 1;
                if (period == 6) {
                    if (month + 6 <= 12)
                    {
                        int year = System.DateTime.Now.Year;
                        string begin = year + "-" + month + "-" + 1;
                        
                        month = (month + 6);
                         
                        string end = year + "-" + month + "-" + 1;
                       
                         sqlSelect = "Select * From КаталогВидань where ПочатокПередоплати BETWEEN '" + bbegin + "' and '" + end + "' and КінецьПередоплати BETWEEN '" + end + "' and '" + eend + "'";
                 
                    }
                    else
                    {
                        int m = 0;
                        if (month > 12) {
                            m = month - 12;
                        }
                        string begin = System.DateTime.Now.Year + "-" + m + "-" + 1;
                        int year = System.DateTime.Now.Year + 1;
                        month = (month + 6 - 12);
                        string end = year + "-" + month + "-" + 1;
                        sqlSelect = "Select * From КаталогВидань where ПочатокПередоплати BETWEEN '" + bbegin + "' and '" + end + "' and КінецьПередоплати BETWEEN '" + end + "' and '" + eend + "'";

                      
                    }
                }
                if (period == 12)
                {
                    if (month <= 12)
                    {
                        string begin = System.DateTime.Now.Year + "-" + month + "-" + 1;
                        int year = System.DateTime.Now.Year+1;
                        string end = year + "-" + month + "-" + 1;
               
                        sqlSelect = "Select * From КаталогВидань where ПочатокПередоплати BETWEEN '" + bbegin + "' and '" + end + "' and КінецьПередоплати BETWEEN '" + end + "' and '" + eend + "'";

                    }
                    else
                    {
                        string begin = System.DateTime.Now.Year + "-" + month + "-" + 1;
                        month = month - 12;
                        int year = System.DateTime.Now.Year + 2;
                        string end = year + "-" + month + "-" + 1;
                 
                        sqlSelect = "Select * From КаталогВидань where ПочатокПередоплати BETWEEN '" + bbegin + "' and '" + end + "' and КінецьПередоплати BETWEEN '" + end + "' and '" + eend + "'";

                    }
                }
              

            }

            try
            {
                connect.Open();
                adapter.SelectCommand = new OleDbCommand(sqlSelect, connect);
                adapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connect.Close();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Індекс.Items.Clear();
            Назва.Items.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                Індекс.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                Назва.Items.Add(dataGridView1.Rows[i].Cells[1].Value);

            }



        }
        public void restart() {
            ПрийняттяПредоплати form1 = new ПрийняттяПредоплати();
            frmMenu m = new frmMenu();
            m.Hide();

            this.Hide();
            form1.Show();
        }
        private void Оновити_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var form2 = new ПрийняттяПредоплати();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

            string sqlSelect = "Select * From КаталогВидань";
            try
            {
                connect.Open();
                adapter.SelectCommand = new OleDbCommand(sqlSelect, connect);
                adapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connect.Close();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Індекс.Items.Clear();
            Назва.Items.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                Індекс.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                Назва.Items.Add(dataGridView1.Rows[i].Cells[1].Value);

            }
        }
        // Створення PDF 
        #region Functions



        DataTable MakeDataTable()
        {
            DataTable friend = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                friend.Columns.Add(col.HeaderText);
           
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                friend.Rows.Add(dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[1].Value,
                                dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value,
                                dataGridView1.Rows[i].Cells[4].Value );
            }
                    
            return friend;
        }
        #endregion

        #region Events
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {


            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();



            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, 8, 2, Color.BLACK);



            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), font));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Міське відділення поштового зв'язку Ярмолинці <Укрпошта>", font));
            prgAuthor.Add(new Chunk("\n Дата видачі : " + DateTime.Now.ToShortDateString(), font));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", font));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), font));
                table.AddCell(cell);
            }
            string a = "";
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.AddElement(new Chunk(dtblTable.Rows[i][j].ToString(), font));
                    table.AddCell(cell);
                    //table.AddCell(dtblTable.Rows[i][j].ToString());

                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }
        #endregion
        private void Друк_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (print)
            {
                sendTo.Enabled = true;
                btnSendEmail.Enabled = true;
                try
                {
                    DataTable dtbl = MakeDataTable();
                    ExportDataTableToPdf(dtbl, @"D:\Передоплата.pdf", "Передоплата");


                    System.Diagnostics.Process.Start(@"D:\Передоплата.pdf");
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Messagesss");
                }
            }
            else {
                MessageBox.Show("Заповніть всі поля!");
            }

        }

        private void Кількість_KeyUp(object sender, KeyEventArgs e)
        {
            if (Кількість.Text == "")
            {
                Кількість.Text = "1";
            }
            else
            {
                ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(Кількість.Text) * countM + 7).ToString() ;

            }
        }

        private void ДатаКінця_ValueChanged(object sender, EventArgs e)
        {
            
          
            int YB = Convert.ToInt32(ДатаПочатку.Value.ToShortDateString().Substring(6, 4));
            int MB = Convert.ToInt32(ДатаПочатку.Value.ToShortDateString().Substring(3, 2));
            int DB = Convert.ToInt32(ДатаПочатку.Value.ToShortDateString().Substring(0, 2));
            int YE = Convert.ToInt32(ДатаКінця.Value.ToShortDateString().Substring(6, 4));
            int ME = Convert.ToInt32(ДатаКінця.Value.ToShortDateString().Substring(3, 2));
            int DE = Convert.ToInt32(ДатаКінця.Value.ToShortDateString().Substring(0, 2));


            if (YB == YE) {
                countM = ME - MB-1;
            
            }
            if (YE - YB == 1) {
                countM = 12+ME - MB - 1;
              
            }
            if (YE - YB == 2)
            {
                countM = 24 + ME - MB - 1;
              
            }
            if (YE - YB == 3)
            {
                countM = 36 + ME - MB - 1;
                
            }

            if (ВидПослуги.SelectedItem.ToString().Trim() == "Передоплата" && Індекс.SelectedItem != null)
            {
                if (Кількість.Text == "")
                {
                    Кількість.Text = "1";
                }
                else
                {
                    ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(Кількість.Text) * countM + 7).ToString();

                }
            }

        }

        private void ДатаПочатку_ValueChanged(object sender, EventArgs e)
        {
            int YB = Convert.ToInt32(ДатаПочатку.Value.ToShortDateString().Substring(6, 4));
            int MB = Convert.ToInt32(ДатаПочатку.Value.ToShortDateString().Substring(3, 2));
            int DB = Convert.ToInt32(ДатаПочатку.Value.ToShortDateString().Substring(0, 2));
            int YE = Convert.ToInt32(ДатаКінця.Value.ToShortDateString().Substring(6, 4));
            int ME = Convert.ToInt32(ДатаКінця.Value.ToShortDateString().Substring(3, 2));
            int DE = Convert.ToInt32(ДатаКінця.Value.ToShortDateString().Substring(0, 2));


            if (YB == YE)
            {
                countM = ME - MB - 1;

            }
            if (YE - YB == 1)
            {
                countM = 12 + ME - MB - 1;

            }
            if (YE - YB == 2)
            {
                countM = 24 + ME - MB - 1;

            }
            if (YE - YB == 3)
            {
                countM = 36 + ME - MB - 1;

            }

            if (ВидПослуги.SelectedItem.ToString().Trim() == "Передоплата" && Індекс.SelectedItem != null)
            {
                if (Кількість.Text == "")
                {
                    Кількість.Text = "1";
                }
                else
                {
                    ЗагальнаВартість.Text = (Convert.ToDouble(ВартістьВидання.Text) * Convert.ToDouble(Кількість.Text) * countM + 7).ToString();

                }
            }
        }

        private void sendTo_MouseClick(object sender, MouseEventArgs e)
        {
            sendTo.Text = "";
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (sendTo.Text == "")
            {
                MessageBox.Show("Введіть e-mail отримувача!");

            }
            else
            {

                string toAdress = sendTo.Text;
                MailAddress fromMailAddress = new MailAddress("Kateryna3008@gmail.com", "Ярмолинці <Укрпошта>");
                MailAddress toAddress = new MailAddress(toAdress, "Test");
                using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
                using (SmtpClient smtpClient = new SmtpClient())
                {

                    mailMessage.Subject = "Передоплата";
                    string mailBody = "";
                    mailBody += "<h2 style='font-size: 25px; color:#333333;  text-align: center;'>Передоплата</h2>";
                    mailBody += "<h2 style='font-size: 15px; color:#333333;  text-align: right;'>Дата видачі: " + DateTime.Now.ToShortDateString() + "</h2>";
                    mailBody += "<hr>";
                    StringBuilder str = new StringBuilder();
                    mailBody += "<table width='100%' style='text-align: center; font-size: 14px; font-family: 'Lucida Sans Unicode', 'Lucida Grande', Sans-Serif; border-collapse: collapse;' >";
                    mailBody += "<tr style='background: #b0e0e6;'>";
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        mailBody += "<th style='background: #AFCDE7; border-color: white; border-style: solid; border-width: 0 1px 1px 0; color: white; padding: 10px 20px;'>" + col.HeaderText + "</th>";
                    }
                    mailBody += "</tr>";
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        mailBody += "<tr>";
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            //  str.Append(dataGridView1.Rows[i].Cells[j].Value);
                            mailBody += "<td style='border-color: white; background: #D8E6F3; border-width: 0 1px 1px 0; border-style: solid;'>" + dataGridView1.Rows[i].Cells[j].Value + "</td>";
                            // str.Append("  ");
                        }
                        mailBody += "</tr>";
                        // str.Append("\n");
                    }
                    mailBody += "</table>";

                    Attachment file = new Attachment(@"D:/Передоплата.pdf");

                    mailMessage.Attachments.Add(file);
                    mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(mailBody, null, "text/html"));
                    //  mailMessage.Body = file;//str.ToString();

                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "VooDooKI69zxcdsa");
                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch (SmtpException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
        }

        private void ГоловнеМеню_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
              frmMenu d = new frmMenu();
             d.Show();
        }
    }
  }
