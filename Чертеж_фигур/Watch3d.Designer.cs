namespace Чертеж_фигур
{
    partial class Watch3d
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.cmbFigurs = new System.Windows.Forms.ComboBox();
            this.lbX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(10, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1827, 913);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarX
            // 
            this.trackBarX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarX.Location = new System.Drawing.Point(26, 969);
            this.trackBarX.Maximum = 100;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(1439, 69);
            this.trackBarX.TabIndex = 1;
            this.trackBarX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(1843, 31);
            this.trackBarY.Maximum = 100;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarY.Size = new System.Drawing.Size(69, 883);
            this.trackBarY.TabIndex = 2;
            this.trackBarY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // cmbFigurs
            // 
            this.cmbFigurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFigurs.FormattingEnabled = true;
            this.cmbFigurs.Items.AddRange(new object[] {
            "Тетраэдр",
            "Сфера",
            "Куб",
            "Ракушка"});
            this.cmbFigurs.Location = new System.Drawing.Point(81, 34);
            this.cmbFigurs.Name = "cmbFigurs";
            this.cmbFigurs.Size = new System.Drawing.Size(244, 33);
            this.cmbFigurs.TabIndex = 3;
            this.cmbFigurs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(32, 42);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(18, 20);
            this.lbX.TabIndex = 5;
            this.lbX.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbY);
            this.groupBox1.Controls.Add(this.lbX);
            this.groupBox1.Controls.Add(this.cmbFigurs);
            this.groupBox1.Location = new System.Drawing.Point(1512, 950);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущее значение";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(356, 42);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(18, 20);
            this.lbY.TabIndex = 6;
            this.lbY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1856, 924);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "YZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1466, 992);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "XZ";
            // 
            // Watch3d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Watch3d";
            this.Text = "Watch3d";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.ComboBox cmbFigurs;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}