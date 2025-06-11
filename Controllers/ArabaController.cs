using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

public class ArabaController:Controller{
    public IActionResult ArabaInfo()
    {
        var araba1 = new ArabaModel{
        ArabaMarka = "Audi",
        ArabaYas = 0,
        ArabaRenk = "Mavi" 
        };
        return View(araba1); 
    }
}