using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sephora.Models
{
	[Table(nameof(TipodeProduto))]
    public class TipodeProduto:Entity
    {
		
		[Required,Column(TypeName="Varchar"),StringLength(100)]
		public string Nome { get; set; }

		public virtual ICollection<Produto> Produtos { get; set; }
	}
}
