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
        void jóív(double szög, double méret, string merre)
        {
            using(new Frissítés(false))
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
			    Bezier(meret/1.4285, 90, meret/1.6666, 25, meret/0.6666);
			    Fordulj(90);
                Bezier(meret/1.6666, 180, meret/3.3333, -90, meret/0.8333);
                Fordulj(-20);
                defaultkaresz.Előre(meret/4);
                for (int i = 0; i < 4; i++)
			    {
                    Fordulj(5);
                    defaultkaresz.Előre(meret/4);
			    }
                defaultkaresz.Előre(meret/7);
                Fordulj(90);
                defaultkaresz.Előre(meret/1.265);
                Tollat(fel);
                Fordulj(135);
                defaultkaresz.Előre(meret/4);
                Tölt(szin);
                defaultkaresz.Hátra(meret/4);
                Fordulj(-45);
                Tollat(le);
	        }
            else
	        {
                Fordulj(180);
			    Bezier(-meret/1.4285, 90, -meret/1.6666, -25, -meret/0.6666);
		    	Fordulj(-90);
		    	Fordulj(180);
                Bezier(-meret/1.6666, 0, -meret/3.3333, 90, -meret/0.8333);
			    Fordulj(20);
                defaultkaresz.Előre(meret/4);
			    for (int i = 0; i < 4; i++)
			    {
                    Fordulj(-5);
                    defaultkaresz.Előre(meret/4);
			    }
			    defaultkaresz.Előre(meret/7);
                Fordulj(-90);
                defaultkaresz.Előre(meret/1.265);
                Tollat(fel);
                Fordulj(-135);
                defaultkaresz.Előre(meret/4);
                Tölt(szin);
                defaultkaresz.Hátra(meret/4);
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
                defaultkaresz.Előre(meret/2);
                Tölt(szin);
                defaultkaresz.Hátra(meret/2);
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
                Fordulj(összfordulas/felkörszam);
			}
        }
        void viragkulso(double meret, Color szin)
        {
            Fordulj(90);
            jóív(90, meret, "Jobbra");
            defaultkaresz.Előre(3*meret);
            Fordulj(5);
            defaultkaresz.Előre(meret/8);
            Fordulj(5);
            defaultkaresz.Előre(meret/8);
            Fordulj(7);
            defaultkaresz.Előre(meret/8);
            Fordulj(10);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret/12);
                Fordulj(10);
		    }
            Fordulj(-120);
            for (int i = 0; i < 3; i++)
	        {
                defaultkaresz.Előre(meret/12);
                Fordulj(-10);
		    }
            defaultkaresz.Előre(meret/12);
            Fordulj(-12);
            for (int i = 0; i < 5; i++)
		    {
                defaultkaresz.Előre(meret/12);
                Fordulj(-15);
		    }
            defaultkaresz.Előre(meret/2.77);
            defaultkaresz.Előre(meret*3);
            jóív(90, meret/1.555, "Balra");
            Tollat(fel);
            Fordulj(-90);
            defaultkaresz.Előre(meret/2.9411);
            Fordulj(-180);
            Tollat(le);
            Fordulj(-90);
            jóív(90, meret, "Balra");
            defaultkaresz.Előre(3*meret);
            Fordulj(-5);
            defaultkaresz.Előre(meret/8);
            Fordulj(-5);
            defaultkaresz.Előre(meret/8);
            Fordulj(-7);
            defaultkaresz.Előre(meret/8);
            Fordulj(-10);
            for (int i = 0; i < 3; i++)
		    {
                defaultkaresz.Előre(meret/12);
                Fordulj(-10);
		    }
            Fordulj(120);
            for (int i = 0; i < 3; i++)
			{
                defaultkaresz.Előre(meret/12);
                Fordulj(10);
			}
            defaultkaresz.Előre(meret/12);
            Fordulj(12);
            for (int i = 0; i < 5; i++)
			{
                defaultkaresz.Előre(meret/12);
                Fordulj(15);
			}
            defaultkaresz.Előre(meret/2.77);
            defaultkaresz.Előre(meret*3);
            jóív(90, meret/1.555, "Jobbra");
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre((meret/2.9411)/2);
            Tölt(szin);
            defaultkaresz.Hátra((meret/2.9411)/2);
            Fordulj(180);
            Tollat(le);
        }
        void viragbelso(double meret, Color szin)
        {
            Fordulj(90);
            jóív(90, meret/1.5, "Jobbra");
            defaultkaresz.Előre(4*meret);
            Fordulj(5);
            defaultkaresz.Előre(meret/8);
            Fordulj(5);
            defaultkaresz.Előre(meret/8);
            Fordulj(7);
            defaultkaresz.Előre(meret/8);
            Fordulj(10);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret/8);
                Fordulj(10);
		    }
            Fordulj(-120);
            for (int i = 0; i < 2; i++)
	        {
                defaultkaresz.Előre(meret/9);
                Fordulj(-5);
		    }
            for (int i = 0; i < 13; i++)
		    {
                defaultkaresz.Előre(meret/9);
                Fordulj(-11);
		    }
            Fordulj(84);
            for (int i = 0; i < 4; i++)
			{
                jóív(100, meret/2, "Jobbra");   
                Fordulj(100);
			}
            jóív(70, meret/1.7, "Jobbra");   
            jóív(22, meret*1.2, "Balra");   
            jóív(180, meret/10, "Balra");   
            jóív(22, meret*1.2, "Jobbra");   
            jóív(70, meret/1.7, "Balra");   
            for (int i = 0; i < 4; i++)
			{
                Fordulj(-100);
                jóív(100, meret/2, "Balra");   
			}
            Fordulj(-84);
            for (int i = 0; i < 6; i++)
		    {
                Fordulj(11);
                defaultkaresz.Előre(meret/9);
		    }
            Fordulj(-60);
            for (int i = 0; i < 7; i++)
		    { 
               Fordulj(-11);
               defaultkaresz.Előre(meret/9);
		    }
            for (int i = 0; i < 2; i++)
	        {
               Fordulj(-5);
               defaultkaresz.Előre(meret/9);
	        }
            Fordulj(-120);
            for (int i = 0; i < 3; i++)
            {
                defaultkaresz.Előre(meret/8);
                Fordulj(10);
		    }
            Fordulj(10);
            defaultkaresz.Előre(meret/8);
            Fordulj(7);
            defaultkaresz.Előre(meret/8);
            Fordulj(5);
            defaultkaresz.Előre(meret/8);
            Fordulj(5);
            defaultkaresz.Előre(4*meret);
            jóív(93, meret/1.45, "Jobbra");
            Tollat(fel);
            Fordulj(-42);
            defaultkaresz.Előre(meret/2);
            Tölt(szin);
            defaultkaresz.Hátra(meret/2);
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
                jóív(130, meret*1.8, "Balra");
                defaultkaresz.Előre(meret/1.51);
                jóív(180, meret/1.005, "Balra");
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
                jóív(130, meret*1.8, "Jobbra");
                defaultkaresz.Előre(meret/1.51);
                jóív(180, meret/1.005, "Jobbra");
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
            defaultkaresz.Előre(meret*2.25);
            Fordulj(-90);
            defaultkaresz.Előre(meret*2);
            Fordulj(-90);
            Tollat(le);
            jóív(360, meret, "Balra");
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre(meret);
            Tölt(körszin);
            defaultkaresz.Hátra(meret*3);
            Fordulj(90);
            defaultkaresz.Előre(meret*2.25);
            Fordulj(-90);
            Tollat(le);
            viragtetoresz(meret, sziromszin, false);
        }
        void viragszar(double meret, Color szin)
        { 
            Fordulj(-90);
            defaultkaresz.Előre(meret/4);
            Fordulj(90);
            defaultkaresz.Előre(meret*3);
            jóív(180, meret/4, "Balra");
            defaultkaresz.Előre(meret*3);
            Fordulj(90);
            defaultkaresz.Előre(meret/2);
            Tollat(fel);
            Fordulj(105);
            defaultkaresz.Előre(meret);
            Tölt(szin);
            defaultkaresz.Hátra(meret);
            Fordulj(75);
            defaultkaresz.Előre(meret/4);
            Fordulj(-90);
            Tollat(le);
        }
        void nagyviragresz(double meret, Color kulsoszirom, Color belsoszirom, Color holyagszin)
        {
            viragkulso(meret, kulsoszirom);
            Tollat(fel);
            defaultkaresz.Előre(meret/4);
            Fordulj(90);
            defaultkaresz.Előre(meret/40);
            Fordulj(-90);
            Tollat(le);
            viragbelso(meret/1.3, belsoszirom);
            Tollat(fel);
            defaultkaresz.Hátra(meret/1.6666);
            Tollat(le);
            Fordulj(90);
            Tollat(fel);
            jóív(90, meret, "Jobbra");
            defaultkaresz.Előre(meret/3.3);
            Tollat(le);
            viragszel(meret/2.4, 4, 0, false, holyagszin);
            Hátra((meret/2.4)*4);
            Fordulj(180);
            félkör(meret/2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(15);
            félkör(meret/2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(30);
            félkör(meret/2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(30);
            félkör(meret/2.4, true, holyagszin);
            defaultkaresz.Előre(meret / 2.4);
            Fordulj(15);
            félkör(meret/2.4, true, holyagszin);
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
            viragszel(meret/2.4, 4, 0, true, holyagszin);
            Hátra((meret/2.4)*4);
            Fordulj(180);
            defaultkaresz.Előre(meret/3.3);
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
            defaultkaresz.Előre(meret*1.2);
            Fordulj(-90);
            Tollat(le);
            viragszar(meret/1.7, szarszin);
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre(meret*1.2);
            Fordulj(-90);
            Tollat(le);
            levél(meret, levelszin, false);
            Tollat(fel);
            Fordulj(-90);
            defaultkaresz.Előre(meret*1.2);
            Fordulj(90);
            defaultkaresz.Előre(meret*2.2);
            Tollat(le);
            nagyviragresz(meret, kulsoszirom, belsoszirom, holyagszin);
            Tollat(fel);
            defaultkaresz.Előre(meret*5.3);
            Tollat(le);
            kompletteto(meret/3.5, tetoszirom, körszin);
        }
        void szem(double meret, Color körszin, Color körkörüliszin, Color körkörülikörüliszin, Color körkörülikörülikörüliszin)
        { 
            Tollat(fel);
            defaultkaresz.Előre(meret/1.56739);
            Tollat(le);
            Fordulj(-90);
            jóív(180, meret, "Balra");
            defaultkaresz.Előre(meret*0.1);
            defaultkaresz.Hátra(meret*0.1);
            Fordulj(-90);
            Tollat(fel);
            defaultkaresz.Hátra(meret*2.15);
            Tollat(le);
            Fordulj(-90);
            jóív(100, meret*1.4, "Balra");
            jóív(45, meret*1.45, "Balra");
            jóív(62, meret*0.8, "Balra");
            Fordulj(-117);
            Tollat(fel);
            defaultkaresz.Hátra(meret*2.8);
            Tollat(le);
            Fordulj(-90);
            jóív(100, (meret*1.4)*1.5, "Balra");
            jóív(45, (meret*1.45)*1.5, "Balra");
            jóív(60, (meret*0.8)*1.5, "Balra");
            Fordulj(-115);
            Tollat(fel);
            defaultkaresz.Hátra(meret*4.3);
            Tollat(le);
            Fordulj(-90);
            jóív(35, meret*2.4, "Balra");
            jóív(30, meret/2, "Balra");
            Fordulj(-84);
            jóív(150, meret/1.6, "Balra");
            Fordulj(-120);
            jóív(150, meret/1.4, "Balra");
            Fordulj(-115);
            jóív(150, meret/1.2, "Balra");
            Fordulj(-115);
            jóív(158, meret/1.2, "Balra");
            Fordulj(-149);
            Tollat(fel);
            defaultkaresz.Hátra(meret/0.231481);
            Tollat(le);
            Fordulj(90);
            jóív(180, meret, "Jobbra");
            Fordulj(90);
            Tollat(fel);
            defaultkaresz.Hátra(meret*2.15);
            Tollat(le);
            Fordulj(90);
            defaultkaresz.Hátra(meret*0.1);
            defaultkaresz.Előre(meret*0.1);
            jóív(100, meret*1.4, "Jobbra");
            jóív(45, meret*1.45, "Jobbra");
            jóív(62, meret*0.8, "Jobbra");
            Fordulj(117);
            Tollat(fel);
            defaultkaresz.Hátra(meret*2.8);
            Tollat(le);
            Fordulj(90);
            jóív(100, (meret*1.4)*1.5, "Jobbra");
            jóív(45, (meret*1.45)*1.5, "Jobbra");
            jóív(60, (meret*0.8)*1.5, "Jobbra");
            Fordulj(115);
            Tollat(fel);
            defaultkaresz.Hátra(meret*4.3);
            Tollat(le);
            Fordulj(90);
            jóív(35, meret*2.4, "Jobbra");
            jóív(30, meret/2, "Jobbra");
            Fordulj(84);
            jóív(150, meret/1.6, "Jobbra");
            Fordulj(120);
            jóív(150, meret/1.4, "Jobbra");
            Fordulj(115);
            jóív(150, meret/1.2, "Jobbra");
            Fordulj(115);
            jóív(158, meret/1.2, "Jobbra");
            Fordulj(149);
            Tollat(fel);
            defaultkaresz.Hátra(meret/3.125);
            Tölt(körkörülikörülikörüliszin);
            defaultkaresz.Hátra(meret/1.08695);
            Tölt(körkörülikörüliszin);
            defaultkaresz.Hátra(meret/1.2195);
            Tölt(körkörüliszin);
            defaultkaresz.Hátra(meret/0.9433);
            Tölt(körszin);
            defaultkaresz.Hátra(meret/0.8333);
            defaultkaresz.Hátra(meret/1.56739);
            Tollat(le);
        }
        void orr(double meret, Color szin)
        { 
            defaultkaresz.Előre(meret);
            Fordulj(-90);
            defaultkaresz.Előre(meret);
            Fordulj(-90);
            defaultkaresz.Előre(meret/5);
            Fordulj(-90);
            defaultkaresz.Előre((meret/5)*4);
            Fordulj(90);
            defaultkaresz.Előre((meret/5)*4);
            Fordulj(-90);
            defaultkaresz.Előre(meret/5);
            Fordulj(-135);
            Tollat(fel);
            defaultkaresz.Előre(meret/10);
            Tölt(szin);
            defaultkaresz.Hátra(meret/10);
            Tollat(le);
            Fordulj(45);
        }
        void szemorr(double meret, Color körszin, Color körkörüliszin, Color körkörülikörüliszin, Color körkörülikörülikörüliszin, Color orrszin)
        {
            Fordulj(-45);
            szem(meret, körszin, körkörüliszin, körkörülikörüliszin, körkörülikörülikörüliszin);
            Fordulj(180);
            orr(meret*2, orrszin);
            defaultkaresz.Előre(meret*2);
            Fordulj(-90);
            defaultkaresz.Előre(meret*2);
            szem(meret, körszin, körkörüliszin, körkörülikörüliszin, körkörülikörülikörüliszin);
            defaultkaresz.Hátra(meret*2);
            Fordulj(135);
        }
    }   
}