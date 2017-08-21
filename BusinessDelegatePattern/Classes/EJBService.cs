using BusinessDelegatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern.Classes
{
    public class EJBService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by EJB Service");
        }
    }
}
