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

    void onChange(object s, RoutedEventArgs e) { foreach (var r in ((Cities.Models.SampleListItem[])dg2.ItemsSource)) r.Name = r.Name == "Mauris" ? "Abc123" : "Mauris"; }
    void onShowMainWindow(object s, RoutedEventArgs e) => new MainWindow().Show();
    void Button_Click(object sender, RoutedEventArgs e) => Close();
  }
}

namespace Cities.Models
{
  public class SampleListItem : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    double _ID = 0; public double ID
    {
      get => _ID;

      set
      {
        if (_ID != value)
        {
          _ID = value;
          OnPropertyChanged("ID");
        }
      }
    }
    string _Name = string.Empty; public string Name
    {
      get => _Name;

      set
      {
        if (_Name != value)
        {
          _Name = value;
          OnPropertyChanged("Name");
        }
      }
    }
    bool _Done = false; public bool Done
    {
      get => _Done;

      set
      {
        if (_Done != value)
        {
          _Done = value;
          OnPropertyChanged("Done");
        }
      }
    }
    ImageSource _Look = null; public ImageSource Look
    {
      get => _Look;

      set
      {
        if (_Look != value)
        {
          _Look = value;
          OnPropertyChanged("Look");
        }
      }
    }
  }
}