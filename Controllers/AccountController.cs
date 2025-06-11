using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ASPALPER.Models;
using System.Web;
using System.Web.Mvc;

public class AccoundController:Controller
{
    private static List<User> users = new List<User>
    {
        new User
        {
            UserName = "admin",Password="1234"
        }
    };

    public ActionResult Login() //Metodu çağırdık 
    {
        return View(); //görünümünü görücez
    }
    [HttpPost]
    public ActionResult Login (User user)
    {
        var found = users.Find(u=>u.UserName==user.UserName
        && u.Password==user.Password);
        if(found!=null)
        {
            Session["User"]=found.UserName;
            return RedirectToAction("Index","Araba");
        }
        ViewBag.Message="Hatalı kullanıcı adı veya şifre!";
        return View();
    }
    public ActionResult Logout()
    {
        Session.Clear();
        return RedirectToAction("Login");
    }
}