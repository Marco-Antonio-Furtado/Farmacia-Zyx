using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class Iten_CompraBll 
    {
        Iten_CompraDal compraDal = new Iten_CompraDal();
        public Response Insert(Item_Compra item)
        {
            return compraDal.Insert(item);
        }
        public Response Update(Item_Compra item)
        {
            return compraDal.Update(item);
        }
        public Response Delete(int id)
        {
            return compraDal.Delete(id);
        }

        public DataResponse<Item_Compra> GetAll()
        {
            return compraDal.GetAll();
        }

        public SingleResponse<Item_Compra> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Item_Compra> GetByID(int id)
        {
            return compraDal.GetByID(id);
        }

    }
}
