namespace Zadanie2
{
    partial class AddRoomViewControl
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
            typSali_comboBox = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            pojemnosc_textBox = new TextBox();
            label15 = new Label();
            dodajSale_button = new Button();
            innaNazwa_textBox = new TextBox();
            numerSali_textBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            wydzial_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // typSali_comboBox
            // 
            typSali_comboBox.FormattingEnabled = true;
            typSali_comboBox.Location = new Point(179, 292);
            typSali_comboBox.Name = "typSali_comboBox";
            typSali_comboBox.Size = new Size(131, 23);
            typSali_comboBox.TabIndex = 26;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(16, 286);
            label17.Name = "label17";
            label17.Size = new Size(93, 29);
            label17.TabIndex = 25;
            label17.Text = "Typ sali";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(16, 238);
            label16.Name = "label16";
            label16.Size = new Size(93, 29);
            label16.TabIndex = 24;
            label16.Text = "Wydział";
            // 
            // pojemnosc_textBox
            // 
            pojemnosc_textBox.Location = new Point(179, 196);
            pojemnosc_textBox.Name = "pojemnosc_textBox";
            pojemnosc_textBox.Size = new Size(131, 23);
            pojemnosc_textBox.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(16, 190);
            label15.Name = "label15";
            label15.Size = new Size(132, 29);
            label15.TabIndex = 22;
            label15.Text = "Pojemność";
            // 
            // dodajSale_button
            // 
            dodajSale_button.Font = new Font("Epilogue Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dodajSale_button.Location = new Point(16, 355);
            dodajSale_button.Name = "dodajSale_button";
            dodajSale_button.Size = new Size(355, 81);
            dodajSale_button.TabIndex = 21;
            dodajSale_button.Text = "Dodaj sale do kolekcji";
            dodajSale_button.UseVisualStyleBackColor = true;
            // 
            // innaNazwa_textBox
            // 
            innaNazwa_textBox.Location = new Point(179, 147);
            innaNazwa_textBox.Name = "innaNazwa_textBox";
            innaNazwa_textBox.Size = new Size(131, 23);
            innaNazwa_textBox.TabIndex = 20;
            // 
            // numerSali_textBox
            // 
            numerSali_textBox.Location = new Point(179, 98);
            numerSali_textBox.Name = "numerSali_textBox";
            numerSali_textBox.Size = new Size(131, 23);
            numerSali_textBox.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(16, 141);
            label8.Name = "label8";
            label8.Size = new Size(134, 29);
            label8.TabIndex = 18;
            label8.Text = "Inna nazwa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(16, 92);
            label7.Name = "label7";
            label7.Size = new Size(129, 29);
            label7.TabIndex = 17;
            label7.Text = "Numer sali";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Epilogue ExtraBold", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(482, 67);
            label6.TabIndex = 16;
            label6.Text = "DODAJ NOWĄ SALE";
            // 
            // wydzial_comboBox
            // 
            wydzial_comboBox.FormattingEnabled = true;
            wydzial_comboBox.Location = new Point(179, 244);
            wydzial_comboBox.Name = "wydzial_comboBox";
            wydzial_comboBox.Size = new Size(131, 23);
            wydzial_comboBox.TabIndex = 27;
            // 
            // AddRoomViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(wydzial_comboBox);
            Controls.Add(typSali_comboBox);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(pojemnosc_textBox);
            Controls.Add(label15);
            Controls.Add(dodajSale_button);
            Controls.Add(innaNazwa_textBox);
            Controls.Add(numerSali_textBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "AddRoomViewControl";
            Size = new Size(828, 564);
            Load += AddRoomViewControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox typSali_comboBox;
        private Label label17;
        private Label label16;
        private TextBox pojemnosc_textBox;
        private Label label15;
        private Button dodajSale_button;
        private TextBox innaNazwa_textBox;
        private TextBox numerSali_textBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox wydzial_comboBox;
    }
}
