using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore_3_0.Models;
using Microsoft.EntityFrameworkCore;
using AspNetCore_3_0.Connection;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCore_3_0.Controllers
{
    public class CadastroController : Controller
    {
        private readonly  BancoContext db;

        public CadastroController(BancoContext conect)
        {
            db = conect;
        }

        public ActionResult ConsultaUsuario()

        {
            ViewBag.user = new SelectList(db.userdb.ToList(), "id", "nome");
            ViewBag.cpf = new SelectList(db.userdb.ToList(), "id", "cpf");
            ViewBag.dataNascimento = new SelectList(db.userdb.ToList(), "id", "dataNascimento");
            return View(db.userdb.ToList());
        }

        [HttpGet]
        public ActionResult CadastroUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroUsuario(UsuarioModel usuariomodref)
        {
            usuariomodref.dataCriacao = DateTime.Now;
            db.userdb.Add(usuariomodref);
            db.SaveChanges();
            return RedirectToAction("ConsultaUsuario");
        }

        [HttpGet]
        public ActionResult EditarUsuario(int id)
        {
            var model = db.userdb.Find(id);


            return View(model);
        }



        [HttpPost]
        public ActionResult EditarUsuario(UsuarioModel cliente)
        {

            //db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();

            return RedirectToAction("ConsultaClientes");
        }


        public ActionResult DeletarUsuario(int Id)
        {
            var user = db.userdb.Find(Id);
            db.userdb.Remove(user);
            db.SaveChanges();
            return RedirectToAction("ConsultaUsuario");
        }

        [HttpGet]
        public ActionResult _BuscasUsuario(int? idcliente, string idcpf, DateTime? dataNasc)
        {
            {
                // consulta linq
                List<UsuarioModel> usuarios = (from u in db.userdb
                                              where (idcliente != null ? u.id == idcliente : 0 == 0)
                                              && (idcpf != null ? u.cpf == idcpf : 0 == 0)
                                              && (dataNasc != null ? u.dataNascimento == dataNasc : 0 == 0)
                                              select u
                               ).ToList();

                return PartialView(usuarios);
            }
        }
    }
}

    

