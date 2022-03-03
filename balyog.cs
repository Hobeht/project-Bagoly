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
			Bezier(70, 90, 60, 25, 150, true, true);
			Fordulj(90);
			Bezier(60, 180, 10, -90, 120, true, true);
        }
	}
}
