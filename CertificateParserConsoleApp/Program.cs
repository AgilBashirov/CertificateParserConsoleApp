using CertificateParserConsoleApp.Services;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        var certificateBase64 = @"MIIEDjCCA2+gAwIBAgIOH9GmwMxv9DcAAAANMx0wCgYIKoZIzj0EAwMwfDEL
                                MAkGA1UEBhMCQVoxOzA5BgNVBAoTMk5hdGlvbmFsIENlcnRpZmljYXRlIFNlcnZpY2Vz
                                IENlbnRlciBvZiBBemVyYmFpamFuMTAwLgYDVQQDEydBemVyYmFpamFuIE5hdGlvbmFs
                                IElzc3VpbmcgTW9iaWxlIENBMDEwHhcNMjIwMzE0MDY0MTIyWhcNMjUwMzEzMDY0MTIy
                                WjB5MQswCQYDVQQGEwJBWjEuMCwGA1UEAwwlRsaPUsSwRCDEsFNNQVlJTFpBRMaPIMSw
                                U1JBRsSwTCBPxJ5MVTEWMBQGA1UEBAwNxLBTTUFZSUxaQUTGjzEQMA4GA1UEKgwHRsaP
                                UsSwRDEQMA4GA1UEBRMHNTZNS0ZSWTBZMBMGByqGSM49AgEGCCqGSM49AwEHA0IABJcn
                                IQlvQGxkpDLla7NAnoKUj1hlihQMudOmsReFC1vtxXpnTilOJi3S5l8zkDClW+zfSAa2
                                ttWwsa4ouy68+RijggHWMIIB0jAOBgNVHQ8BAf8EBAMCBsAwHQYDVR0OBBYEFLnwcNxU
                                /4Lohi2gCDuf3pTZqaRqMB8GA1UdIwQYMBaAFI2LbEK25/guXeefWs5oS9s7fjSAMD0G
                                A1UdHwQ2MDQwMqAwoC6GLGh0dHA6Ly9tb2JpbGUuZS1pbXphLmF6L2NkcGFpYS9BWk5J
                                TUNBMDEuY3JsMHIGCCsGAQUFBwEBBGYwZDA4BggrBgEFBQcwAoYsaHR0cDovL21vYmls
                                ZS5lLWltemEuYXovY2RwYWlhL0FaTklNQ0EwMS5jcnQwKAYIKwYBBQUHMAGGHGh0dHA6
                                Ly9tb2JpbGUuZS1pbXphLmF6L29jc3AwPQYJKwYBBAGCNxUHBDAwLgYmKwYBBAGCNxUI
                                gq3GFIGzhxG5kw2G5/lUge2pDIFhhrbOb4GAi2UCAWQCAQkwHwYDVR0lBBgwFgYIKwYB
                                BQUHAwQGCisGAQQBgjcKAwwwKQYJKwYBBAGCNxUKBBwwGjAKBggrBgEFBQcDBDAMBgor
                                BgEEAYI3CgMMMEIGA1UdIAQ7MDkwNwYKKwYBBAGCgEsHATApMCcGCCsGAQUFBwIBFhto
                                dHRwczovL21vYmlsZS5hei9yZXBvc2l0cnkwCgYIKoZIzj0EAwMDgYwAMIGIAkIBZH/f
                                NQEcV8YV89pdIq9OVdyLqP7Yxw9myb3rRiAhvP2adRXoLGvcKoPnSvl+fdYw3YFaFNLv
                                A1BkXBJAh61Yn74CQgD+rH+iKmJ8KWMIzRiXyVf1EtEd3LoB/D3IUETaAgTnx8h1Ud7a
                                ZBCsrn5ZIxHzv545hgp4kaoIqsM0bV6Ni8O7Ig==";


        //file path
        string filePath = "C:/Users/agil.bashirov/Downloads/bgb.pdf";

        //certificate parser
        CertificateParser.Parser(certificateBase64);

        // Specify the path to the signed PDF file
        PdfSignatureService.GetDigitalSignatureAsBase64(filePath);


    }
}
