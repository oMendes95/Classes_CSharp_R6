using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_R6.src
{
    public class Agentes
    {
        string Nome { get; set; }
        string País { get; set; }
        string Habilidade { get; set; }
        int Velocidade { get; set; }
        string Função { get; set; }

        public Agentes()
        {

        }

        public Agentes(string nome, string país, string habilidade, int velocidade, string função)
        {
            Nome= nome;
            País = país;
            Habilidade = habilidade;
            Velocidade = velocidade;
            Função = função;
        }

        public override string ToString()
        {
            return $" Nome: {Nome}\n " +
                   $" País: {País}\n " +
                   $" Habilidade: {Habilidade}\n " +
                   $" Velocidade: {Velocidade}\n " +
                   $" Função: {Função}\n " ;
        }

    }

}

