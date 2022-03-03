using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1
    {
		void levél(double meret, Color szin)
		{
			defaultkaresz.Előre(meret);
			defaultkaresz.Ív(meret * 0.6, 90);
			Fordulj(120);
			defaultkaresz.Ív(meret * 0.6, 90);
		}
	}
}
