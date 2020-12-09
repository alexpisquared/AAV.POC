using System.Windows;
using System.Windows.Controls;

namespace AAV.Animation.POC
{
    public partial class DataTriggerUserControl : UserControl
    {
        public DataTriggerUserControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty IsCurrentProperty = DependencyProperty.Register("IsCurrent", typeof(bool), typeof(DataTriggerUserControl), new PropertyMetadata(true)); public bool IsCurrent { get { return (bool)GetValue(IsCurrentProperty); } set { SetValue(IsCurrentProperty, value); } }


    }
}
