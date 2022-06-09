using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Class
{
    public class AllocatedOrders
    {
        public event EventHandler<AllocatedOrdersEventArgs> OnAllocatedOrdersComplete;

        public class AllocatedOrdersEventArgs : EventArgs
        {
            public int AllocatedOrdersCount { get; set; }
        }

        public void StartCountingOrders(object senderName, int totalAllocatedOrders)
        {
            OnAllocatedOrdersComplete?.Invoke(senderName, new AllocatedOrdersEventArgs { AllocatedOrdersCount = totalAllocatedOrders });
        }
    }
}
