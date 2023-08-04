using Client.Client;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Client.ViewModel
{
    class Sidebar : BaseViewModel
    {
        public DelegateCommand Receive => new DelegateCommand(() =>
        {
            _clientSocket.ReceiveData();
        });

        public DelegateCommand Send => new DelegateCommand(() =>
        {
            _clientSocket.SentData();
        });
    }
}
