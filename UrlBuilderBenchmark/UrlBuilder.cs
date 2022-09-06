using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UrlBuilderBenchmark {
    public class UrlBuilder {

        public static string CreateUrlOriginal(string brandUrl, string productUrl)
        {
            return !string.IsNullOrWhiteSpace(brandUrl) ? (brandUrl + productUrl.TrimStart('/')) : productUrl;
        }
        public static string CreateUrlOriginalWithoutNullCheck(string brandUrl, string productUrl)
        {
            return brandUrl + productUrl.TrimStart('/');
        }

        public static string CreateUrlWithConcat(string brandUrl, string productUrl)
        {
            return "/" + brandUrl.Trim('/') + "/" + productUrl.Trim('/');
        }

        public static string CreateUrlWithRegEx(string brandUrl, string productUrl)
        {
            return Regex.Replace($"/{brandUrl}/{productUrl.TrimEnd('/')}", "/+", "/");
        }

        public static string CreateUrlWithInterpolation(string brandUrl, string productUrl)
        {
            return $"/{brandUrl.Trim('/')}/{productUrl.Trim('/')}";
        }
        
        public static string CreateUrlWithJoin(string brandUrl, string productUrl)
        {
            return "/" + string.Join('/', brandUrl.Trim('/'), productUrl.Trim('/'));
        }

    }
}
