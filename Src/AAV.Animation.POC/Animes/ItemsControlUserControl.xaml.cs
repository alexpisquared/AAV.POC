using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AAV.Animation.POC
{
  public partial class ItemsControlUserControl : UserControl
  {
    readonly ViewModel _vm;
    readonly ObservableCollection<TaskTodo> _lst;
    public ItemsControlUserControl()
    {
      InitializeComponent();

      _vm = new ViewModel();
      DataContext = _vm.TaskTodos; //  
      _lst = (ObservableCollection<TaskTodo>)DataContext;

      b1.KeyUp += (s, e) => Debug.WriteLine(e);
      b1.KeyDown += (s, e) =>
      {
        foreach (var item in _lst) item.IsCurrent = false;
        switch (e.Key)
        {
          case System.Windows.Input.Key.NumPad0: case System.Windows.Input.Key.D0: _lst[0].IsCurrent = true; break;
          case System.Windows.Input.Key.NumPad1: case System.Windows.Input.Key.D1: _lst[1].IsCurrent = true; break;
          case System.Windows.Input.Key.NumPad2: case System.Windows.Input.Key.D2: _lst[2].IsCurrent = true; break;
          case System.Windows.Input.Key.NumPad3: case System.Windows.Input.Key.D3: _lst[3].IsCurrent = true; break;
          case System.Windows.Input.Key.NumPad4: case System.Windows.Input.Key.D4: _lst[4].IsCurrent = true; break;
          case System.Windows.Input.Key.NumPad5: case System.Windows.Input.Key.D5: _lst[5].IsCurrent = true; break;
          default: break;
        }

        var idx = _lst.ToList().FindIndex(r => r.IsCurrent);

        _daX.To = idx;
        BeginAnimation(AnmProperty, _daX);
        _daY.To = -10;
        BeginAnimation(UpYProperty, _daY);
      };

      b1.Focus();
    }

    void b1_Click(object sender, System.Windows.RoutedEventArgs e) => _vm.TaskTodos.ToList().ForEach(tt => tt.IsCurrent = false);
    public static readonly DependencyProperty ValProperty = DependencyProperty.Register("Val", typeof(double), typeof(ItemsControlUserControl), new PropertyMetadata(1d, new PropertyChangedCallback(onChanged))); public double Val { get => (double)GetValue(ValProperty); set => SetValue(ValProperty, value); }
    public static readonly DependencyProperty AnmProperty = DependencyProperty.Register("Anm", typeof(double), typeof(ItemsControlUserControl), new PropertyMetadata(1d)); public double Anm { get => (double)GetValue(AnmProperty); set => SetValue(AnmProperty, value); }
    public static readonly DependencyProperty UpYProperty = DependencyProperty.Register("UpY", typeof(double), typeof(ItemsControlUserControl), new PropertyMetadata(1d)); public double UpY { get => (double)GetValue(UpYProperty); set => SetValue(UpYProperty, value); }
    static void onChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { _daX.To = (double)e.NewValue; (d as ItemsControlUserControl).BeginAnimation(AnmProperty, _daX); }
    static readonly DoubleAnimation _daX = new() { Duration = new Duration(TimeSpan.FromSeconds(.4)), EasingFunction = new BounceEase { Bounciness = 7 } };
    static readonly DoubleAnimation _daY = new() { Duration = new Duration(TimeSpan.FromSeconds(.2)), EasingFunction = new SineEase(), AutoReverse = true };
  }
}