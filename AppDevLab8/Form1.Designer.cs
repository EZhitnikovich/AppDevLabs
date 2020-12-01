namespace LAB8
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxXS = new System.Windows.Forms.TextBox();
            this.textBoxXF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите значение X:";
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(174, 12);
            this.TextBoxX.MaxLength = 20;
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(80, 20);
            this.TextBoxX.TabIndex = 1;
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(174, 38);
            this.TextBoxY.MaxLength = 20;
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(80, 20);
            this.TextBoxY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение Y:";
            // 
            // TextBoxZ
            // 
            this.TextBoxZ.Location = new System.Drawing.Point(174, 64);
            this.TextBoxZ.MaxLength = 20;
            this.TextBoxZ.Name = "TextBoxZ";
            this.TextBoxZ.Size = new System.Drawing.Size(80, 20);
            this.TextBoxZ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите значение Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат выполнения программы:";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AnswerTextBox.Location = new System.Drawing.Point(15, 107);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.ReadOnly = true;
            this.AnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AnswerTextBox.Size = new System.Drawing.Size(361, 213);
            this.AnswerTextBox.TabIndex = 8;
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(100, 328);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(461, 23);
            this.Button.TabIndex = 9;
            this.Button.Text = "Выполнить";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "U";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.AxisY.Title = "X";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.CursorX.LineWidth = 3;
            chartArea1.CursorY.LineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Графики";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(382, 90);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "U к X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X к U";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(251, 232);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(260, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Шаг X:";
            // 
            // textBoxXS
            // 
            this.textBoxXS.Location = new System.Drawing.Point(358, 12);
            this.textBoxXS.Name = "textBoxXS";
            this.textBoxXS.Size = new System.Drawing.Size(100, 20);
            this.textBoxXS.TabIndex = 17;
            // 
            // textBoxXF
            // 
            this.textBoxXF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxXF.Location = new System.Drawing.Point(358, 41);
            this.textBoxXF.Name = "textBoxXF";
            this.textBoxXF.Size = new System.Drawing.Size(100, 20);
            this.textBoxXF.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(260, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Конечный X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 361);
            this.Controls.Add(this.textBoxXF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxXS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxXS;
        private System.Windows.Forms.TextBox textBoxXF;
        private System.Windows.Forms.Label label10;
    }
}

