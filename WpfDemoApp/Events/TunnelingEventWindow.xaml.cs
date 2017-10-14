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
using System.Windows.Shapes;

namespace WpfDemoApp.Events
{
    /// <summary>
    /// Interaction logic for TunnelingEventWindow.xaml
    /// </summary>
    public partial class TunnelingEventWindow : Window
    {
        public TunnelingEventWindow()
        {
            InitializeComponent();
            Button1.PreviewMouseDown += Button1_PreviewMouseDown;
            InnerST.PreviewMouseDown += InnerST_PreviewMouseDown;
            RootST.PreviewMouseDown += RootST_PreviewMouseDown;
        }

        private void RootST_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Coming from RootST");
        }

        private void InnerST_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Coming from InnerST");
        }

        private void Button1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Coming from Button1");
        }
    }
}
