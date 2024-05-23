using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Trainer_Dash : Form
    {
        public Trainer_Dash()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();

            this.panel1.BackColor = Color.FromArgb(150, Color.MediumOrchid);
            privateFonts.AddFontFile("Deep_Hero.ttf");

            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);

            label1.Font = customFont;
        }

        private void Trainer_Dash_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
