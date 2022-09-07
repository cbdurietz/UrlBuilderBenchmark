using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace UrlBuilderBenchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class UrlBuilderBenchmarks
{
  private const string BrandUrl = "foo";
  private const string ProductUrl = "bar";

  [Benchmark]
  public void CreateUrlOriginal()
  {
    UrlBuilder.CreateUrlOriginal(BrandUrl, ProductUrl);
  }

  //[Benchmark]
  //public void CreateUrlOriginalWithoutNullCheck()
  //{
  //  UrlBuilder.CreateUrlOriginalWithoutNullCheck(BrandUrl, ProductUrl);
  //}

  [Benchmark]
  public void CreateUrlWithConcat()
  {
    UrlBuilder.CreateUrlWithConcat(BrandUrl, ProductUrl);
  }

  [Benchmark]
  public void CreateUrlWithExpandedConcat()
  {
    UrlBuilder.CreateUrlWithExpandedConcat(BrandUrl, ProductUrl);
  }

  //[Benchmark]
  //public void CreateUrlWithRegEx()
  //{
  //  UrlBuilder.CreateUrlWithRegEx(BrandUrl, ProductUrl);
  //}

  //[Benchmark]
  //public void CreateUrlWithInterpolation()
  //{
  //  UrlBuilder.CreateUrlWithInterpolation(BrandUrl, ProductUrl);
  //}

  //[Benchmark]
  //public void CreateUrlWithJoin()
  //{
  //  UrlBuilder.CreateUrlWithJoin(BrandUrl, ProductUrl);
  //}
}