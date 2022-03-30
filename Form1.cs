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
			szemorr(méret/8, Color.White, Color.Black, Color.SandyBrown, Color.Green, Color.Black);
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
			Balra(90);
			Tollat(le);
		}
		void teljes_kép()
        {
			KERET(11, 14, 11, 11, 14, 11, 16, Color.White, Color.Brown);
			Tollat(fel);
			Előre(5);
			Fordulj(90);
			Előre(7);
			Tollat(le);
			Előre(5);
			Hátra(5);
			Tollat(fel);
			Fordulj(-90);
			Előre(95);
			Tollat(le);
            teljesbagoly(63);
			Tollat(fel);
			Hátra(48);
			Fordulj(-90);
			Előre(100);
			Fordulj(90);
			Tollat(le);
			egeszvirag(30, Color.Green, Color.White, Color.SandyBrown, Color.White, Color.White, Color.SandyBrown, Color.White);
			Tollat(fel);
			Hátra(222.5);
			Fordulj(90);
			Előre(238);
			Fordulj(-90);
			Tollat(le);
			egeszvirag(30, Color.Green, Color.White, Color.SandyBrown, Color.White, Color.White, Color.SandyBrown, Color.White);
			Tollat(fel);
			Előre(30);
			Tölt(Color.DimGray);
			Tollat(le);
			/*
			 */
        }
		void FELADAT()
        { 
			/*
			Tollat(fel);
			Előre(50);
			Tollat(le);
            
			using(new Frissítés(false))
			{ 
				teljesbagoly(80); 
			}
			 */
			using(new Frissítés(false))
            { 
				/*
				KERET(11, 14, 11, 11, 14, 11, 16, Color.White, Color.Brown);
				 */
				teljes_kép();
			}
		}
	}
}
