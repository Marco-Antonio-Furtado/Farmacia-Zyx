using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Endereco
    {
        public Endereco(string rua, string bairro, string cEP, string numero, string complemento, string pontoReferencia, string cidade, string estado)
        {
            Rua = rua;
            Bairro = bairro;
            CEP = cEP;
            Numero = numero;
            Complemento = complemento;
            PontoReferencia = pontoReferencia;
            Cidade = cidade;
            Estado = estado;
        }
        public int ID { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string PontoReferencia { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return this.Rua + "\r\n" +
                   this.Bairro + "\r\n" +
                   this.CEP + "\r\n" +
                   this.Numero + "\r\n" +
                   this.Complemento + "\r\n" +
                   this.PontoReferencia + "\r\n" +
                   this.Cidade + "\r\n" +
                   this.Estado + "\r\n";
        } 
    }
}
