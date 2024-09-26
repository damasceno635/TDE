using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerencia_Tarefas
{
    public class Tarefa : Conteudo 
    {
        public string prazo;
        public string andamento;

        public string PrazoConteudo { get => prazo; set => prazo = value; }
        public string AndamentoConteudo { get => andamento; set => andamento = value; }

        public Tarefa(string titulo, string descricao, string prazo, string andamento)
        {
            base.TituloConteudo = titulo;
            base.DescricaoConteudo = descricao;
            this.PrazoConteudo = prazo;
            this.AndamentoConteudo = andamento;
        }

        public override string Conceito()
        {
            return base.Conceito() + $",\nData: {PrazoConteudo},\nAndamento: {AndamentoConteudo}";
        }
    }
}