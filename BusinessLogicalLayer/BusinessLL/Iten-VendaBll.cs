using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BusinessLL
{
    public class Iten_VendaBll : ICRUD<Item_Venda>
    {
        Iten_VendaDal iten_VendaDal = new Iten_VendaDal();
        public Response Insert(Item_Venda item)
        {
            return iten_VendaDal.Insert(item);
        }

        public Response Update(Item_Venda item)
        {
            return iten_VendaDal.Update(item);

        }
        public Response Delete(int id)
        {
            return iten_VendaDal.Delete(id);
        }

        public DataResponse<Item_Venda> GetAll()
        {
            return iten_VendaDal.GetAll();
        }

        public SingleResponse<Item_Venda> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Item_Venda> GetByID(int id)
        {
            return iten_VendaDal.GetByID(id);
        }

    }
}
