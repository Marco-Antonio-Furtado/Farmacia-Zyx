using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class LaboratorioBLL : ICRUD<Laboratorio>
    {
        LaboratorioDAL labdal = new LaboratorioDAL();
        public Response Insert(Laboratorio item)
        {
            Response resposta = LaboratorioValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return labdal.Insert(item);
            }
            else { return resposta; }
        }

        public Response Update(Laboratorio item)
        {
            Response resposta = LaboratorioValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return labdal.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return labdal.Delete(id);
        }

        public DataResponse<Laboratorio> GetAll()
        {
            return labdal.GetAll();
        }

        public SingleResponse<Laboratorio> GetByID(int id)
        {
            return labdal.GetByID(id);
        }
    }
}
