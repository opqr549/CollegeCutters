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
    public class WorkOrderReceived : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var name = context.Request.Form["name"];
            var email = context.Request.Form["email"];
            var phone = context.Request.Form["phone"];
            var description = context.Request.Form["description"];
            

            //--
            // Create and a mail message with the customer information
            //--
            var msg = new MailMessage();
            var toAddresses = new MailAddressCollection();     
            var toAddress = new MailAddress("drummerdude2112@gmail.com");
            var fromAddress = new MailAddress("workorders@collegecutters.com");
            msg.Subject = "New Customer Work Order";

            var body = new System.Text.StringBuilder();
            body.Append("New customer order:\n\n");
            body.Append("Name: " + name + "\n");
            body.Append("Email: " + email + "\n");
            body.Append("Phone: " + phone + "\n");
            body.Append("Details: " + description + "\n");

            msg.Body = body.ToString();

            var smtp = new SmtpClient("smtp.sendgrid.net", 2525);
            smtp.Credentials = new System.Net.NetworkCredential("opqr549", "mees8963");
            
            msg.To.Add(toAddress);
            msg.From = fromAddress;
            smtp.Send(msg);

            context.Response.Redirect("ordersuccess.html");


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