namespace Zadanie2
{
    partial class AddReservViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            koniec_dateTime = new DateTimePicker();
            poczatek_dateTime = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            wybranyProwadzacy_comboBox = new ComboBox();
            label5 = new Label();
            wybranaSala_comboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // koniec_dateTime
            // 
            koniec_dateTime.Location = new Point(247, 113);
            koniec_dateTime.Name = "koniec_dateTime";
            koniec_dateTime.Size = new Size(200, 23);
            koniec_dateTime.TabIndex = 20;
            // 
            // poczatek_dateTime
            // 
            poczatek_dateTime.Location = new Point(247, 70);
            poczatek_dateTime.Name = "poczatek_dateTime";
            poczatek_dateTime.Size = new Size(200, 23);
            poczatek_dateTime.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(13, 107);
            label6.Name = "label6";
            label6.Size = new Size(206, 29);
            label6.TabIndex = 18;
            label6.Text = "Koniec rezerwacji";
            // 
            // button1
            // 
            button1.Font = new Font("Epilogue Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 252);
            button1.Name = "button1";
            button1.Size = new Size(355, 81);
            button1.TabIndex = 17;
            button1.Text = "Dokonaj rezerwacji";
            button1.UseVisualStyleBackColor = true;
            // 
            // wybranyProwadzacy_comboBox
            // 
            wybranyProwadzacy_comboBox.FormattingEnabled = true;
            wybranyProwadzacy_comboBox.Location = new Point(247, 198);
            wybranyProwadzacy_comboBox.Name = "wybranyProwadzacy_comboBox";
            wybranyProwadzacy_comboBox.Size = new Size(121, 23);
            wybranyProwadzacy_comboBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(13, 192);
            label5.Name = "label5";
            label5.Size = new Size(143, 29);
            label5.TabIndex = 15;
            label5.Text = "Prowadzący";
            // 
            // wybranaSala_comboBox
            // 
            wybranaSala_comboBox.FormattingEnabled = true;
            wybranaSala_comboBox.Location = new Point(247, 154);
            wybranaSala_comboBox.Name = "wybranaSala_comboBox";
            wybranaSala_comboBox.Size = new Size(121, 23);
            wybranaSala_comboBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(13, 148);
            label4.Name = "label4";
            label4.Size = new Size(157, 29);
            label4.TabIndex = 13;
            label4.Text = "Wybrana sala";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(13, 67);
            label3.Name = "label3";
            label3.Size = new Size(230, 29);
            label3.TabIndex = 12;
            label3.Text = "Początek rezerwacji";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Epilogue ExtraBold", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(462, 67);
            label2.TabIndex = 11;
            label2.Text = "REZERWACJA SALI";
            // 
            // AddReservViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(koniec_dateTime);
            Controls.Add(poczatek_dateTime);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(wybranyProwadzacy_comboBox);
            Controls.Add(label5);
            Controls.Add(wybranaSala_comboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddReservViewControl";
            Size = new Size(828, 564);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker koniec_dateTime;
        private DateTimePicker poczatek_dateTime;
        private Label label6;
        private Button button1;
        private ComboBox wybranyProwadzacy_comboBox;
        private Label label5;
        private ComboBox wybranaSala_comboBox;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
