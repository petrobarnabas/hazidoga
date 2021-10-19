using System.Collections.Generic;
using ElektronikaiSzakuzletWebShopV2.Entity;

namespace ElektronikaiSzakuzletWebShopV2.Service
{
    public interface IGenericService<ENTITY> where ENTITY : AbstractBaseEntity
    {
        ENTITY GetById(int id);
        List<ENTITY> GetAll();
        ENTITY Save(ENTITY inputData);
        ENTITY Update(int id, ENTITY updateData);
        void Delete(int id);
    }
}
