namespace Zadanie2
{
    partial class WydzialViewControl
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
            nazwaWydzialu_textBox = new TextBox();
            label21 = new Label();
            listaWydzialow_listBox = new ListBox();
            miasto_textBox = new TextBox();
            label20 = new Label();
            nrBudynku_textBox = new TextBox();
            label19 = new Label();
            ulica_textBox = new TextBox();
            label18 = new Label();
            dodajWydzial_button = new Button();
            label24 = new Label();
            SuspendLayout();
            // 
            // nazwaWydzialu_textBox
            // 
            nazwaWydzialu_textBox.Location = new Point(108, 65);
            nazwaWydzialu_textBox.Name = "nazwaWydzialu_textBox";
            nazwaWydzialu_textBox.Size = new Size(224, 23);
            nazwaWydzialu_textBox.TabIndex = 44;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.Control;
            label21.Location = new Point(24, 62);
            label21.Name = "label21";
            label21.Size = new Size(84, 29);
            label21.TabIndex = 43;
            label21.Text = "Nazwa";
            // 
            // listaWydzialow_listBox
            // 
            listaWydzialow_listBox.FormattingEnabled = true;
            listaWydzialow_listBox.Location = new Point(17, 251);
            listaWydzialow_listBox.Name = "listaWydzialow_listBox";
            listaWydzialow_listBox.Size = new Size(794, 289);
            listaWydzialow_listBox.TabIndex = 42;
            // 
            // miasto_textBox
            // 
            miasto_textBox.Location = new Point(108, 123);
            miasto_textBox.Name = "miasto_textBox";
            miasto_textBox.Size = new Size(224, 23);
            miasto_textBox.TabIndex = 41;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(22, 119);
            label20.Name = "label20";
            label20.Size = new Size(88, 29);
            label20.TabIndex = 40;
            label20.Text = "Miasto";
            // 
            // nrBudynku_textBox
            // 
            nrBudynku_textBox.Location = new Point(290, 94);
            nrBudynku_textBox.Name = "nrBudynku_textBox";
            nrBudynku_textBox.Size = new Size(42, 23);
            nrBudynku_textBox.TabIndex = 39;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(245, 91);
            label19.Name = "label19";
            label19.Size = new Size(39, 29);
            label19.TabIndex = 38;
            label19.Text = "Nr";
            // 
            // ulica_textBox
            // 
            ulica_textBox.Location = new Point(108, 94);
            ulica_textBox.Name = "ulica_textBox";
            ulica_textBox.Size = new Size(131, 23);
            ulica_textBox.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Epilogue ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(43, 91);
            label18.Name = "label18";
            label18.Size = new Size(65, 29);
            label18.TabIndex = 36;
            label18.Text = "Ulica";
            // 
            // dodajWydzial_button
            // 
            dodajWydzial_button.Font = new Font("Epilogue Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dodajWydzial_button.Location = new Point(17, 152);
            dodajWydzial_button.Name = "dodajWydzial_button";
            dodajWydzial_button.Size = new Size(355, 81);
            dodajWydzial_button.TabIndex = 35;
            dodajWydzial_button.Text = "Dodaj wydział";
            dodajWydzial_button.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Epilogue ExtraBold", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.Control;
            label24.Location = new Point(2, -1);
            label24.Name = "label24";
            label24.Size = new Size(580, 67);
            label24.TabIndex = 34;
            label24.Text = "DODAJ NOWY WYDZIAŁ";
            // 
            // WydzialViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(nazwaWydzialu_textBox);
            Controls.Add(label21);
            Controls.Add(listaWydzialow_listBox);
            Controls.Add(miasto_textBox);
            Controls.Add(label20);
            Controls.Add(nrBudynku_textBox);
            Controls.Add(label19);
            Controls.Add(ulica_textBox);
            Controls.Add(label18);
            Controls.Add(dodajWydzial_button);
            Controls.Add(label24);
            Name = "WydzialViewControl";
            Size = new Size(828, 564);
            Load += WydzialViewControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nazwaWydzialu_textBox;
        private Label label21;
        private ListBox listaWydzialow_listBox;
        private TextBox miasto_textBox;
        private Label label20;
        private TextBox nrBudynku_textBox;
        private Label label19;
        private TextBox ulica_textBox;
        private Label label18;
        private Button dodajWydzial_button;
        private Label label24;
    }
}
