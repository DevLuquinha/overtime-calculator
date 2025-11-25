using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
