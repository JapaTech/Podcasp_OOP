using Podcast; // Importa o namespace Podcast, que contém as classes definidas no projeto

// Cria instâncias de convidados com nome e descrição
Convidado c1 = new Convidado("Caneta Azul", "Cantor famoso da internet");
Convidado c2 = new Convidado("Joelma", "Rainha do Axé brasileira");

// Cria uma instância de um episódio com ordem, título e duração
Episodio e1 = new Episodio(1, "Falando com Joelma", 45);
// Adiciona um convidado ao episódio
e1.AdicionarConvidado(c2);

// Cria outro episódio, agora com dois convidados
Episodio e3 = new Episodio(3, "Falando com Joelma e caneta azul", 35);
e3.AdicionarConvidado(c2); // Adiciona Joelma como convidada
e3.AdicionarConvidado(c1); // Adiciona Caneta Azul como convidado

// Cria um terceiro episódio
Episodio e2 = new Episodio(2, "Falando Caneta azul", 70);
// Adiciona Caneta Azul como convidado
e3.AdicionarConvidado(c1);

// Cria um podcast com nome e apresentador
Podcast.Podcast podcast1 = new Podcast.Podcast("Entrevistando músicos Brasileiros", "Luisa");

// Adiciona os episódios criados ao podcast
podcast1.AdicioarEpisodio(e3); // Adiciona o terceiro episódio
podcast1.AdicioarEpisodio(e2); // Adiciona o segundo episódio
podcast1.AdicioarEpisodio(e1); // Adiciona o primeiro episódio

// Exibe uma linha em branco para separar os detalhes do podcast no console
Console.WriteLine();

// Chama o método para exibir os detalhes do podcast e dos episódios no console
podcast1.ExibirDetalhes();
