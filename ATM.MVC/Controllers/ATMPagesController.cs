using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATM.MVC.Controllers
{
    public class ATMPagesController : Controller
    {
        //    private readonly ILogger<ATMPagesController> _logger;

        //    public ATMPagesController(ILogger<ATMPagesController> logger)
        //    {
        //        _logger = logger;
        //    }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deposit()
        {
            return View();
        }

        public IActionResult View_History()
        {
            return View();
        }

        public IActionResult TransferForm()
        {
            return View();
        }

        public IActionResult ViewBalance()
        {
            return View();
        }

        public IActionResult WithdrawalForm()
        {
            return View();
        }
        // GET: /<controller>/

    }
}

