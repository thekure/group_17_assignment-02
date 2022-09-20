namespace Assignment2.NewClassLib;

public class StudentTests
{
    [Fact]
    public void StudentShouldBeGraduate()
    {
        // Arrange
        var student = new Student {id = 0, givenName = "Jens", surname = "Graduate", startDate = new DateTime(2017,1,1), endDate = new DateTime(2020,1,1), graduationDate = new DateTime(2020,1,1)};

        // Act

        // Assert
        student.status.Should().Be(Status.Graduate);
    }

    [Fact]
    public void StudentShouldBeNew()
    {
          // Arrange
        var student = new Student {id = 0, givenName = "Jens", surname = "New", startDate = new DateTime(2023,1,1), endDate = new DateTime(2027,1,1), graduationDate = new DateTime(2027,1,1)};

        // Act

        // Assert
        student.status.Should().Be(Status.New);
    }

    [Fact]
    public void StudentShouldBeActive()
    {
         // Arrange
        var student = new Student {id = 0, givenName = "Jens", surname = "Active", startDate = new DateTime(2017,1,1), endDate = new DateTime(2028,1,1), graduationDate = new DateTime(2028,1,1)};

        // Act
        // Assert
        student.status.Should().Be(Status.Active);
    }

    [Fact]
    public void StudentShouldBeDropout()
    {
          // Arrange
        var student = new Student {id = 0, givenName = "Jens", surname = "DropOut", startDate = new DateTime(2017,1,1), endDate = new DateTime(2018,1,1), graduationDate = new DateTime(2020,1,1)};

        // Act
        // Assert
        student.status.Should().Be(Status.Dropout);
    }
}
