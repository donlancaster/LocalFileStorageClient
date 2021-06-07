using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;
using System.Net;

namespace ksis3_client
{
   
    static class Client
    {
        static HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8080/")
        };
        static HttpMethod copyMethod = new HttpMethod("COPY"),
                    moveMethod = new HttpMethod("MOVE");
        public static HttpStatusCode statusCode;

        public static async Task<Stream> SendGetAsync(String s)
        {
            var result = await client.GetAsync(s);
            statusCode = result.StatusCode;
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsStreamAsync();
        }

        public static async Task SendPostAsync(String s, Stream stream)
        {
            var result = await client.PostAsync(s, GetByteArrayContent(stream));
            statusCode = result.StatusCode;
            result.EnsureSuccessStatusCode();
        }

        public static async Task SendPutAsync(String s, Stream stream)
        {
            var result = await client.PutAsync(s, GetByteArrayContent(stream));
            statusCode = result.StatusCode;
            result.EnsureSuccessStatusCode();
        }

        public static async Task SendDeleteAsync(String s)
        {
            var result = await client.DeleteAsync(s);
            statusCode = result.StatusCode;
            result.EnsureSuccessStatusCode();
        }

        public static async Task SendCopyAsync(String source, String destination)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = copyMethod;
            message.RequestUri = new Uri(client.BaseAddress + source);
            message.Headers.Add("destination", destination);
            var result = await client.SendAsync(message);
            statusCode = result.StatusCode;
            result.EnsureSuccessStatusCode();
        }

        public static async Task SendMoveAsync(String source, String destination)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = moveMethod;
            message.RequestUri = new Uri(client.BaseAddress + source);
            message.Headers.Add("destination", destination);
            var result = await client.SendAsync(message);
            statusCode = result.StatusCode;
            result.EnsureSuccessStatusCode();
        }

        private static ByteArrayContent GetByteArrayContent(Stream stream)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(stream))
            {
                bytes = br.ReadBytes((int)stream.Length);
            }
            return new ByteArrayContent(bytes);
        }
    }
}
