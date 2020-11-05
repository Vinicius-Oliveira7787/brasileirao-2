using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace entra21_tests
{
    public class CampeonatoTest
    {
        public List<Time> GerarTimes()
        {
            var nomeDoTime = new List<string>{"Palmeiras","Corinthians","Santos","São Paulo","Flamengo","Atlético-MG","Grêmio","Internacional"};
            
            //Elenco Palmeiras
            var Palmeiras1 = new Jogador(nomeDoTime[0], "Weverton", 1); var Palmeiras2 = new Jogador(nomeDoTime[0], "Marcos Rocha", 2); 
            var Palmeiras3 = new Jogador(nomeDoTime[0], "Felipe M.", 30); var Palmeiras4 = new Jogador(nomeDoTime[0], "Vina", 17); 
            var Palmeiras5 = new Jogador(nomeDoTime[0], "Wesley", 21); var Palmeiras6 = new Jogador(nomeDoTime[0], "Vitor H.", 6); 
            var Palmeiras7 = new Jogador(nomeDoTime[0], "G. Gomez", 15); var Palmeiras8 = new Jogador(nomeDoTime[0], "Patrick P", 5);
            var Palmeiras9 = new Jogador(nomeDoTime[0], "Willian.", 29); var Palmeiras10 = new Jogador(nomeDoTime[0], "L. Adriano", 10);
            var Palmeiras11 = new Jogador(nomeDoTime[0], "Rony", 11); var Palmeiras12 = new Jogador(nomeDoTime[0], "Mayke", 12);
            var Palmeiras13 = new Jogador(nomeDoTime[0], "Luan", 13);var Palmeiras14 = new Jogador(nomeDoTime[0], "Zé Rafael", 8);
            var Palmeiras15 = new Jogador(nomeDoTime[0], "Ramires", 18); var Palmeiras16 = new Jogador(nomeDoTime[0], "Lucas Esteves", 16);
            
            var jogadoresPalmeiras = new List<Jogador>{Palmeiras1,Palmeiras2,Palmeiras3,Palmeiras4,Palmeiras5,Palmeiras6,Palmeiras7,
            Palmeiras8,Palmeiras9,Palmeiras10,Palmeiras11,Palmeiras12,Palmeiras13,Palmeiras14,Palmeiras15,Palmeiras16};
            
            //Elenco Corinthians
            var Corinthians1 = new Jogador(nomeDoTime[1], "Cássio", 12); var Corinthians2 = new Jogador(nomeDoTime[1], "Michel", 2); 
            var Corinthians3 = new Jogador(nomeDoTime[1], "Gil", 4); var Corinthians4 = new Jogador(nomeDoTime[1], "Lucas P.", 6); 
            var Corinthians5 = new Jogador(nomeDoTime[1], "Ramiro", 8); var Corinthians6 = new Jogador(nomeDoTime[1], "Luan", 7); 
            var Corinthians7 = new Jogador(nomeDoTime[1], "Cazares", 10); var Corinthians8 = new Jogador(nomeDoTime[1], "Otero", 11);
            var Corinthians9 = new Jogador(nomeDoTime[1], "Jô", 77); var Corinthians10 = new Jogador(nomeDoTime[1], "Léo Santos", 13);
            var Corinthians11 = new Jogador(nomeDoTime[1], "Sidcley", 16); var Corinthians12 = new Jogador(nomeDoTime[1], "Boselli", 17);
            var Corinthians13 = new Jogador(nomeDoTime[1], "A. Araos", 21); var Corinthians14 = new Jogador(nomeDoTime[1], "Léo Natel", 18);
            var Corinthians15 = new Jogador(nomeDoTime[1], "Camacho", 20); var Corinthians16 = new Jogador(nomeDoTime[1], "M. Vital", 22 );

            var jogadoresCorinthians = new List<Jogador>{Corinthians1,Corinthians2,Corinthians3,Corinthians4,Corinthians5,Corinthians6,Corinthians7,
            Corinthians8,Corinthians9,Corinthians10,Corinthians11,Corinthians12,Corinthians13,Corinthians14,Corinthians15,Corinthians16};
            
            //Elenco Santos
            var Santos1 = new Jogador(nomeDoTime[2], "Vladimir", 1); var Santos2 = new Jogador(nomeDoTime[2], "Luis Felipe", 2);
            var Santos3 = new Jogador(nomeDoTime[2], "Pará", 4); var Santos4 = new Jogador(nomeDoTime[2], "Lucas Veríssimo", 28);
            var Santos5 = new Jogador(nomeDoTime[2], "Alison", 5); var Santos6 = new Jogador(nomeDoTime[2], "Luan Peres", 14);
            var Santos7 = new Jogador(nomeDoTime[2], "Taílson", 39); var Santos8 = new Jogador(nomeDoTime[2], "Jean Mota", 41);
            var Santos9 = new Jogador(nomeDoTime[2], "Carlos Sánchez", 7); var Santos10 = new Jogador(nomeDoTime[2], "Soteldo", 10);
            var Santos11 = new Jogador(nomeDoTime[2], "Marinho", 11); var Santos12 = new Jogador(nomeDoTime[2], "Jobson", 8);
            var Santos13 = new Jogador(nomeDoTime[2], "Madson", 13); var Santos14 = new Jogador(nomeDoTime[2], "Kaio Jorge", 19);
            var Santos15 = new Jogador(nomeDoTime[2], "Anderson Ceará", 40); var Santos16 = new Jogador(nomeDoTime[2], "Raniel", 12);
            
            var jogadoresSantos = new List<Jogador>{Santos1,Santos2,Santos3,Santos4,Santos5,Santos6,Santos7,
            Santos8,Santos9,Santos10,Santos11,Santos12,Santos13,Santos14,Santos15,Santos16};
            
            //Elenco São Paulo
            var SaoPaulo1 = new Jogador(nomeDoTime[3], "Tiago Volpi", 1); var SaoPaulo2 = new Jogador(nomeDoTime[3], "Igor Vinicius", 2);
            var SaoPaulo3 = new Jogador(nomeDoTime[3], "Bruno Alves", 3); var SaoPaulo4 = new Jogador(nomeDoTime[3], "Lucas Perri", 23);
            var SaoPaulo5 = new Jogador(nomeDoTime[3], "Arboleda", 5); var SaoPaulo6 = new Jogador(nomeDoTime[3], "Reinaldo", 6);
            var SaoPaulo7 = new Jogador(nomeDoTime[3], "Hernanes", 15); var SaoPaulo8 = new Jogador(nomeDoTime[3], "Jonas Toró", 18);
            var SaoPaulo9 = new Jogador(nomeDoTime[3], "Juanfran", 20); var SaoPaulo10 = new Jogador(nomeDoTime[3], "Dani Alves", 10);
            var SaoPaulo11 = new Jogador(nomeDoTime[3], "Helinho", 37); var SaoPaulo12 = new Jogador(nomeDoTime[3], "Pablo", 9);
            var SaoPaulo13 = new Jogador(nomeDoTime[3], "Brenner", 30); var SaoPaulo14 = new Jogador(nomeDoTime[3], "Luciano", 11);
            var SaoPaulo15 = new Jogador(nomeDoTime[3], "Santiago Trellez", 17); var SaoPaulo16 = new Jogador(nomeDoTime[3], "Léo", 16);
            
            var jogadoresSaoPaulo = new List<Jogador>{SaoPaulo1,SaoPaulo2,SaoPaulo3,SaoPaulo4,SaoPaulo5,SaoPaulo6,SaoPaulo7,
            SaoPaulo8,SaoPaulo9,SaoPaulo10,SaoPaulo11,SaoPaulo12,SaoPaulo13,SaoPaulo14,SaoPaulo15,SaoPaulo16};

            //Elenco Flamengo
            var Flamengo1 = new Jogador(nomeDoTime[4], "Diego Alves", 1); var Flamengo2 = new Jogador(nomeDoTime[4], "Gustavo Henrique", 2);
            var Flamengo3 = new Jogador(nomeDoTime[4], "Rodrigo Caio", 3); var Flamengo4 = new Jogador(nomeDoTime[4], "Léo Pereira", 4);
            var Flamengo5 = new Jogador(nomeDoTime[4], "Willian Arão", 5); var Flamengo6 = new Jogador(nomeDoTime[4], "Renê", 6);
            var Flamengo7 = new Jogador(nomeDoTime[4], "Everton Ribeiro", 7); var Flamengo8 = new Jogador(nomeDoTime[4], "Gerson", 8);
            var Flamengo9 = new Jogador(nomeDoTime[4], "G. Barbosa", 9); var Flamengo10 = new Jogador(nomeDoTime[4], "Diego", 10);
            var Flamengo11 = new Jogador(nomeDoTime[4], "Vitinho", 11); var Flamengo12 = new Jogador(nomeDoTime[4], "G. Arrascaeta", 14);
            var Flamengo13 = new Jogador(nomeDoTime[4], "Dudu", 13); var Flamengo14 = new Jogador(nomeDoTime[4], "Pedro", 21);
            var Flamengo15 = new Jogador(nomeDoTime[4], "Bruno Henrique", 27); var Flamengo16 = new Jogador(nomeDoTime[4], "Felipe Luis", 16);

            var jogadoresFlamengo = new List<Jogador>{Flamengo1,Flamengo2,Flamengo3,Flamengo4,Flamengo5,Flamengo6,Flamengo7,
            Flamengo8,Flamengo9,Flamengo10,Flamengo11,Flamengo12,Flamengo13,Flamengo14,Flamengo15,Flamengo16};
            
            //Elenco Atlético MG
            var AtleticoMG1 = new Jogador(nomeDoTime[5], "Everson", 31); var AtleticoMG2 = new Jogador(nomeDoTime[5], "Gabriel V.", 2);
            var AtleticoMG3 = new Jogador(nomeDoTime[5], "Junior Alonso", 3); var AtleticoMG4 = new Jogador(nomeDoTime[5], "Réver", 4);
            var AtleticoMG5 = new Jogador(nomeDoTime[5], "Alan Franco", 21); var AtleticoMG6 = new Jogador(nomeDoTime[5], "Bueno", 40);
            var AtleticoMG7 = new Jogador(nomeDoTime[5], "Gustavo Blanco", 5); var AtleticoMG8 = new Jogador(nomeDoTime[5], "Guilherme Arana", 13);
            var AtleticoMG9 = new Jogador(nomeDoTime[5], "Tardelli", 9); var AtleticoMG10 = new Jogador(nomeDoTime[5], "Maílton", 22);
            var AtleticoMG11 = new Jogador(nomeDoTime[5], "Keno", 11); var AtleticoMG12 = new Jogador(nomeDoTime[5], "Mariano", 25);
            var AtleticoMG13 = new Jogador(nomeDoTime[5], "Eduardo Sasha", 18); var AtleticoMG14 = new Jogador(nomeDoTime[5], "Marquinhos", 150);
            var AtleticoMG15 = new Jogador(nomeDoTime[5], "Marrony", 38); var AtleticoMG16 = new Jogador(nomeDoTime[5], "Savarino", 70);

            var jogadoresAtleticoMG = new List<Jogador>{AtleticoMG1,AtleticoMG2,AtleticoMG3,AtleticoMG4,AtleticoMG5,AtleticoMG6,AtleticoMG7,
            AtleticoMG8,AtleticoMG9,AtleticoMG10,AtleticoMG11,AtleticoMG12,AtleticoMG13,AtleticoMG14,AtleticoMG15,AtleticoMG16};

            //Elenco Grêmio
            var Gremio1 = new Jogador(nomeDoTime[6], "Paulo Victor", 1); var Gremio2 = new Jogador(nomeDoTime[6], "Victor Ferraz", 2);
            var Gremio3 = new Jogador(nomeDoTime[6], "Geromel", 3); var Gremio4 = new Jogador(nomeDoTime[6], "Kannemann", 4);
            var Gremio5 = new Jogador(nomeDoTime[6], "Robinho", 18); var Gremio6 = new Jogador(nomeDoTime[6], "Léo Gomes", 6);
            var Gremio7 = new Jogador(nomeDoTime[6], "Matheus Henrique", 7); var Gremio8 = new Jogador(nomeDoTime[6], "Maicon", 8);
            var Gremio9 = new Jogador(nomeDoTime[6], "Jean Pierre", 21); var Gremio10 = new Jogador(nomeDoTime[6], "Pepê", 25);
            var Gremio11 = new Jogador(nomeDoTime[6], "Éverton", 11); var Gremio12 = new Jogador(nomeDoTime[6], "Bruno Cortez", 12);
            var Gremio13 = new Jogador(nomeDoTime[6], "Diogo Barbosa", 32); var Gremio14 = new Jogador(nomeDoTime[6], "David Braz", 14);
            var Gremio15 = new Jogador(nomeDoTime[6], "Darlan Mendes", 15); var Gremio16 = new Jogador(nomeDoTime[6], "Lucas Silva", 16);

            var jogadoresGremio = new List<Jogador>{Gremio1,Gremio2,Gremio3,Gremio4,Gremio5,Gremio6,Gremio7,
            Gremio8,Gremio9,Gremio10,Gremio11,Gremio12,Gremio13,Gremio14,Gremio15,Gremio16};

            //Elenco Internacional
            var Inter1 = new Jogador(nomeDoTime[7], "Marcelo Lomba", 12); var Inter2 = new Jogador(nomeDoTime[7], "Gabriel V.", 2);
            var Inter3 = new Jogador(nomeDoTime[7], "Victor Cuesta", 15); var Inter4 = new Jogador(nomeDoTime[7], "Lucas Ribeiro", 14);
            var Inter5 = new Jogador(nomeDoTime[7], "Rodrigo Moledo", 4); var Inter6 = new Jogador(nomeDoTime[7], "Uendel", 6);
            var Inter7 = new Jogador(nomeDoTime[7], "Patrick", 88); var Inter8 = new Jogador(nomeDoTime[7], "Moisés", 20);
            var Inter9 = new Jogador(nomeDoTime[7], "Nonato", 33); var Inter10 = new Jogador(nomeDoTime[7], "Heitor", 2);
            var Inter11 = new Jogador(nomeDoTime[7], "Jussa", 25); var Inter12 = new Jogador(nomeDoTime[7], "D'Alessandro", 10);
            var Inter13 = new Jogador(nomeDoTime[7], "Rodrigo Dourado", 13); var Inter14 = new Jogador(nomeDoTime[7], "Willian Pottker", 7);
            var Inter15 = new Jogador(nomeDoTime[7], "Gabriel Boschilia", 21); var Inter16 = new Jogador(nomeDoTime[7], "Tiago Galhardo", 17);
            
            var jogadoresInter = new List<Jogador>{Inter1,Inter2,Inter3,Inter4,Inter5,Inter6,Inter7,
            Inter8,Inter9,Inter10,Inter11,Inter12,Inter13,Inter14,Inter15,Inter16};

            var timeInter = new Time(nomeDoTime[7]); timeInter.CriarJogadores(jogadoresInter);
            var timeGremio = new Time(nomeDoTime[6]); timeGremio.CriarJogadores(jogadoresGremio);
            var timeAlteticoMG = new Time(nomeDoTime[5]); timeAlteticoMG.CriarJogadores(jogadoresAtleticoMG);
            var timeFlamengo = new Time(nomeDoTime[4]); timeFlamengo.CriarJogadores(jogadoresFlamengo);
            var timeSaoPaulo = new Time(nomeDoTime[3]); timeSaoPaulo.CriarJogadores(jogadoresSaoPaulo);
            var timeSantos = new Time(nomeDoTime[2]); timeSantos.CriarJogadores(jogadoresSantos);
            var timeCorinthians = new Time(nomeDoTime[1]); timeCorinthians.CriarJogadores(jogadoresCorinthians);
            var timePalmeiras = new Time(nomeDoTime[0]); timePalmeiras.CriarJogadores(jogadoresPalmeiras);

            return new List<Time>{timeInter,timeAlteticoMG,timeCorinthians,timeFlamengo,timeGremio,timePalmeiras,timeSantos,timeSaoPaulo};
        }

        public List<Jogador> GerarJogadores()
        {
            var nomeDoTime = new List<string>{"Palmeiras","Corinthians","Santos","São Paulo","Flamengo","Atlético-MG","Grêmio","Internacional"};
            
            //Elenco Palmeiras
            var Palmeiras1 = new Jogador(nomeDoTime[0], "Weverton", 1); var Palmeiras2 = new Jogador(nomeDoTime[0], "Marcos Rocha", 2); 
            var Palmeiras3 = new Jogador(nomeDoTime[0], "Felipe M.", 30); var Palmeiras4 = new Jogador(nomeDoTime[0], "Vina", 17); 
            var Palmeiras5 = new Jogador(nomeDoTime[0], "Wesley", 21); var Palmeiras6 = new Jogador(nomeDoTime[0], "Vitor H.", 6); 
            var Palmeiras7 = new Jogador(nomeDoTime[0], "Dudu", 7); var Palmeiras8 = new Jogador(nomeDoTime[0], "Patrick P", 5);
            var Palmeiras9 = new Jogador(nomeDoTime[0], "Gabriel J.", 9); var Palmeiras10 = new Jogador(nomeDoTime[0], "L. Adriano", 10);
            var Palmeiras11 = new Jogador(nomeDoTime[0], "Rony", 11); var Palmeiras12 = new Jogador(nomeDoTime[0], "Mayke", 12);
            var Palmeiras13 = new Jogador(nomeDoTime[0], "Luan", 13);var Palmeiras14 = new Jogador(nomeDoTime[0], "Zé Rafael", 8);
            var Palmeiras15 = new Jogador(nomeDoTime[0], "Ramires", 18); var Palmeiras16 = new Jogador(nomeDoTime[0], "Lucas Esteves", 16);
            
            return new List<Jogador>{Palmeiras1,Palmeiras2,Palmeiras3,Palmeiras4,Palmeiras5,Palmeiras6,Palmeiras7,
            Palmeiras8,Palmeiras9,Palmeiras10,Palmeiras11,Palmeiras12,Palmeiras13,Palmeiras14,Palmeiras15,Palmeiras16};
        }

        [Fact]
        public void Should_not_create_players_when_user_isnt_CBF()
        {
            // Dado / Setup
            var campeonato = new Campeonato();

            // Quando / Ação
            var criar = campeonato.CriarTimes(GerarTimes());

            // Deve / Asserções
            Assert.False(criar);
        }
    }
}