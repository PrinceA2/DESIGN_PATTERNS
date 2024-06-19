using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class UploadServices
    {
        private UploadServices(){}
        public int UploadId { get; private set; }

        private static UploadServices _instance;
        private static readonly object _instanceLock = new object();
        
        public static UploadServices Instance(int id)
        {

            if(_instance == null)
            {
                lock(_instanceLock)
                {
                    if(_instance == null)
                    {
                        _instance = new UploadServices();
                        _instance.UploadId = id;    
                    }
                }
            }
            return _instance;
        }
    }
}
