using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace gergegregaregrsegre
{
    public partial class MainWindow : Window
    {
        string[] Songs = {"Humility", "Tranz", "Hollywood", "Kansas", "Sorcererz", "Idaho", "Lake Zurich", "Magic City", "Fire Flies", "One Percent", "Souk Eye"};
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRightArrow_Click(object sender, RoutedEventArgs e)
        {
            if (i == Songs.Length - 1)
            {
                i = 0;
                TextSongTitle.Content = Songs[i];
                TextSongID.Content = i + 1;
            }
            else
            {
                i++;
                TextSongTitle.Content = Songs[i];
                TextSongID.Content = i + 1;
            }
        }

        private void ButtonLeftArrow_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                i = Songs.Length - 1;
                TextSongTitle.Content = Songs[i];
                TextSongID.Content = i + 1;
            }
            else
            {
                i--;
                TextSongTitle.Content = Songs[i];
                TextSongID.Content = i + 1;
            }
        }
    }
}
