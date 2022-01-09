using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace AAV.Animation.POC.Animes
{
  public partial class ArrivaThirdUserControl : UserControl
  {
    public ArrivaThirdUserControl()
    {
      InitializeComponent();
      DataContext = this;
    }
    public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(ArrivaThirdUserControl), new PropertyMetadata(false, propertyChangedCallback)); public bool IsOn { get => (bool)GetValue(IsOnProperty); set => SetValue(IsOnProperty, value); }

    static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e) => Debug.WriteLine($"@@@@@@@@ 1/3 {e.NewValue}");
  }
}
