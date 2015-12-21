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
using DepartmentGrid.ViewModel; 

namespace DepartmentGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModelView VM = new ViewModelView(); 
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) => { this.DataContext = this.VM; };
        }
    }
}
