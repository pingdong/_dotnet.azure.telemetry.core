using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PingDong.Azure.Telemetry
{
    public class PassThroughTelemetryService : ITelemetryService
    {
        /// <inheritdoc />
        public Task<HttpResponseMessage> TrackApiCallAsync(HttpRequestMessage request, Func<Task<HttpResponseMessage>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<HttpResponseMessage> TrackApiCallAsync(string requestMethod, Uri requestUri, Func<Task<HttpResponseMessage>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<HttpResponseMessage> TrackApiCallAsync(string requestMethod, string requestUri, Func<Task<HttpResponseMessage>> func)
        {
            return func();
        }

        public Task<T> TrackCallAsync<T>(string target, string funcName, string data, Func<Task<T>> func)
        {
            return func();
        }

        public Task TrackCallAsync(string target, string funcName, string data, Func<Task> func)
        {
            return func();
        }
    }
}
