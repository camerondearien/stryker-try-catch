using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp1;

namespace unit_tests
{
    public class SampleTests
    {
        [Fact]
        public async Task Just_A_Sample_Test()
        {
            var number = Sample.TestMe(5);

            number.Should().Be(5);
        }

    }
}
