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
		void nemfogyatékosív(double szög, double méret, string merre)
		{using(new Frissítés(false))
            {
                Előre((2 * méret * Math.Tan(Math.PI / 360)) / 2);
                for (int i = 0; i < szög; i++)
                {

                    if (merre == "Balra")
                    {
                        Balra(1);
                    }
                    else
                    {
                        Jobbra(1);
                    }
                    Előre(2 * méret * Math.Tan(Math.PI / 360));
                }
            }
			
		}
		void oldalra(double méret, bool rajzol_e)
		{
			if (rajzol_e == false)
			{
				Tollat(fel);
			}
			Jobbra(90);
			Előre(méret);
			Balra(90);
			if (rajzol_e == false)
			{
				Tollat(le);
			}

		}

		#region láb
		void láb(double méret, Color szín)
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
		void keretdarab(int méret, Color ív_szín, Color körszín, bool irány)
		{
            using(new Frissítés(false))
            { 
			if (irány == true)
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
				nemfogyatékosív(90, méret, "Balra");
				Jobbra(90);
				nemfogyatékosív(180, 0.75*méret, "Jobbra");
				Előre(méret);
				Jobbra(90);
				Előre(méret / 2) ;
				Hátra(méret / 3);
				Tollat(fel);
				Jobbra(90);
				Előre(méret / 5);
				Tollat(le);
				Tölt(ív_szín);
				Tollat(fel);
				Hátra(méret / 5);
				Balra(90);
				Előre(méret / 3);
				Tollat(le);

				Tollat(fel);
				Pihi(1000);
				Előre(2*(0.4 * méret));
				Balra(-90);
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
				Előre(2*(0.4 * méret));
				Tollat(le);
				Balra(90);
			}
            }
		}
		#endregion
		#region toll
		void tollak(double méret, Color szín, bool féltoll,string féltolltipus)
		{
			if (féltoll == false)
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
			Előre(méret);
				Tollat(le);

			}
			if(féltoll==true&&féltolltipus=="Bal")
			{
                
				Ív(90, méret);
				//Tollat(fel); //itt
				Hátra(méret);
				//Tollat(le);
				Balra(90);
				Hátra(méret);
				Előre(méret / 1.5);
				Jobbra(90);
				Tollat(fel);
				Előre(méret / 10);
				Tollat(le);
				Tölt(szín);
				Tollat(fel);
				Hátra(méret / 10);
				Balra(90);
				Hátra(méret / 1.5);
				Tollat(le);


			}
            if (féltoll == true && féltolltipus == "Jobb")
            {
                Jobbra(90);
                Hátra(méret);
				nemfogyatékosív(90, méret, "Balra");
				//Tollat(fel);//itt
				Hátra(méret);
				//Tollat(le);
				Balra(-90);
				Hátra(méret);
				Előre(méret / 1.5);
				Jobbra(-90);
				Tollat(fel);
				Előre(méret / 10);
				Tollat(le);
				Tölt(szín);
				Tollat(fel);
				Hátra(méret / 10);
				Balra(-90);
				Hátra(méret / 1.5);
				Tollat(le);
			}

		}

		#endregion
		#region tollsor
		void tollsor(int hossz, double méret, Color szín)
		{
			tollak(méret, szín, true,"Jobb");
			Jobbra(180);
			for (int i = 0; i < hossz-2; i++)
			{
				tollak(méret, szín, false,"Jobb");
				
			}
			tollak(méret, szín, true,"Bal");
			Előre(méret);
			Jobbra(90);
		}
		void tollmozaik(double méret,double csökkenés_mértéke,int sorok_szama)
        {
            for (int i = 0; i < sorok_szama-1; i++)
            {
				tollsor(6, méret, Color.SandyBrown);
				
				Tollat(fel);
				Hátra(méret*1.05);
				Jobbra(90);
				Előre(méret * 9);
				
				Tollat(le);
				
			}
			tollsor(6, méret, Color.SandyBrown);

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
		void jobboldalikeret(int felsőhossz, int jobbhossz, int alsóhossz, int méret, Color körszín, Color szín)
		{
			for (int i = 0; i < felsőhossz; i++)
			{
				keretdarab(méret, szín, körszín, true);
				Tollat(fel);
				Jobbra(90);
				Előre(méret * 1.5);
				Balra(90);
				Tollat(le);

			}
			for (int i = 0; i < jobbhossz; i++)
			{
				keretdarab(méret, szín, körszín, true);
				Tollat(fel);
				Hátra(méret * 1.74);

				Tollat(le);


			}
			for (int i = 0; i < alsóhossz; i++)
			{
				keretdarab(méret, szín, körszín, true);
				Tollat(fel);
				Jobbra(-90);
				Előre(méret * 1.45);
				Balra(-90);
				Tollat(le);
			}
			
			
			keretdarab(méret, szín, körszín, true);
		}
		#endregion
	void baloldalikeret(int felsőhossz, int balhossz, int alsóhossz, int méret, Color körszín, Color szín)
        {
			for (int i = 0; i < alsóhossz; i++)
			{
				keretdarab(méret, szín, körszín, false);
				Tollat(fel);
				Balra(90);
				Előre(méret * 1.5);
				Balra(-90);
				Tollat(le);

			}
			for (int i = 0; i < balhossz; i++)
			{
				keretdarab(méret, szín, körszín, false);
				Tollat(fel);
				Előre(méret * 1.75);

				Tollat(le);


			}
			for (int i = 0; i < felsőhossz; i++)
			{
				keretdarab(méret, szín, körszín, false);
				Tollat(fel);
				Jobbra(90);
				Előre(méret * 1.5);
				Balra(90);
				Tollat(le);
			}
			keretdarab(méret, szín, körszín, false);
		}
		void KERET(int jobbfelsohossz,int jobbhossz,int jobbalsóhossz,int balalsóhossz,int balhossz,int balfelsőhossz,int méret,Color körszín,Color szín)
        {
			baloldalikeret(balalsóhossz-1, balhossz-1, balfelsőhossz-1, méret, körszín, szín);
			Jobbra(90);
			Előre(méret);
			Balra(90);
			jobboldalikeret(jobbfelsohossz-1, jobbhossz-1, jobbalsóhossz-1, méret, körszín, szín);
			
		}
		void bagoly(double méret)
        {
			Jobbra(90);
			Előre(méret / 16);
			Balra(90);
			Hátra(méret);
			oldalra(méret / 8, true);
			nemfogyatékosív(90, méret/2, "Jobbra");
			Balra(90);
			Tollat(fel);
			Hátra(méret/2);
			oldalra(-méret/2, false);

			Tollat(le);
			láb(méret/2, Color.Black);
			Tollat(fel);

			oldalra(méret/2, false);
			Hátra(-méret/2);
			Tollat(le);

			Bezier(10, 0, 40, 20, méret*1.5);

			nemfogyatékosív(10, méret * 9, "Balra");
			nemfogyatékosív(40, méret, "Balra");
			
			Jobbra(50);
			Tollat(fel);
			Hátra(méret * 3.14);
			Balra(90);
			Előre(méret/1.5);
			Jobbra(90);
			
			Tollat(le);
			Jobbra(-90);
			Előre(méret / 16);
			Balra(-90);
			Hátra(méret);
			oldalra(-méret / 8, true);
			nemfogyatékosív(90, méret / 2, "Balra");
			Balra(-90);
			Tollat(fel);
			Hátra(méret / 2);
			oldalra(méret / 2, false);
			oldalra(-méret, false);
			Tollat(le);
			láb(méret / 2, Color.Black);
			Tollat(fel);
			nemfogyatékosív(90, méret/2, "Jobbra");
			Balra(90);
			Tollat(le);
			Bezier(10, 0, 40, -20, méret * 1.5);
			nemfogyatékosív(10, méret * 9, "Jobbra");
			nemfogyatékosív(40, méret, "Jobbra");

			Balra(50);
			Jobbra(90);
			Tollat(fel);
			Előre(méret*1.37);
			Tollat(le);
			Balra(90);
			Jobbra(78);
			fül(méret/5.35);
			Balra(103);


		}
		void fül(double méret)
        {
			nemfogyatékosív(80, méret , "Jobbra");
			Balra(90);
			nemfogyatékosív(70, méret / 2.5, "Balra");
			Jobbra(90);

			nemfogyatékosív(95, méret/1.5 , "Jobbra");
			Balra(90);
			nemfogyatékosív(70, méret / 1.5, "Balra");
			Jobbra(90);
			nemfogyatékosív(80, méret / 1.5, "Jobbra");
			nemfogyatékosív(160, méret / 5, "Balra");
			nemfogyatékosív(60, méret , "Balra");
			nemfogyatékosív(50, méret *5, "Balra");
			nemfogyatékosív(40, méret * 5, "Balra");
			nemfogyatékosív(50, méret, "Balra");
			Jobbra(155);
			nemfogyatékosív(50, méret, "Balra");
			nemfogyatékosív(40, méret * 5, "Balra");
			nemfogyatékosív(50, méret * 5, "Balra");
			nemfogyatékosív(60, méret, "Balra");
			nemfogyatékosív(160, méret / 5, "Balra");
			
			nemfogyatékosív(80, méret / 1.5, "Jobbra");
			Jobbra(90);
			nemfogyatékosív(70, méret / 1.5, "Balra");
			Balra(90);
			nemfogyatékosív(95, méret / 1.5, "Jobbra");
			Jobbra(90);
			nemfogyatékosív(70, méret / 2.5, "Balra");
			Balra(90);
			nemfogyatékosív(80, méret , "Jobbra");


		}
        void jóív(double szög, double méret, string merre)
        {
            using (new Frissítés(false))
            {
                for (int i = 0; i < szög; i++)
                {
                    defaultkaresz.Előre(2 * méret * Math.Tan(Math.PI / 360));
                    if (merre == "Balra")
                    {
                        Balra(1);
                    }
                    else
                    {
                        Jobbra(1);
                    }
                }
            }
        }
        void levél(double meret, Color szin, bool irany)
        {
            if (irany)
            {
                Bezier(meret / 1.4285, 90, meret / 1.6666, 25, meret / 0.6666);
                Fordulj(90);
                Bezier(meret / 1.6666, 180, meret / 3.3333, -90, meret / 0.8333);
                Fordulj(-20);
                defaultkaresz.Előre(meret / 4);
                for (int i = 0; i < 4; i++)
                {
                    Fordulj(5);
                    defaultkaresz.Előre(meret / 4);
                }
                defaultkaresz.Előre(meret / 7);
                Fordulj(90);
                defaultkaresz.Előre(meret / 1.265);
                Tollat(fel);
                Fordulj(135);
                defaultkaresz.Előre(meret / 4);
                Tölt(szin);
                defaultkaresz.Hátra(meret / 4);
                Fordulj(-45);
                Tollat(le);
            }
            else
            {
                Fordulj(180);
                Bezier(-meret / 1.4285, 90, -meret / 1.6666, -25, -meret / 0.6666);
                Fordulj(-90);
                Fordulj(180);
                Bezier(-meret / 1.6666, 0, -meret / 3.3333, 90, -meret / 0.8333);
                Fordulj(20);
                defaultkaresz.Előre(meret / 4);
                for (int i = 0; i < 4; i++)
                {
                    Fordulj(-5);
                    defaultkaresz.Előre(meret / 4);
                }
                defaultkaresz.Előre(meret / 7);
                Fordulj(-90);
                defaultkaresz.Előre(meret / 1.265);
                Tollat(fel);
                Fordulj(-135);
                defaultkaresz.Előre(meret / 4);
                Tölt(szin);
                defaultkaresz.Hátra(meret / 4);
                Fordulj(45);
                Tollat(le);
            }
        }
        void félkör(double meret, bool irany, Color szin)
        {
            if (irany)
            {
                defaultkaresz.Előre(meret);
                Fordulj(-90);
                jóív(180, meret / 2, "Jobbra");
                Tollat(fel);
                Fordulj(-135);
                defaultkaresz.Előre(meret / 2);
                Tölt(szin);
                defaultkaresz.Hátra(meret / 2);
                Fordulj(45);
                Tollat(le);
            }
            else
            {
                defaultkaresz.Előre(meret);
                Fordulj(90);
                jóív(180, meret / 2, "Balra");
                Tollat(fel);
                Fordulj(135);
                defaultkaresz.Előre(meret / 2);
                Tölt(szin);
                defaultkaresz.Hátra(meret / 2);
                Fordulj(-45);
                Tollat(le);
            }
        }
        void viragszel(double meret, int felkörszam, double összfordulas, bool irany, Color szin)
        {
            for (int i = 0; i < felkörszam; i++)
            {
                félkör(meret, irany, szin);
                defaultkaresz.Előre(meret);
                Fordulj(összfordulas / felkörszam);
            }
        }
        void viragkulso(double meret, Color szin)
        {
            Fordulj(90);
            jóív(90, meret, "Jobbra");
            defaultkaresz.Előre(3 * meret);
            Fordulj(5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(7);
            defaultkaresz.Előre(meret / 8);
            Fordulj(10);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret / 12);
                Fordulj(10);
            }
            Fordulj(-120);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret / 12);
                Fordulj(-10);
            }
            defaultkaresz.Előre(meret / 12);
            Fordulj(-12);
            for (int i = 0; i < 5; i++)
            {
                defaultkaresz.Előre(meret / 12);
                Fordulj(-15);
            }
            defaultkaresz.Előre(meret / 2.77);
            defaultkaresz.Előre(meret * 3);
            jóív(90, meret / 1.555, "Balra");
            Tollat(fel);
            Fordulj(-90);
            defaultkaresz.Előre(meret / 2.9411);
            Fordulj(-180);
            Tollat(le);
            Fordulj(-90);
            jóív(90, meret, "Balra");
            defaultkaresz.Előre(3 * meret);
            Fordulj(-5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(-5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(-7);
            defaultkaresz.Előre(meret / 8);
            Fordulj(-10);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret / 12);
                Fordulj(-10);
            }
            Fordulj(120);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret / 12);
                Fordulj(10);
            }
            defaultkaresz.Előre(meret / 12);
            Fordulj(12);
            for (int i = 0; i < 5; i++)
            {
                defaultkaresz.Előre(meret / 12);
                Fordulj(15);
            }
            defaultkaresz.Előre(meret / 2.77);
            defaultkaresz.Előre(meret * 3);
            jóív(90, meret / 1.555, "Jobbra");
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre((meret / 2.9411) / 2);
            Tölt(szin);
            defaultkaresz.Hátra((meret / 2.9411) / 2);
            Fordulj(180);
            Tollat(le);
        }
        void viragbelso(double meret, Color szin)
        {
            Fordulj(90);
            jóív(90, meret / 1.5, "Jobbra");
            defaultkaresz.Előre(4 * meret);
            Fordulj(5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(7);
            defaultkaresz.Előre(meret / 8);
            Fordulj(10);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret / 8);
                Fordulj(10);
            }
            Fordulj(-120);
            for (int i = 0; i < 2; i++)
            {
                defaultkaresz.Előre(meret / 9);
                Fordulj(-5);
            }
            for (int i = 0; i < 13; i++)
            {
                defaultkaresz.Előre(meret / 9);
                Fordulj(-11);
            }
            Fordulj(84);
            for (int i = 0; i < 4; i++)
            {
                jóív(100, meret / 2, "Jobbra");
                Fordulj(100);
            }
            jóív(70, meret / 1.7, "Jobbra");
            jóív(22, meret * 1.2, "Balra");
            jóív(180, meret / 10, "Balra");
            jóív(22, meret * 1.2, "Jobbra");
            jóív(70, meret / 1.7, "Balra");
            for (int i = 0; i < 4; i++)
            {
                Fordulj(-100);
                jóív(100, meret / 2, "Balra");
            }
            Fordulj(-84);
            for (int i = 0; i < 6; i++)
            {
                Fordulj(11);
                defaultkaresz.Előre(meret / 9);
            }
            Fordulj(-60);
            for (int i = 0; i < 7; i++)
            {
                Fordulj(-11);
                defaultkaresz.Előre(meret / 9);
            }
            for (int i = 0; i < 2; i++)
            {
                Fordulj(-5);
                defaultkaresz.Előre(meret / 9);
            }
            Fordulj(-120);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret / 8);
                Fordulj(10);
            }
            Fordulj(10);
            defaultkaresz.Előre(meret / 8);
            Fordulj(7);
            defaultkaresz.Előre(meret / 8);
            Fordulj(5);
            defaultkaresz.Előre(meret / 8);
            Fordulj(5);
            defaultkaresz.Előre(4 * meret);
            jóív(93, meret / 1.45, "Jobbra");
            Tollat(fel);
            Fordulj(-42);
            defaultkaresz.Előre(meret / 2);
            Tölt(szin);
            defaultkaresz.Hátra(meret / 2);
            Fordulj(-45);
            Tollat(le);
        }
        void viragtetoresz(double meret, Color szin, bool irany)
        {
            if (irany)
            {
                defaultkaresz.Előre(meret);
                jóív(90, meret, "Jobbra");
                Fordulj(140);
                jóív(130, meret * 1.8, "Balra");
                defaultkaresz.Előre(meret / 1.51);
                jóív(180, meret / 1.005, "Balra");
                Tollat(fel);
                Fordulj(45);
                defaultkaresz.Előre(meret);
                Tölt(szin);
                defaultkaresz.Hátra(meret);
                Fordulj(-45);
                Tollat(le);
            }
            else
            {
                defaultkaresz.Előre(meret);
                jóív(90, meret, "Balra");
                Fordulj(-140);
                jóív(130, meret * 1.8, "Jobbra");
                defaultkaresz.Előre(meret / 1.51);
                jóív(180, meret / 1.005, "Jobbra");
                Tollat(fel);
                Fordulj(-45);
                defaultkaresz.Előre(meret);
                Tölt(szin);
                defaultkaresz.Hátra(meret);
                Fordulj(45);
                Tollat(le);
            }
        }
        void kompletteto(double meret, Color sziromszin, Color körszin)
        {
            Tollat(fel);
            Fordulj(-90);
            defaultkaresz.Előre(meret * 2.25);
            Fordulj(90);
            Tollat(le);
            viragtetoresz(meret, sziromszin, true);
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre(meret * 2.25);
            Fordulj(-90);
            defaultkaresz.Előre(meret * 2);
            Fordulj(-90);
            Tollat(le);
            jóív(360, meret, "Balra");
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre(meret);
            Tölt(körszin);
            defaultkaresz.Hátra(meret * 3);
            Fordulj(90);
            defaultkaresz.Előre(meret * 2.25);
            Fordulj(-90);
            Tollat(le);
            viragtetoresz(meret, sziromszin, false);
        }
        void viragszar(double meret, Color szin)
        {
            Fordulj(-90);
            defaultkaresz.Előre(meret / 4);
            Fordulj(90);
            defaultkaresz.Előre(meret * 3);
            jóív(180, meret / 4, "Balra");
            defaultkaresz.Előre(meret * 3);
            Fordulj(90);
            defaultkaresz.Előre(meret / 2);
            Tollat(fel);
            Fordulj(105);
            defaultkaresz.Előre(meret);
            Tölt(szin);
            defaultkaresz.Hátra(meret);
            Fordulj(75);
            defaultkaresz.Előre(meret / 4);
            Fordulj(-90);
            Tollat(le);
        }
        void nagyviragresz(double meret, Color kulsoszirom, Color belsoszirom, Color holyagszin)
        {
            viragkulso(meret, kulsoszirom);
            Tollat(fel);
            defaultkaresz.Előre(meret / 4);
            Fordulj(90);
            defaultkaresz.Előre(meret / 40);
            Fordulj(-90);
            Tollat(le);
            viragbelso(meret / 1.3, belsoszirom);
            Tollat(fel);
            defaultkaresz.Hátra(meret / 1.6666);
            Tollat(le);
            Fordulj(90);
            Tollat(fel);
            jóív(90, meret, "Jobbra");
            defaultkaresz.Előre(meret / 3.3);
            Tollat(le);
            viragszel(meret / 2.4, 4, 0, false, holyagszin);
            Hátra((meret / 2.4) * 4);
            Fordulj(180);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(15);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(30);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(30);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(15);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(15);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(30);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(30);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(15);
            félkör(meret / 2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            viragszel(meret / 2.4, 4, 0, true, holyagszin);
            Hátra((meret / 2.4) * 4);
            Fordulj(180);
            defaultkaresz.Előre(meret / 3.3);
            Tollat(fel);
            jóív(90, meret, "Jobbra");
            Fordulj(-90);
            Tollat(le);
        }
        void egeszvirag(double meret, Color levelszin, Color szarszin, Color holyagszin, Color kulsoszirom, Color belsoszirom, Color tetoszirom, Color körszin)
        {
            levél(meret, levelszin, true);
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre(meret * 1.2);
            Fordulj(-90);
            Tollat(le);
            viragszar(meret / 1.7, szarszin);
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre(meret * 1.2);
            Fordulj(-90);
            Tollat(le);
            levél(meret, levelszin, false);
            Tollat(fel);
            Fordulj(-90);
            defaultkaresz.Előre(meret * 1.2);
            Fordulj(90);
            defaultkaresz.Előre(meret * 2.2);
            Tollat(le);
            nagyviragresz(meret, kulsoszirom, belsoszirom, holyagszin);
            Tollat(fel);
            defaultkaresz.Előre(meret * 5.3);
            Tollat(le);
            kompletteto(meret / 3.5, tetoszirom, körszin);
        }
        void szem(double meret, Color körszin, Color körkörüliszin, Color körkörülikörüliszin, Color körkörülikörülikörüliszin)
        {
            Tollat(fel);
            defaultkaresz.Előre(meret / 1.56739);
            Tollat(le);
            Fordulj(-90);
            jóív(180, meret, "Balra");
            defaultkaresz.Előre(meret * 0.1);
            defaultkaresz.Hátra(meret * 0.1);
            Fordulj(-90);
            Tollat(fel);
            defaultkaresz.Hátra(meret * 2.15);
            Tollat(le);
            Fordulj(-90);
            jóív(100, meret * 1.4, "Balra");
            jóív(45, meret * 1.45, "Balra");
            jóív(62, meret * 0.8, "Balra");
            Fordulj(-117);
            Tollat(fel);
            defaultkaresz.Hátra(meret * 2.8);
            Tollat(le);
            Fordulj(-90);
            jóív(100, (meret * 1.4) * 1.5, "Balra");
            jóív(45, (meret * 1.45) * 1.5, "Balra");
            jóív(60, (meret * 0.8) * 1.5, "Balra");
            Fordulj(-115);
            Tollat(fel);
            defaultkaresz.Hátra(meret * 4.3);
            Tollat(le);
            Fordulj(-90);
            jóív(35, meret * 2.4, "Balra");
            jóív(30, meret / 2, "Balra");
            Fordulj(-84);
            jóív(150, meret / 1.6, "Balra");
            Fordulj(-120);
            jóív(150, meret / 1.4, "Balra");
            Fordulj(-115);
            jóív(150, meret / 1.2, "Balra");
            Fordulj(-115);
            jóív(158, meret / 1.2, "Balra");
            Fordulj(-149);
            Tollat(fel);
            defaultkaresz.Hátra(meret / 0.231481);
            Tollat(le);
            Fordulj(90);
            jóív(180, meret, "Jobbra");
            Fordulj(90);
            Tollat(fel);
            defaultkaresz.Hátra(meret * 2.15);
            Tollat(le);
            Fordulj(90);
            defaultkaresz.Hátra(meret * 0.1);
            defaultkaresz.Előre(meret * 0.1);
            jóív(100, meret * 1.4, "Jobbra");
            jóív(45, meret * 1.45, "Jobbra");
            jóív(62, meret * 0.8, "Jobbra");
            Fordulj(117);
            Tollat(fel);
            defaultkaresz.Hátra(meret * 2.8);
            Tollat(le);
            Fordulj(90);
            jóív(100, (meret * 1.4) * 1.5, "Jobbra");
            jóív(45, (meret * 1.45) * 1.5, "Jobbra");
            jóív(60, (meret * 0.8) * 1.5, "Jobbra");
            Fordulj(115);
            Tollat(fel);
            defaultkaresz.Hátra(meret * 4.3);
            Tollat(le);
            Fordulj(90);
            jóív(35, meret * 2.4, "Jobbra");
            jóív(30, meret / 2, "Jobbra");
            Fordulj(84);
            jóív(150, meret / 1.6, "Jobbra");
            Fordulj(120);
            jóív(150, meret / 1.4, "Jobbra");
            Fordulj(115);
            jóív(150, meret / 1.2, "Jobbra");
            Fordulj(115);
            jóív(158, meret / 1.2, "Jobbra");
            Fordulj(149);
            Tollat(fel);
            defaultkaresz.Hátra(meret / 3.125);
            Tölt(körkörülikörülikörüliszin);
            defaultkaresz.Hátra(meret / 1.08695);
            Tölt(körkörülikörüliszin);
            defaultkaresz.Hátra(meret / 1.2195);
            Tölt(körkörüliszin);
            defaultkaresz.Hátra(meret / 0.9433);
            Tölt(körszin);
            defaultkaresz.Hátra(meret / 0.8333);
            defaultkaresz.Hátra(meret / 1.56739);
            Tollat(le);
        }
        void orr(double meret, Color szin)
        {
            defaultkaresz.Előre(meret);
            Fordulj(-90);
            defaultkaresz.Előre(meret);
            Fordulj(-90);
            defaultkaresz.Előre(meret / 5);
            Fordulj(-90);
            defaultkaresz.Előre((meret / 5) * 4);
            Fordulj(90);
            defaultkaresz.Előre((meret / 5) * 4);
            Fordulj(-90);
            defaultkaresz.Előre(meret / 5);
            Fordulj(-135);
            Tollat(fel);
            defaultkaresz.Előre(meret / 10);
            Tölt(szin);
            defaultkaresz.Hátra(meret / 10);
            Tollat(le);
            Fordulj(45);
        }
        void szemorr(double meret, Color körszin, Color körkörüliszin, Color körkörülikörüliszin, Color körkörülikörülikörüliszin, Color orrszin)
        {
            Fordulj(-45);
            szem(meret, körszin, körkörüliszin, körkörülikörüliszin, körkörülikörülikörüliszin);
            Fordulj(180);
            orr(meret * 2, orrszin);
            defaultkaresz.Előre(meret * 2);
            Fordulj(-90);
            defaultkaresz.Előre(meret * 2);
            szem(meret, körszin, körkörüliszin, körkörülikörüliszin, körkörülikörülikörüliszin);
            defaultkaresz.Hátra(meret * 2);
            Fordulj(135);
        }

    }
}
