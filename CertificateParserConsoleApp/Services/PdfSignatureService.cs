
using iTextSharp.text.pdf;

namespace CertificateParserConsoleApp.Services
{
    public static class PdfSignatureService
    {
        public static string GetDigitalSignatureAsBase64(string pdfFilePath)
        {
            using (var reader = new PdfReader(pdfFilePath))
            {
                var signatures = reader.AcroFields.GetSignatureNames();
                if (signatures == null || signatures.Count == 0)
                {
                    throw new Exception("No digital signatures found in the PDF.");
                }

                var signatureName = signatures[0]; // Assuming you want to extract the first signature

                var signatureDictionary = reader.AcroFields.GetSignatureDictionary(signatureName);
                var signatureContents = signatureDictionary.GetAsString(PdfName.CONTENTS);

                //var signatureBytes = Convert.FromBase64String(signatureContents.ToString());
                var base64Signature = Convert.ToBase64String(signatureContents.GetBytes());

                CertificateParser.Parser(base64Signature);

                return base64Signature;
            }
        }
    }

}

