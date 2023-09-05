using ImageDBSave2.AplicationData;
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

namespace ImageDBSave2.PageModerator
{
    /// <summary>
    /// Логика взаимодействия для PageMenuModerator.xaml
    /// </summary>
    public partial class PageMenuModerator : Page
    {
        public PageMenuModerator()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
