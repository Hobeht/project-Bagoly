using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void teljesbagoly(double méret)
        {
			bagoly(méret);
			Jobbra(90);
			Tollat(fel);
			Előre(méret/1.09090909);
			Balra(90);
			


			Hátra(méret/1.71428571);

			Tollat(le);
			szemorr(méret/8, Color.White, Color.Red, Color.Black, Color.Blue, Color.Purple);
			Jobbra(180);
			Tollat(fel);
			Hátra(méret/3);
			
			Balra(-90);
			Előre(méret/1.18+ méret / 4.615);
			Tollat(le);
			Balra(90);
            
				tollsor(6, méret / 4.615, Color.SandyBrown);
				Tollat(fel);
				Hátra(méret / 4.315);
				Jobbra(90);
				Előre(méret / 4.52 * 10);
				Tollat(le);
				Balra(90);
			//
			tollsor(6, méret / 4.45, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.4 * 10);
			Tollat(le);
			Balra(90);
			//
			tollsor(6, méret / 4.35, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.3 * 10);
			Tollat(le);
			Balra(90);
			//
			tollsor(6, méret / 4.3, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.2);
			Jobbra(90);
			Előre(méret / 4.28 * 10);
			Tollat(le);
			Balra(90);
			//
			tollsor(6, méret / 4.25, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.25 * 10);
			Tollat(le);
			Balra(90);
			//
			tollsor(6, méret / 4.25, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.3 * 10);
			Tollat(le);
			Balra(90);
			//
			tollsor(6, méret / 4.35, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.5 * 10);
			Tollat(le);
			Balra(90);

			tollsor(6, méret / 4.7, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.9 * 10);
			Tollat(le);
			Balra(90);

			tollsor(6, méret / 5.1, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 5.3);
			Jobbra(90);
			Előre(méret / 5.5 * 10);
			Tollat(le);
			Balra(90);
			tollsor(6, méret / 5.8, Color.SandyBrown);
			Tollat(fel);
			Hátra(méret / 4.3);
			Jobbra(90);
			Előre(méret / 4.8 * 10);
			Tollat(le);
			Balra(90);






		}
		void teljes_kép()
        {
			KERET(11, 14, 11, 11, 14, 11, 15, Color.White, Color.Brown);
        }
		void FELADAT()
		{




			Tollat(fel);
			Előre(50);
			Tollat(le);
            
			using(new Frissítés(false)) { teljesbagoly(80); }
            
				
			
				
				
				
			
				
			




		}
	}
}
