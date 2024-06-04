using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Models;

namespace Test.Controllers
{
    public class PhepTinhController : Controller
    {
        public IActionResult Index()

        {

            return View();
        }

        public IActionResult XuLy(MayTinhModels mt)
        {
            double ketQua = 0;
            switch (mt.phepTinh)
            {
                case "+":
                    ketQua = mt.So1 + mt.So2;
                    break;

                case "-":
                    ketQua = mt.So1 - mt.So2;
                    break;
                case "*":
                    ketQua = mt.So1 * mt.So2;
                    break;
                case "/":
                    ketQua = mt.So1 / mt.So2;
                    break;
                    //default:

                    //    break;
            }
            // ViewData["K"] = ketQua;
            ViewBag.KQ = ketQua;
            return View("Index");
        }
    }
}
