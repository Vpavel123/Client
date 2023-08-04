using Client.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Utils
{
    public static class Ioc
    {
        public static readonly ServiceProvider _provider;
        static Ioc()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton(typeof(Sidebar));
            services.AddSingleton(typeof(BaseViewModel));

            _provider = services.BuildServiceProvider();
        }

        public static T ReResolve<T>() => _provider.GetService<T>();
    }
}
