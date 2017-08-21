using BusinessDelegatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern.Classes
{
    public class BusinessDelegate
    {
        private BusinessLookup service = new BusinessLookup();
        private IBusinessService businessService;
        private string serviceType;

        public void SetService(string serviceType)
        {
            this.serviceType = serviceType;
        }

        public void DoTask()
        {
            businessService = service.GetBusinessService(serviceType);
            businessService.DoProcessing();
        }
    }
}
