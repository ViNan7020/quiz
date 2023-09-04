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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Media.Animation;
using MaterialDesignThemes.Wpf;
using System.Media;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        
       
        public MainWindow()
        {
            
            InitializeComponent();
            
            
            
           
            
            
                new SoundPlayer(@"C:\Users\ViMaT\source\repos\WpfApp2\WpfApp2\Own World.wav").PlayLooping();
                
            
            
        }
        
        private void NewGame(object sender, RoutedEventArgs e)
        {
            ChoooseDif chooose = new();
            
            if (!chooose.IsActive) chooose = new ChoooseDif();
            chooose.Show();
        }
        private void ConGame(object sender, RoutedEventArgs e)
        {
            
            ChoooseDif.window.Show();
            
        }
        private void Music(object sender, RoutedEventArgs e)
        {
            Window1 musicwin = new Window1();
            musicwin.Owner = this;
            if (!musicwin.IsActive)
                musicwin.Show();
            
        }
        
        private void Exit(object sender, RoutedEventArgs e)
        {
          System.Windows.Application.Current.Shutdown();
            
            
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            table.Content = "Сейчас недоступно";
        }
    }
}
