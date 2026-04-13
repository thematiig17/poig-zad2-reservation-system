using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zadanie2.View;

namespace Zadanie2
{
    public partial class SaveLoadButtons : UserControl, IFileServiceView
    {
        public SaveLoadButtons()
        {
            InitializeComponent();

            zapisz_button.Click += (s, e) => SaveToFileClicked?.Invoke(this, EventArgs.Empty);
            wczytaj_button.Click += (s, e) => LoadFromFileClicked?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler SaveToFileClicked;
        public event EventHandler LoadFromFileClicked;

    }
}
