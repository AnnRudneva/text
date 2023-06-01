using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют
               // только текстовые файлы
               string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаемсодержимое файла в richTextBox
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываемв файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)//выравнивание по центру
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)//выравнивание по левому краю
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)//вы впавнивание по правому краю
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void button2_Click(object sender, EventArgs e)//копировать
        {
            richTextBox.SelectAll();
            richTextBox.Copy();
        }

        private void button4_Click(object sender, EventArgs e)//очистить
        {
            richTextBox.SelectAll();
            richTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)//вырезать
        {
            richTextBox.SelectAll();
            richTextBox.Cut();
        }

        private void button3_Click(object sender, EventArgs e)//вставить
        {
            richTextBox.Paste();
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)//настройка принтера
        {
            pageSetupDialog1.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


        private void button7_Click(object sender, EventArgs e)//шрифт
        {
            fontDialog1.ShowDialog();
            richTextBox.Font = fontDialog1.Font;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = richTextBox.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != richTextBox.SelectionColor)
            {
                richTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)//печать
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button9_Click(object sender, EventArgs e)//выход
        {
            this.Close();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)//предварительный просмотр
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//выделить
        {
            richTextBox1.Select();
        }
    }
}
