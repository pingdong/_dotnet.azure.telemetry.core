using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PingDong.Azure.Telemetry
{
    public class PassThroughTelemetryService : ITelemetryService
    {
        /// <inheritdoc />
        public Task<HttpResponseMessage> TrackWebApiAsync(string correlationId, HttpRequestMessage request, Func<Task<HttpResponseMessage>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<HttpResponseMessage> TrackWebApiAsync(string correlationId, string requestMethod, Uri requestUri, Func<Task<HttpResponseMessage>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<HttpResponseMessage> TrackWebApiAsync(string correlationId, string requestMethod, string requestUri, Func<Task<HttpResponseMessage>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<T> TrackFunctionAsync<T>(string function, string type, string target, string data, Func<Task<T>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<T> TrackFunctionAsync<T>(string function, string type, string target, Func<Task<T>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<T> TrackFunctionAsync<T>(string function, string type, Func<Task<T>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task<T> TrackFunctionAsync<T>(string correlationId, string function, string type, string target, string data, Func<Task<T>> func)
        {
            return func();
        }
        
        /// <inheritdoc />
        public Task TrackActionAsync(string function, string type, string target, string data, Func<Task> action)
        {
            return action();
        }
        
        /// <inheritdoc />
        public Task TrackActionAsync(string function, string type, string target, Func<Task> action)
        {
            return action();
        }
        
        /// <inheritdoc />
        public Task TrackActionAsync(string function, string type, Func<Task> action)
        {
            return action();
        }
        
        /// <inheritdoc />
        public Task TrackActionAsync(string correlationId, string function, string type, string target, string data, Func<Task> action)
        {
            return action();
        }
    }
}
