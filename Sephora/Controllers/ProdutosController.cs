﻿using Sephora.Data;
using Sephora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sephora.Controllers
{
	public class ProdutosController : Controller
	{
		private readonly SephoraStoreDataContext _ctx = new SephoraStoreDataContext();

		public ViewResult Index()
		{
			var produtos = _ctx.Produtos.ToList();
			return View(produtos);
		}

		[HttpGet]
		public ViewResult AddEdit(int ? id )
		{
			Produto produto = new Produto();
			if(id!= null)
			{
				 produto = _ctx.Produtos.Find(id);
			}
			var tipos = _ctx.TipodeProdutos.ToList();
			ViewBag.Tipos = tipos;
			return View(produto);
		}
		

		[HttpPost]
		public ActionResult AddEdit(Produto produto)
		{
			if(produto.Id == 0)
			{
				_ctx.Produtos.Add(produto);
			}
			else
			{
				_ctx.Entry(produto).State = System.Data.Entity.EntityState.Modified;
			}
			
			_ctx.SaveChanges();
				
			return RedirectToAction("Index");
		}

		public ActionResult DelProd(int id)
		{

			var produto = _ctx.Produtos.Find(id);
			if (produto == null)
			{
				return HttpNotFound();
			}
			else
			{
				_ctx.Produtos.Remove(produto);
				_ctx.SaveChanges();
				return null;
			}
			
		}

		protected override void Dispose(bool disposing)
		{
			_ctx.Dispose();
		}

		

	}
}
