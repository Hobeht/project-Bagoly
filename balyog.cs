﻿using System;
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
		void levél(double meret, Color szin, bool irany)
        {
            if (irany)
	        {
			Bezier(70, 90, 60, 25, 150);
			Fordulj(90);
            Bezier(60, 180, 30, -90, 120);
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
			    Bezier(-70, 90, -60, -25, -150);
		    	Fordulj(-90);
		    	Fordulj(180);
                Bezier(-60, 0, -30, 90, -120);
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
        void viragszel(double meret, int felkörszam, double összfordulas, Color szin)
        {
            for (int i = 0; i < felkörszam; i++)
			{
                félkör(meret, szin);
                defaultkaresz.Előre(meret);
                Fordulj(összfordulas/felkörszam);
			}
        }
        void viragkulso(double meret, Color szin)
        {
            Fordulj(90);
            nemfogyatékosív(90, meret, "Jobbra");
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
            for (int i = 0; i < 3; i++)
	        {
                defaultkaresz.Előre(meret/8);
                Fordulj(-10);
		    }
            defaultkaresz.Előre(meret/8);
            Fordulj(-12);
            for (int i = 0; i < 5; i++)
		    {
                defaultkaresz.Előre(meret/8);
                Fordulj(-15);
		    }
            defaultkaresz.Előre(meret/2.77);
            defaultkaresz.Előre(meret*4);
            nemfogyatékosív(90, meret/2.5, "Balra");
            Tollat(fel);
            Fordulj(-90);
            defaultkaresz.Előre(meret/1.66);
            Fordulj(-180);
            Tollat(le);
            Fordulj(-90);
            nemfogyatékosív(90, meret, "Balra");
            defaultkaresz.Előre(4*meret);
            Fordulj(-5);
            defaultkaresz.Előre(meret/8);
            Fordulj(-5);
            defaultkaresz.Előre(meret/8);
            Fordulj(-7);
            defaultkaresz.Előre(meret/8);
            Fordulj(-10);
            for (int i = 0; i < 3; i++)
		    {
                defaultkaresz.Előre(meret/8);
                Fordulj(-10);
		    }
            Fordulj(120);
            for (int i = 0; i < 3; i++)
			{
                defaultkaresz.Előre(meret/8);
                Fordulj(10);
			}
            defaultkaresz.Előre(meret/8);
            Fordulj(12);
            for (int i = 0; i < 5; i++)
			{
                defaultkaresz.Előre(meret/8);
                Fordulj(15);
			}
            defaultkaresz.Előre(meret/2.77);
            defaultkaresz.Előre(meret*4);
            nemfogyatékosív(90, meret/2.5, "Jobbra");
            Tollat(fel);
            Fordulj(90);
            defaultkaresz.Előre((meret/1.66)/2);
            Tölt(szin);
            defaultkaresz.Előre((meret/1.66)/2);
            Fordulj(180);
            Tollat(le);
        }
        void viragbelso(double meret, Color szin)
        {
             Fordulj(90);
            nemfogyatékosív(90, meret, "Jobbra");
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
            for (int i = 0; i < 5; i++)
			{
                nemfogyatékosív(100, meret/2, "Jobbra");   
                Fordulj(100);
			}
        }
    }   
}