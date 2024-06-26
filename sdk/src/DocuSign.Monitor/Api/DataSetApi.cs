/* 
 * Monitor API
 *
 * An API for an integrator to access the features of DocuSign Monitor
 *
 * OpenAPI spec version: v2.0
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using DocuSign.Monitor.Client;
using DocuSign.Monitor.Model;

namespace DocuSign.Monitor.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataSetApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets customer event data for an organization.
        /// </summary>
        /// <remarks>
        /// Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        CursoredResult GetStream(string version, string dataSetName, DataSetApi.GetStreamOptions options = null);

        /// <summary>
        /// Gets customer event data for an organization.
        /// </summary>
        /// <remarks>
        /// Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<CursoredResult> GetStreamWithHttpInfo(string version, string dataSetName, DataSetApi.GetStreamOptions options = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets customer event data for an organization.
        /// </summary>
        /// <remarks>
        /// Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of CursoredResult</returns>
        System.Threading.Tasks.Task<CursoredResult> GetStreamAsync(string version, string dataSetName, DataSetApi.GetStreamOptions options = null);

        /// <summary>
        /// Gets customer event data for an organization.
        /// </summary>
        /// <remarks>
        /// Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (CursoredResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CursoredResult>> GetStreamAsyncWithHttpInfo(string version, string dataSetName, DataSetApi.GetStreamOptions options = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataSetApi : IDataSetApi
    {
        private DocuSign.Monitor.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public DataSetApi(DocuSignClient aplClient)
        {
            this.ApiClient = aplClient;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.GetBasePath();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public DocuSignClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.Monitor.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets customer event data for an organization. Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </summary>
        public class GetStreamOptions
        {
            /// Specifies a pointer into the dataset where your query will begin. You can either provide an ISO DateTime or a string cursor (from the &#x60;endCursor&#x60; value in the response). If no value is provided, the query begins from seven days ago.  For example, to fetch event data beginning from January 1, 2022, set this value to &#x60;2022-01-01T00:00:00Z&#x60;. The response will include data about events starting from that date in chronological order. The response also includes an &#x60;endCursor&#x60; property. To fetch the next page of event data, call this endpoint again with &#x60;cursor&#x60; set to the previous &#x60;endCursor&#x60; value.  
            public string cursor {get; set;}
            /// The maximum number of records to return. The default value is 1000. 
            public int? limit {get; set;}
        }

        /// <summary>
        /// Gets customer event data for an organization. Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>CursoredResult</returns>
        public CursoredResult GetStream(string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
        {
             ApiResponse<CursoredResult> localVarResponse = GetStreamWithHttpInfo(version, dataSetName, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets customer event data for an organization. Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of CursoredResult</returns>
        public ApiResponse<CursoredResult> GetStreamWithHttpInfo(string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
        {
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling DataSetApi->GetStream");
            // verify the required parameter 'dataSetName' is set
            if (dataSetName == null)
                throw new ApiException(400, "Missing required parameter 'dataSetName' when calling DataSetApi->GetStream");

            var localVarPath = "/api/v{version}/datasets/{dataSetName}/stream";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (version != null) localVarPathParams.Add("version", this.ApiClient.ParameterToString(version)); // path parameter
            if (dataSetName != null) localVarPathParams.Add("dataSetName", this.ApiClient.ParameterToString(dataSetName)); // path parameter
            if (options != null)
            {
                if (options.cursor != null) localVarQueryParams.Add("cursor", this.ApiClient.ParameterToString(options.cursor)); // query parameter
                if (options.limit != null) localVarQueryParams.Add("limit", this.ApiClient.ParameterToString(options.limit)); // query parameter
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("GET"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = this.ApiClient.CallApi(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStream", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CursoredResult>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (CursoredResult)this.ApiClient.Deserialize(localVarResponse, typeof(CursoredResult)));
        }

        /// <summary>
        /// Gets customer event data for an organization. Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of CursoredResult</returns>
        public async System.Threading.Tasks.Task<CursoredResult> GetStreamAsync(string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
        {
             ApiResponse<CursoredResult> localVarResponse = await GetStreamAsyncWithHttpInfo(version, dataSetName, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets customer event data for an organization. Gets customer event data for the organization that owns the integration key.  The results for this endpoint are paginated by event timestamp. Use the &#x60;cursor&#x60; parameter to specify where the query begins in the dataset. Use the &#x60;limit&#x60; parameter to set the number of records returned. 
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Must be &#x60;2&#x60;. </param>
        /// <param name="dataSetName">Must be &#x60;monitor&#x60;.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (CursoredResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CursoredResult>> GetStreamAsyncWithHttpInfo(string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
        {
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling DataSetApi->GetStream");
            // verify the required parameter 'dataSetName' is set
            if (dataSetName == null)
                throw new ApiException(400, "Missing required parameter 'dataSetName' when calling DataSetApi->GetStream");

            var localVarPath = "/api/v{version}/datasets/{dataSetName}/stream";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (version != null) localVarPathParams.Add("version", this.ApiClient.ParameterToString(version)); // path parameter
            if (dataSetName != null) localVarPathParams.Add("dataSetName", this.ApiClient.ParameterToString(dataSetName)); // path parameter
            if (options != null)
            {
                if (options.cursor != null) localVarQueryParams.Add("cursor", this.ApiClient.ParameterToString(options.cursor)); // query parameter
                if (options.limit != null) localVarQueryParams.Add("limit", this.ApiClient.ParameterToString(options.limit)); // query parameter
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("GET"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStream", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CursoredResult>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (CursoredResult)this.ApiClient.Deserialize(localVarResponse, typeof(CursoredResult)));
        }

    }
}