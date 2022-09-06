using UrlBuilderBenchmark;

namespace UrlBuilder_UnitTests {
    public class UrlBuilderUnitTests {

        public static IEnumerable<object[]> TestData => new List<object[]> {
            new object[] {"foo", "bar", "/foo/bar"},
            new object[] {"/foo", "bar", "/foo/bar"},
            new object[] {"foo", "/bar", "/foo/bar"},
            new object[] {"/foo", "/bar", "/foo/bar"},
            new object[] {"foo/", "bar/", "/foo/bar"},
            new object[] {"/foo/", "/bar", "/foo/bar"},
            new object[] {"/foo/", "/bar/", "/foo/bar"},
            new object[] {"//foo//", "//bar//", "/foo/bar"},
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void CreateUrlOriginal_Ok(string brandUrl, string productUrl, string expected) {
            //Act
            var sut = UrlBuilder.CreateUrlOriginal(brandUrl, productUrl);

            //Assert
            Assert.Equal(expected, sut);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void CreateUrlOriginalWithoutNullCheck_Ok(string brandUrl, string productUrl, string expected) {
            //Act
            var sut = UrlBuilder.CreateUrlOriginalWithoutNullCheck(brandUrl, productUrl);

            //Assert
            Assert.Equal(expected, sut);
        }


        [Theory]
        [MemberData(nameof(TestData))]
        public void CreateUrlWithConcat_Ok(string brandUrl, string productUrl, string expected) {
            //Act
            var sut = UrlBuilder.CreateUrlWithConcat(brandUrl, productUrl);

            //Assert
            Assert.Equal(expected, sut);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void CreateUrlWithRegEx_Ok(string brandUrl, string productUrl, string expected) {
            //Act
            var sut = UrlBuilder.CreateUrlWithRegEx(brandUrl, productUrl);

            //Assert
            Assert.Equal(expected, sut);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void CreateUrlWithTrim_Ok(string brandUrl, string productUrl, string expected) {
            //Act
            var sut = UrlBuilder.CreateUrlWithInterpolation(brandUrl, productUrl);

            //Assert
            Assert.Equal(expected, sut);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void CreateUrlWithJoin_Ok(string brandUrl, string productUrl, string expected) {
            //Act
            var sut = UrlBuilder.CreateUrlWithJoin(brandUrl, productUrl);

            //Assert
            Assert.Equal(expected, sut);
        }
    }
}