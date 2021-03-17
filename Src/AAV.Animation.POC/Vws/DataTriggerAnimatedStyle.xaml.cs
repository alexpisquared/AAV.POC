using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace AAV.Animation.POC.Vws
{
  public partial class DataTriggerAnimatedStyle : Window
  {
    public DataTriggerAnimatedStyle()
    {
      InitializeComponent();
      DataContext = this;
    }

    public static readonly DependencyProperty IsCurrentProperty = DependencyProperty.Register("IsCurrent", typeof(bool), typeof(DataTriggerAnimatedStyle), new PropertyMetadata(true)); public bool IsCurrent { get { return (bool)GetValue(IsCurrentProperty); } set { SetValue(IsCurrentProperty, value); } }

    void Button_Click(object sender, RoutedEventArgs e)    {      Close();    }
  }
}
