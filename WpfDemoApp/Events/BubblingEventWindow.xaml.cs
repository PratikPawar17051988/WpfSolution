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
    /// Interaction logic for BubblingEventWindow.xaml
    /// </summary>
    public partial class BubblingEventWindow : Window
    {
        public BubblingEventWindow()
        {
            InitializeComponent();
            Checkbox1.KeyDown += Checkbox1_KeyDown;
            Button1.KeyDown += Button1_KeyDown;
            InnerST.KeyDown += InnerST_KeyDown;
            RootST.KeyDown += RootST_KeyDown;
        }

        private void RootST_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming form RootST");
        }

        private void InnerST_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming form InnerST");
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming form Button1");
        }

        private void Checkbox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming form Checkbox1");
        }
    }
}
