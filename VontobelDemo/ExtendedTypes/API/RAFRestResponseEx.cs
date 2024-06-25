using Newtonsoft.Json.Linq;
using RAF3kAPItesting;
using RAF3kAPItesting.Base_Types;
using RAF3kShared.Logging;
using RestSharp;

namespace VontobelDemo.ExtendedTypes.API
{
    public class RAFRestResponseEx : RAFRestResponse
    {
        private RAFRestResponse baseResponse;

        public RAFRestResponseEx()
        {
        }

        public RAFRestResponseEx(Exception ex) : base(ex)
        {
        }

        public RAFRestResponseEx(QueryString query, IRestResponse resp) : base(query, resp)
        {
        }

        public RAFRestResponseEx(RAFRestResponse _RAFRestResponse)
        {
            base.Client = _RAFRestResponse.Client;
            base.Response = _RAFRestResponse.Response;
            base.sAlias = _RAFRestResponse.sAlias;
            base.sPath = _RAFRestResponse.sPath;
            base.QueryStringBase = _RAFRestResponse.QueryStringBase;
        }

        /// <summary>
        /// Method verifies if value exists in json response.
        /// </summary>
        /// <param name="sJPath">Path to the json field.</param>
        /// <param name="sValue">Value to be verified.</param>
        /// <param name="bExists">Verifies if sValue exists.</param>
        /// <returns>Success object.</returns>
        public Success VerifyValue(string sJPath, string sValue, bool bExists = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                JObject jObject = JObject.Parse(Response.Content);

                if (bExists)
                {
                    if (!jObject.SelectToken(sJPath).ToString().Equals(sValue))
                        throw new Exception("Failed. Value not as expected. Response value is : " + (string)jObject.SelectToken(sJPath));

                    if (string.IsNullOrEmpty((string)jObject.SelectToken(sJPath)))
                        throw new Exception("Failed. Value is empty.");
                }

                if (!bExists)
                {
                    if (jObject.SelectToken(sJPath).ToString().Contains(sValue))
                        throw new Exception("Failed. Response value is : " + (string)jObject.SelectToken(sJPath));
                }

            }, this);
        }

        public Success GetValue(string sJPath, out string sValue)
        {
            Success suc = new Success(QueryStringBase);
            JObject jObject = JObject.Parse(Response.Content);
            sValue = "";
            try
            {
                sValue = jObject.SelectToken(sJPath).ToString();
                suc.AddArgumentsOfMethodForLog(nameof(sJPath), sJPath);
                suc.AddArgumentsOfMethodForLog(nameof(sValue), sValue, true);

                return suc.Finish();
            }
            catch (Exception ex)
            {

                return suc.Finish(ex);
            }
        }

        /// <summary>
        /// Method verifies if json field is not empty.
        /// </summary>
        /// <param name="sJPath">Path to the json field.</param>
        /// <param name="bEmpty">Verifies if the json field is empty. It is 'true' by default.</param>
        /// <returns>Success object</returns>
        public Success VerifyEmpty(string sJPath, bool bEmpty = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                JObject jObject = JObject.Parse(Response.Content);

                if (!bEmpty && string.IsNullOrEmpty((string)jObject.SelectToken(sJPath)))
                    throw new Exception("Failed. Value is empty.");

                if (bEmpty && !string.IsNullOrEmpty((string)jObject.SelectToken(sJPath)))
                    throw new Exception("Failed. Value is not empty. Value : " + (string)jObject.SelectToken(sJPath));
            }, this);

        }

        /// <summary>
        /// Method verifies if a json path contains a value.
        /// </summary>
        /// <param name="sJPath">Path to the json field.</param>
        /// <param name="sValue">Value to be verified.</param>
        /// <param name="bExists">Verifies if sValue exists.</param>
        /// <returns>Success object.</returns>
        public Success VerifyValueContains(string sJPath, string sValue, bool bExists = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                JObject jObject = JObject.Parse(Response.Content);

                if (bExists && !jObject.SelectToken(sJPath).ToString().Contains(sValue))
                    throw new Exception("Failed. Path does not contain expected value. Response value is: " + (string)jObject.SelectToken(sJPath));

                if (!bExists && jObject.SelectToken(sJPath).ToString().Contains(sValue))
                    throw new Exception("Failed. Expected value exists. " + (string)jObject.SelectToken(sJPath));

            }, this);

        }

        /// <summary>
        /// Method verifies if an array is empty.
        /// </summary>
        /// <param name="sJPath">Path to the json field.</param>
        /// <param name="bEmpty">Verifies if an array is empty. It is 'true' by default</param>
        /// <param name="bIsRoot">Set array as the root element of the response.It is 'false' by default.</param>
        /// <returns>Success object.</returns>
        public Success VerifyArrayEmpty(string sJPath, bool bEmpty = true, bool bIsRoot = false)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                JArray jObject = bIsRoot ? JArray.Parse(Response.Content) : (JArray)JObject.Parse(Response.Content).SelectToken(sJPath);

                if (bEmpty && jObject.Count != 0)
                    throw new Exception("Failed. Array is not empty." + (string)jObject.SelectToken(sJPath));

                if (!bEmpty && jObject.Count == 0)
                    throw new Exception("Failed. Array is empty." + (string)jObject.SelectToken(sJPath));

            }, this);

        }

        /// <summary>
        /// Method verifies if an array exists and contains a value.
        /// </summary>
        /// <param name="sJPath">Path to the json field.</param>
        /// <param name="dValue">Value to be verified.</param>
        /// <param name="bIsRoot">Set array as the root element of the response. It is false by default.</param>
        /// <returns>Success object.</returns>
        public Success VerifyArrayContains(string sJPath, dynamic dValue, bool bIsRoot = false, bool bContains = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                bool bFound = false;
                JArray jObject = bIsRoot ? JArray.Parse(Response.Content) : (JArray)JObject.Parse(Response.Content).SelectToken(sJPath);

                if (jObject.Count == 0)
                    throw new Exception("Failed. Array is empty." + (string)jObject.SelectToken(sJPath));

                foreach (dynamic item in jObject)
                {
                    if (item == dValue)
                    {
                        bFound = true;
                        break;
                    }
                }
                if (!bFound && bContains)
                    throw new Exception("Failed. Array does not contain expected value." + (string)jObject.SelectToken(sJPath));

                if (bFound && !bContains)
                    throw new Exception("Failed. Array contains the value but it should not contain it." + (string)jObject.SelectToken(sJPath));

            }, this);

        }
    }
}