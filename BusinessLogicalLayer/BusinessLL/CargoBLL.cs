using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados de Cargo com a tela 
    /// e fazendo sua regras de negocios onde no caso de cargo nao existe
    /// </summary>
    public class CargoBLL 
    {
        CargoDAL cargoDAL = new();
        public Response Insert(Cargo item)
        {
            return cargoDAL.Insert(item);
        }
        public DataResponse<Cargo> GetAll()
        {
            return cargoDAL.GetAll();
        }
        public SingleResponse<Cargo> GetByID(int id)
        {
            return cargoDAL.GetByID(id);
        }
    }
}
