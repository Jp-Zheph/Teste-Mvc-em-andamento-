using Sephora.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Sephora.Data
{
	internal class DbInitializer : CreateDatabaseIfNotExists<SephoraStoreDataContext>
	{
		

		protected override void Seed(SephoraStoreDataContext context)
		{
			var alimento = new TipodeProduto() { Nome = "Alimento" };
			var higiene = new TipodeProduto() { Nome = "Higiene" };
			var eletronico = new TipodeProduto() { Nome = "Eletronico" };
			var bebida = new TipodeProduto() { Nome = "Bebida" };
			var Limpeza = new TipodeProduto() { Nome = "Limpeza" };
			
			var produtos = new List<Produto>() {
			new Produto() {  Nome = "Picanha" , Preco = 70.5m , Qtde = 100 , TipoDeProduto = alimento},
			new Produto() {  Nome = "Leite" , Preco = 3.30m , Qtde = 525 ,TipoDeProduto = bebida },
			new Produto() {  Nome = "Pão " , Preco = 5.5m , Qtde = 15 , TipoDeProduto = alimento},
			new Produto() {  Nome = "Café " , Preco = 5.70m , Qtde = 500 , TipoDeProduto = bebida},
			new Produto() {  Nome = "Desinfetante " , Preco = 8.70m , Qtde = 250 , TipoDeProduto = Limpeza},
			new Produto() {  Nome = "Telefone  " , Preco = 199.90m , Qtde = 100 , TipoDeProduto = eletronico},
			new Produto() {  Nome = "Sabonete" , Preco = 1.90m , Qtde = 220 , TipoDeProduto = higiene},
			};
			context.Produtos.AddRange(produtos);
			context.SaveChanges();
		}
	}
}