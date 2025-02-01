using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabMVC.Models;

namespace LabMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Acceuil()
        {
            return View();
        }

        public ActionResult Commander()
        {
            return View();
        }

        public ActionResult Confirmation(string TxtNom, string TxtPrenom, string TxtDateNaissance, string TxtDescription, string TxtAdresse, string TxtTelephone)
        {
            ClientVO clientVO = new ClientVO();
            ClientDAO clientDAO = new ClientDAO();


            clientVO.PrenomClient = TxtPrenom;
            clientVO.NomClient = TxtNom;
            clientVO.DateNaissanceClient = TxtDateNaissance;
            clientVO.DescriptionClient = TxtDescription;
            clientVO.AdresseClient = TxtAdresse;
            clientVO.TelephoneClient = TxtTelephone;

            ViewData["numeroconfirmation"] = clientDAO.SauvegardeClient(clientVO);
            ViewData["prenom"]= TxtPrenom;
            ViewData["nom"] = TxtNom;
            ViewData["datenaissance"] = TxtDateNaissance;
            ViewData["description"] = TxtDescription;
            ViewData["adresse"] = TxtAdresse;
            ViewData["telephone"] = TxtTelephone;
            return View("Confirmation");
        }

        public ActionResult Produits()
        {
            ViewBag.Message = "Liste des produits";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacter-nous.";

            return View();
        }
    }
}