using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp1;

namespace unit_tests
{
    public class SampleTests
    {
        [Fact]
        public async Task Returns_a_number()
        {
            var number = Sample.TestMe(5);

            number.Should().Be(5);
        }

        [Fact]
        public async Task Throws_exception()
        {
            var number = Sample.TestMe(0);

            number.Should().Be(-1);
        }
    }
}
