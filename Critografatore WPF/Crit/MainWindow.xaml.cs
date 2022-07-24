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

namespace Crit
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[,] ASCIITable;
        const int MAX_TABLE = 15;
        IList<int> KeyList;


        string Message;
        string CriptMessage = "";
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void ChangeProfile(object sender, RoutedEventArgs e)
        {
            
        }

        private void Cripta(object sender, RoutedEventArgs e)
        {


            GetKey(InputKey.Text);

            Message = InputMess.Text;

            if(KeyList != null && Message != null)
            {
                foreach (char ch in Message)
                    CriptMessage += (char)((int)(ch) + KeyList[0]);
            }


            OutBox.Text = CriptMessage;


        }

        private void Decripta(object sender, RoutedEventArgs e)
        {

        }



        private void GetKey(String KeyStr)
        {

             KeyList = new List<int>();

            foreach (char ch in KeyStr)
                KeyList.Add((int)ch);

        }



        private void Init()
        {

           ASCIITable = new char[MAX_TABLE,MAX_TABLE];

            for (int i = 0; i < MAX_TABLE; i++)
                for (int j = 0; j < MAX_TABLE; j++)
                    ASCIITable[i, j] = (char)(MAX_TABLE * i + j+32);

        }
    }
}
