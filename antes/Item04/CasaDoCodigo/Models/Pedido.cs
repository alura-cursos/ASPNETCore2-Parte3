using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    //MELHORIA: 5) arquivo modelo.cs foi quebrado em v�rios arquivos
    //veja o diagrama
    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        //TAREFA 02: CRIAR CONSTRUTOR COM ID DO CLIENTE

        //TAREFA 03: ADICIONAR MIGRA��O
        //TAREFA 04: APLICAR MIGRA��O
        
        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();

        [ForeignKey("CadastroId")]
        public int CadastroId { get; set; }
        [Required]
        public virtual Cadastro Cadastro { get; private set; }

        //TAREFA 01: ADICIONAR ID DO CLIENTE AO PEDIDO
    }
}
