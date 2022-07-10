using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AAV.Animation.POC.Helpers;

namespace AAV.Animation.POC.Vws;
public partial class ArcPi : UserControl
{
  public ArcPi()
  {
    InitializeComponent();
  }
  public static readonly DependencyProperty AngleProperty = DependencyProperty.Register("Angle", typeof(double), typeof(ArcPi), new PropertyMetadata(0d, propertyChangedCallback)); public double Angle { get => (double)GetValue(AngleProperty); set => SetValue(AngleProperty, value); }
  static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    Trace.WriteLine($"@@@@@@@@ propertyChangedCallback  {e.NewValue}  {d.GetType().Name}");

    ((ArcPi)d).propertyChangedCallback2((double)e.NewValue);
  }
  void propertyChangedCallback2(double anglePercent)
  {
    const int _halfSize = 50;
    ArcHelper.DrawArc(arc_path, new Point(_halfSize, _halfSize), _halfSize - 1 - (arc_path.StrokeThickness / 2), Math.PI * 2 * anglePercent * .01, 0);
  }
}

