using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PingDong.Azure.Telemetry
{
    public interface ITelemetryService
    {
        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="func">The func that executes the call</param>
        /// <param name="correlationId">Correlation Id</param>
        /// <param name="request">Http request</param>
        /// <returns></returns>
        Task<HttpResponseMessage> TrackWebApiAsync(string correlationId, HttpRequestMessage request, Func<Task<HttpResponseMessage>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="func">The func that executes the call</param>
        /// <param name="correlationId">Correlation Id</param>
        /// <param name="requestMethod">Http method</param>
        /// <param name="requestUri">Uri of the request</param>
        /// <returns></returns>
        Task<HttpResponseMessage> TrackWebApiAsync(string correlationId, string requestMethod, Uri requestUri, Func<Task<HttpResponseMessage>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="func">The func that executes the call</param>
        /// <param name="correlationId">Correlation Id</param>
        /// <param name="requestMethod">Http method</param>
        /// <param name="requestUri">Uri of the request</param>
        /// <returns></returns>
        Task<HttpResponseMessage> TrackWebApiAsync(string correlationId, string requestMethod, string requestUri, Func<Task<HttpResponseMessage>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="function">The name of func</param>
        /// <param name="data"></param>
        /// <param name="func">The func that executes the call</param>
        /// <param name="type"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        Task<T> TrackFunctionAsync<T>(string function, string type, string target, string data, Func<Task<T>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="function">The name of func</param>
        /// <param name="target"></param>
        /// <param name="type"></param>
        /// <param name="func">The func that executes the call</param>
        /// <returns></returns>
        Task<T> TrackFunctionAsync<T>(string function, string type, string target, Func<Task<T>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="function">The name of func</param>
        /// <param name="type"></param>
        /// <param name="func">The func that executes the call</param>
        /// <returns></returns>
        Task<T> TrackFunctionAsync<T>(string function, string type, Func<Task<T>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="correlationId"></param>
        /// <param name="function">The name of func</param>
        /// <param name="data"></param>
        /// <param name="func">The func that executes the call</param>
        /// <param name="type"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        Task<T> TrackFunctionAsync<T>(string correlationId, string function, string type, string target, string data, Func<Task<T>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="function">The name of func</param>
        /// <param name="data"></param>
        /// <param name="action">The func that executes the call</param>
        /// <param name="type"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        Task TrackActionAsync(string function, string type, string target, string data, Func<Task> action);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="function">The name of func</param>
        /// <param name="target"></param>
        /// <param name="type"></param>
        /// <param name="action">The func that executes the call</param>
        /// <returns></returns>
        Task TrackActionAsync(string function, string type, string target, Func<Task> action);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="function">The name of func</param>
        /// <param name="type"></param>
        /// <param name="action">The func that executes the call</param>
        /// <returns></returns>
        Task TrackActionAsync(string function, string type, Func<Task> action);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="correlationId"></param>
        /// <param name="function">The name of func</param>
        /// <param name="data"></param>
        /// <param name="action">The func that executes the call</param>
        /// <param name="type"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        Task TrackActionAsync(string correlationId, string function, string type, string target, string data, Func<Task> action);
    }
}
