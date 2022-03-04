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
			Előre(150);
			Tollat(le);
			keretdarab(100, Color.Brown, Color.Red, false);

		}
	}
}
