using DocuSign.Monitor.Client;
using System;

namespace SdkNetCoreTests
{
    class TestConfig
    {
        public string IntegratorKey { get; set; }

        public string Host { get; set; }

        public string UserInfoHost { get; set; }

        public DocuSignClient ApiClient { get; set; }

        public string AccountId { get; set; }

        public string RecipientEmail { get; set; }

        public string RecipientName { get; set; }

        public string ReturnUrl { get; set; }

        public string UserId { get; set; }

        public string OAuthBasePath { get; set; }

        public string PrivateKey { get; set; }

        public int ExpiresInHours { get; set; }

        public TestConfig(string integratorKey = null, string host = null, string recipientEmail = null, string recipientName = null, string returnUrl = null, string userInfoHost = null)
        {
            string userIdFromEnv = Environment.GetEnvironmentVariable("userid");
            string integratorKeyFromEnv = Environment.GetEnvironmentVariable("integratorkey");

            this.Host = host ?? "https://lens-d.docusign.net";
            this.UserInfoHost = userInfoHost ?? "https://lens-d.docusign.net";
            this.IntegratorKey = (integratorKey != null) ? integratorKey : integratorKeyFromEnv;

            this.RecipientEmail = (recipientEmail != null) ? recipientEmail : "docusignsdktest@mailinator.com";
            this.RecipientName = (recipientName != null) ? recipientName : "Pat Developer";

            this.ReturnUrl = (returnUrl != null) ? returnUrl : "https://www.docusign.com/api";

            this.UserId = userIdFromEnv;
            this.OAuthBasePath = "account-d.docusign.com";
            this.PrivateKey = Environment.GetEnvironmentVariable("privatekey");
            this.ExpiresInHours = 1;
        }
    }
}