namespace Podcast
{
    // Classe que representa um convidado de um episódio de podcast
    internal class Convidado
    {
        // Propriedade para armazenar o nome do convidado
        // É somente leitura, definida apenas no construtor
        public string Nome { get; }

        // Propriedade para armazenar uma apresentação ou descrição do convidado
        // Pode ser lida e modificada após a criação do objeto
        public string Apresentacao { get; set; }

        // Construtor que inicializa as propriedades do convidado
        public Convidado(string nome, string apresentacao)
        {
            Nome = nome;                // Define o nome do convidado
            Apresentacao = apresentacao; // Define a apresentação ou descrição do convidado
        }
    }
}
