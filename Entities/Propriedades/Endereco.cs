namespace Entities
{
    public class Endereco
    {
        public Endereco( string cEP, string nomeRua, string numeroCasa, int estadoID, int cidadeID)
        {
            CEP = cEP;
            NomeRua = nomeRua;
            NumeroCasa = numeroCasa;
            EstadoID = estadoID;
            CidadeID = cidadeID;
        }
        public int ID { get; set; }
        public string CEP { get; set; }
        public string NomeRua { get; set; }
        public string NumeroCasa { get; set; }
        public int EstadoID { get; set; }
        public int CidadeID { get; set; }


        public override string ToString()
        {
            return this.NomeRua + "\r\n" +
                   this.NumeroCasa + "\r\n" +
                   this.CidadeID + "\r\n" +
                   this.EstadoID + "\r\n" +
                   this.CEP + "\r\n";
        } 
    }
}
