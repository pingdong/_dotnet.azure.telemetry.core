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
        /// <param name="request">Http request</param>
        /// <returns></returns>
        Task<HttpResponseMessage> TrackApiCallAsync(HttpRequestMessage request, Func<Task<HttpResponseMessage>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="func">The func that executes the call</param>
        /// <param name="requestMethod">Http method</param>
        /// <param name="requestUri">Uri of the request</param>
        /// <returns></returns>
        Task<HttpResponseMessage> TrackApiCallAsync(string requestMethod, Uri requestUri, Func<Task<HttpResponseMessage>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="func">The func that executes the call</param>
        /// <param name="requestMethod">Http method</param>
        /// <param name="requestUri">Uri of the request</param>
        /// <returns></returns>
        Task<HttpResponseMessage> TrackApiCallAsync(string requestMethod, string requestUri, Func<Task<HttpResponseMessage>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="funcName">The name of func</param>
        /// <param name="data">Data</param>
        /// <param name="func">The func that executes the call</param>
        /// <param name="target">Target</param>
        /// <returns></returns>
        Task<T> TrackCallAsync<T>(string target, string funcName, string data, Func<Task<T>> func);

        /// <summary>
        /// Track api call
        /// </summary>
        /// <param name="funcName">The name of func</param>
        /// <param name="data">Data</param>
        /// <param name="func">The func that executes the call</param>
        /// <param name="target">Target</param>
        /// <returns></returns>
        Task TrackCallAsync(string target, string funcName, string data, Func<Task> func);
    }
}
