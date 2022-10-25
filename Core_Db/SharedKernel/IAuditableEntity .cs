using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSafe.Core.SharedKernel
{
    public interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }

        int CreatedBy { get; set; }

        DateTime UpdatedDate { get; set; }

        int UpdatedBy { get; set; }
    }
}
