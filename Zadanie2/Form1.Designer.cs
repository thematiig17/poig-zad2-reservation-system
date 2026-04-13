namespace Zadanie2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            rezerwacjaSali_tabPage = new TabPage();
            addReservViewControl1 = new AddReservViewControl();
            dodajSale_tabPage = new TabPage();
            addRoomViewControl1 = new AddRoomViewControl();
            dodajProwadzacego_tabPage = new TabPage();
            wszystkieSale_tabPage = new TabPage();
            allRoomViewControl1 = new AllRoomViewControl();
            wszystkieRezerwacje_tabPage = new TabPage();
            allReservViewControl1 = new AllReservViewControl();
            wydzialy_tabPage = new TabPage();
            wydzialViewControl1 = new WydzialViewControl();
            label1 = new Label();
            tabControl1.SuspendLayout();
            rezerwacjaSali_tabPage.SuspendLayout();
            dodajSale_tabPage.SuspendLayout();
            wszystkieSale_tabPage.SuspendLayout();
            wszystkieRezerwacje_tabPage.SuspendLayout();
            wydzialy_tabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(rezerwacjaSali_tabPage);
            tabControl1.Controls.Add(dodajSale_tabPage);
            tabControl1.Controls.Add(dodajProwadzacego_tabPage);
            tabControl1.Controls.Add(wszystkieSale_tabPage);
            tabControl1.Controls.Add(wszystkieRezerwacje_tabPage);
            tabControl1.Controls.Add(wydzialy_tabPage);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(836, 592);
            tabControl1.TabIndex = 0;
            // 
            // rezerwacjaSali_tabPage
            // 
            rezerwacjaSali_tabPage.BackColor = Color.DimGray;
            rezerwacjaSali_tabPage.Controls.Add(addReservViewControl1);
            rezerwacjaSali_tabPage.Location = new Point(4, 24);
            rezerwacjaSali_tabPage.Name = "rezerwacjaSali_tabPage";
            rezerwacjaSali_tabPage.Padding = new Padding(3);
            rezerwacjaSali_tabPage.Size = new Size(828, 564);
            rezerwacjaSali_tabPage.TabIndex = 0;
            rezerwacjaSali_tabPage.Text = "Rezerwacja sali";
            // 
            // addReservViewControl1
            // 
            addReservViewControl1.BackColor = Color.DimGray;
            addReservViewControl1.Location = new Point(-3, -3);
            addReservViewControl1.Name = "addReservViewControl1";
            addReservViewControl1.Size = new Size(828, 564);
            addReservViewControl1.TabIndex = 0;
            // 
            // dodajSale_tabPage
            // 
            dodajSale_tabPage.BackColor = Color.DimGray;
            dodajSale_tabPage.Controls.Add(addRoomViewControl1);
            dodajSale_tabPage.Location = new Point(4, 24);
            dodajSale_tabPage.Name = "dodajSale_tabPage";
            dodajSale_tabPage.Padding = new Padding(3);
            dodajSale_tabPage.Size = new Size(828, 564);
            dodajSale_tabPage.TabIndex = 1;
            dodajSale_tabPage.Text = "Nowa sala";
            // 
            // addRoomViewControl1
            // 
            addRoomViewControl1.BackColor = Color.DimGray;
            addRoomViewControl1.Location = new Point(0, 0);
            addRoomViewControl1.Name = "addRoomViewControl1";
            addRoomViewControl1.Size = new Size(828, 564);
            addRoomViewControl1.TabIndex = 0;
            // 
            // dodajProwadzacego_tabPage
            // 
            dodajProwadzacego_tabPage.BackColor = Color.DimGray;
            dodajProwadzacego_tabPage.Location = new Point(4, 24);
            dodajProwadzacego_tabPage.Name = "dodajProwadzacego_tabPage";
            dodajProwadzacego_tabPage.Size = new Size(828, 564);
            dodajProwadzacego_tabPage.TabIndex = 2;
            dodajProwadzacego_tabPage.Text = "Nowy prowadzący";
            // 
            // wszystkieSale_tabPage
            // 
            wszystkieSale_tabPage.BackColor = Color.DimGray;
            wszystkieSale_tabPage.Controls.Add(allRoomViewControl1);
            wszystkieSale_tabPage.Location = new Point(4, 24);
            wszystkieSale_tabPage.Name = "wszystkieSale_tabPage";
            wszystkieSale_tabPage.Size = new Size(828, 564);
            wszystkieSale_tabPage.TabIndex = 3;
            wszystkieSale_tabPage.Text = "Wszystkie sale";
            // 
            // allRoomViewControl1
            // 
            allRoomViewControl1.BackColor = Color.DimGray;
            allRoomViewControl1.Location = new Point(0, 0);
            allRoomViewControl1.Name = "allRoomViewControl1";
            allRoomViewControl1.Size = new Size(828, 564);
            allRoomViewControl1.TabIndex = 0;
            // 
            // wszystkieRezerwacje_tabPage
            // 
            wszystkieRezerwacje_tabPage.BackColor = Color.DimGray;
            wszystkieRezerwacje_tabPage.Controls.Add(allReservViewControl1);
            wszystkieRezerwacje_tabPage.Location = new Point(4, 24);
            wszystkieRezerwacje_tabPage.Name = "wszystkieRezerwacje_tabPage";
            wszystkieRezerwacje_tabPage.Size = new Size(828, 564);
            wszystkieRezerwacje_tabPage.TabIndex = 4;
            wszystkieRezerwacje_tabPage.Text = "Wszystkie rezerwacje";
            // 
            // allReservViewControl1
            // 
            allReservViewControl1.BackColor = Color.DimGray;
            allReservViewControl1.Location = new Point(0, 0);
            allReservViewControl1.Name = "allReservViewControl1";
            allReservViewControl1.Size = new Size(828, 564);
            allReservViewControl1.TabIndex = 0;
            // 
            // wydzialy_tabPage
            // 
            wydzialy_tabPage.BackColor = Color.DimGray;
            wydzialy_tabPage.Controls.Add(wydzialViewControl1);
            wydzialy_tabPage.Location = new Point(4, 24);
            wydzialy_tabPage.Name = "wydzialy_tabPage";
            wydzialy_tabPage.Size = new Size(828, 564);
            wydzialy_tabPage.TabIndex = 5;
            wydzialy_tabPage.Text = "Wydziały";
            // 
            // wydzialViewControl1
            // 
            wydzialViewControl1.BackColor = Color.DimGray;
            wydzialViewControl1.Location = new Point(0, 0);
            wydzialViewControl1.Name = "wydzialViewControl1";
            wydzialViewControl1.Size = new Size(828, 564);
            wydzialViewControl1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Epilogue SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 607);
            label1.Name = "label1";
            label1.Size = new Size(527, 22);
            label1.TabIndex = 1;
            label1.Text = " System rezerwacji sal - Mateusz Grabowski - Politechnika Śląska";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(861, 634);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "System rezerwacji sal";
            tabControl1.ResumeLayout(false);
            rezerwacjaSali_tabPage.ResumeLayout(false);
            dodajSale_tabPage.ResumeLayout(false);
            wszystkieSale_tabPage.ResumeLayout(false);
            wszystkieRezerwacje_tabPage.ResumeLayout(false);
            wydzialy_tabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage rezerwacjaSali_tabPage;
        private TabPage dodajSale_tabPage;
        private Label label1;
        private TabPage dodajProwadzacego_tabPage;
        private TabPage wszystkieSale_tabPage;
        private TabPage wszystkieRezerwacje_tabPage;
        private TabPage wydzialy_tabPage;
        private WydzialViewControl wydzialViewControl1;
        private AddRoomViewControl addRoomViewControl1;
        private AllReservViewControl allReservViewControl1;
        private AllRoomViewControl allRoomViewControl1;
        private AddReservViewControl addReservViewControl1;
    }
}
