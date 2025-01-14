using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast
{
    // Define uma classe representando um Podcast
    internal class Podcast
    {
        // Propriedades somente leitura para o nome e o apresentador do podcast
        public string Nome { get; }
        public string Host { get; }

        // Lista de episódios associados ao podcast
        private List<Episodio> Episodios = new List<Episodio>();

        // Propriedade que retorna a quantidade total de episódios no podcast
        public int TotalEpisodios => Episodios.Count;

        // Construtor que inicializa o nome e o host do podcast
        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        // Método para adicionar um episódio à lista
        // Exibe uma mensagem no console informando que o episódio foi adicionado
        public void AdicioarEpisodio(Episodio episodio)
        {
            Episodios.Add(episodio); // Adiciona o episódio à lista
            //Console.WriteLine($"{episodio.Titulo} adicionado"); // Confirma a adição no console
        }

        // Método para exibir os detalhes do podcast, incluindo os episódios
        public void ExibirDetalhes()
        {
            // Exibe o nome do podcast e o host no console
            Console.WriteLine($"{Nome} apresentado por {Host}");

            // Percorre e exibe cada episódio da lista, ordenado pela propriedade 'Ordem'
            foreach (var item in Episodios.OrderBy(x => x.Ordem))
            {
                Console.WriteLine($"{item.Ordem}: {item.Titulo} ({item.DuracaoMinutos} min)");
            }
        }
    }
}