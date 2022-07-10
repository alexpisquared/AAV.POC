using AAV.Animation.POC.Helpers;

namespace AAV.Animation.POC.Vws;
public partial class ArcPi : UserControl
{
  public ArcPi() => InitializeComponent();
  public static readonly DependencyProperty RadiuProperty = DependencyProperty.Register("Radiu", typeof(double), typeof(ArcPi), new PropertyMetadata(50d)); public double Radiu { get => (double)GetValue(RadiuProperty); set => SetValue(RadiuProperty, value); }
  public static readonly DependencyProperty AngleProperty = DependencyProperty.Register("Angle", typeof(double), typeof(ArcPi), new PropertyMetadata(0d, propertyChangedCallback)); public double Angle { get => (double)GetValue(AngleProperty); set => SetValue(AngleProperty, value); }
  static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    Trace.WriteLine($"@@@@@@@@ propertyChangedCallback  {e.NewValue}  {d.GetType().Name}");

    ((ArcPi)d).propertyChangedCallback2((double)e.NewValue);
  }
  void propertyChangedCallback2(double anglePercent)
  {
    ArcHelper.DrawArc(arc_path, new Point(Radiu, Radiu), Radiu - 1 - (arc_path.StrokeThickness / 2), 0, Math.PI * 2 * anglePercent * .01);
  }
}

