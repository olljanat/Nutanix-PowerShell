namespace Sample.API
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    using SignalDelegateI = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>;
    using SignalDelegate = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task>;
    using GetParameterDelegate = System.Func<string, string, System.Collections.Generic.Dictionary<string,object>, string, object>;
    using SendAsyncStepDelegate = System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;
    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module
    {
        /// <summary>FIXME: Field _handler is MISSING DESCRIPTION</summary>
        public System.Net.Http.HttpClientHandler _handler = new System.Net.Http.HttpClientHandler();

        public System.Net.Http.HttpClientHandler _handlerSkipSSL = new System.Net.Http.HttpClientHandler();

        public System.Net.Http.HttpClientHandler _handlerDefaultSkipSSL = new System.Net.Http.HttpClientHandler();

       
        /// <summary>the ISendAsync pipeline instance</summary>
         private Microsoft.Rest.ClientRuntime.HttpPipeline _pipeline;

        /// <summary>the ISendAsync pipeline instance</summary>
         private Microsoft.Rest.ClientRuntime.HttpPipeline _pipelineWithSkipSSL;

        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
         private Microsoft.Rest.ClientRuntime.HttpPipeline _pipelineWithProxy;

        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
         private Microsoft.Rest.ClientRuntime.HttpPipeline _pipelineWithProxyWithSkipSSL;
        /// <summary>FIXME: Field _webProxy is MISSING DESCRIPTION</summary>
        public System.Net.WebProxy _webProxy = new System.Net.WebProxy();
        /// <summary>The instance of the Client API</summary>
        public Sample.API.NutanixIntentfulAPI ClientAPI {get;set;}
        /// <summary>Backing field for Instance property</summary>
        private static Sample.API.Module _instance;

        /// <summary>the singleton of this module class</summary>
        public static Sample.API.Module Instance => Sample.API.Module._instance?? (Sample.API.Module._instance = new Sample.API.Module());
        /// <summary>FIXME: Method AfterCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="boundParams">FIXME: Parameter boundParams is MISSING DESCRIPTION</param>
        /// <param name="pipeline">FIXME: Parameter pipeline is MISSING DESCRIPTION</param>
        partial void AfterCreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParams, ref Microsoft.Rest.ClientRuntime.HttpPipeline pipeline);
        /// <summary>FIXME: Method BeforeCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="boundParams">FIXME: Parameter boundParams is MISSING DESCRIPTION</param>
        /// <param name="pipeline">FIXME: Parameter pipeline is MISSING DESCRIPTION</param>
        partial void BeforeCreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParams, ref Microsoft.Rest.ClientRuntime.HttpPipeline pipeline);
        /// <summary>FIXME: Method CustomInit is MISSING DESCRIPTION</summary>

        partial void CustomInit();
        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="boundParameters">The bound parameters from the cmdlet call.</param>
        /// <returns>An instance of Microsoft.Rest.ClientRuntime.HttpPipeline for the remote call.</returns>
        public Microsoft.Rest.ClientRuntime.HttpPipeline CreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParameters)
        {
            Microsoft.Rest.ClientRuntime.HttpPipeline pipeline = null;
            BeforeCreatePipeline(boundParameters, ref pipeline);
            pipeline = (pipeline ?? (_handler.UseProxy ? _pipelineWithProxy : _pipeline)).Clone();
            AfterCreatePipeline(boundParameters, ref pipeline);
            return pipeline;
        }

        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="boundParameters">The bound parameters from the cmdlet call.</param>
        /// <returns>An instance of Microsoft.Rest.ClientRuntime.HttpPipeline for the remote call.</returns>
        public Microsoft.Rest.ClientRuntime.HttpPipeline CreatePipelineWithProxy(System.Collections.Generic.Dictionary<string,object> boundParameters)
        {    
            Microsoft.Rest.ClientRuntime.HttpPipeline pipeline = null;
            BeforeCreatePipeline(boundParameters, ref pipeline);
            pipeline = (pipeline ?? (_handlerSkipSSL.UseProxy ? _pipelineWithProxyWithSkipSSL : _pipelineWithSkipSSL)).Clone();
            AfterCreatePipeline(boundParameters, ref pipeline);
            return pipeline;
        }
        /// <summary>Initialization steps performed after the module is loaded.</summary>

        public void Init()
        {
            // called at module init time...
            CustomInit();
        }
        /// <summary>Creates the module instance.</summary>
        private Module()
        {
            /// constructor
            ClientAPI = new Sample.API.NutanixIntentfulAPI();
            _handler.Proxy = _webProxy;

            // SkipSSL handlers
            _handlerDefaultSkipSSL.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            _handlerSkipSSL.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            _handlerSkipSSL.Proxy = _webProxy;

            // var httpClientHandler = new System.Net.Http.HttpClientHandler();
            // httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            _pipeline = new Microsoft.Rest.ClientRuntime.HttpPipeline(new Microsoft.Rest.ClientRuntime.HttpClientFactory(new System.Net.Http.HttpClient()));
            _pipelineWithProxy = new Microsoft.Rest.ClientRuntime.HttpPipeline(new Microsoft.Rest.ClientRuntime.HttpClientFactory(new System.Net.Http.HttpClient(_handler)));

            // skip ssl pipelines
            _pipelineWithSkipSSL = new Microsoft.Rest.ClientRuntime.HttpPipeline(new Microsoft.Rest.ClientRuntime.HttpClientFactory(new System.Net.Http.HttpClient(_handlerDefaultSkipSSL)));
            _pipelineWithProxyWithSkipSSL = new Microsoft.Rest.ClientRuntime.HttpPipeline(new Microsoft.Rest.ClientRuntime.HttpClientFactory(new System.Net.Http.HttpClient(_handlerSkipSSL)));

        }
        /// <summary>FIXME: Method SetProxyConfiguration is MISSING DESCRIPTION</summary>
        /// <param name="proxy">FIXME: Parameter proxy is MISSING DESCRIPTION</param>
        /// <param name="proxyCredential">FIXME: Parameter proxyCredential is MISSING DESCRIPTION</param>
        /// <param name="proxyUseDefaultCredentials">FIXME: Parameter proxyUseDefaultCredentials is MISSING DESCRIPTION</param>
        public void SetProxyConfiguration(System.Uri proxy, System.Management.Automation.PSCredential proxyCredential, bool proxyUseDefaultCredentials)
        {
            // set the proxy configuration
            _webProxy.Address = proxy;
            _webProxy.BypassProxyOnLocal = false;
            _webProxy.Credentials = proxyCredential ?.GetNetworkCredential();
            _webProxy.UseDefaultCredentials = proxyUseDefaultCredentials;
            _handler.UseProxy = proxy != null;
            _handlerSkipSSL.UseProxy = proxy != null;
        }
    }
}