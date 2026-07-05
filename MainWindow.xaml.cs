using System.Windows;
using TaskManager_Markova.ViewModels;

namespace TaskManager_Markova
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static MainWindow init;
		public MainWindow()
		{
			InitializeComponent();
			init = this;
			DataContext = new VM_Pages();
		}
	}
}