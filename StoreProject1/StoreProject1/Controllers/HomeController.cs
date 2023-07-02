using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreProject1.DAL.interfaces;
using StoreProject1.Domain.Entity;
using StoreProject1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() => View();




    }
}
