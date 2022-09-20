namespace Assignment2.NewClassLib;

public class ImmutableStudentTests
{
    [Fact]
    public void objectsShouldBeEqual()
    {
        // Arrange
        var s1 = new ImmutableStudent {id = 0, givenName = "Jens", surname = "Graduate", startDate = new DateTime(2017,1,1), endDate = new DateTime(2020,1,1), graduationDate = new DateTime(2020,1,1)};
        var s2 = new ImmutableStudent {id = 0, givenName = "Jens", surname = "Graduate", startDate = new DateTime(2017,1,1), endDate = new DateTime(2020,1,1), graduationDate = new DateTime(2020,1,1)};

        // Act
        Boolean test = (s1 == s2);

        // Assert
        test.Should().Be(true);  
    }

    [Fact]
    public void objectsShouldNOTBeEqual()
    {
        // Arrange
        var s1 = new ImmutableStudent {id = 0, givenName = "Jens", surname = "Graduate", startDate = new DateTime(2017,1,1), endDate = new DateTime(2020,1,1), graduationDate = new DateTime(2020,1,1)};
        var s2 = new ImmutableStudent {id = 0, givenName = "Hans", surname = "Graduate", startDate = new DateTime(2017,1,1), endDate = new DateTime(2020,1,1), graduationDate = new DateTime(2020,1,1)};

        // Act
        Boolean test = (s1 == s2);

        // Assert
        test.Should().Be(false);  
    }

[Fact]
    public void toStringShouldPrint()
    {
        // Arrange
        var s = new ImmutableStudent {id = 0, givenName = "Jens", surname = "Graduate", startDate = new DateTime(2017,1,1), endDate = new DateTime(2020,1,1), graduationDate = new DateTime(2020,1,1)};
        var comparisonString = "ImmutableStudent { id = 0, givenName = Jens, surname = Graduate, status = Graduate, startDate = 01/01/2017 00:00:00, endDate = 01/01/2020 00:00:00, graduationDate = 01/01/2020 00:00:00 }";
        // Act
        var testString = s.ToString();
        // Assert
        testString.Should().Be(comparisonString);  
    }
}
