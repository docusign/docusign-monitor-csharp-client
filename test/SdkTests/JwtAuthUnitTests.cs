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
                    //testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
        }

        [TestMethod]
        public void JwtGetStreamTest()
        {
            DataSetApi dataSetApi = new DataSetApi(testConfig.ApiClient);
            String dataSetName = "monitor";
            String version = "2.0";
            CursoredResult cursoredResult = dataSetApi.GetStream(version, dataSetName);
            Assert.IsNotNull(cursoredResult);
        }
    }
}