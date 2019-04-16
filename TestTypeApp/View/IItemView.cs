using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.View
{
    interface IItemView<ClientType> 
    {
        event EventHandler<EventArgs> Refresh;
        event EventHandler<EventArgs> Save;

        IList<ClientType> ItemList { set; }
        ClientType CurrentItem { get; set; }
    }
}
