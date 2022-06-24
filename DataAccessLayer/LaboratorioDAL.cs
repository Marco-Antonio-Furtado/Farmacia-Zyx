using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LaboratorioDAL : ICRUD<Laboratorio>
    {
        public Response Insert(Laboratorio item)
        {
            throw new NotImplementedException();
        }

        public Response Update(Laboratorio item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Laboratorio> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Laboratorio> GetByID(int id)
        {
            throw new NotImplementedException();
        }

    }
}
