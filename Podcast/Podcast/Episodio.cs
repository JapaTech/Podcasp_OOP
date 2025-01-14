namespace Podcast
{
    // Classe que representa um episódio de podcast
    internal class Episodio
    {
        // Propriedade para a duração do episódio (em minutos)
        public int DuracaoMinutos { get; }

        // Propriedade que indica a ordem do episódio na sequência
        public int Ordem { get; }

        // Propriedade para o título do episódio
        public string Titulo { get; }

        // Lista que armazena os convidados do episódio
        private List<Convidado> Convidados = new List<Convidado>();

        // Propriedade somente leitura que cria um resumo do episódio
        // Inclui a ordem, título, duração e os convidados
        public string Resumo => $"{Ordem}º: {Titulo}. Duração: {DuracaoMinutos}s. Convidados: {string.Join(", ", Convidados)}";

        // Construtor para inicializar as propriedades do episódio
        public Episodio(int ordem, string titulo, int duracaoSegundos)
        {
            DuracaoMinutos = duracaoSegundos; // Define a duração em segundos
            Ordem = ordem;                   // Define a ordem do episódio
            Titulo = titulo;                 // Define o título do episódio
        }

        // Método para adicionar um convidado ao episódio
        public void AdicionarConvidado(Convidado convidado)
        {
            Convidados.Add(convidado); // Adiciona o convidado à lista
            Console.WriteLine("Convidado Adicionado"); // Exibe mensagem no console
        }
    }
}
