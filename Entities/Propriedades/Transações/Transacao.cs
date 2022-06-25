namespace Entities.Propriedades
{
    public class Transacao
    {
        public int ID { get; set; }
        public string IDLaboratorio { get; set; }
        public DateTime Data { get; set; }
        public string IDProduto { get; set; }
        public string IDNomeFuncionario { get; set; }
        public string IDFornecedor { get; set; }
        public string FormaPagamento { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double ValorTotal { get; set; }
    }
}
