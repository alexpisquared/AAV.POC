using System.Windows;
using System.Windows.Controls;

namespace AAV.Animation.POC.Animes
{
  public partial class ArrivaLogoUserControl : UserControl
  {
    public ArrivaLogoUserControl() => InitializeComponent();
    public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(ArrivaLogoUserControl), new PropertyMetadata(false)); public bool IsOn { get => (bool)GetValue(IsOnProperty); set => SetValue(IsOnProperty, value); }
  }
}
