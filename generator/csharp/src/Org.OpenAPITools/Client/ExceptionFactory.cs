/* 
 * Swagger Petstore
 *
 * A sample API that uses a petstore as an example to demonstrate features in the swagger-2.0 specification
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using RestSharp.Portable;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
