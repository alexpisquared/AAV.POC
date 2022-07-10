using System.Windows;
using AAV.Animation.POC.Vws;

namespace AAV.Animation.POC
{
    public partial class App : Application
    {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      new
        ArrivalLogoTester
        //MainWindow
        //AwesomeDataGrid
        ().ShowDialog();
    }
  }
}
