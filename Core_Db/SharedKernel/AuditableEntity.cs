using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSafe.Core.SharedKernel
{
    public abstract class AuditableEntity : IAuditableEntity
    {
        public  DateTime CreatedDate { get; set; }
        public  int CreatedBy { get; set; }
        public  DateTime UpdatedDate { get; set; }
        public  int UpdatedBy { get; set; }
    }
}
