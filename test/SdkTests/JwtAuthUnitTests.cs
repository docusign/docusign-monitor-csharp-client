using DocuSign.Monitor.Api;
using DocuSign.Monitor.Client;
using DocuSign.Monitor.Client.Auth;
using DocuSign.Monitor.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests
{
    [TestClass]
    public class JwtAuthUnitTests
    {
        TestConfig testConfig = new TestConfig();
        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new DocuSignClient(testConfig.Host);
            testConfig.ApiClient.SetOAuthBasePath(testConfig.OAuthBasePath);

            Assert.IsNotNull(testConfig.PrivateKey);

            byte[] privateKeyStream = Convert.FromBase64String(testConfig.PrivateKey);

            var scopes = new List<string>();
            scopes.Add("monitor.manage");
            scopes.Add("monitor.send");
            scopes.Add("signature");
            scopes.Add("impersonation");

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);
            Assert.IsNotNull(tokenInfo);

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            // for testing purposes, we have to connect using a different host than we do for authentication and other monitor tests
            DocuSignClient userInfoApiClient = new DocuSignClient(testConfig.UserInfoHost);
            userInfoApiClient.SetOAuthBasePath(testConfig.OAuthBasePath);
            OAuth.UserInfo userInfo = userInfoApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    testConfig.OrganizationId = item.Organization?.OrganizationId;
                    //testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
            Assert.IsNotNull(testConfig.OrganizationId);
        }

        [TestMethod]
        public void JwtGetStreamTest()
        {
            DocuMonitorApi docuMonitorApi = new DocuMonitorApi(testConfig.ApiClient);
            Guid organizationId = Guid.Parse(testConfig.OrganizationId);
            DocuMonitorApi.StreamOptions options = new DocuMonitorApi.StreamOptions
            {
                cursor = DateTime.UtcNow.AddDays(-1).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                limit = 100
            };

            StreamResponse streamResponse = docuMonitorApi.Stream(organizationId, options);

            Assert.IsNotNull(streamResponse);
            Assert.IsNotNull(streamResponse.EndCursor);
            Assert.IsNotNull(streamResponse.ResultData);

            if (streamResponse.ResultData.Count > 0)
            {
                Assert.IsNotNull(streamResponse.ResultData[0].EventId);
            }
        }
    }
}