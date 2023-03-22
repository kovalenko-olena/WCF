using MathServiceLibrary;
using System;
using System.ServiceModel;
using System.ServiceProcess;

namespace MathWindowsServiceHost
{
    public partial class MathWinService : ServiceBase
    {
        // Переменная-член типа ServiceHost.
        private ServiceHost myHost;
        public MathWinService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            // Проверить для подстраховки. 
            myHost?.Close();
            // Создать хост.
            myHost = new ServiceHost(typeof(MathService));
            // Указать ABC в коде.
            Uri address = new Uri("http://localhost: 8080/MathServiceLibrary");
            WSHttpBinding binding = new WSHttpBinding();
            Type contract = typeof(IBasicMath);
            // Добавить эту конечную точку.
            myHost.AddServiceEndpoint(contract, binding, address);
            // Открыть хост.
            myHost.Open();
        }
        protected override void OnStop()
        {
            // Остановить хост.
            myHost?.Close();
        }
    }
}