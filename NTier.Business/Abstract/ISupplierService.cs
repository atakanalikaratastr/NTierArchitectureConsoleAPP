using NTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Business.Abstract
{
    public interface ISupplierService
    {
        List<Supplier> GetSuppliers();
    }
}
