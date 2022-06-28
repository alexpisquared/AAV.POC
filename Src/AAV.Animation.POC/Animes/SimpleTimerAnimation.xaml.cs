namespace AAV.Animation.POC.Animes;
public partial class SimpleTimerAnimation : UserControl
{
  CancellationTokenSource _ctsCheckr;

  public SimpleTimerAnimation()
  {
    InitializeComponent();
    DataContext = this;
  }
  public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(SimpleTimerAnimation)); public bool IsOn { get => (bool)GetValue(IsOnProperty); set => SetValue(IsOnProperty, value); }

  async void OnLoaded(object s, RoutedEventArgs e) => await StartPeriodicChecker();
  async Task StartPeriodicChecker()
  {
    WriteLine($"\n{DateTime.Now:HH:mm:ss}   Starting Checkr   ");
    _ctsCheckr?.Cancel();
    _ctsCheckr = new();
    PeriodicTimer timer = new(TimeSpan.FromSeconds(2));
    try
    {
      while (await timer.WaitForNextTickAsync(_ctsCheckr.Token))
      {
        Write($"C");
        IsOn = !IsOn;
      }
    }
    catch (OperationCanceledException ex) { WriteLine("Cancelled:  " + ex.Message); }
    catch (Exception ex) { _ = MessageBox.Show(ex.ToString()); }
    finally { if (_ctsCheckr is not null) { _ctsCheckr.Dispose(); _ctsCheckr = null; } }
  }
}
