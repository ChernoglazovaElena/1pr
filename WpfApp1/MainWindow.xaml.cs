using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.bdDataSetTableAdapters;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        goblinTableAdapter sss = new goblinTableAdapter();
        clothesTableAdapter aaa = new clothesTableAdapter();
        public MainWindow()
        {

            InitializeComponent();
            goblinDataGrid.ItemsSource = sss.GetData();
            clothesComboBox.ItemsSource = aaa.GetData();
            clothesComboBox.DisplayMemberPath = "title";
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (clothesComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }
    }
}
