using Sephora.Models;
using System.Data.Entity;

namespace Sephora.Data
{
	public class SephoraStoreDataContext : DbContext
    {
		public SephoraStoreDataContext() : base("StoreConn")
		{
			Database.SetInitializer(new DbInitializer());
		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<TipodeProduto> TipodeProdutos { get; set; }
	}
}
