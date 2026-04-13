namespace Zadanie2
{
    partial class AllReservViewControl
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
            listaRezerwacji_listBox = new ListBox();
            label14 = new Label();
            SuspendLayout();
            // 
            // listaRezerwacji_listBox
            // 
            listaRezerwacji_listBox.BackColor = SystemColors.WindowFrame;
            listaRezerwacji_listBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaRezerwacji_listBox.ForeColor = SystemColors.Menu;
            listaRezerwacji_listBox.FormattingEnabled = true;
            listaRezerwacji_listBox.Location = new Point(12, 70);
            listaRezerwacji_listBox.Name = "listaRezerwacji_listBox";
            listaRezerwacji_listBox.Size = new Size(802, 466);
            listaRezerwacji_listBox.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Epilogue ExtraBold", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(626, 67);
            label14.TabIndex = 14;
            label14.Text = "WSZYSTKIE REZERWACJE";
            // 
            // AllReservViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(listaRezerwacji_listBox);
            Controls.Add(label14);
            Name = "AllReservViewControl";
            Size = new Size(828, 564);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaRezerwacji_listBox;
        private Label label14;
    }
}
