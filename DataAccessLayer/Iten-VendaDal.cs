using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Iten_VendaDal : ICRUD<Item_Venda>
    {
        public Response Insert(Item_Venda item)
        {
            throw new NotImplementedException();
        }

        public Response Update(Item_Venda item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Item_Venda> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Item_Venda> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Item_Venda> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
