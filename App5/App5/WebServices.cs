using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Net.HttpStatusCode;
using RestSharp;

namespace App5
{
    private IRestResponse _response;
    private readonly RestClient _restClient;
    private readonly RestRequest _request;
    public string UrlBase { get; set; }
    public string RequestResource { get; set; }
    
    public WebServiceRead(string baseUrl, string requestResource, Dictionary<string, string> requestParameters,
             RestSharp.Method method)
    {
        UrlBase = baseUrl;
        RequestResource = requestResource;
        RequestParameters = requestParameters;
        _restClient = new RestClient(baseUrl);
        _request = new RestRequest(requestResource, method) { RequestFormat = DataFormat.Json };
        if (requestParameters == null || requestParameters.Count == 0) return;
        if (_request.Parameters.Count == 0) _request.Parameters.Clear();
        foreach (var param in requestParameters)
            _request.Parameters.Add(new Parameter()
            {
                Name = param.Key,
                Value = param.Value,
                Type = ParameterType.GetOrPost
            });
    }
}
