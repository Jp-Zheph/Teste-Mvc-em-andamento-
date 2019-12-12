using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sephora.Models
{
	[Table(nameof(Produto))]
    public class Produto:Entity
    {

		[Required,Column(TypeName ="Varchar"),StringLength(100)]
		public string Nome { get; set; }

		[Column(TypeName ="Money")]
		public decimal Preco { get; set; }
		
		[Column("Quantidade")]
		public short Qtde { get; set; }
		

		public int TipoDeProdutoId { get; set; }
		[ForeignKey(nameof(TipoDeProdutoId))]
		public virtual TipodeProduto TipoDeProduto { get; set; }
	}
}
