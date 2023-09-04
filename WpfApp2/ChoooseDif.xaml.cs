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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ChoooseDif : Window
    {
        public static Window2 window = new Window2();
        public ChoooseDif()
        {
            InitializeComponent();
        }
        private void EasyDes(object sender, RoutedEventArgs e)
        {
            
            Text.Text = "За правильный ответ получаешь по 1 баллу\n Вопросы простые\n\n(или стремяться быть ими)";
            
            
        }
        private void Conf(object sender, RoutedEventArgs e)
        {
            if(Text.Text.Contains("1"))Text.Text = "Сейчас недоступно";
            if (Text.Text.Contains("2"))
            {
                Easy.Visibility = Visibility.Hidden;
                Mid.Visibility = Visibility.Hidden;
                High.Visibility = Visibility.Hidden;
                Text.Visibility = Visibility.Hidden;
                games.Visibility = Visibility.Visible;
                conf.Visibility = Visibility.Hidden;
                conf2.Visibility = Visibility.Visible;
            }
            if (Text.Text.Contains("3")) Text.Text = "Сейчас недоступно";
            
        }
        private void Gamedes(object sender, RoutedEventArgs e)
        {

            Text.Text = "Игры";


        }
        
        private void Conf2(object sender, RoutedEventArgs e)
        {

            if (Text.Text.Contains("Игры")) {
                window.Show();
                Close();
            }
        }
        private void ex_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
           
        }

        private void Mid_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = "За правильный ответ получаешь по 2 балла\n Вопросы средней сложности\n\n(никакой-либо другой)";
        }

        private void High_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = "За правильный ответ получаешь по 3 балла\n Вопросы высокой трудности\n\n(но не уровня Гарвардского университета)";

        }
    }
}
