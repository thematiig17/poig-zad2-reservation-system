namespace Zadanie2
{
    partial class AddProwadzacyViewControl
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
            listaProwadzacych_listBox = new ListBox();
            tytulNaukowy_comboBox = new ComboBox();
            label12 = new Label();
            dodajProwadzacego_button = new Button();
            nazwisko_textBox = new TextBox();
            imie_textBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // listaProwadzacych_listBox
            // 
            listaProwadzacych_listBox.FormattingEnabled = true;
            listaProwadzacych_listBox.Location = new Point(16, 258);
            listaProwadzacych_listBox.Name = "listaProwadzacych_listBox";
            listaProwadzacych_listBox.Size = new Size(794, 289);
            listaProwadzacych_listBox.TabIndex = 52;
            // 
            // tytulNaukowy_comboBox
            // 
            tytulNaukowy_comboBox.FormattingEnabled = true;
            tytulNaukowy_comboBox.Location = new Point(199, 197);
            tytulNaukowy_comboBox.Name = "tytulNaukowy_comboBox";
            tytulNaukowy_comboBox.Size = new Size(133, 23);
            tytulNaukowy_comboBox.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(16, 191);
            label12.Name = "label12";
            label12.Size = new Size(168, 29);
            label12.TabIndex = 50;
            label12.Text = "Tytuł naukowy";
            // 
            // dodajProwadzacego_button
            // 
            dodajProwadzacego_button.Font = new Font("Epilogue Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dodajProwadzacego_button.Location = new Point(402, 98);
            dodajProwadzacego_button.Name = "dodajProwadzacego_button";
            dodajProwadzacego_button.Size = new Size(355, 81);
            dodajProwadzacego_button.TabIndex = 49;
            dodajProwadzacego_button.Text = "Dodaj prowadzącego";
            dodajProwadzacego_button.UseVisualStyleBackColor = true;
            // 
            // nazwisko_textBox
            // 
            nazwisko_textBox.Location = new Point(199, 147);
            nazwisko_textBox.Name = "nazwisko_textBox";
            nazwisko_textBox.Size = new Size(133, 23);
            nazwisko_textBox.TabIndex = 48;
            // 
            // imie_textBox
            // 
            imie_textBox.Location = new Point(199, 98);
            imie_textBox.Name = "imie_textBox";
            imie_textBox.Size = new Size(133, 23);
            imie_textBox.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(16, 141);
            label9.Name = "label9";
            label9.Size = new Size(114, 29);
            label9.TabIndex = 46;
            label9.Text = "Nazwisko";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(16, 92);
            label10.Name = "label10";
            label10.Size = new Size(59, 29);
            label10.TabIndex = 45;
            label10.Text = "Imie";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Epilogue ExtraBold", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(830, 67);
            label11.TabIndex = 44;
            label11.Text = "DODAJ NOWEGO PROWADZĄCEGO";
            // 
            // AddProwadzacyViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(listaProwadzacych_listBox);
            Controls.Add(tytulNaukowy_comboBox);
            Controls.Add(label12);
            Controls.Add(dodajProwadzacego_button);
            Controls.Add(nazwisko_textBox);
            Controls.Add(imie_textBox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Name = "AddProwadzacyViewControl";
            Size = new Size(828, 564);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaProwadzacych_listBox;
        private ComboBox tytulNaukowy_comboBox;
        private Label label12;
        private Button dodajProwadzacego_button;
        private TextBox nazwisko_textBox;
        private TextBox imie_textBox;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
