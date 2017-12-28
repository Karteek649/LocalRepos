using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
using Threading = System.Windows.Threading;
using WinForms = System.Windows.Forms;

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

            CustomBA.Model = new Model(this);
            CustomBA.Dispatcher = Threading.Dispatcher.CurrentDispatcher;
            RootViewModel viewModel = new RootViewModel();

            // Kick off detect which will populate the view models.
            this.Engine.Detect();
            
            if(CustomBA.Model.Command.Display == Display.Passive ||
                CustomBA.Model.Command.Display == Display.Full)
            {
                this.Engine.Log(LogLevel.Standard, "UI enabled...");
                CustomBA.View = new RootView(viewModel);
                CustomBA.View.Show();
            }

            Threading.Dispatcher.Run();

            this.Engine.Quit(CustomBA.Model.Result);

        }
    }
}
