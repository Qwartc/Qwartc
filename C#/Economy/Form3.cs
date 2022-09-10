using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Economy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double kapvut, skor, srzp, esv, priceone, tervukosfond, workers, Period, podnaprub, ownprice, skorownprice, producebase, produceup;
        double AbSkor, GroshVug, ZpYearEcom, Nzp, ownpriceproj, dotprubownprice, dotprubownproduce, Amr, DotChusprub, ChusGp, terOk;

        private void button1_Click(object sender, EventArgs e)
        {
            //Створення ПДФ
            progressBar1.Value = 0;
            progressBar1.Value = 100;

            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            var doc = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string name = "Analysis-of-restructuring-of-management-structures";
            if (!File.Exists(path + @"\" + name + ".pdf"))
            {
                PdfWriter.GetInstance(doc, new FileStream(/*Application.StartupPath*/path + @"\" + name + ".pdf", FileMode.Create));
            }
            else
            {
                int k = 1;
                bool i = false;
                while (i == false)
                {
                    if (!File.Exists(path + @"\" + name + "(" + Convert.ToString(k) + ").pdf"))
                    {
                        PdfWriter.GetInstance(doc, new FileStream(/*Application.StartupPath*/path + @"\" + name + "(" + Convert.ToString(k) + ").pdf", FileMode.Create));
                        i = true;
                    }
                    else
                    {
                        k++;
                    }
                }

            }
            doc.Open();
            Paragraph paragraf = new Paragraph(new Phrase("Аналіз перебудови управлінських структур \n\n", new iTextSharp.text.Font(font)));            
            paragraf.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragraf);
            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("Вхідні данні",
              new iTextSharp.text.Font(font)));
            cell.BackgroundColor = new BaseColor(Color.Wheat);
            cell.Padding = 5;
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
            table.AddCell(new Phrase(label31.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(kapvut));
            table.AddCell(new Phrase(label32.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(skor));
            table.AddCell(new Phrase(label33.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(srzp));
            table.AddCell(new Phrase(label34.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(esv));
            table.AddCell(new Phrase(label35.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(priceone));
            table.AddCell(new Phrase(label36.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(tervukosfond));
            table.AddCell(new Phrase(label37.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(workers));
            table.AddCell(new Phrase(label38.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Period));
            table.AddCell(new Phrase(label39.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(podnaprub));
            table.AddCell(new Phrase(label1.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(ownprice));
            table.AddCell(new Phrase(label2.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(skorownprice));
            table.AddCell(new Phrase(label3.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(producebase));
            table.AddCell(new Phrase(label4.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(produceup));
            PdfPTable table2 = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Розрахункові данні",
             new iTextSharp.text.Font(font)));
            cell2.BackgroundColor = new BaseColor(Color.Wheat);
            cell2.Padding = 5;
            cell2.Colspan = 3;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            table2.AddCell(cell2);
            table2.AddCell(new Phrase(label40.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label49.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label41.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label50.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label42.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label51.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label43.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label52.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label44.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label53.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label45.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label54.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label46.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label55.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label47.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label56.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label5.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label6.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label7.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label8.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label9.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label11.Text, new iTextSharp.text.Font(font)));
            doc.Add(table);
            doc.Add(table2);
            doc.Close();
            MessageBox.Show("Готово!\n Ваш файл збережено на Робочому столі");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        bool i;
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',')
            {
                e.Handled = true;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            i = true;

            if (String.IsNullOrEmpty(KapVut.Text))
            {
                errorProvider1.SetError(KapVut, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(Skor.Text))
                {
                    errorProvider2.SetError(Skor, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(SrZp.Text))
                {
                    errorProvider3.SetError(SrZp, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(Esv.Text))
                {
                    errorProvider4.SetError(Esv, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(priceOne.Text))
                {
                    errorProvider5.SetError(priceOne, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(TerVukOsFond.Text))
                {
                    errorProvider6.SetError(TerVukOsFond, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(Workers.Text))
                {
                    errorProvider7.SetError(Workers, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(period.Text))
                {
                    errorProvider8.SetError(period, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(PodNaPrub.Text))
                {
                    errorProvider9.SetError(PodNaPrub, "Введіть дані");
                    i = false;
                }
            if (String.IsNullOrEmpty(OwnPrice.Text))
            {
                errorProvider10.SetError(OwnPrice, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(SkorOwnPrice.Text))
            {
                errorProvider11.SetError(SkorOwnPrice, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(ProduceBase.Text))
            {
                errorProvider12.SetError(ProduceBase, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(ProduceUp.Text))
            {
                errorProvider13.SetError(ProduceUp, "Введіть дані");
                i = false;
            }
            if (i == true)
            {
                progressBar1.Value = 25;
                Amr = 0;
                kapvut = Convert.ToSingle(KapVut.Text) * 1000;
                skor = Convert.ToSingle(Skor.Text) / 100;
                srzp = Convert.ToSingle(SrZp.Text) * 1000;
                esv = Convert.ToSingle(Esv.Text) / 100;
                priceone = Convert.ToSingle(priceOne.Text) * 1000;
                tervukosfond = Convert.ToSingle(TerVukOsFond.Text);
                workers = Convert.ToSingle(Workers.Text);
                Period = Convert.ToSingle(period.Text);
                podnaprub = Convert.ToSingle(PodNaPrub.Text) / 100;
                ownprice = Convert.ToSingle(OwnPrice.Text) * 1000;
                skorownprice = Convert.ToSingle(SkorOwnPrice.Text) / 100;
                producebase = Convert.ToSingle(ProduceBase.Text) ;
                produceup = Convert.ToSingle(ProduceUp.Text) / 100;
                progressBar1.Value += 25;

                AbSkor = Math.Truncate(workers * skor );
                ZpYearEcom = AbSkor * srzp * 12 ;
                Nzp = ZpYearEcom * esv;
                ownpriceproj = (ownprice - (ownprice * skorownprice));
                dotprubownprice = (ownprice - ownpriceproj) * producebase * (1 + produceup) ;
                dotprubownproduce = (priceone - ownprice) * (producebase * (1 + produceup) - producebase) ;
                for (int j = 0; j < Period; j++)
                {
                    Amr += kapvut / (tervukosfond + j);
                }
                DotChusprub = ZpYearEcom + Nzp + dotprubownprice + dotprubownproduce - Amr;
                GroshVug = DotChusprub * (1 - podnaprub);
                ChusGp = GroshVug + Amr;
                terOk = kapvut / ChusGp;

                progressBar1.Value += 25;


                progressBar1.Value += 25;
                label49.Text = Convert.ToString(Math.Round(AbSkor, 3) );
                label50.Text = Convert.ToString(Math.Round(GroshVug / 1000, 3) * Period );
                label51.Text = Convert.ToString(Math.Round(ZpYearEcom / 1000, 3) * Period );
                label52.Text = Convert.ToString(Math.Round(Nzp / 1000, 3) * Period);
                label53.Text = Convert.ToString(Math.Round(ownpriceproj / 1000, 3));
                label54.Text = Convert.ToString(Math.Round(dotprubownprice / 1000, 3) * Period );
                label55.Text = Convert.ToString(Math.Round(dotprubownproduce / 1000, 3) * Period );
                label56.Text = Convert.ToString(Math.Round(Amr / 1000, 3) );
                label6.Text = Convert.ToString(Math.Round(DotChusprub / 1000, 3) * Period );
                label8.Text = Convert.ToString(Math.Round(ChusGp / 1000, 3) * Period );
                label11.Text = Convert.ToString(Math.Round(terOk, 3) * Period);

            }

        }

        private void KapVut_TextChanged(object sender, EventArgs e)
        {

        }

        private void KapVut_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Skor_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void SrZp_Click(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void Esv_Click(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void priceOne_Click(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }
        private void TerVukOsFond_Click(object sender, EventArgs e)
        {
            errorProvider6.Clear();
        }

        private void Workers_Click(object sender, EventArgs e)
        {
            errorProvider7.Clear();
        }

        private void period_Click(object sender, EventArgs e)
        {
            errorProvider8.Clear();
        }

        private void PodNaPrub_Click(object sender, EventArgs e)
        {
            errorProvider9.Clear();
        }

        private void OwnPrice_Click(object sender, EventArgs e)
        {
            errorProvider10.Clear();
        }

        private void SkorOwnPrice_Click(object sender, EventArgs e)
        {
            errorProvider11.Clear();
        }

        private void ProduceBase_Click(object sender, EventArgs e)
        {
            errorProvider12.Clear();
        }

        private void ProduceUp_Click(object sender, EventArgs e)
        {
            errorProvider13.Clear();
        }

    }
}
