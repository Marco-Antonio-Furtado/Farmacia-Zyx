namespace Entities.Propriedades
{
    public class Transacao
    {
        public int ID { get; set; }
        public string Laboratorio { get; set; }
        public DateTime Data { get; set; }
        public string Produto { get; set; }
        public string NomeFuncionario { get; set; }
        public string Fornecedor { get; set; }
        public string FormaPagamento { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double ValorTotal { get; set; }

    }
}
