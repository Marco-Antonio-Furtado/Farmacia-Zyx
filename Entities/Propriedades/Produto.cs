namespace Entities
{
    /// <summary>
    /// Classe padrao de produto que determina cada produto a sua diferenca
    /// e tem um contrutor padrao e outro preenchido por causa da um melhor funcionamento do sistema 
    /// por exemplo o funcionamento do dbexecuter
    /// </summary>
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao,double valor_unitario, Laboratorio laboratorio)
        {
            Nome = nome;
            Descricao = descricao;
            Valor_Unitario = valor_unitario;
            ID_Laboratorio = laboratorio;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor_Unitario { get; set; }
        public double Valor_Venda { get; set; }
        public Laboratorio ID_Laboratorio { get; set; }
        public double Quantia_Estoque { get; set; }
        public bool Ativo { get; set; }
        public bool IsPrecoAlterado { get; set; }
        
       
        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.Descricao + "\r\n" +
                   this.Valor_Unitario + "\r\n" +
                   this.ID_Laboratorio.Razao_Social.ToString()+ "\r\n" +
                   this.Quantia_Estoque + "\r\n" +
                   this.Ativo.ToString();
        }





    }
}
