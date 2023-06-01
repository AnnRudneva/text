namespace Text
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйПросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПринтераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 51);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(602, 524);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вырезать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Копировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Вставить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(639, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Выделить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(639, 450);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(125, 31);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(639, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "Шрифт";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(639, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "Цвет";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(639, 562);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 31);
            this.button9.TabIndex = 9;
            this.button9.Text = "Выход";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(639, 510);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 31);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.предварительныйПросмотрToolStripMenuItem,
            this.настройкаПринтераToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            this.предварительныйПросмотрToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            this.предварительныйПросмотрToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.предварительныйПросмотрToolStripMenuItem.Text = "Предварительный просмотр";
            this.предварительныйПросмотрToolStripMenuItem.Click += new System.EventHandler(this.предварительныйПросмотрToolStripMenuItem_Click);
            // 
            // настройкаПринтераToolStripMenuItem
            // 
            this.настройкаПринтераToolStripMenuItem.Name = "настройкаПринтераToolStripMenuItem";
            this.настройкаПринтераToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.настройкаПринтераToolStripMenuItem.Text = "Настройка принтера";
            this.настройкаПринтераToolStripMenuItem.Click += new System.EventHandler(this.настройкаПринтераToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.button9_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.выравниваниеToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.button8_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.button7_Click);
            // 
            // выравниваниеToolStripMenuItem
            // 
            this.выравниваниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЦентруToolStripMenuItem,
            this.поЛевомуКраюToolStripMenuItem,
            this.поПравомуКраюToolStripMenuItem});
            this.выравниваниеToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            this.выравниваниеToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.выравниваниеToolStripMenuItem.Text = "Выравнивание";
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            this.поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            this.поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
            this.поЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поЛевомуКраюToolStripMenuItem_Click);
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            this.поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            this.поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.поПравомуКраюToolStripMenuItem.Text = "По правому краю";
            this.поПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поПравомуКраюToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 605);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйПросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПринтераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

