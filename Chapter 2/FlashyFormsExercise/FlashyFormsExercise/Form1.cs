using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashyFormsExercise
{
    public partial class FlashyThing : Form
    {
        public FlashyThing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {


                for (int c = 0; c < 254; c = c + 1)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(3);
                }

                for (int c = 254; c > 0; c = c - 1)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
