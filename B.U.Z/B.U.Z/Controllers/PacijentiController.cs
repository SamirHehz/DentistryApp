using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using B.U.Z.Areas.Identity.Pages.Account;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace B.U.Z.Controllers
{
    public class PacijentiController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public List<AuthenticationScheme> ExternalLogins { get; private set; }

        public PacijentiController (
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        ILogger<RegisterModel> logger,
        IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }
        public IActionResult Pacijenti(string filter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Pacijent> m = db.Pacijenti.Where(s => filter == null || s.FirstName.ToLower().StartsWith(filter)).ToList();
            return View(m);
        }
        public IActionResult NoviPacijent()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int UkupnoPacijenata = db.Pacijenti.Count() + 1;
            string pass = CreatePassword(12);
            PacijentiDodajVM model = new PacijentiDodajVM
            {
                Gradovi = db.Grad.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
                Spolovi=db.Spol.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
                UkupnoPacijenata=UkupnoPacijenata,
                PasswordHash=pass
            };
            return View(model);
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890#$%&/()=?*~";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        //public IActionResult SpasiNovogPacijenta(PacijentiDodajVM l)
        //{
        //    ApplicationDbContext db = new ApplicationDbContext();
        //    Pacijent novi = new Pacijent
        //    {
        //       FirstName=l.Ime,
        //       LastName=l.Prezime,
        //       GodinaRodjenja=l.DatumRodjenja,
        //       PhoneNumber=l.BrojTelefona,
        //       SpolId=l.SpolId,
        //       GradId=l.GradId
        //    };
        //    db.Pacijenti.Add(novi);
        //    db.SaveChanges();
        //    return Redirect("Pacijenti");
        //}
        public async Task<IActionResult> SpasiNovogPacijenta(PacijentiDodajVM s, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Pacijent
                {
                    UserName = s.BrojTelefona,
                    FirstName = s.Ime,
                    PasswordHash=s.PasswordHash,
                    LastName = s.Prezime,
                    PhoneNumber=s.BrojTelefona,
                    SpolId = s.SpolId,
                    GradId = s.GradId, 
                };
                var result = await _userManager.CreateAsync(user, s.PasswordHash);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(System.Windows.Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        //return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            s.modelState = ModelState;
            // If we got this far, something failed, redisplay form
            return Redirect("Pacijenti");
        }
        public IActionResult ObrisiPacijenta(string PacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent l = db.Pacijenti.Find(PacijentId);
            db.Pacijenti.Remove(l);
            db.SaveChanges();
            return Redirect("Pacijenti");
        }
        public IActionResult UrediPacijenta(string PacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent l = db.Pacijenti.Find(PacijentId);
            int redniBroj = db.Pacijenti.Count() + 1;
            var m = new PacijentiUrediVM
            {
                pacijent_id = l.Id,
                Ime = l.FirstName,
                Prezime = l.LastName,
                DatumRodjenja = l.GodinaRodjenja,
                RedniBroj = redniBroj,
                BrojTelefona=l.PhoneNumber
            };
            return View(m);
        }
        public IActionResult SpasiNovogStarogPacijenta(Pacijent l)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent novi = db.Pacijenti.Find(l.Id);
            novi.FirstName = l.FirstName;
            novi.LastName = l.LastName;
            novi.GodinaRodjenja = l.GodinaRodjenja;
            novi.PhoneNumber = l.PhoneNumber;
            db.SaveChanges();
            return Redirect("Pacijenti");
        }

        public IActionResult SelectPacijent(string PacijentId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Pacijent l = db.Pacijenti.Find(PacijentId);
            return View("PacijentiOdabir", l);
        }
    }
}
