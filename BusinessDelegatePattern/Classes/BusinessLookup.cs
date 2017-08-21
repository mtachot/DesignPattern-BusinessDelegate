using BusinessDelegatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern.Classes
{
    public class BusinessLookup
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            if (String.Compare(serviceType, "EJB") == 0)
                return new EJBService();
            else
                return new JMSService();
        }
    }
}
