using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class Window2 : Window
    {
        int count = 0;
        int i = 0;
        string[] quess = {"Год выхода консоли 4-поколения на рынок?","Откуда знаменитый тортик", "ТОП-2 самая популярная игра в мире", "Самая дорогая игровая компания в мире", "Что делает чит-код AEZAKMI в GTA SA", };
        string[] answs = {"1987" , "Portal", "ТЕТРИС", "Sony", "ОТключение полиции"};
        bool[] correctans;
        public Window2()
        {
            InitializeComponent();
            Text.Text = "1 : " + quess.Length + " вопросов\n" + quess[0] ;
            correctans = new bool[quess.Length];
        }
        private void conf_click(object sender, RoutedEventArgs e)
        {
            if(ans.Text.Trim().ToLower().Length == 0) return;
            if (ans.Text.Trim().ToLower() == answs[i].ToLower()) 
            {
                Text.Text = quess[i] + "\nПравильный ответ";
                count += 2;
                correctans[i] = true;
            }
            if (ans.Text.Trim().ToLower() != answs[i].ToLower())
            {
                Text.Text = quess[i] + "\nНеправильный ответ\nПравильный ответ:" + answs[i];
                correctans[i] = false;
            }
            conf.Visibility = Visibility.Hidden;
            conf1.Visibility = Visibility.Visible;
        }
        private void esc_click(object sender, RoutedEventArgs e) => Hide();
        
        private void conf1_click(object sender, RoutedEventArgs e)
        {
            
            if (i == quess.Length - 1)
            {
                bool kli = false;
                if (kli == true) Hide();
                Text.Text = "Набрано очков:" + count + "\nМаксимальное кол-во очков: " + 2* quess.Length;
                for (int j = 0; j < correctans.Length; j++)
                {
                    if (correctans[j] == true) Text.Text += "\n" + (j + 1) + ")Правильно";
                    if (correctans[j] == false) Text.Text += "\n" + (j + 1) + ")Неправильно";
                }
                kli = true;
            }
            else
            {
                conf1.Visibility = Visibility.Hidden;
                conf.Visibility = Visibility.Visible;

                i++;
                ans.Text = "";
                Text.Text = (i + 1) + " : " + quess.Length + " вопросов\n" + quess[i];
            }
        }
    }
}
