using System.IO;
using System.Text;
using System;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           //Author by //https://github.com/paulmowat/EncryptDecrypt
            string encrypted = "e70edd685b76dce468b82009cb5a788c:9d82eac88651a3bed68854cbf8e2aff246a3c54eaac5d377ccd4980373330447";
            //string password = "mynameispaulmowat";
           // string key = "YFpoGQ@$VrUMf64tZ9eg^RiaQSZ^Pw%*";
            string key = "XNopKZ@$TiMBf64tZ9eg~RiaQSZ#Pw%*";
            string decrypted = DecryptData.Decrypt(encrypted, key);
            return View();
        }
    }
}