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

namespace Twenty_sex
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Square square;
        Rect rect;
        RUSSIA RUSSIA;
        int x, y;
        bool sq, rc, RF;

        private void Click(object sender, RoutedEventArgs e)
        {
            var send=sender as MenuItem;
            switch (send.Name) 
            {
                case "Sqr":
                    Sqr.IsEnabled = false;
                    Pen.IsEnabled = true;
                    RUS.IsEnabled = true;
                    square.Show();
                    rect.Hide();
                    RUSSIA.Hide();
                    break;
                case "Pen":
                    Sqr.IsEnabled = true;
                    Pen.IsEnabled = false;
                    RUS.IsEnabled = true;
                    square.Hide();
                    rect.Show();
                    RUSSIA.Hide();
                    break;
                case "RUS":
                    Sqr.IsEnabled = true;
                    Pen.IsEnabled = true;
                    RUS.IsEnabled = false;
                    square.Hide();
                    rect.Hide();
                    RUSSIA.Show();
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            square = new Square(x,y,Polotno);
            //Square(0, 0, Polotno);.
            square.Show();
            rect = new Rect(x, y, Polotno);
            rect.Hide();
            //rect.Show();
            RUSSIA = new RUSSIA(x, y, Polotno);
            RUSSIA.Hide();
            //RUSSIA.Show();
          
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D:
                    x = x + 5;
                    
                    break;
                case Key.A:
                    x = x - 5;
                    
                    break;
                case Key.W:
                    y = y - 5;
                    
                    break;
                case Key.S:
                    y = y + 5;
                   
                    break;
            }
            square.MoveXY(x, y);
            rect.MoveXY(x, y);  
            RUSSIA.MoveXY(x, y);
            //switch (sq,rc,RF) 
            //{
            //    case (true,false,false):
            //        break;
            //}
        }
    }
}
