using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe07
{
    public class Musica
    {
        public string nome;
        public string autor;
        public string gravadora;

        // Construtor da classe Musica que inicializa os atributos com os valores fornecidos
        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }
    }

    // Definição da classe Playlist, responsável por gerenciar as músicas em uma playlist
    public class Playlist
    {
        // Lista privada para armazenar as músicas da playlist
        private List<Musica> listaDeMusicas = new List<Musica>();

        // Atributo para armazenar o nome do dono da playlist
        public string dono;

        // Construtor da classe Playlist que inicializa o nome do dono
        public Playlist(string dono)
        {
            this.dono = dono;
        }

        // adiciona uma nova música à playlist
        public void AdicionarMúsica(Musica música)
        {
            // Adiciona a música à lista de músicas da playlist
            listaDeMusicas.Add(música);
        }

        // toca uma música aleatória da playlist
        public void TocarMúsicaAleatória()
        {
            // Verifica se a lista de músicas não está vazia
            if (listaDeMusicas.Count > 0)
            {
                // índice aleatório
                Random random = new Random();
                // Gera um índice aleatório dentro do intervalo válido da lista de músicas
                int índiceAleatório = random.Next(listaDeMusicas.Count);
                // Obtém a música correspondente ao índice aleatório gerado
                Musica músicaTocada = listaDeMusicas[índiceAleatório];
                // Exibe a música que está sendo tocada
                Console.WriteLine($"Tocando a música: {músicaTocada.nome} - {músicaTocada.autor}");
            }
            else
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas antes de tocar.");
            }
        }
    }

}
