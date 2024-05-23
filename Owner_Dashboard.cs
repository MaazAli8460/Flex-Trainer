using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Owner_Dashboard : Form
    {
        public Owner_Dashboard()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.panel2.BackColor = Color.FromArgb(150, Color.Turquoise);
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
            label2.Font = customFont;
        }

        private void Owner_Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
