using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Clientkurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int port = 22;

        IPAddress ipAddr = null;
        IPEndPoint ipPoint = null;
        Socket socket = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReg(object sender, RoutedEventArgs e)
        {
            RegistrationButton.Visibility = Visibility.Collapsed;
            LoginButton.Visibility = Visibility.Visible;
            autorization_panel.Visibility = Visibility.Collapsed;
            registration_panel.Visibility = Visibility.Visible;
            grid1.Height = new GridLength(370);
        }
        private void btnLog(object sender, RoutedEventArgs e)
        {
            RegistrationButton.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Collapsed;
            autorization_panel.Visibility = Visibility.Visible;
            registration_panel.Visibility = Visibility.Collapsed;
            grid1.Height = new GridLength(200);
        }

        private void autorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            ipAddr = IPAddress.Parse("127.0.0.1");
            ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            socket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), port));

            BoolRequest boolRequest = null;

            byte[] msg = SerializationMethod.objectToByteArray(new AutorizationInquiry()
            {
                typeInquiry = (int)TypeInquiry.authorization,
                login = autorizationLogin.Text,
                password = autorizationPassword.Password
            }, typeof(object));

            try
            {
                socket.Send(msg);
                msg = new byte[1024];
                int length = socket.Receive(msg);
                boolRequest=((BoolRequest)SerializationMethod.fromByteArray(msg, typeof(BoolRequest), length));
            }
            catch { MessageBox.Show("Ошибка авторизации"); return; }

            if (boolRequest.flag)
            {

            }              
        }
    }
}
