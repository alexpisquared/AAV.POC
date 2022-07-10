namespace AAV.Animation.POC.Vws;

public partial class ArrivalLogoTester : Window
{
  public ArrivalLogoTester()
  {
    InitializeComponent();
    DataContext = this;
    KeyDown += (s, e) => { if (e.Key == Key.Escape) { Close(); System.Diagnostics.Trace.WriteLine($"{DateTime.Now:yy.MM.dd HH:mm:ss.f} => ::>Application.Current.Shutdown();n"); Application.Current.Shutdown(); } };
    MouseLeftButtonDown += (s, e) => { if (e.LeftButton == MouseButtonState.Pressed) DragMove(); }; //tu: workaround for  "Can only call DragMove when primary mouse button is down." (2021-03-10: pre-opened dropdown seemingly caused the error)
    _ = btnOnOff.Focus();
  }
  public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(ArrivalLogoTester), new PropertyMetadata(false, propertyChangedCallback)); public bool IsOn { get => (bool)GetValue(IsOnProperty); set => SetValue(IsOnProperty, value); }

  static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e) => Debug.WriteLine($"@@@@@@@@ Win {e.NewValue}");
}
