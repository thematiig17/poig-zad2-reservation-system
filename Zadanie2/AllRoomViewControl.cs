using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2
{
    public partial class AllRoomViewControl : UserControl, IAllRoomView
    {
        public AllRoomViewControl()
        {
            InitializeComponent();
        }
        public void UstawListeSal(List<Sala> sale)
        {
            listaSal_listBox.Items.Clear();
            foreach (var sala in sale)
            {
                listaSal_listBox.Items.Add(sala);
            }
        }

        private void AllRoomViewControl_Load(object sender, EventArgs e)
        {

        }
    }
}
