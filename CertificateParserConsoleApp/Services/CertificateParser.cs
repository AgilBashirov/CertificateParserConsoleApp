using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CertificateParserConsoleApp.Services
{
    public static class CertificateParser
    {
        public static void Parser(string cert)
        {
            // Assuming the binary certificate is stored in a byte array named 'certificateData'
            byte[] certificateData = Convert.FromBase64String(cert);

            // Create an X509Certificate2 object from the binary certificate data
            X509Certificate2 certificate = new X509Certificate2(certificateData);

            // Extracting information from the certificate
            string subject = certificate.Subject;
            string issuer = certificate.Issuer;
            DateTime validFrom = certificate.NotBefore;
            DateTime validTo = certificate.NotAfter;

            // Converting the extracted information to strings
            string subjectStr = subject;
            string issuerStr = issuer;
            string validFromStr = validFrom.ToString("yyyy-MM-dd");
            string validToStr = validTo.ToString("yyyy-MM-dd");

            // Printing the extracted information
            Console.WriteLine("Subject: " + subjectStr);
            Console.WriteLine("Issuer: " + issuerStr);
            Console.WriteLine("Valid From: " + validFromStr);
            Console.WriteLine("Valid To: " + validToStr);
        }
    }
}
