using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DelegatiXYZ
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Obavestenje o = new Obavestenje();
			o.NO = o.ObavestenjeUFajl;

			Obavestenje o2 = new Obavestenje();
			o2.NO = o.ObavestenjeUProzor;

			Obavestenje o3 = new Obavestenje();
			o3.NO = o.ObavestenjeUProzor;
			o3.NO += o.ObavestenjeUFajl;

			List<Obavestenje> obv = new List<Obavestenje>();
			obv.Add(o);
			obv.Add(o2);
			obv.Add(o3);

			foreach (Obavestenje oo in obv)
				oo.NO("Evo neki string");
		}
	}

	public class Obavestenje
	{
		public delegate void NacinObavestavanja(string o);

		public NacinObavestavanja NO;
		public void ObavestenjeUProzor(string ob) => MessageBox.Show(ob);
		public void ObavestenjeUFajl(string ob) => File.AppendAllText("ob.txt", ob);
	}
}
