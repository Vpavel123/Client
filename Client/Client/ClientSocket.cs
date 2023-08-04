using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Client.Client
{
    class ClientSocket
    {
        private Socket _client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] bytes = new byte[1024];
        
        public async void ReceiveData()
        {
            try
            {
                await _client_socket.ConnectAsync("127.0.0.1", 8000);
                //richsocket.Document.Blocks.Clear();
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Подключение к 127.0.0.1 установлено\n")));
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Адрес подключения {_client_socket.RemoteEndPoint}\n")));
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Адрес приложения {_client_socket.LocalEndPoint}\n")));


                byte[] data = Encoding.UTF8.GetBytes("Hello World" + '\n');
                await _client_socket.SendAsync(data, SocketFlags.None);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async void SentData()
        {
            try
            {
                await _client_socket.ConnectAsync("127.0.0.1", 8000);
                //richsocket.Document.Blocks.Clear();
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Подключение к 127.0.0.1 установлено\n")));
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Адрес подключения {_client_socket.RemoteEndPoint}\n")));
                //richsocket.Document.Blocks.Add(new Paragraph(new Run($"Адрес приложения {_client_socket.LocalEndPoint}\n")));


                byte[] data = Encoding.UTF8.GetBytes("Hello World" + '\n');
                await _client_socket.SendAsync(data, SocketFlags.None);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
