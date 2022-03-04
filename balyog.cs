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
    partial class Form1
    {
		void levél(double meret, Color szin)
        {
			Bezier(70, 90, 60, 25, 150, true, true);
			Fordulj(90);
            Bezier(60, 180, 30, -90, 120, true, true);
            defaultkaresz.Ív(30, -meret);
        }
        void félkör(double meret, Color szin) 
        { 
            defaultkaresz.Előre(meret);
            Fordulj(-90);
            defaultkaresz.Ív(180, meret / 2);
            Tollat(fel);
            Fordulj(-135);
            defaultkaresz.Előre(meret/2);
            Tölt(szin);
            defaultkaresz.Hátra(meret/2);
            Fordulj(45);
            Tollat(le);
        }
        void viragszel(double meret, int felkörszam, double összfordulas, Color tollszin, Color masikszin)
        {
            for (int i = 0; i < felkörszam; i++)
			{
                félkör(meret, tollszin);
                defaultkaresz.Előre(meret);
                Fordulj(összfordulas/felkörszam);
			}
        }
	}
}