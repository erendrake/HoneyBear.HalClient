using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace iUS.Halclient.Http
{
    internal class HalJsonMediaTypeFormatter : JsonMediaTypeFormatter
    {
        public HalJsonMediaTypeFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/hal+json"));
        }
    }
}