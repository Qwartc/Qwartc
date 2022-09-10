using System;
//using System.Collections.Generic;
//using System.ComponentModel; 
// using System.Data;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        bool i;
        float WorkerUp, SrZp, Esv, SpecOb, DotVut, Workers, ProduceBase, Price, OwnPrice,Period;
        float ZpDotWorker, EsvDotWorker, VutZp, VutEsv, DotVutSpecOb, VutSpecob, BaseProduse, BaseProduseWorkerMonth, BaseProduseWorker, DotProduseWorkerMonth, DotProduseWorker, ProduceUpMonth, ProduceUp, WantProduceUp, DotPrub, DotProduceOneWorker, DotChusPrubUp, ObChusPrub;

        private void button2_Click(object sender, EventArgs e)
        {
            //Створення ПДФ
            progressBar1.Value = 0;
            progressBar1.Value = 100;
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            var doc = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string name = "Analysis-of-the-state-increase";
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
            Paragraph paragraf = new Paragraph(new Phrase("Аналіз збільшення штату \n\n", new iTextSharp.text.Font(font)));
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
            table.AddCell(new Phrase(label1.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(WorkerUp));//1
            table.AddCell(new Phrase(label2.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(SrZp));//2
            table.AddCell(new Phrase(label3.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Esv));//3
            table.AddCell(new Phrase(label4.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(SpecOb));//4
            table.AddCell(new Phrase(label5.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(DotVut));//5
            table.AddCell(new Phrase(label6.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Workers));//6
            table.AddCell(new Phrase(label7.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(ProduceBase));//7
            table.AddCell(new Phrase(label8.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Price));//8
            table.AddCell(new Phrase(label46.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(OwnPrice));//9
            table.AddCell(new Phrase(label9.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Period));//10
            PdfPTable table2 = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Розрахункові данні",
             new iTextSharp.text.Font(font)));
            cell2.BackgroundColor = new BaseColor(Color.Wheat);
            cell2.Padding = 5;
            cell2.Colspan = 3;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            table2.AddCell(cell2);
            table2.AddCell(new Phrase(label10.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label26.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label11.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label27.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label12.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label28.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label13.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label29.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label14.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label30.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label15.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label31.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label16.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label32.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label17.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label33.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label18.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label34.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label19.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label35.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label20.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label36.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label21.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label37.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label22.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label38.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label42.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label43.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label44.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label45.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label23.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label39.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label24.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label40.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label25.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label41.Text, new iTextSharp.text.Font(font)));
            doc.Add(table);
            doc.Add(table2);
            doc.Close();
            MessageBox.Show("Готово!\n Ваш файл збережено на Робочому столі");
        }

        private void label47_Click(object sender, EventArgs e)
        {

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
            i = true;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Введіть дані");
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
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider5.SetError(textBox5, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider6.SetError(textBox6, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox7.Text))
            {
                errorProvider7.SetError(textBox7, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox8.Text))
            {
                errorProvider8.SetError(textBox8, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox9.Text))
            {
                errorProvider9.SetError(textBox9, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox10.Text))
            {
                errorProvider10.SetError(textBox10, "Введіть дані");
                i = false;
            }
            if (i == true)
            {
                progressBar1.Value = 25;

                WorkerUp = Convert.ToSingle(textBox1.Text);
                SrZp = Convert.ToSingle(textBox2.Text) * 1000;
                Esv = Convert.ToSingle(textBox3.Text) / 100;
                SpecOb = Convert.ToSingle(textBox4.Text) * 1000;
                DotVut = Convert.ToSingle(textBox5.Text) * 1000;
                Workers = Convert.ToSingle(textBox6.Text);
                ProduceBase = Convert.ToSingle(textBox7.Text);
                Price = Convert.ToSingle(textBox8.Text);
                OwnPrice = Convert.ToSingle(textBox10.Text);
                Period = Convert.ToSingle(textBox9.Text);

                
                progressBar1.Value += 25;

                ZpDotWorker = WorkerUp * SrZp * 12;
                EsvDotWorker = ZpDotWorker * (1 + Esv) - ZpDotWorker;
                VutZp = Workers * SrZp * 12 + ZpDotWorker;
                VutEsv = VutZp * (1 + Esv) - VutZp;
                DotVutSpecOb = WorkerUp * SpecOb + DotVut * WorkerUp;
                VutSpecob = Workers * SpecOb + DotVut*Workers + DotVutSpecOb;
                BaseProduse = ProduceBase * 12;
                BaseProduseWorkerMonth = ProduceBase / Workers;
                BaseProduseWorker = BaseProduseWorkerMonth * 12;
                DotProduseWorkerMonth = BaseProduseWorkerMonth * WorkerUp;
                DotProduseWorker = DotProduseWorkerMonth * 12;
                ProduceUpMonth = DotProduseWorkerMonth + ProduceBase;
                ProduceUp = BaseProduse + DotProduseWorker;
                DotChusPrubUp = DotProduseWorker * (Price - OwnPrice);
                ObChusPrub = ProduceUp * Price - ProduceUp * OwnPrice;
                WantProduceUp = ProduceUpMonth / ProduceBase * 100;
                DotPrub = DotProduseWorker * Price;
                DotProduceOneWorker = (BaseProduse + BaseProduseWorker) * 100 / BaseProduse;
                

                for (int j = 1; j <= 12 * Period; j++)
                {
                    chart1.Series[0].Points.AddXY(Workers* SrZp * j, j);
                    chart1.Series[1].Points.AddXY((Workers+WorkerUp) * SrZp *  j, j);

                    chart2.Series[0].Points.AddXY(ProduceBase * j, j);
                    chart2.Series[1].Points.AddXY(ProduceUpMonth * j, j);

                    chart3.Series[0].Points.AddXY(BaseProduse*(Price - OwnPrice) * j, j);
                    chart3.Series[1].Points.AddXY(ObChusPrub * j, j);

                }
                progressBar1.Value += 25;

                label26.Text = Convert.ToString(Math.Round(ZpDotWorker * Period / 1000, 3) );
                label27.Text = Convert.ToString(Math.Round(EsvDotWorker * Period / 1000, 3) );
                label28.Text = Convert.ToString(Math.Round(VutZp * Period / 1000, 3) );
                label29.Text = Convert.ToString(Math.Round(VutEsv * Period / 1000, 3) );
                label30.Text = Convert.ToString(Math.Round(DotVutSpecOb / 1000, 3) );
                label31.Text = Convert.ToString(Math.Round(VutSpecob / 1000, 3) );
                label32.Text = Convert.ToString(Math.Round(BaseProduse * Period, 3) );
                label33.Text = Convert.ToString(Math.Round(BaseProduseWorkerMonth, 3));
                label34.Text = Convert.ToString(Math.Round(BaseProduseWorker * Period, 3));
                label35.Text = Convert.ToString(Math.Round(DotProduseWorkerMonth, 3));
                label36.Text = Convert.ToString(Math.Round(DotProduseWorker * Period, 3) );
                label37.Text = Convert.ToString(Math.Round(ProduceUpMonth, 3));
                label38.Text = Convert.ToString(Math.Round(ProduceUp * Period, 3) );
                label43.Text = Convert.ToString(Math.Round(DotChusPrubUp * Period / 1000, 3)); //
                label45.Text = Convert.ToString(Math.Round(ObChusPrub * Period / 1000, 3)); //
                label39.Text = Convert.ToString(Math.Round(WantProduceUp - 100, 3) );
                label40.Text = Convert.ToString(Math.Round(DotPrub * Period / 1000, 3) );
                label41.Text = Convert.ToString(Math.Round(DotProduceOneWorker - 100, 3));
                
                progressBar1.Value += 25;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            errorProvider6.Clear();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            errorProvider7.Clear();
        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            errorProvider8.Clear();
        }
        private void textBox9_Click(object sender, EventArgs e)
        {
            errorProvider9.Clear();
        }
        private void textBox10_Click(object sender, EventArgs e)
        {
            errorProvider10.Clear();
        }
    }
}
