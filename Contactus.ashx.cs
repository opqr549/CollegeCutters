using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace CollegeCutters
{
    /// <summary>
    /// Summary description for WorkOrderReceove
    /// </summary>
    public class Contactus : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var name = context.Request.Form["name"];
            var email = context.Request.Form["email"];
            var phone = context.Request.Form["phone"];
            var comments = context.Request.Form["comments"];


            //--
            // Create and a mail message with the customer information
            //--
            var msg = new MailMessage();
            var toAddresses = new MailAddressCollection();
            var toAddress = new MailAddress("drummerdude2112@gmail.com");
            var fromAddress = new MailAddress("comments@collegecutters.com");
            msg.Subject = "New Customer Comments";

            var body = new System.Text.StringBuilder();
            body.Append("New customer comment:\n\n");
            body.Append("Name: " + name + "\n");
            body.Append("Email: " + email + "\n");
            body.Append("Phone: " + phone + "\n");
            body.Append("Details: " + comments + "\n");

            msg.Body = body.ToString();

            var smtp = new SmtpClient("smtp.sendgrid.net", 2525);
            smtp.Credentials = new System.Net.NetworkCredential("opqr549", "mees8963");

            msg.To.Add(toAddress);
            msg.From = fromAddress;
            smtp.Send(msg);

            context.Response.Redirect("comments.html");


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}