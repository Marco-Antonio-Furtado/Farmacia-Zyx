using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Iten_CompraDal : ICRUD<Item_Compra>
    {
        public Response Insert(Item_Compra item)
        {
            throw new NotImplementedException();
        }

        public Response Update(Item_Compra item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Item_Compra> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Item_Compra> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Item_Compra> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
