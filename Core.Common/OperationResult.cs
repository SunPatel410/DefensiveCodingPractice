using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public List<string> MessageList { get; private set; }
        

        public OperationResult()
        {
            Success = true;
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
    }
}
