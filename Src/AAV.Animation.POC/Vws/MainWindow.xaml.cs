using System;
using System.Windows;
using System.Windows.Input;

namespace AAV.Animation.POC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel _vm;
        public MainWindow()
        {
            InitializeComponent(); KeyDown += (s, e) => { if (e.Key == Key.Escape) { Close(); System.Diagnostics.Trace.WriteLine($"{DateTime.Now:yy.MM.dd HH:mm:ss.f} => ::>Application.Current.Shutdown();n"); Application.Current.Shutdown(); } };
            _vm = new ViewModel();
            DataContext = _vm;
        }
    }
}
