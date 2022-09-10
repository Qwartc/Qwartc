using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Economy
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
       double[] dohidA = new double[3];
        double[] dohidB = new double[3];
        double[] VerA = new double[3];
        double[] VerB = new double[3];
        double[] SerKvVidhA = new double[3];
        double[] SerKvVidhB = new double[3];
        double SerDohA, SerDohB, KovVarA, KovVarB, DuspA, DuspB;
        int a,b, a1, b1, a2, b2, a3, b3;
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
            if (String.IsNullOrEmpty(textBox11.Text))
            {
                errorProvider11.SetError(textBox11, "Введіть дані");
                i = false;
            }
            if (String.IsNullOrEmpty(textBox12.Text))
            {
                errorProvider12.SetError(textBox12, "Введіть дані");
                i = false;
            }
            if (i == true)
            {
                progressBar1.Value = 25;
                dohidA[0] = Convert.ToSingle(textBox1.Text) * 1000;
                dohidA[1] = Convert.ToSingle(textBox3.Text) * 1000;
                dohidA[2] = Convert.ToSingle(textBox5.Text) * 1000;
                VerA[0] = Convert.ToSingle(textBox2.Text);
                VerA[1] = Convert.ToSingle(textBox4.Text);
                VerA[2] = Convert.ToSingle(textBox6.Text);

                dohidB[0] = Convert.ToSingle(textBox7.Text) * 1000;
                dohidB[1] = Convert.ToSingle(textBox9.Text) * 1000;
                dohidB[2] = Convert.ToSingle(textBox11.Text) * 1000;
                VerB[0] = Convert.ToSingle(textBox8.Text);
                VerB[1] = Convert.ToSingle(textBox10.Text);
                VerB[2] = Convert.ToSingle(textBox12.Text);

                SerDohA = dohidA[0] * VerA[0] + dohidA[1] * VerA[1] + dohidA[2] * VerA[2];
                SerDohB = dohidB[0] * VerB[0] + dohidB[1] * VerB[1] + dohidB[2] * VerB[2];
                progressBar1.Value += 25;
                SerKvVidhA[0] = Math.Sqrt(Math.Pow(dohidA[0] - SerDohA, 2) * VerA[0]);
                SerKvVidhA[1] = Math.Sqrt(Math.Pow(dohidA[1] - SerDohA, 2) * VerA[1]);
                SerKvVidhA[2] = Math.Sqrt(Math.Pow(dohidA[2] - SerDohA, 2) * VerA[2]);
                SerKvVidhB[0] = Math.Sqrt(Math.Pow(dohidB[0] - SerDohB, 2) * VerB[0]);
                SerKvVidhB[1] = Math.Sqrt(Math.Pow(dohidB[1] - SerDohB, 2) * VerB[1]);
                SerKvVidhB[2] = Math.Sqrt(Math.Pow(dohidB[2] - SerDohB, 2) * VerB[2]);
                KovVarA = SerKvVidhA.Max()/ SerDohA;
                KovVarB = SerKvVidhB.Max() / SerDohB;
                a = Array.IndexOf(dohidA, dohidA.Min());
                b = Array.IndexOf(dohidB, dohidB.Min());
                a1 = Array.IndexOf(dohidA, dohidA.Max());
                b1 = Array.IndexOf(dohidB, dohidB.Max());

                a2 = Array.IndexOf(SerKvVidhA, SerKvVidhA.Min());
                a3 = Array.IndexOf(SerKvVidhA, SerKvVidhA.Max());
                b2 = Array.IndexOf(SerKvVidhB, SerKvVidhB.Min());
                b3 = Array.IndexOf(SerKvVidhB, SerKvVidhB.Max());
                DuspA = VerA[a1]* Math.Pow (dohidA.Max() - SerDohA,2) + VerA[a]*Math.Pow(dohidA.Min() - SerDohA, 2);
                DuspB = VerB[b1] * Math.Pow(dohidB.Max() - SerDohB, 2) + VerB[b] * Math.Pow(dohidB.Min() - SerDohB, 2);


                progressBar1.Value += 25;

                chart1.Series[0].Points.AddXY(Math.Round(VerA[a2],2), SerKvVidhA.Min());
                chart1.Series[0].Points.AddXY(Math.Round(VerA[a3],2), SerKvVidhA.Max());
                for (int j = 0; j < 3; j++)
                {
                    if (SerKvVidhA[j] != SerKvVidhA.Min() && SerKvVidhA[j] != SerKvVidhA.Max())
                    {
                        chart1.Series[0].Points.AddXY(Math.Round(VerA[j],2), SerKvVidhA[j]);
                    }
                }


                chart1.Series[1].Points.AddXY(Math.Round(VerB[b2],2), SerKvVidhB.Min());
                chart1.Series[1].Points.AddXY(Math.Round(VerB[b3],2), SerKvVidhB.Max());
                for (int j = 0; j < 3; j++)
                {
                    if (SerKvVidhB[j] != SerKvVidhB.Min() && SerKvVidhB[j] != SerKvVidhB.Max())
                    {
                        chart1.Series[1].Points.AddXY(Math.Round(VerB[j],2), SerKvVidhB[j]);
                    }
                }


                    label15.Text = Convert.ToString(Math.Round(SerDohA,3));
                label23.Text = Convert.ToString(dohidA.Max());
                label22.Text = Convert.ToString(dohidA.Min());
                label26.Text = "Маємо коливання в діапазоні від " + Convert.ToString(dohidA.Min()) + " до " + Convert.ToString(dohidA.Max()) + ". Різниця між найбільшою та найменшою сумою можливого прибутку " + Convert.ToString(dohidA.Max()) + " – " + Convert.ToString(dohidA.Min()) + " = " + Convert.ToString(dohidA.Max() - dohidA.Min());
                label34.Text = Convert.ToString(Math.Round(SerKvVidhA[0], 2));
                label35.Text = Convert.ToString(Math.Round(SerKvVidhA[1], 2));
                label36.Text = Convert.ToString(Math.Round(SerKvVidhA[2], 2));
                label41.Text = Convert.ToString(Math.Round(KovVarA, 2));
                label47.Text = Convert.ToString(Math.Round(Math.Sqrt(DuspA), 2));
                label49.Text = Convert.ToString(Math.Round(Math.Sqrt(DuspA)/SerDohA * 100, 2)) + "%";

                label16.Text = Convert.ToString(Math.Round(SerDohB, 3));
                label24.Text = Convert.ToString(dohidB.Min());
                label25.Text = Convert.ToString(dohidB.Max());
                label27.Text = "Маємо коливання в діапазоні від " + Convert.ToString(dohidB.Min()) + " до " + Convert.ToString(dohidB.Max()) + ". Різниця між найбільшою та найменшою сумою можливого прибутку " + Convert.ToString(dohidB.Max()) + " – " + Convert.ToString(dohidB.Min()) + " = " + Convert.ToString(dohidB.Max() - dohidB.Min());
                label37.Text = Convert.ToString(Math.Round(SerKvVidhB[0], 2));
                label38.Text = Convert.ToString(Math.Round(SerKvVidhB[1], 2));
                label39.Text = Convert.ToString(Math.Round(SerKvVidhB[2], 2));
                label43.Text = Convert.ToString(Math.Round(KovVarB, 2));
                label48.Text = Convert.ToString(Math.Round(Math.Sqrt(DuspB), 2));
                label50.Text = Convert.ToString(Math.Round(Math.Sqrt(DuspB) / SerDohB * 100, 2))+"%";
                progressBar1.Value += 25;
            }
        }

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
            string name = "Risk-analysis-for-two-projects";
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
            Paragraph paragraf = new Paragraph(new Phrase("Аналіз ризиків по двом проектах\n\n", new iTextSharp.text.Font(font)));
            paragraf.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragraf);
            PdfPTable table = new PdfPTable(3);
            PdfPCell cell = new PdfPCell(new Phrase("Вхідні данні",
              new iTextSharp.text.Font(font)));
            cell.BackgroundColor = new BaseColor(Color.Wheat);
            cell.Padding = 5;
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell2 = new PdfPCell(new Phrase("Підсумки", new iTextSharp.text.Font(font)));
            cell2.BackgroundColor = new BaseColor(Color.Wheat);
            cell2.Padding = 5;
            cell2.Colspan = 3;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell3 = new PdfPCell(new Phrase("Розрахунки", new iTextSharp.text.Font(font)));
            cell3.BackgroundColor = new BaseColor(Color.Wheat);
            cell3.Padding = 5;
            cell3.Colspan = 3;
            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
            table.AddCell(new Phrase(" ", new iTextSharp.text.Font(font)));
            table.AddCell(new Phrase("Проект А", new iTextSharp.text.Font(font)));
            table.AddCell(new Phrase("Проект Б", new iTextSharp.text.Font(font)));
            table.AddCell(new Phrase("Першоочікуване отримання доходу від вкладення, тис грн", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(dohidA[0]));//А1 dohid
            table.AddCell(Convert.ToString(dohidB[0]));//В1 dohid
            table.AddCell(new Phrase("Ймовірність отримання першоочікуваного доходу від вкладенного капіталу", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(VerA[0]));//А1 ver
            table.AddCell(Convert.ToString(VerB[0]));//В1 ver
            table.AddCell(new Phrase("Другоочікуване отримання доходу від вкладення,  тис грн", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(dohidA[1]));//А2 dohid
            table.AddCell(Convert.ToString(dohidB[1]));//В2 dohid
            table.AddCell(new Phrase("Ймовірність отримання другоочікуваного доходу від вкладенного капіталу", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(VerA[1]));//А2 ver
            table.AddCell(Convert.ToString(VerB[1]));//В2 ver
            table.AddCell(new Phrase("Третьоочікуване отримання доходу від вкладення,  тис грн", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(dohidA[2]));//А3 dohid
            table.AddCell(Convert.ToString(dohidB[2]));//В3 dohid
            table.AddCell(new Phrase("Ймовірність отримання Третьоочікуваного доходу від вкладенного капіталу", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(VerA[2]));//А3 ver
            table.AddCell(Convert.ToString(VerB[2]));//В3 ver
            table.AddCell(cell2);
            table.AddCell(new Phrase("Середній очікуваний дохід від вкладення капіталу ", new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(SerDohA));
            table.AddCell(Convert.ToString(SerDohB));
            table.AddCell(new Phrase("Розраховані величини доходів за проектами, min ", new iTextSharp.text.Font(font)));
            table.AddCell(label22.Text);
            table.AddCell(label24.Text);
            table.AddCell(new Phrase("Розраховані величини доходів за проектами, max ", new iTextSharp.text.Font(font)));
            table.AddCell(label23.Text);
            table.AddCell(label25.Text);
            table.AddCell(new Phrase(" ", new iTextSharp.text.Font(font)));
            table.AddCell(new Phrase("Маємо коливання в діапазоні від " + Convert.ToString(dohidA.Min()) + " до " + Convert.ToString(dohidA.Max()) + ". Різниця між найбільшою та найменшою сумою можливого прибутку " + Convert.ToString(dohidA.Max()) + " – " + Convert.ToString(dohidA.Min()) + " = " + Convert.ToString(dohidA.Max() - dohidA.Min()), new iTextSharp.text.Font(font)));
            table.AddCell(new Phrase("Маємо коливання в діапазоні від " + Convert.ToString(dohidB.Min()) + " до " + Convert.ToString(dohidB.Max()) + ". Різниця між найбільшою та найменшою сумою можливого прибутку " + Convert.ToString(dohidB.Max()) + " – " + Convert.ToString(dohidB.Min()) + " = " + Convert.ToString(dohidB.Max() - dohidB.Min()), new iTextSharp.text.Font(font)));
            table.AddCell(cell3);
            table.AddCell(new Phrase("Середньоквадратичне відхилення за першоочікуваним прибутком", new iTextSharp.text.Font(font)));
            table.AddCell(label34.Text);
            table.AddCell(label37.Text);
            table.AddCell(new Phrase("Середньоквадратичне відхилення за другоочікуваним прибутком", new iTextSharp.text.Font(font)));
            table.AddCell(label35.Text);
            table.AddCell(label38.Text);
            table.AddCell(new Phrase("Середньоквадратичне відхилення за третьоочікуваним прибутком", new iTextSharp.text.Font(font)));
            table.AddCell(label36.Text);
            table.AddCell(label39.Text);
            table.AddCell(new Phrase("Коефіцієнт варіації", new iTextSharp.text.Font(font)));
            table.AddCell(label41.Text);
            table.AddCell(label43.Text);
            table.AddCell(new Phrase("Розрахунок дисперсії, середнього квадратичного відхилення і коефіцієнту варіації", new iTextSharp.text.Font(font)));
            table.AddCell(label47.Text + "\n\n" + label49.Text);
            table.AddCell(label48.Text + "\n\n" + label50.Text);

            doc.Add(table);
            doc.Close();
            MessageBox.Show("Готово!\n Ваш файл збережено на Робочому столі");
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

        private void textBox11_Click(object sender, EventArgs e)
        {
            errorProvider11.Clear();
        }
        private void textBox12_Click(object sender, EventArgs e)
        {
            errorProvider12.Clear();
        }
    }
}
