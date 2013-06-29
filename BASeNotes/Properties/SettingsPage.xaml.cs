using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BASeNotes.Properties
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Window
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Apply()
        {
            Settings.Default.Save();
        }
        private void cmdOK_Click(object sender, RoutedEventArgs e)
        {
            Apply();
            Close();
        }

        private void cmdApply_Click(object sender, RoutedEventArgs e)
        {
            Apply();
        }
    }
}
