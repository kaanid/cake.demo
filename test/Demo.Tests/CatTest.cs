using Demo.Animals;
using Xunit;

namespace Demo.Tests
{
    public class CatTest
    {
        [Fact]
        public void Should_return_miao()
        {
            IAnimal animal=new Cat();
            var result=animal.Talk();
            
            Assert.Contains("miao",result);
        }
    }
}