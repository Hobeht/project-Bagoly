using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		
		void FELADAT()
		{
			Tollat(fel);
			Előre(100);
			Tollat(le);
			
			
			
			using(new Frissítés(false))
            {

				bagoly(40);
            }
				
			




		}
	}
}
