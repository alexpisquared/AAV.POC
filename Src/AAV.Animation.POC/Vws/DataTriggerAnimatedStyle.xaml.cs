using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace AAV.Animation.POC.Vws
{
  public partial class DataTriggerAnimatedStyle : Window
  {
    public DataTriggerAnimatedStyle()
    {
      InitializeComponent();
      DataContext = this;
    }
    public static readonly DependencyProperty IsCurrentProperty = DependencyProperty.Register("IsCurrent", typeof(bool), typeof(DataTriggerAnimatedStyle), new PropertyMetadata(true)); public bool IsCurrent { get => (bool)GetValue(IsCurrentProperty); set => SetValue(IsCurrentProperty, value); }

    void onChange(object s, RoutedEventArgs e) { foreach (var r in ((AAV.Animation.POC.Model.SampleListItem[])dg2.ItemsSource)) r.Name = r.Name == "Mauris" ? "Abc123" : "Mauris"; }
    void onShowMainWindow(object s, RoutedEventArgs e) => new MainWindow().Show();
    void onClose(object s, RoutedEventArgs e) => Close();
  }
}
