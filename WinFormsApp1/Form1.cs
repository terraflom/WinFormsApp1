using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string BDS = BulletDamge.Text;
            int BDI = Int32.Parse(BDS);
            string WDS = WeaponDamage.Text;
            int WDI = Int32.Parse(WDS);
            string WCS = WeaponCrit.Text;
            int WCI = Int32.Parse(WCS);
            string MDS = ModsDamage.Text;
            int MDI = Int32.Parse(MDS);
            string MCS = ModsCrit.Text;
            int MCI = Int32.Parse(MCS);
            string NAS = NumberAccs.Text;
            int NAI = Int32.Parse(NAS);

            int Answr1 = (WDI + BDI) * (1 + (MDI + NAI*4) % 100);
            int Answr2 = (WDI + BDI) * (1 + MDI % 100);
            Answr1 = (Answr1 * (WCI + MCI) * 2) + Answr1 * (100 - (WCI + MCI));
            Answr2 = (Answr2 * (WCI + MCI + NAI * 4) * 2) + Answr2*(100-(WCI + MCI + NAI * 4));
            if (Answr1 <= Answr2)
            {
                Answer.Text = "Modifier for Crit is Better";
            }
            else
            {
                Answer.Text = "Modifier for Damage is Better";
            }
        }
    }
}
