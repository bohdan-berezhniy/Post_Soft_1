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

namespace Publications
{
    public partial class ІндексиНаселенихПунктів : Form
    {
        public ІндексиНаселенихПунктів()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void ІндексиНаселенихПунктів_FormClosing(object sender, FormClosingEventArgs e)
        {
            Довідники d = new Довідники();
            d.Show();
        }

        private void ІндексиНаселенихПунктів_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=SQLOLEDB;Data Source= BEREZHNIY;Integrated Security=SSPI;Initial Catalog=publications";

            // TODO: This line of code loads data into the 'publicationsDataSet.ІндексиНаселенихПунктів' table. You can move, or remove it, as needed.
            this.індексиНаселенихПунктівTableAdapter.Fill(this.publicationsDataSet.ІндексиНаселенихПунктів);

        }

        private void Додати_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ДодатиІндексиНаселенихПунктів f3 = new ДодатиІндексиНаселенихПунктів();
            f3.Text = "Введення даних";
            f3.ShowDialog();
            if (f3.DialogResult == DialogResult.OK)
            {

                string sqlSelect = "INSERT INTO ІндексиНаселенихПунктів(Індекс, НаселенийПункт, Район, Область) VALUES('" + f3.text1 +
               "','" + f3.text2 + "','" + f3.text3 + "','" + f3.text4 + "')";
                connect.Open();
                adapter.InsertCommand = new OleDbCommand(sqlSelect, connect);
                adapter.InsertCommand.ExecuteNonQuery();
                connect.Close();

                індексиНаселенихПунктівTableAdapter.Update(publicationsDataSet);
                індексиНаселенихПунктівTableAdapter.Fill(publicationsDataSet.ІндексиНаселенихПунктів);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSelect = "Select * From ІндексиНаселенихПунктів Where Індекс Like '" + textBoxSearch.Text.Trim() + "'or НаселенийПункт Like '" + textBoxSearch.Text.Trim() + "'or Район Like '" + textBoxSearch.Text.Trim() + "'or Область Like '" + textBoxSearch.Text.Trim()  + "'or ID Like'" + textBoxSearch.Text.Trim() + "'";


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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            індексиНаселенихПунктівTableAdapter.Update(publicationsDataSet);
            string sqlSelect = "Select * From ІндексиНаселенихПунктів";
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
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Редагувати_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ДодатиІндексиНаселенихПунктів f3 = new ДодатиІндексиНаселенихПунктів();
            f3.Text = "Редагування даних";
            f3.ShowDialog();
            if (f3.DialogResult == DialogResult.OK)
            {

                string sqlSelect = "Update ІндексиНаселенихПунктів Set  Індекс='" + f3.text1 + "', НаселенийПункт='" + f3.text2 + "', Район='" + f3.text3 + "', Область='" + f3.text4 + 
                    "' WHERE ID=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value;


                try
                {
                    connect.Open();
                    adapter.UpdateCommand = new OleDbCommand(sqlSelect, connect);
                    adapter.UpdateCommand.ExecuteNonQuery();
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
                індексиНаселенихПунктівTableAdapter.Update(publicationsDataSet);
                індексиНаселенихПунктівTableAdapter.Fill(publicationsDataSet.ІндексиНаселенихПунктів);
            }
        }
        DataTable MakeDataTable()
        {




            //Create friend table object
            DataTable friend = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                friend.Columns.Add(col.HeaderText);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                friend.Rows.Add(dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[1].Value,
                                dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value,
                                dataGridView1.Rows[i].Cells[4].Value);
            }

            return friend;
        }
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
        private void Друк_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DataTable dtbl = MakeDataTable();
                ExportDataTableToPdf(dtbl, @"D:\Індекси населених пунктів.pdf", "Індекси населених пунктів");


                System.Diagnostics.Process.Start(@"D:\Індекси населених пунктів.pdf");
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Messagesss");
            }
        }

        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearch.Text = "";
        }
    }
}
