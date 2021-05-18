/* 
 * DocuSign Monitor API - v2
 *
 * An API for an integrator to access the features of DocuSign Monitor
 *
 * OpenAPI spec version: v2.0
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
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
        /// 
        /// </summary>
        /// <remarks>
        /// Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        CursoredResult GetStream (string version, string dataSetName, DataSetApi.GetStreamOptions options = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<CursoredResult> GetStreamWithHttpInfo (string version, string dataSetName, DataSetApi.GetStreamOptions options = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of CursoredResult</returns>
        System.Threading.Tasks.Task<CursoredResult> GetStreamAsync (string version, string dataSetName, DataSetApi.GetStreamOptions options = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </remarks>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (CursoredResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CursoredResult>> GetStreamAsyncWithHttpInfo (string version, string dataSetName, DataSetApi.GetStreamOptions options = null);
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
        public DataSetApi(ApiClient aplClient)
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
            return this.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

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
        ///  Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </summary>
        public class GetStreamOptions
        {
            /// The cursor value to continue querying the data with. For an intial call, use empty string 
            public string cursor {get; set;}
            /// The maximum number of records to return, minimum of 1, maximum of 2000. Defaults to 1000 if no value is provided 
            public int? limit {get; set;}
        }

        /// <summary>
        ///  Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>CursoredResult</returns>
        public CursoredResult GetStream (string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
        {
             ApiResponse<CursoredResult> localVarResponse = GetStreamWithHttpInfo(version, dataSetName, options);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of CursoredResult</returns>
        public ApiResponse< CursoredResult > GetStreamWithHttpInfo (string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
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
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStream", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<CursoredResult>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (CursoredResult) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(CursoredResult)));
            }
            else
            {
                return new ApiResponse<CursoredResult>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (CursoredResult) this.ApiClient.Deserialize(localVarResponse, typeof(CursoredResult)));
            }
            
        }

        /// <summary>
        ///  Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of CursoredResult</returns>
        public async System.Threading.Tasks.Task<CursoredResult> GetStreamAsync (string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
        {
             ApiResponse<CursoredResult> localVarResponse = await GetStreamAsyncWithHttpInfo(version, dataSetName, options);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Allows for the streaming of data as it becomes available  Required scopes: impersonation
        /// </summary>
        /// <exception cref="DocuSign.Monitor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested API version</param>/// <param name="dataSetName">The name of the dataset to stream</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (CursoredResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CursoredResult>> GetStreamAsyncWithHttpInfo (string version, string dataSetName, DataSetApi.GetStreamOptions options = null)
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
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStream", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CursoredResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CursoredResult) this.ApiClient.Deserialize(localVarResponse, typeof(CursoredResult)));
            
        }

    }
}