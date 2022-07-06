namespace Shared
{
    /// <summary>
    /// classe padrao de cargo para cadastrar cada cargo e ter varias funcoes dentro da empresa
    /// </summary>
    public class Cargo
    {
        public Cargo()
        {
        }

        public Cargo(string nome)
        {
           
            Nome_Cargo = nome;
        }

        public int ID { get; set; }
        public string Nome_Cargo { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return this.Nome_Cargo + "\r\n";
                 
        }





    }
}
