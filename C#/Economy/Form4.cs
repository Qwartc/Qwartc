using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Economy
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        double NormVutMat, SkorMat, TrudProd, ZpEconom, SkorEsv, dotprubproduce, Amr, DotChusprub, ChusGp, terOk, esv, podnaprub;
        bool i;
        double kapvut, varmat, skornnormvutmat, skortrudmisk, priceone, tervukosfond, baseworkers, Period, sertarufstaf, ownprice, skorownprice, producebase, produceproj;

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void PodNaPrub_Click(object sender, EventArgs e)
        {
            errorProvider15.Clear();
        }

        private void Esv_Click(object sender, EventArgs e)
        {
            errorProvider14.Clear();
        }

        private void ProduceUp_Click(object sender, EventArgs e)
        {
            errorProvider13.Clear();
        }

        private void ProduceBase_Click(object sender, EventArgs e)
        {
            errorProvider12.Clear();
        }

        private void SkorOwnPrice_Click(object sender, EventArgs e)
        {
            errorProvider11.Clear();
        }

        private void OwnPrice_Click(object sender, EventArgs e)
        {
            errorProvider10.Clear();
        }

        private void SerTarufStaf_Click(object sender, EventArgs e)
        {
            errorProvider9.Clear();
        }
        private void period_Click(object sender, EventArgs e)
        {
            errorProvider8.Clear();
        }
        private void BaseWorkers_Click(object sender, EventArgs e)
        {
            errorProvider7.Clear();
        }

        private void TerVukOsFond_Click(object sender, EventArgs e)
        {
            errorProvider6.Clear();
        }

        private void priceOne_Click(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

        private void SkorTrudMisk_Click(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void SkornNormVutMat_Click(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void VarMat_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void KapVut_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',')
            {
                e.Handled = true;
            }
        }
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
            string name = "Analysis-of-cost-management-system-implementation";
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
            Paragraph paragraf = new Paragraph(new Phrase("Аналіз системи впровадження управління витрат \n\n", new iTextSharp.text.Font(font)));
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
            table.AddCell(new Phrase(label12.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(kapvut));//1
            table.AddCell(new Phrase(label35.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(priceone));//2
            table.AddCell(new Phrase(label1.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(ownprice));//3
            table.AddCell(new Phrase(label2.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(skorownprice));//4
            table.AddCell(new Phrase(label32.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(varmat));//5
            table.AddCell(new Phrase(label33.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(skornnormvutmat));//6
            table.AddCell(new Phrase(label34.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(skortrudmisk));//7
            table.AddCell(new Phrase(label37.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(baseworkers));//8
            table.AddCell(new Phrase(label39.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(sertarufstaf));//9
            table.AddCell(new Phrase(label3.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(producebase));//10
            table.AddCell(new Phrase(label11.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(produceproj));//11
            table.AddCell(new Phrase(label36.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(tervukosfond));//12
            table.AddCell(new Phrase(label9.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(esv));//13
            table.AddCell(new Phrase(label4.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(podnaprub));//14
            table.AddCell(new Phrase(label38.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Period));//15
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
            doc.Add(table);
            doc.Add(table2);
            doc.Close();
            MessageBox.Show("Готово!\n Ваш файл збережено на Робочому столі");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            i = true;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider5.SetError(textBox5, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox6.Text))//
            {
                errorProvider6.SetError(textBox6, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox7.Text))
            {
                errorProvider7.SetError(textBox7, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox12.Text))
            {
                errorProvider12.SetError(textBox12, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox8.Text))
            {
                errorProvider8.SetError(textBox8, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox15.Text))
            {
                errorProvider15.SetError(textBox15, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox9.Text))
            {
                errorProvider9.SetError(textBox9, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider3.SetError(textBox3, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider4.SetError(textBox4, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox10.Text))
            {
                errorProvider10.SetError(textBox10, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox11.Text))
            {
                errorProvider11.SetError(textBox11, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox13.Text))
            {
                errorProvider13.SetError(textBox13, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox14.Text))
            {
                errorProvider15.SetError(textBox14, "Введіть дані");
                i = false;
            }
            if (i == true)
            {
                progressBar1.Value = 25;
                
                kapvut = Convert.ToSingle(textBox1.Text) * 1000;
                priceone = Convert.ToSingle(textBox2.Text) * 1000;
                ownprice = Convert.ToSingle(textBox3.Text) * 1000;
                skorownprice = Convert.ToSingle(textBox4.Text) / 100;
                varmat = Convert.ToSingle(textBox5.Text) * 1000;
                skornnormvutmat = Convert.ToSingle(textBox6.Text) / 100;
                skortrudmisk = Convert.ToSingle(textBox7.Text) / 100;
                baseworkers = Convert.ToSingle(textBox8.Text);
                sertarufstaf = Convert.ToSingle(textBox9.Text);
                producebase = Convert.ToSingle(textBox10.Text);
                produceproj = Convert.ToSingle(textBox11.Text);
                tervukosfond = Convert.ToSingle(textBox12.Text);
                esv = Convert.ToSingle(textBox13.Text) / 100;
                podnaprub = Convert.ToSingle(textBox14.Text) / 100;
                Period = Convert.ToSingle(textBox15.Text);

                progressBar1.Value += 25;

                NormVutMat = varmat * (1 - skornnormvutmat) ;
                SkorMat = (varmat  - NormVutMat) * (produceproj );
                TrudProd = Math.Truncate(baseworkers * (1 - skortrudmisk)) ;
                ZpEconom = (baseworkers - TrudProd) * produceproj * sertarufstaf;
                SkorEsv = ZpEconom * esv;
                dotprubproduce = (produceproj - producebase) * (priceone - ownprice);
                for(int j = 0; j < Period; j++)
                {
                    Amr += kapvut / (tervukosfond + j);
                }
                Amr = kapvut / tervukosfond;
                DotChusprub = (SkorMat + ZpEconom + SkorEsv + dotprubproduce - Amr) * (1 - podnaprub);
                ChusGp = DotChusprub + Amr ;
                terOk = kapvut / ChusGp;

                progressBar1.Value += 25;


                progressBar1.Value += 25;
                label49.Text = Convert.ToString(Math.Round(NormVutMat, 3) * Period );
                label50.Text = Convert.ToString(Math.Round(SkorMat, 3) * Period / 1000);
                label51.Text = Convert.ToString(Math.Round(TrudProd, 3) );
                label52.Text = Convert.ToString(Math.Round(ZpEconom, 3) * Period / 1000);
                label53.Text = Convert.ToString(Math.Round(SkorEsv, 3) * Period / 1000);
                label54.Text = Convert.ToString(Math.Round(dotprubproduce, 3) * Period / 1000);
                label55.Text = Convert.ToString(Math.Round(Amr, 3)  / 1000);
                label56.Text = Convert.ToString(Math.Round(DotChusprub, 3) * Period / 1000);
                label6.Text = Convert.ToString(Math.Round(ChusGp, 3)  * Period / 1000);
                label8.Text = Convert.ToString(Math.Round(terOk, 3) * Period);

            }

        }


    }
}
