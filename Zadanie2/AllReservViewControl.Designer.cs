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
            listBox2 = new ListBox();
            label14 = new Label();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.WindowFrame;
            listBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = SystemColors.Menu;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(12, 70);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(802, 484);
            listBox2.TabIndex = 15;
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
            Controls.Add(listBox2);
            Controls.Add(label14);
            Name = "AllReservViewControl";
            Size = new Size(828, 564);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox2;
        private Label label14;
    }
}
