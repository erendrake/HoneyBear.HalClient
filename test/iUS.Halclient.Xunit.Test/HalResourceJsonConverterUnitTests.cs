using FluentAssertions;
using iUS.Halclient.Models;
using iUS.Halclient.Serialization;
using Newtonsoft.Json;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoRhinoMock;
using Ploeh.SemanticComparison.Fluent;
using Xunit;

namespace iUS.Halclient.Test
{
    public class HalResourceJsonConverterUnitTests
    {
        private TestContext _context;

        public HalResourceJsonConverterUnitTests ()
        {
            _context = new TestContext();
        }

        [Fact]
        public void Writing_JSON_makes_no_difference_to_the_serialization()
        {
            _context.Act();
        }

        [Fact]
        public void Can_convert_Hal_resource()
        {
            _context.CanConvertHalResource();
        }

        private class TestContext
        {
            private readonly JsonWriter _writer;
            private readonly JsonSerializer _serializer;
            private readonly iUS.Halclient.Serialization.HalResourceJsonConverter _sut;
            private readonly object _obj;

            public TestContext()
            {
                var fixture = new Fixture().Customize(new AutoRhinoMockCustomization());

                _writer = fixture.Create<JsonWriter>();
                _obj = fixture.Create<object>();
                _serializer = fixture.Create<JsonSerializer>();

                _sut = fixture.Create<HalResourceJsonConverter>();
            }

            public void Act()
            {
                _sut.WriteJson(_writer, _obj, _serializer);
            }

            public void CanConvertHalResource()
            {
                _sut.CanConvert(typeof(Resource)).Should().BeTrue();
            }
        }
    }
}