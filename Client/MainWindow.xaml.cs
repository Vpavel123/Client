using System;
using Client.Services;
using Client.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
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
using System.Net.Http;
using System.IO;
using System.Security.Policy;
using System.Timers;
using System.Windows.Markup;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // буфер для получения данных
        public Thread th;
        byte[] bytesa = new byte[1024];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecvMessage();

            richsocket.Focus();
        }



        async void RecvMessage() 
        {
            using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Адрес подключения {class1.tcpClient.RemoteEndPoint}\n")));
            //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Адрес приложения {class1.tcpClient.LocalEndPoint}\n")));

            var response = new List<byte>();
            int bytesRead = 10; // для считывания байтов из потока

                byte[] data = Encoding.UTF8.GetBytes("Hello World" + '\n');
                await tcpClient.SendAsync(data, SocketFlags.None);
                //var bytes = class1.tcpClient.Client.Receive(responseData);
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"{bytes}\n")));
                //a++;
            

            //byte[] responseData = new byte[512];
            //// получаем данные из потока
            //var bytes = class1.socket.Receive(responseData);
            //// получаем отправленное время
            //string time = Encoding.UTF8.GetString(responseData, 0, bytes);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationService.Inst.OnNavigate += (p) => { PageConteiner.Children.Clear(); PageConteiner.Children.Add(p); };
            NavigationService.Inst.PageControl(new UserControlSidebar());
        }

        //TcpClient tcpClient = new TcpClient();
        //await tcpClient.ConnectAsync("127.0.0.1", 8000);
        //if (tcpClient.Connected)
        //{
        //    richsocket.AppendText($"Connected value is {tcpClient.Connected}");
        //    var stream = tcpClient.GetStream();


        //    // StringBuilder для склеивания полученных данных в одну строку
        //    StringBuilder response = new StringBuilder();
        //    int bytes = 0;  // количество полученных байтов
        //    do
        //    {
        //        // получаем данные
        //        bytes = await stream.ReadAsync(responseData);
        //        // преобразуем в строку и добавляем ее в StringBuilder
        //        response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
        //    }
        //    while (bytes > 0); // пока данные есть в потоке 

        //    // выводим данные на консоль
        //    richsocket.AppendText($"{response}\n");

        //    // отправляем маркер завершения подключения - END
        //    richsocket.AppendText("Все сообщения отправлены\n");
        //}
        //else 
        //{
        //    richsocket.AppendText("не подключен");
        //}
        //byte[] buffer = new byte[1024];

        //for (int i = 0; i < buffer.Length; i++)
        //{
        //    buffer[i] = 0;
        //}
        //for (; ; )
        //{
        //    try
        //    {
        //        class1.socket.Receive(buffer);
        //        string message = Encoding.UTF8.GetString(buffer);
        //        int count = message.IndexOf(";;;5");

        //        if (count == -1)
        //        {
        //            continue;
        //        }

        //        string Clear_Message = "";
        //        for (int i = 0; i < count; i++)
        //        {
        //            Clear_Message += message[i];
        //        }

        //        for (int i = 0; i < buffer.Length; i++)
        //        {
        //            buffer[i] = 0;
        //        }

        //        richsocket.AppendText(Clear_Message);
        //    }
        //    catch (Exception ex) { }
        //}
    }
}
