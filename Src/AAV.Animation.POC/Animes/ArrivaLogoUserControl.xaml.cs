namespace AAV.Animation.POC.Animes;

public partial class ArrivaLogoUserControl : UserControl
{
  public ArrivaLogoUserControl()
  {
    InitializeComponent();
    DataContext = this;
  }
  public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(ArrivaLogoUserControl), new PropertyMetadata(false, propertyChangedCallback)); public bool IsOn { get => (bool)GetValue(IsOnProperty); set => SetValue(IsOnProperty, value); }
  static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e) => WriteLine($"@@@@@@@@ propertyChangedCallback  {e.NewValue}  {d.GetType().Name}");
}
