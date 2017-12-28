using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBA
{
    public enum InstallationState
    {
        Initializing,
        Detecting,
        Waiting,
        Planning,
        Applying,
        Applied,
        Failed,
    }

    public enum DetectionState
    {
        Absent,
        Present,
        Newer,
    }

    class InstallationViewModel : PropertyNotifyBase
    {
        private RootViewModel root;

        public InstallationViewModel(RootViewModel root)
        {
            this.root = root;
        }

        private void WireEventsHandlers()
        {

        }
    }
}
