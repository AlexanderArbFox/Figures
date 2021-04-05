namespace Чертеж_фигур
{
    partial class Create2d
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.txtLine3 = new System.Windows.Forms.TextBox();
            this.txtLine4 = new System.Windows.Forms.TextBox();
            this.cmbSelectColor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btn3d = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCleare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(216, 252);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(193, 38);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(187, 26);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(231, 26);
            this.txtLine1.TabIndex = 1;
            // 
            // txtLine2
            // 
            this.txtLine2.Location = new System.Drawing.Point(187, 69);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(231, 26);
            this.txtLine2.TabIndex = 2;
            // 
            // txtLine3
            // 
            this.txtLine3.Location = new System.Drawing.Point(187, 115);
            this.txtLine3.Name = "txtLine3";
            this.txtLine3.Size = new System.Drawing.Size(231, 26);
            this.txtLine3.TabIndex = 3;
            // 
            // txtLine4
            // 
            this.txtLine4.Location = new System.Drawing.Point(187, 158);
            this.txtLine4.Name = "txtLine4";
            this.txtLine4.Size = new System.Drawing.Size(231, 26);
            this.txtLine4.TabIndex = 4;
            // 
            // cmbSelectColor
            // 
            this.cmbSelectColor.FormattingEnabled = true;
            this.cmbSelectColor.Items.AddRange(new object[] {
            "Черный",
            "Красный",
            "Желтый"});
            this.cmbSelectColor.Location = new System.Drawing.Point(187, 199);
            this.cmbSelectColor.Name = "cmbSelectColor";
            this.cmbSelectColor.Size = new System.Drawing.Size(231, 28);
            this.cmbSelectColor.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnRectangle);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btn3d);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCleare);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLine4);
            this.groupBox1.Controls.Add(this.txtLine3);
            this.groupBox1.Controls.Add(this.cmbSelectColor);
            this.groupBox1.Controls.Add(this.txtLine2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLine1);
            this.groupBox1.Controls.Add(this.btnDraw);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 1002);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ластик";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Чертеж_фигур.Properties.Resources.Circle;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(216, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Чертеж_фигур.Properties.Resources.Square;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(39, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 120);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::Чертеж_фигур.Properties.Resources.Rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Location = new System.Drawing.Point(216, 394);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(120, 120);
            this.btnRectangle.TabIndex = 13;
            this.btnRectangle.UseVisualStyleBackColor = true;
           // this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackgroundImage = global::Чертеж_фигур.Properties.Resources.Triangle;
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriangle.Location = new System.Drawing.Point(39, 394);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(120, 120);
            this.btnTriangle.TabIndex = 12;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btn3d
            // 
            this.btn3d.BackColor = System.Drawing.Color.Snow;
            this.btn3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3d.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn3d.Location = new System.Drawing.Point(39, 905);
            this.btn3d.Name = "btn3d";
            this.btn3d.Size = new System.Drawing.Size(297, 56);
            this.btn3d.TabIndex = 11;
            this.btn3d.Text = "Перейти к 3D";
            this.btn3d.UseVisualStyleBackColor = false;
            this.btn3d.Click += new System.EventHandler(this.btn3d_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Верхний правый угол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Нижний правый угол";
            // 
            // btnCleare
            // 
            this.btnCleare.Location = new System.Drawing.Point(19, 252);
            this.btnCleare.Name = "btnCleare";
            this.btnCleare.Size = new System.Drawing.Size(140, 38);
            this.btnCleare.TabIndex = 8;
            this.btnCleare.Text = "Очистить всё";
            this.btnCleare.UseVisualStyleBackColor = true;
            this.btnCleare.Click += new System.EventHandler(this.btnCleare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Верхний левый угол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выбор цвета";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(466, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1446, 1024);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // Create2d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Create2d";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.TextBox txtLine3;
        private System.Windows.Forms.TextBox txtLine4;
        private System.Windows.Forms.ComboBox cmbSelectColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCleare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn3d;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

