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
    {void nemfogyatékosív(double szög,double méret,string merre)
        {

			for (int i = 0; i < szög; i++)
			{Előre(2 * méret * Math.Tan(Math.PI / 360));
				if (merre=="Balra")
				{
					Balra(1);
				}
				else
				{
			      Jobbra(1);
				}
			}
        }
		void oldalra(int méret,bool rajzol_e)
        {
		if (rajzol_e==false)
		{
				Tollat(fel);
		}
		Jobbra(90);
		Előre(méret);
		Balra(90);
		if (rajzol_e==false)
		{
			Tollat(le);
		}

        }

		#region láb
		void láb(int méret, Color szín)
		{
			Ív(180, méret);
			Jobbra(90);
			for (int i = 0; i < 2; i++)
			{
				Előre(méret / 2.5);
				Jobbra(60);
				Előre(méret / 2.5);
				Balra(120);
				Előre(méret / 2.5);
				Jobbra(60);

			}
			Előre(méret / 2.5);
			Tollat(fel);
			Jobbra(120);
			Előre(méret / 4);
			Tölt(szín);
			Tollat(le);
			Tollat(fel);
			Hátra(méret / 4);
			Balra(120);
			Tollat(le);
			Jobbra(90);



		}
		#endregion
		#region keretdarab
		void keretdarab(int méret, Color ív_szín, Color körszín,bool irány)
        {
            if (irány==true)
            {
				Ív(90, méret);
				Balra(180);

				Tollat(fel);
				Előre(1.5 * méret);
				Tollat(le);
				Jobbra(270);

				Ív(180, -0.75 * méret);
				Balra(90);
				Tollat(fel);
				Előre(1.5 * méret);
				Tollat(le);
				Jobbra(90);
				Hátra(méret);
				Balra(90);
				Hátra(méret / 2);
				Jobbra(40);
				Tollat(fel);
				Előre(méret / 5);

				Tollat(le);
				Tölt(ív_szín);
				Tollat(fel);
				Hátra(méret / 5);
				Balra(40);
				Tollat(le);
				Jobbra(180);
				Tollat(fel);
				Előre(0.4 * méret);
				Balra(90);
				Előre(0.45 * méret);

				Tollat(le);
				Ív(360, méret * 0.2);
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
				Hátra(0.4 * méret);
				Tollat(le);
				Balra(90);

			}
            else
            {
				Balra(90);
				Ív(90, -méret);
				Balra(180);

				Tollat(fel);
				Előre(1.5 * méret);
				Tollat(le);
				Jobbra(270);

				Ív(180, -0.75 * méret);
				Balra(90);
				Tollat(fel);
				Előre(1.5 * méret);
				Tollat(le);
				Jobbra(90);
				Hátra(méret);
				Balra(90);
				Hátra(méret / 2);
				Jobbra(40);
				Tollat(fel);
				Előre(méret / 5);

				Tollat(le);
				Tölt(ív_szín);
				Tollat(fel);
				Hátra(méret / 5);
				Balra(40);
				Tollat(le);
				Jobbra(180);
				Tollat(fel);
				Előre(0.4 * méret);
				Balra(90);
				Előre(0.45 * méret);

				Tollat(le);
				Ív(360, méret * 0.2);
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
				Hátra(0.4 * méret);
				Tollat(le);
				Balra(90);
			}
			
		}
		#endregion
		#region toll
		void tollak(int méret, Color szín,bool féltoll)
        {
            if (féltoll==false)
            {
				Ív(90, méret);
				Jobbra(180);
				Ív(90, méret);
				Hátra(méret * 2);
				Tollat(fel);
				Előre(méret);
				Jobbra(90);
				Előre(méret / 5);
				Tollat(le);
				Tölt(szín);
				Tollat(fel);
				Hátra(méret / 5);
				Balra(90);
				Hátra(méret);
				Tollat(le);

			}
            else
            {
				Ív(90, méret);
				Hátra(méret);
				Balra(90);
				Hátra(méret);
				Előre(méret / 2);
				Jobbra(90);
				Tollat(fel);
				Előre(méret / 8);
				Tollat(le);
				Tölt(szín);
				Tollat(fel);
				Hátra(méret /8);
				Balra(90);
				Hátra(méret / 2);
				Tollat(le);


			}
			
		}
		#endregion
		#region tollsor
		void tollsor(int hossz,int méret,Color szín)
        {tollak(méret,szín,true);
			for (int i = 0; i < hossz; i++)
			{
				tollak(méret,szín,false);
				oldalra(méret*2);
			}
			tollak(méret,szín,true);

        }
		#endregion
		#region szár
		void virágszár(int méret, Color szín)
		{
			Előre(méret);
			Ív(180, méret / 10);
			Előre(méret);
			Jobbra(90);
			Előre(méret / 5);
			Jobbra(90);
			Tollat(fel);
			Jobbra(45);
			Előre(méret / 10);
			Tollat(le);
			Tölt(szín);
			Tollat(fel);
			Hátra(méret / 10);
			Balra(45);

		}
		#endregion
		#region jobbkeret
		void jobboldalikeret(int felsőhossz, int jobbhossz, int alsóhossz, int méret,Color körszín ,Color szín)
        {
            for (int i = 0; i < felsőhossz; i++)
            {
				keretdarab(méret,szín,körszín,true);
				Tollat(fel);
				Jobbra(90);
				Előre(méret * 1.5);
				Balra(90);
				Tollat(le);

            }
            for (int i = 0; i < jobbhossz; i++)
            {
				keretdarab(méret, szín, körszín,true);
				Tollat(fel);
				Hátra(méret*1.75);
				
				Tollat(le);


			}
            for (int i = 0; i < alsóhossz; i++)
            {
				keretdarab(méret, szín, körszín,true);
				Tollat(fel);
				Jobbra(-90);
				Előre(méret * 1.5);
				Balra(-90);
				Tollat(le);
			}
			keretdarab(méret, szín, körszín,true);
		}
		#endregion

	}

}
