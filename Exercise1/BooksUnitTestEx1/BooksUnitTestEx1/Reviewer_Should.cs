//using BookSystem;
using FluentAssertions;
using System.Diagnostics.Metrics;

namespace BooksUnitTestEx1
{
    public class Reviewer_Should
    {
        #region Constructor
        //[Theory]
        //[InlineData("Fantasy Worlds")]
        //[InlineData(null)]
        //public void Create_a_Good_Reviewer(string expectedorganization)
        //{
        //    //Given - Arrange
        //    string expectedfirstname = "Lowan";
        //    string expectedlastname = "Behold";
        //    string expectedemail = "LBehold@somewhere.net";
            
        //    //When - Act
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", expectedorganization);

        //    //Then - Assert
        //    actual.FirstName.Should().Be(expectedfirstname);
        //    actual.LastName.Should().Be(expectedlastname);
        //    actual.Email.Should().Be(expectedemail);
        //    actual.Organization.Should().Be(expectedorganization);
           
        //}

        //[Theory]
        //[InlineData(null, "Behold", "LBehold@somewhere.net", "Fantasy Worlds")]
        //[InlineData("", "Behold", "LBehold@somewhere.net", "Fantasy Worlds")]
        //[InlineData("   ", "Behold", "LBehold@somewhere.net", "Fantasy Worlds")]
        //[InlineData("Lowan", null, "LBehold@somewhere.net", "Fantasy Worlds")]
        //[InlineData("Lowan", "", "LBehold@somewhere.net", "Fantasy Worlds")]
        //[InlineData("Lowan", "   ", "LBehold@somewhere.net", "Fantasy Worlds")]
        //[InlineData("Lowan", "Behold", null, "Fantasy Worlds")]
        //[InlineData("Lowan", "Behold", "", "Fantasy Worlds")]
        //[InlineData("Lowan", "Behold", "   ", "Fantasy Worlds")]
        //[InlineData("Lowan", "Behold", "LBehold.somewhere.net", "Fantasy Worlds")]
        //public void Throw_Exception_For_Bad_Data_Using_Constructor(string firstname,
        //            string lastname, string email, string organization)
        //{
        //    //Arrange

        //    //Act
        //    Action action = () => new Reviewer(firstname, lastname, email, organization);

        //    //Assert
        //    action.Should().Throw<ArgumentException>();
        //}
        #endregion
        
        #region Properties
        //[Fact]
        //public void Allow_Change_To_FirstName()
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    string expectedfirstname = "Bob";
        //    //Act
        //    actual.FirstName = "Bob";

        //    //Assert
        //    actual.FirstName.Should().Be(expectedfirstname);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_FirstName(string firstname)
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");

        //    //Act
        //    Action action = () => actual.FirstName = firstname;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}

        //[Fact]
        //public void Allow_Change_To_LastName()
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    string expectedlastname = "Bob";
        //    //Act
        //    actual.LastName = "Bob";

        //    //Assert
        //    actual.LastName.Should().Be(expectedlastname);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_LastName(string lastname)
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");

        //    //Act
        //    Action action = () => actual.LastName = lastname;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}

        //[Theory]
        //[InlineData("BobBehold@fantasy.net")]
        //[InlineData("Bob.Behold@fantasyworld.com")]
        //[InlineData("Bob.Behold@fantasy.world.com")]
        //[InlineData("Bob-Behold@fantasy.world.com")]
        //public void Allow_Change_To_Email(string email)
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "lowanbehold@fantasy.ca", "Fantasy Worlds");


        //    //Act
        //    actual.Email = email;

        //    //Assert
        //    actual.Email.Should().Be(email);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_Email_Missing_Data(string email)
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "lowanbehold@fantasy.ca", "Fantasy Worlds");

        //    //Act
        //    Action action = () => actual.Email = email;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}
        //[Theory]
        //[InlineData("BobBehold.fantasy.net")]
        //[InlineData("Bob Behold@fantasyworld.com")]
        //[InlineData("Bob.Behold@fantasy")]
        

        //public void Throw_Exception_For_Changing_Email_Bad_URL_Pattern(string email)
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "lowanbehold@fantasy.ca", "Fantasy Worlds");

        //    //Act
        //    Action action = () => actual.Email = email;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*acceptable email address pattern*");
        //}
        //[Theory]
        //[InlineData("Make Believe")]
        //[InlineData(null)]
        //public void Allow_Change_To_Organization(string organization)
        //{
        //    //Arrange
        //    Reviewer actual = new Reviewer("Lowan", "Behold", "lowanbehold@fantasy.ca", "Fantasy Worlds");
          

        //    //Act
        //    actual.Organization = organization;

        //    //Assert
        //    actual.Organization.Should().Be(organization);
        //}
        
      
        #endregion
        
        #region Methods
        //[Fact]
        //public void Return_Expected_CSV_String()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    string expectedCSV = "Lowan,Behold,LBehold@somewhere.net,Fantasy Worlds";
        //    //Act
        //    string actual = reviewer.ToString();

        //    //Assert
        //    actual.Should().Be(expectedCSV);
        //}
        //[Fact]
        //public void Return_Expected_Reviewer_FullName()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    string expectedfullname = "Behold, Lowan";
        //    //Act
        //    string actual = reviewer.ReviewerName;

        //    //Assert
        //    actual.Should().Be(expectedfullname);
        //}
        #endregion
    }
}
