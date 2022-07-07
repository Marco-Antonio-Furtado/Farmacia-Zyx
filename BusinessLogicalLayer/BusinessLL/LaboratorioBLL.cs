using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados de Laboratorio com a tela 
    /// e fazendo sua regras de negocios onde no caso de Laboratorios Sao validacoes
    /// </summary>

    public class LaboratorioBLL : ICRUD<Laboratorio>
    {
        LaboratorioDAL labdal = new();
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

        public Response Disable(int iDCLiente)
        {
            return labdal.Disable(iDCLiente);
        }
    }
}
