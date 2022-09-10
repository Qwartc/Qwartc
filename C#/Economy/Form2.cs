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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        float KapVut, Skor, SrZp, SpecOdyag, Esv, TerVukOsnFond, Workers, period, PodNaPrub;
        float Ipp, Sov, ZpYearEcom, Nzp, Sco, Ar, Gp, Tok, DotChusPrub;

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
            string name = "Analysis-of-staff-reductions";
            if (!File.Exists(path + @"\"+name + ".pdf"))
            {
                PdfWriter.GetInstance(doc, new FileStream(/*Application.StartupPath*/path + @"\" + name+ ".pdf", FileMode.Create));
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
                Paragraph paragraf = new Paragraph(new Phrase("Аналіз скорочення штату \n\n", new iTextSharp.text.Font(font)));
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
                table.AddCell(Convert.ToString(KapVut));//1
                table.AddCell(new Phrase(label2.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(Skor));//2
                table.AddCell(new Phrase(label3.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(SrZp));//3
                table.AddCell(new Phrase(label4.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(Esv));//4
                table.AddCell(new Phrase(label5.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(SpecOdyag));//5
                table.AddCell(new Phrase(label8.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(TerVukOsnFond));//6
                table.AddCell(new Phrase(label9.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(Workers));//7
                table.AddCell(new Phrase(label27.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(period));//8
                table.AddCell(new Phrase(label28.Text, new iTextSharp.text.Font(font)));
                table.AddCell(Convert.ToString(PodNaPrub));//9
                PdfPTable table2 = new PdfPTable(2);
                PdfPCell cell2 = new PdfPCell(new Phrase("Розрахункові данні",
                 new iTextSharp.text.Font(font)));
                cell2.BackgroundColor = new BaseColor(Color.Wheat);
                cell2.Padding = 5;
                cell2.Colspan = 3;
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                table2.AddCell(cell2);
                table2.AddCell(new Phrase(label10.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label18.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label11.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label19.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label12.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label20.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label13.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label21.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label14.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label22.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label15.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label23.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label16.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label24.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label17.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label25.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label29.Text, new iTextSharp.text.Font(font)));
                table2.AddCell(new Phrase(label30.Text, new iTextSharp.text.Font(font)));
                doc.Add(table);
                doc.Add(table2);
            doc.Close();
            
            MessageBox.Show("Готово!\n Ваш файл збережено на Робочому столі");
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
        private void button1_Click(object sender, EventArgs e)
        // Аналіз скорочення штату
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
            if (i == true)
            {
                if (Convert.ToDouble(textBox7.Text) <= Convert.ToDouble(textBox2.Text))
                {
                    errorProvider9.SetError(textBox7, "Не вірні данні(Кількість скорочуваних працівників не може перевищувати/дорівнювати загальної кількості працівників)");
                    errorProvider2.SetError(textBox2, "Не вірні данні(Кількість скорочуваних працівників не може перевищувати/дорівнювати загальної кількості працівників)");
                    i = false;
                }               
                progressBar1.Value = 25;
            }
            if (i == true)
            {
                Ar = 0;
                KapVut = Convert.ToSingle(textBox1.Text) * 1000;
                Skor = Convert.ToSingle(textBox2.Text);
                SrZp = Convert.ToSingle(textBox3.Text) * 1000;
                Esv = Convert.ToSingle(textBox4.Text) / 100;
                SpecOdyag = Convert.ToSingle(textBox5.Text) * 1000;
                TerVukOsnFond = Convert.ToSingle(textBox6.Text);
                Workers = Convert.ToSingle(textBox7.Text);               
                period = Convert.ToSingle(textBox8.Text);
                PodNaPrub = Convert.ToSingle(textBox9.Text) / 100;

                progressBar1.Value += 25;

                progressBar1.Value += 25;

                if (i == true)
                {
                    Ipp = Skor / Workers  * 100;
                    ZpYearEcom = SrZp * Skor * 12;
                    Nzp = Esv * ZpYearEcom ;
                    for (int j = 0; j < period; j++)
                    {
                        Ar += KapVut / (TerVukOsnFond + j);
                    }
                    Sco = SpecOdyag * Skor;
                    Sov = ZpYearEcom + Nzp + Sco - Ar;
                    DotChusPrub = Sov * (1 - PodNaPrub);
                    Gp = DotChusPrub + Ar;
                    Tok = KapVut / Gp;

                    progressBar1.Value += 25;

                    label18.Text = Convert.ToString(Math.Round(Ipp, 2) );
                    label19.Text = Convert.ToString(Math.Round(Sov, 2) * period / 1000);
                    label20.Text = Convert.ToString(Math.Round(ZpYearEcom, 2) * period / 1000);
                    label21.Text = Convert.ToString(Math.Round(Nzp, 2) * period / 1000);
                    label22.Text = Convert.ToString(Math.Round(Sco, 2) * period / 1000);
                    label23.Text = Convert.ToString(Math.Round(Gp, 2) * period / 1000);
                    label24.Text = Convert.ToString(Math.Round(Ar, 2) / 1000);
                    label25.Text = Convert.ToString(Math.Round(Tok, 2) * period);
                    label30.Text = Convert.ToString(Math.Round(DotChusPrub, 2) * period / 1000);
                }
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
    }
}
