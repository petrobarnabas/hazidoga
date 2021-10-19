using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Entity;
namespace Elektronikaiszakuzletwebshop.Service
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
