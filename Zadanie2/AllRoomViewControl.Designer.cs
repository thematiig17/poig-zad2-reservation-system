namespace Zadanie2
{
    partial class AllRoomViewControl
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
            listaSal_listBox = new ListBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // listaSal_listBox
            // 
            listaSal_listBox.BackColor = SystemColors.WindowFrame;
            listaSal_listBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaSal_listBox.ForeColor = SystemColors.Menu;
            listaSal_listBox.FormattingEnabled = true;
            listaSal_listBox.Location = new Point(12, 70);
            listaSal_listBox.Name = "listaSal_listBox";
            listaSal_listBox.Size = new Size(802, 484);
            listaSal_listBox.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Epilogue ExtraBold", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(432, 67);
            label13.TabIndex = 12;
            label13.Text = "WSZYSTKIE SALE";
            // 
            // AllRoomViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(listaSal_listBox);
            Controls.Add(label13);
            Name = "AllRoomViewControl";
            Size = new Size(828, 564);
            Load += AllRoomViewControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaSal_listBox;
        private Label label13;
    }
}
