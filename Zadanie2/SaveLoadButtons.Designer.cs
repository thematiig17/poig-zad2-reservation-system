namespace Zadanie2
{
    partial class SaveLoadButtons
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
            zapisz_button = new Button();
            wczytaj_button = new Button();
            SuspendLayout();
            // 
            // zapisz_button
            // 
            zapisz_button.Location = new Point(3, 3);
            zapisz_button.Name = "zapisz_button";
            zapisz_button.Size = new Size(105, 23);
            zapisz_button.TabIndex = 0;
            zapisz_button.Text = "Zapisz do pliku";
            zapisz_button.UseVisualStyleBackColor = true;
            // 
            // wczytaj_button
            // 
            wczytaj_button.Location = new Point(114, 3);
            wczytaj_button.Name = "wczytaj_button";
            wczytaj_button.Size = new Size(105, 23);
            wczytaj_button.TabIndex = 1;
            wczytaj_button.Text = "Wczytaj z pliku";
            wczytaj_button.UseVisualStyleBackColor = true;
            // 
            // SaveLoadButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(wczytaj_button);
            Controls.Add(zapisz_button);
            Name = "SaveLoadButtons";
            Size = new Size(224, 32);
            ResumeLayout(false);
        }

        #endregion

        private Button zapisz_button;
        private Button wczytaj_button;
    }
}
