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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        float KapVut, ProduceOb, ProducceObUp, SumAmr, SumAmrNew, ProduceBase, ProdWorkNewOne, Price, OwnPrice, Period;
        float l40, l41, l42, l43, l44, l45, l46, l47, l48, y;

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
            string name = "Analysis-of-feasibility-of-modernization-of-basic-production-funds";
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
            Paragraph paragraf = new Paragraph(new Phrase("Аналіз доцільності модернізації основних виробничих фондів\n\n", new iTextSharp.text.Font(font)));
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
            table.AddCell(Convert.ToString(ProduceOb));//2
            table.AddCell(new Phrase(label3.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(ProducceObUp));//3
            table.AddCell(new Phrase(label4.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(SumAmr));//4
            table.AddCell(new Phrase(label5.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(SumAmrNew));//5
            table.AddCell(new Phrase(label6.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(ProduceBase));//6
            table.AddCell(new Phrase(label7.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(ProdWorkNewOne));//7
            table.AddCell(new Phrase(label8.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Price));//8
            table.AddCell(new Phrase(label9.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(OwnPrice));//9
            table.AddCell(new Phrase(label10.Text, new iTextSharp.text.Font(font)));
            table.AddCell(Convert.ToString(Period));//10
            PdfPTable table2 = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Розрахункові данні",
             new iTextSharp.text.Font(font)));
            cell2.BackgroundColor = new BaseColor(Color.Wheat);
            cell2.Padding = 5;
            cell2.Colspan = 3;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            table2.AddCell(cell2);
            table2.AddCell(new Phrase(label14.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label40.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label15.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label41.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label16.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label42.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label17.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label43.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label18.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label44.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label19.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label45.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label20.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label46.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label21.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label47.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label22.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label48.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label23.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label49.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label24.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label50.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label27.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label51.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label26.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label52.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label25.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label53.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label28.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label54.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label29.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label55.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label30.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label56.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label31.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label57.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label32.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label58.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label33.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label59.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label34.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label60.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label35.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label61.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label36.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label62.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label37.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label63.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label38.Text, new iTextSharp.text.Font(font)));
            table2.AddCell(new Phrase(label64.Text, new iTextSharp.text.Font(font)));
            doc.Add(table);
            doc.Add(table2);
            doc.Close();
            MessageBox.Show("Готово!\n Ваш файл збережено на Робочому столі");
        }

        float l49, l50, l51, l52, l53, l54, l55, l56, l57, l58, l59, l60, l61, l62, l63, l64;
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

            if (i == true)
            {
                progressBar1.Value = 25;

                KapVut = Convert.ToSingle(textBox1.Text) * 1000;
                ProduceOb = Convert.ToSingle(textBox2.Text);
                ProducceObUp = Convert.ToSingle(textBox3.Text);
                SumAmr = Convert.ToSingle(textBox4.Text);
                SumAmrNew = Convert.ToSingle(textBox5.Text);
                ProduceBase = Convert.ToSingle(textBox6.Text);
                ProdWorkNewOne = Convert.ToSingle(textBox7.Text);
                Price = Convert.ToSingle(textBox8.Text);
                OwnPrice = Convert.ToSingle(textBox9.Text);

                Period = Convert.ToSingle(textBox10.Text);

                y = ProduceOb - ProducceObUp;//9
                progressBar1.Value += 25;


                l40 = SumAmr * ProduceOb;//766659
                l41 = SumAmrNew * ProducceObUp;//378000 
                l42 = SumAmr * y + SumAmrNew * ProducceObUp;//677977
                l43 = l40 - l42;//88682
                l44 = ProduceBase / ProduceOb;//41
                l45 = l44 * 12;//492
                l46 = ProduceBase * 12;//11316
                l47 = ProdWorkNewOne * ProducceObUp;//630
                l48 = l47 * 12;//7560
                l49 = l47 + l44 * y;//999
                l50 = l44 * y * 12 + l47 * 12; //11988
                l51 = l49 - ProduceBase;//56
                l52 = l50 - l46;//672
                l53 = ProduceBase * Price;//801550
                l54 = l53 - ProduceBase * OwnPrice; // 169740
                l55 = l54 / ProduceOb; //7380
                l56 = l49 * Price; //849150 
                l57 = l56 - l49 * OwnPrice;//179820
                l58 = l57 - l54; //10080
                l59 = ProdWorkNewOne * 100 / l44;//1,0975
                l60 = l50 * Price;//10189800 
                l61 = l60 - l50 * OwnPrice;//2157840
                l62 = l61 - (l46 * Price - l46 * OwnPrice);//120960
                l63 = l61 * 100 / (l54 * 12);//105,94
                l64 = KapVut / (l62 + l43);//


                for (int j = 1; j <= 12 * Period; j++)
                {

                    chart1.Series[0].Points.AddXY(l40/12 * j, j);// Амортизаційні відрахування до проведення модернізації
                    chart1.Series[1].Points.AddXY(l42/12 * j, j);// Амортизаційні відрахування після проведення модернізації

                    chart2.Series[0].Points.AddXY(l46 / 12 * j, j);// Обсяги виробництва продукції до проведення модернізації
                    chart2.Series[1].Points.AddXY(l50 / 12 * j, j);//Обсяги виробництва продукції після проведення модернізації

                    chart3.Series[0].Points.AddXY(l54 * j, j);
                    chart3.Series[1].Points.AddXY(l57 * j, j);

                    chart4.Series[0].Points.AddXY(l53 * j, j);
                    chart4.Series[1].Points.AddXY(l56 * j, j);
                }

            }





            progressBar1.Value += 50;


            label40.Text = Convert.ToString(Math.Round(l40 / 1000, 3)); // 1
            label41.Text = Convert.ToString(Math.Round(l41 / 1000, 3)); // 2
            label42.Text = Convert.ToString(Math.Round(l42 / 1000, 3)); // 3
            label43.Text = Convert.ToString(Math.Round(l43, 3)); // 4
            label44.Text = Convert.ToString(Math.Round(l44, 3)); // 5
            label45.Text = Convert.ToString(Math.Round(l45, 3) ); // 6
            label46.Text = Convert.ToString(Math.Round(l46, 3) * Period); // 7
            label47.Text = Convert.ToString(Math.Round(l47, 3)); // 8
            label48.Text = Convert.ToString(Math.Round(l48, 3) * Period); // 9
            label49.Text = Convert.ToString(Math.Round(l49, 3)); // 10
            label50.Text = Convert.ToString(Math.Round(l50 , 3) * Period); // 11
            label51.Text = Convert.ToString(Math.Round(l51 , 3)); // 12
            label52.Text = Convert.ToString(Math.Round(l52 , 3) * Period); // 13
            label53.Text = Convert.ToString(Math.Round(l53 / 1000 , 3)); // 14
            label54.Text = Convert.ToString(Math.Round(l54 / 1000 , 3)); // 15
            label55.Text = Convert.ToString(Math.Round(l55 / 1000 , 3)); // 16
            label56.Text = Convert.ToString(Math.Round(l56 / 1000 , 3)); // 17
            label57.Text = Convert.ToString(Math.Round(l57 / 1000 , 3)); // 18
            label58.Text = Convert.ToString(Math.Round(l58 / 1000 , 3)); // 19
            label59.Text = Convert.ToString(Math.Round(l59 , 3)); // 20
            label60.Text = Convert.ToString(Math.Round(l60 , 3) * Period); // 21
            label61.Text = Convert.ToString(Math.Round(l61 / 1000 , 3) * Period); // 22
            label62.Text = Convert.ToString(Math.Round(l62 / 1000 , 3) * Period); // 23
            label63.Text = Convert.ToString(Math.Round(l63 , 3)); // 24
            label64.Text = Convert.ToString(Math.Round(l64, 3)); // 25
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
