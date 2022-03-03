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
    {void keretdarab(int méret, Color ív_szín,Color körszín)
        {
			Ív(90, méret);
			Balra(180);

			Tollat(fel);
			Előre(1.5*méret);
			Tollat(le);
			Jobbra(270);
			
			Ív(180, -0.75*méret);
			Balra(90);
			Tollat(fel);
			Előre(1.5*méret);
			Tollat(le);
			Jobbra(90);
			Hátra(méret);
			Balra(90);
			Hátra(méret/2);
			Jobbra(40);
			Tollat(fel);
			Előre(méret/5);

			Tollat(le);
			Tölt(ív_szín);
			Tollat(fel);
			Hátra(méret / 5);
			Balra(40);
			Tollat(le);
			Jobbra(180);
			Tollat(fel);
			Előre(0.6*méret);
			Balra(90);
			Előre(0.45*méret);

			Tollat(le);
			Ív(360, méret*0.25);
			Tollat(fel);
			Jobbra(90);
			Előre(méret * 0.1);
			Tollat(le);
			Tölt(körszín);
			Tollat(fel);
			Hátra(méret * 0.1);
			Balra(90);
			Tollat(le);
			Tollat(fel);
			
			Hátra(0.45 * méret);
			Jobbra(90);
			Hátra(0.6 * méret);
			Tollat(le);
			Balra(90);
		}
    }
}
