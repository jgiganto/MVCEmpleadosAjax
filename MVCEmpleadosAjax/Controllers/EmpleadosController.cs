using MVCEmpleadosAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmpleadosAjax.Controllers
{
    public class EmpleadosController : Controller
    {
        ModeloEmpleados modelo;
        public EmpleadosController()
        {
            modelo = new ModeloEmpleados();
        }
        // GET: Empleados
        public ActionResult Index()
        {
            return View();
        }
       
      


        public ActionResult MostrarEmpleados()
        {
            List<EMP> lista = modelo.GetEmpleados();
            
            return View("_VistaEmpleados", lista);
        }
     
        public ActionResult Detalles(int? empno)
        {
            EMP empleado = modelo.BuscarEmpleado(empno.GetValueOrDefault());
            ViewBag.Mensaje = "controler detalles";
            return View("_VistaDetalles", empleado);
        }
    }
}