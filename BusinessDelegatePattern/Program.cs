using BusinessDelegatePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.SetService("EJB");

            Client client = new Client(businessDelegate);
            client.DoTask();

            businessDelegate.SetService("JMS");
            client.DoTask();

            Console.ReadLine();
        }
    }
}
