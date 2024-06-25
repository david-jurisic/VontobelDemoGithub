using RAF3kAPItesting;
using RAF3kAPItesting.Base_Types;
using RAF3kShared.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;

 

namespace VontobelDemo.ExtendedTypes.API
{
    public class QueryStringEx : QueryString
    {
        private string sQueryString { get; set; }
        public QueryStringEx()
        {
        }



        public QueryStringEx(string _sQueryString) : base(_sQueryString)
        {
            this.sQueryString = _sQueryString;
        }



        /// <summary>
        /// Method requests data from a specified resource.
        /// </summary>
        /// <param name="response">RAFRestResponse object.</param>
        /// <param name="sUrlParameters">Url parameters to be set.It is null by default.</param>
        /// <param name="headers">Headers to be set.It is null by default.</param>
        /// <returns>RAFRestResponse object.</returns>
        public new Success GET(out RAFRestResponse response, string sUrlParameters = null, Dictionary<string, string> headers = null)
        {
            Success suc = new Success(this);
            response = null;
            try
            {
                String sMessageAddon = "";
                if (!String.IsNullOrEmpty(sUrlParameters))
                {
                    sMessageAddon += "<h3>URL Parameters:</h3> <br><p>" + sUrlParameters + "</p><br>";
                }



                if (headers != null)
                {
                    sMessageAddon += "<h3> Request headers:</h3> <br>" + GenerateTableFromDict("Header", "Value", headers);
                }



                suc.sMessageAddon = sMessageAddon;



                string sPath = Path.Combine(APIReferences.CurrentPageContext, sQueryString);
                if (!String.IsNullOrEmpty(sUrlParameters))
                    sPath += sUrlParameters;
                restClient = new RestClient(sPath);
                RestRequest Req = new RestRequest(Method.GET);
                if (headers != null)
                    Req.AddHeaders(headers);



                IRestResponse resp = restClient.Execute(Req);
                response = new RAFRestResponse(this, resp);
                return suc.Finish();
            }
            catch (Exception ex)
            {



                response = new RAFRestResponse(ex);
                return suc.Finish(ex);
            }



        }



        public Success DELETEJson(out RAFRestResponse response, string sUrlParameters = null, Dictionary<string, Object> body = null, Dictionary<string, string> headers = null)
        {
            Success suc = new Success(this);
            response = null;
            try
            {
                String sMessageAddon = "";
                if (!String.IsNullOrEmpty(sUrlParameters))
                {
                    sMessageAddon += "<h3>URL Parameters:</h3> <br><p>" + sUrlParameters + "</p><br>";
                }
                if (body != null)
                {
                    sMessageAddon += "<h3> Message Body:</h3> <br><p>" + GenerateTableFromDict("Header", "Value", body) + "</p><br>";
                }
                if (headers != null)
                {
                    sMessageAddon += "<h3> Request headers:</h3> <br>" + GenerateTableFromDict("Header", "Value", headers);
                }



                suc.sMessageAddon = sMessageAddon;



                string sPath = Path.Combine(APIReferences.CurrentPageContext, sQueryString);
                if (!String.IsNullOrEmpty(sUrlParameters))
                    sPath = Path.Combine(sPath, sUrlParameters);
                restClient = new RestClient(sPath);
                RestRequest Req = new RestRequest(Method.DELETE);
                if (headers != null)
                    Req.AddHeaders(headers);
                if (body != null && body.Count > 0)
                    Req.AddJsonBody(body);



                IRestResponse resp = restClient.Execute(Req);
                response = new RAFRestResponse(this, resp);



                return suc.Finish();
            }
            catch (Exception ex)
            {



                response = new RAFRestResponse(ex);
                return suc.Finish(ex);
            }
        }



        /// <summary>
        /// Method sends given data to create a resource as www-form-urlencoded.
        /// </summary>
        /// <param name="response">RAFRestResponse object.</param>
        /// <param name="sUrlParameters">Url parameters to be set.It is null by default.</param>
        /// <param name="body">Body to be set.It is null by default.</param>
        /// <param name="headers">Headers to be set.It is null by default.</param>
        /// <param name="parameterType">Type of parameter that can be added to the request.</param>
        /// <returns>RAFRestResponse object.</returns>
        public Success POSTXwwFormUrlEncoded(out RAFRestResponse response, string sUrlParameters = null, Dictionary<string, object> body = null, Dictionary<string, string> headers = null, ParameterType parameterType = ParameterType.GetOrPost)
        {



            Success suc = new Success(this);
            response = null;
            try
            {
                String sMessageAddon = "";
                if (!String.IsNullOrEmpty(sUrlParameters))
                {
                    sMessageAddon += "<h3>URL Parameters:</h3> <br><p>" + sUrlParameters + "</p><br>";
                }
                if (body != null)
                {
                    sMessageAddon += "<h3> Message Body:</h3> <br><p>" + GenerateTableFromDict("Parameter Name", "Value", body) + "</p><br>";
                }
                if (headers != null)
                {
                    sMessageAddon += "<h3> Request headers:</h3> <br>" + GenerateTableFromDict("Header", "Value", headers);
                }



                suc.sMessageAddon = sMessageAddon;



                string sPath = Path.Combine(APIReferences.CurrentPageContext, sQueryString);
                if (!String.IsNullOrEmpty(sUrlParameters))
                    sPath = Path.Combine(sPath, sUrlParameters);
                restClient = new RestClient(sPath);
                RestRequest Req = new RestRequest(Method.POST);
                Req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                if (headers != null)
                    Req.AddHeaders(headers);



                if (body != null)
                {
                    foreach (KeyValuePair<string, object> pairs in body)
                    {
                        Req.AddParameter(pairs.Key, pairs.Value, "application/x-www-form-urlencoded", parameterType);
                    }
                }



                IRestResponse resp = restClient.Execute(Req);
                response = new RAFRestResponse(this, resp);



                return suc.Finish();
            }
            catch (Exception ex)
            {



                response = new RAFRestResponse(ex);
                return suc.Finish(ex);
            }
        }



        /// <summary>
        /// Method sends given data to create a resource as www-form-urlencoded.
        /// </summary>
        /// <param name="response">RAFRestResponse object.</param>
        /// <param name="sUrlParameters">Url parameters to be set.It is null by default.</param>
        /// <param name="body">Body to be set.It is null by default.</param>
        /// <param name="headers">Headers to be set.It is null by default.</param>
        /// <param name="parameterType">Type of parameter that can be added to the request.</param>
        /// <returns>RAFRestResponse object.</returns>
        public Success PUTXwwFormUrlEncoded(out RAFRestResponse response, string sUrlParameters = null, Dictionary<string, object> body = null, Dictionary<string, string> headers = null, ParameterType parameterType = ParameterType.GetOrPost)
        {



            Success suc = new Success(this);
            response = null;
            try
            {
                String sMessageAddon = "";
                if (!String.IsNullOrEmpty(sUrlParameters))
                {
                    sMessageAddon += "<h3>URL Parameters:</h3> <br><p>" + sUrlParameters + "</p><br>";
                }
                if (body != null)
                {
                    sMessageAddon += "<h3> Message Body:</h3> <br><p>" + GenerateTableFromDict("Parameter Name", "Value", body) + "</p><br>";
                }
                if (headers != null)
                {
                    sMessageAddon += "<h3> Request headers:</h3> <br>" + GenerateTableFromDict("Header", "Value", headers);
                }



                suc.sMessageAddon = sMessageAddon;



                string sPath = Path.Combine(APIReferences.CurrentPageContext, sQueryString);
                if (!String.IsNullOrEmpty(sUrlParameters))
                    sPath = Path.Combine(sPath, sUrlParameters);
                restClient = new RestClient(sPath);
                RestRequest Req = new RestRequest(Method.PUT);
                Req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                if (headers != null)
                    Req.AddHeaders(headers);



                if (body != null)
                {
                    foreach (KeyValuePair<string, object> pairs in body)
                    {
                        Req.AddParameter(pairs.Key, pairs.Value, "application/x-www-form-urlencoded", parameterType);
                    }
                }



                IRestResponse resp = restClient.Execute(Req);
                response = new RAFRestResponse(this, resp);



                return suc.Finish();
            }
            catch (Exception ex)
            {



                response = new RAFRestResponse(ex);
                return suc.Finish(ex);
            }
        }



        /// <summary>
        /// Method sends given data to create a resource as www-form-urlencoded.
        /// </summary>
        /// <param name="response">RAFRestResponse object.</param>
        /// <param name="sUrlParameters">Url parameters to be set.It is null by default.</param>
        /// <param name="body">Body to be set.It is null by default.</param>
        /// <param name="headers">Headers to be set.It is null by default.</param>
        /// <param name="parameterType">Type of parameter that can be added to the request.</param>
        /// <returns>RAFRestResponse object.</returns>
        public Success DELETEXwwFormUrlEncoded(out RAFRestResponse response, string sUrlParameters = null, Dictionary<string, object> body = null, Dictionary<string, string> headers = null, ParameterType parameterType = ParameterType.GetOrPost)
        {



            Success suc = new Success(this);
            response = null;
            try
            {
                String sMessageAddon = "";
                if (!String.IsNullOrEmpty(sUrlParameters))
                {
                    sMessageAddon += "<h3>URL Parameters:</h3> <br><p>" + sUrlParameters + "</p><br>";
                }
                if (body != null)
                {
                    sMessageAddon += "<h3> Message Body:</h3> <br><p>" + GenerateTableFromDict("Parameter Name", "Value", body) + "</p><br>";
                }
                if (headers != null)
                {
                    sMessageAddon += "<h3> Request headers:</h3> <br>" + GenerateTableFromDict("Header", "Value", headers);
                }



                suc.sMessageAddon = sMessageAddon;



                string sPath = Path.Combine(APIReferences.CurrentPageContext, sQueryString);
                if (!String.IsNullOrEmpty(sUrlParameters))
                    sPath = Path.Combine(sPath, sUrlParameters);
                restClient = new RestClient(sPath);
                RestRequest Req = new RestRequest(Method.DELETE);
                Req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                if (headers != null)
                    Req.AddHeaders(headers);



                if (body != null)
                {
                    foreach (KeyValuePair<string, object> pairs in body)
                    {
                        Req.AddParameter(pairs.Key, pairs.Value, "application/x-www-form-urlencoded", parameterType);
                    }
                }



                IRestResponse resp = restClient.Execute(Req);
                response = new RAFRestResponse(this, resp);



                return suc.Finish();
            }
            catch (Exception ex)
            {



                response = new RAFRestResponse(ex);
                return suc.Finish(ex);
            }
        }
    }
}
