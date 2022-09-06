using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace UrlBuilderBenchmark {
    
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class UrlBuilderBenchmarks
    {
        private const string _brandUrl = "foo";
        private const string _productUrl = "bar";

        private static readonly UrlBuilder UrlBuilder = new();

        [Benchmark]
        public void CreateUrlOriginal()
        {
            UrlBuilder.CreateUrlOriginal(_brandUrl, _productUrl);
        }

        [Benchmark]
        public void CreateUrlOriginalWithoutNullCheck()
        {
            UrlBuilder.CreateUrlOriginalWithoutNullCheck(_brandUrl, _productUrl);
        }

        [Benchmark]
        public void CreateUrlWithConcat()
        {
            UrlBuilder.CreateUrlWithConcat(_brandUrl, _productUrl);
        }

        [Benchmark]
        public void CreateUrlWithRegEx()
        {
            UrlBuilder.CreateUrlWithRegEx(_brandUrl, _productUrl);
        }

        [Benchmark]
        public void CreateUrlWithInterpolation()
        {
            UrlBuilder.CreateUrlWithInterpolation(_brandUrl, _productUrl);
        }

        [Benchmark]
        public void CreateUrlWithJoin()
        {
            UrlBuilder.CreateUrlWithJoin(_brandUrl, _productUrl);
        }
    }
}
