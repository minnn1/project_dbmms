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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {   
            //textchange เมื่อคลิก
            MessageBox.Show(TextName_product.Text);
            
        }

        private void TextName_product_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextName_product_Change.Text = TextName_product.Text;
        }

        private void FormProduct_Loaded(object sender, RoutedEventArgs e)
        {
            TextName_product_Change.IsReadOnly = true;
        }
    }
}
