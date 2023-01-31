using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinha_nome
{
    public static class vars
    {
        public static string caminhoImagens = Environment.CurrentDirectory + @"\_imagens\";
        public static string caminhoMusica = Environment.CurrentDirectory + @"\_musicas\Toque2.wav";
        public static string pastaPersonagens = caminhoImagens + @"\_personagens\";
        public static string pastaAnimes = caminhoImagens + @"\_animes\";

        public static string comecar = caminhoImagens + "comecar.png";
        public static string comecarLuz = caminhoImagens + "comecar-luz.png";
        public static string voltar = caminhoImagens + "voltar.png";
        public static string voltarLuz = caminhoImagens + "voltar-luz.png";
        public static string pontuacao = caminhoImagens + "pontuacao.png";
        public static string pontuacaoLuz = caminhoImagens + "pontuacao-luz.png";
        public static string responder = caminhoImagens + "responder.png";
        public static string responderLuz = caminhoImagens + "responder-luz.png";

        public static string pontuacaoFundo = caminhoImagens + "pontuacao-fundo.png";

        public static string[] imagensPersonagens = { "asta.png", "bakugo.jpg", "bakugo.png", "bils.jpg", "broly.png", "chikamaro.jpg", "chikamaru.jpg", "deku.jpg","deku-2.jpg",
                                                      "gara.jpg", "goku.jpg", "goku-black.jpg", "goku-2.png", "guy.jpg", "hashirama.jpg", "hashirama.png","hashirama-2.png", "hinata.png",
                                                      "hinata-2.jpg", "ichigo.jpg", "itachi.png", "itachi-2.jpg", "kakashi.jpg","lee.jpg", "madara.png", "might.jpg", "minato.jpg",
                                                      "minato-2.jpg", "naruto.jpg", "naruto-3.png", "pain.jpg", "sasuke.jpg","sasuke-2.jpg", "tobirama.png", "zoro.png",
                                                      "zoro-2.png", "sanji.png" };

        public static string[] respostasPersonagens = { "asta", "katsuki bakugou", "katsuki bakugou", "bils", "broly", "nara shikamaru", "nara shikamaru", "midoriya izuku","midoriya izuku",
                                                        "sabaku no gaara", "son goku", "goku black", "son goku", "maito gai", "hashirama senju", "hashirama senju","hashirama senju",
                                                        "hinata hyuuga", "hinata hyuuga", "kurosaki ichigo", "itachi uchiha", "itachi uchiha", "kakashi hatake","rock lee", "madara uchiha",
                                                        "all might", "minato namikaze", "minato namikaze", "naruto uzumaki", "naruto uzumaki", "pain", "sasuke uchiha","sasuke uchiha",
                                                        "tobirama senju", "roro noa zoro", "roro noa zoro", "sanji okay"};

        public static string[] imagensAnimes = { "bleach.jpg", "boku.png", "boku.png", "dagonbal.jpg", "naruto.png", "naruto-2.jpg", "naruto-3.jpg" };
    }
}
