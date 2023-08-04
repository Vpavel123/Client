using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Utils
{
    class ViewModelLocator
    {
        public static BaseViewModel BaseViewModel => Ioc.ReResolve<BaseViewModel>();
        public static Sidebar Sidebar => Ioc.ReResolve<Sidebar>();
    }
}
