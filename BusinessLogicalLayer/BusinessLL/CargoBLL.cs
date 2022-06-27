using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class CargoBLL : ICRUD<Cargo>
    {
        CargoDAL cargoDAL = new CargoDAL();
        public Response Insert(Cargo item)
        {
            return cargoDAL.Insert(item);
        }

        public Response Update(Cargo item)
        {
            return cargoDAL.Update(item);
        }
        public Response Delete(int id)
        {
            return cargoDAL.Delete(id);
        }

        public DataResponse<Cargo> GetAll()
        {
            return cargoDAL.GetAll();
        }

        public SingleResponse<Cargo> GetByID(int id)
        {
            return cargoDAL.GetByID(id);
        }

        public Response Disable(int id)
        {
            throw new NotImplementedException();
        }
    }
}
