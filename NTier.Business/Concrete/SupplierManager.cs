using NTier.Business.Abstract;
using NTier.DataAccess.Abstract;
using NTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDAL _supplierDAL;
        public SupplierManager(ISupplierDAL supplierDAL)
        {
            _supplierDAL = supplierDAL;
        }
        public List<Supplier> GetSuppliers()
        {
            return _supplierDAL.GetAll();
        }
    }
}
