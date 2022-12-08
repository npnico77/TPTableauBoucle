using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPTableauBoucle
{
    public partial class Decompte : Form
    {
        public Decompte()
        {
            InitializeComponent();
        }

        private void buttonDecompte_Click(object sender, EventArgs e)
        {  
            for (int i = 10; i >= 0;i--)
            {
                decompte.Text = Convert.ToString(i);
                Task.Delay(1000).Wait();
            }
           
        }

       
    }
}
