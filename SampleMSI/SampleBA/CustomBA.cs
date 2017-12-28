using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
using Threading = System.Windows.Threading;

namespace SampleBA
{
    public class CustomBA : BootstrapperApplication
    {
        public static Model Model { get; private set; }

        public static RootView View { get; private set; }

        public static Threading.Dispatcher Dispatcher { get; private set; }

        protected override void Run()
        {
            this.Engine.Log(LogLevel.Standard, "Wix Custom BA started...");

            CustomBA.Dispatcher = Threading.Dispatcher.CurrentDispatcher;
            

        }
    }
}
