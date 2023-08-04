using Client.Services.Client.Client;
using DevExpress.Mvvm;

namespace Client.ViewModel
{
    class BaseViewModel : BindableBase
    {
        protected ClientSocket _clientSocket;
        
        public BaseViewModel()
        {
            _clientSocket = new ClientSocket();
        }
    }
}
