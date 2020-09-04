using Demo.Animals;
using Xunit;

namespace Demo.Tests
{
    public class DogTest
    {
        [Fact]
        public void Should_return_wang()
        {
            IAnimal animal=new Dog();
            var result=animal.Talk();

            Assert.Contains("wang",result);
        }
    }
}