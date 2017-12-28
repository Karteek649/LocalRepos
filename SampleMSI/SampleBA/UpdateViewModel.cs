using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBA
{
    class UpdateViewModel : PropertyNotifyBase
    {
        private RootViewModel root;

        public UpdateViewModel(RootViewModel root)
        {
            this.root = root;
        }
        private void WireEventsHandlers()
        {

        }
    }
}
