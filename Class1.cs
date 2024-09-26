using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerencia_Tarefas
{
    public class Conteudo
    {
        public string titulo;
        public string descricao;

        public string TituloConteudo { get => titulo; set => titulo = value; }
        public string DescricaoConteudo { get => descricao; set => descricao = value; }


        public virtual string Conceito()
        {
            return $"\nTítulo: {TituloConteudo},\nDescrição: {DescricaoConteudo}";
        }
    }
}