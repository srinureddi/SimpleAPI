namespace SimpleAPI.Test;
using SimpleAPI.Controllers;
using Xunit;

public class UnitTest1
{
    ValuesController valuesController = new ValuesController();

    [Fact]
    public void GetReturnsMyName()
    {
        // Given
         
        var returnValue = valuesController.Get(1);
        Assert.Equal("Les Jackson",returnValue.Value);
        // When
    
        // Then

    }
    [Fact]
    public void Test1()
    {

    }
}