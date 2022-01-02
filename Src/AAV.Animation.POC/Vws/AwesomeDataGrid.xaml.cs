using System;
using System.Windows;

namespace AAV.Animation.POC.Vws
{
  public partial class AwesomeDataGrid : Window
  {
    public AwesomeDataGrid()
    {
      InitializeComponent();

      if (Environment.MachineName == "RAZER1") { Top = 0; Left = 0; }
    }
    void onClose(object s, RoutedEventArgs e) => Close();
  }
}
