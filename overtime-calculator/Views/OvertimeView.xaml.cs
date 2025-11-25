using System.Windows.Controls;

namespace overtime_calculator.Views
{
    /// <summary>
    /// Interaction logic for OvertimeView.xaml
    /// </summary>
    public partial class OvertimeView : UserControl
    {
        public OvertimeView()
        {
            InitializeComponent();
            DataContext = new ViewModels.OvertimeViewModel();
        }
    }
}
