using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;

namespace SampleBA
{
    public class Model
    {

        private BootstrapperApplication BootstrapperApplication { get; private set; }

        public Model(BootstrapperApplication ba)
        {
            this.BootstrapperApplication = ba;

        }
    }
}
