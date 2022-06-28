namespace AAV.Animation.POC.Animes;
public partial class ArrivaLogoDropPanel : UserControl
{
  public ArrivaLogoDropPanel()
  {
    InitializeComponent();
    DataContext = this;
  }
  public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(ArrivaLogoDropPanel), new PropertyMetadata(false, propertyChangedCallback)); public bool IsOn { get => (bool)GetValue(IsOnProperty); set => SetValue(IsOnProperty, value); }
  static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e) => WriteLine($"@@@@@@@@ propertyChangedCallback  {e.NewValue}  {d.GetType().Name}");
}
