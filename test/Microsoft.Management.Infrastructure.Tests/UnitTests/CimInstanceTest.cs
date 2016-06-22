namespace Microsoft.Management.Infrastructure.UnitTests
{    
    using System;
    using Microsoft.Management.Infrastructure;
    using Xunit;

    public class CimInstanceTest
    {
        [Fact]
        public void Constructor_ClassName_BasicTest()
        { 
            Console.WriteLine("We are testing!");
            CimAdd obj = new CimAdd();         
            Console.WriteLine("Test Hello World!");
            Assert.Equal(5, obj.Add(2, 3));      
        }

        [Fact]
        public void Constructor_ClassName_BasicTest2()
        { 
            Console.WriteLine("We are testing!");
            CimAdd obj = new CimAdd();         
            Console.WriteLine("Test Hello World!");
            Assert.Equal(4, obj.Add(2, 3));      
        }
    }
}