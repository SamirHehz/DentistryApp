using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using B.U.Z.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Mail;
using System.Net;

namespace B.U.Z.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;

        public ForgotPasswordModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                var user = await _userManager.FindByEmailAsync(Input.Email);
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var link = Url.Action("ResetPassword", "Home", new { code, email = user.Email }, Request.Scheme);


                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                var email = Input.Email;
                message.To.Add(new MailAddress(email.ToString()));
                message.From = new MailAddress("buz.stomatologija@gmail.com");
                message.Subject = "Reset passworda";
                message.Body = string.Format(body, "B.U.Z", "buz.stomatologija@gmail.com", link);

                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "buz.stomatologija@gmail.com",
                        Password = "vmhXPuAg2hTEdw3"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return Redirect("ForgotPasswordConfirmation");
                }
            }

            return Redirect("/Identity/Account/Login");
        }
    }
}
