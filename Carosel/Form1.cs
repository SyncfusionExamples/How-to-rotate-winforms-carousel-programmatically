using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace CaroselImageCollection
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonAdv10_Click(object sender, EventArgs e)
        {
            this.carousel1.ActiveItem = this.carousel1.Items[index];
            this.label2.Text = this.carousel1.ActiveItem.Text;
            index++;
            if (index >= this.carousel1.Items.Count)
            {
                index = 0;
            }
        }
    }
}
