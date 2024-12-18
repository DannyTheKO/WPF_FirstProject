using System.Windows;

namespace WPF_FirstProject
{
	public partial class MainWindow : Window
	{
		private bool Running = false;

		public MainWindow()
		{
			InitializeComponent();

			//TbHelloWorld.Text = "Hello World, This Has Been Change By An Constructor!";
		}

		//private void BtnRun_OnClick(object sender, RoutedEventArgs e)
		//{
		//	if (!Running)
		//	{
		//		// Run
		//		TbHelloWorld.Text = "Hello Danny!, Running!";
		//		BtnRun.Content = "Stop";
		//	}
		//	else
		//	{
		//		// Stop
		//		TbHelloWorld.Text = "Hello Danny!, Stopped!";
		//		BtnRun.Content = "Run";
		//	}

		//	Running = !Running;
		//}

		//private void BtnHi_OnClick(object sender, RoutedEventArgs e)
		//{
		//	TbHelloWorld.Text = "Hi Danny!";
		//}
	}
}