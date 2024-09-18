//using BookSystem;
using FluentAssertions;
using System.Diagnostics.Metrics;

namespace BooksUnitTestEx1
{
    public class Author_Should
    {
        #region Constructor
        //[Fact]
        //public void Create_a_Good_Author()
        //{
        //    //Given - Arrange
        //    string expectedfirstname = "Lowan";
        //    string expectedlastname = "Behold";
        //    string expectedcontacturl = "lowanbehold.fantasy.ca";
        //    string expectedcity = "Edmonton";
        //    string expectedcountry = "Canada";

        //    //When - Act
        //    Author actual = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Then - Assert
        //    actual.FirstName.Should().Be(expectedfirstname);
        //    actual.LastName.Should().Be(expectedlastname);
        //    actual.ContactUrl.Should().Be(expectedcontacturl);
        //    actual.ResidentCity.Should().Be(expectedcity);
        //    actual.ResidentCountry.Should().Be(expectedcountry);
        //}
        
        //[Theory]
        //[InlineData(null, "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada")]
        //[InlineData("", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada")]
        //[InlineData("   ", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada")]
        //[InlineData("Lowan", null, "lowanbehold.fantasy.ca", "Edmonton", "Canada")]
        //[InlineData("Lowan", "", "lowanbehold.fantasy.ca", "Edmonton", "Canada")]
        //[InlineData("Lowan", "   ", "lowanbehold.fantasy.ca", "Edmonton", "Canada")]
        //[InlineData("Lowan", "Behold", null, "Edmonton", "Canada")]
        //[InlineData("Lowan", "Behold", "", "Edmonton", "Canada")]
        //[InlineData("Lowan", "Behold", "   ", "Edmonton", "Canada")]
        //[InlineData("Lowan", "Behold", "lowanbeholdfantasyca", "Edmonton", "Canada")]
        //[InlineData("Lowan", "Behold", "lowanbehold.fantasy.ca", null, "Canada")]
        //[InlineData("Lowan", "Behold", "lowanbehold.fantasy.ca", "", "Canada")]
        //[InlineData("Lowan", "Behold", "lowanbehold.fantasy.ca", "   ", "Canada")]
        //[InlineData("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", null)]
        //[InlineData("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "")]
        //[InlineData("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "    ")]
        //public void Throw_Exception_For_Bad_Data_Using_Constructor(string firstname,
        //            string lastname, string contacturl, string city, string country)
        //{
        //    //Arrange

        //    //Act
        //    Action action = () => new Author(firstname, lastname, contacturl, city, country);

        //    //Assert
        //    action.Should().Throw<ArgumentException>();
        //}
        #endregion

        #region Properties
        //[Fact]
        //public void Allow_Change_To_FirstName()
        //{
        //    //Arrange
        //    Author actual = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
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
        //public  void Throw_Exception_For_Changing_FirstName(string firstname)
        //{
        //    //Arrange
        //    Author actual = new Author("lowand", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Act
        //    Action action = () => actual.FirstName = firstname;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}

        //[Fact]
        //public void Allow_Change_To_LastName()
        //{
        //    //Arrange
        //    Author actual = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
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
        //    Author actual = new Author("lowand", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Act
        //    Action action = () => actual.LastName = lastname;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}

        //[Theory]
        //[InlineData("BobBehold.fantasy")]
        //[InlineData("BobBehold.fantasy.world.com")]
        //[InlineData(@"http://www.BobBehold.fantasy")]
        //[InlineData(@"https://www.BobBehold.fantasy")]
        //public void Allow_Change_To_ContactUrl(string contacturl)
        //{
        //    //Arrange
        //    Author actual = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
          

        //    //Act
        //    actual.ContactUrl = contacturl;

        //    //Assert
        //    actual.ContactUrl.Should().Be(contacturl);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_ContactUrl_Missing_Data(string contacturl)
        //{
        //    //Arrange
        //    Author actual = new Author("lowand", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Act
        //    Action action = () => actual.ContactUrl = contacturl;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}
        //[Fact]
       
        //public void Throw_Exception_For_Changing_ContactUrl_Bad_URL_Pattern()
        //{
        //    //Arrange
        //    Author actual = new Author("lowand", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Act
        //    Action action = () => actual.ContactUrl = "badpattern";

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*acceptable url pattern*");
        //}
        //[Fact]
        //public void Allow_Change_To_City()
        //{
        //    //Arrange
        //    Author actual = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
        //    string expectedcity = "Calgary";

        //    //Act
        //    actual.ResidentCity = "Calgary";

        //    //Assert
        //    actual.ResidentCity.Should().Be(expectedcity);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_City(string city)
        //{
        //    //Arrange
        //    Author actual = new Author("lowand", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Act
        //    Action action = () => actual.ResidentCity = city;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}
        //[Fact]
        //public void Allow_Change_To_Country()
        //{
        //    //Arrange
        //    Author actual = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
        //    string expectedcountry = "England";

        //    //Act
        //    actual.ResidentCountry = "England";

        //    //Assert
        //    actual.ResidentCountry.Should().Be(expectedcountry);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_Country(string country)
        //{
        //    //Arrange
        //    Author actual = new Author("lowand", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");

        //    //Act
        //    Action action = () => actual.ResidentCountry = country;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}
        #endregion
        
        #region Methods
        //[Fact]
        //public void Return_Expected_CSV_String()
        //{
        //    //Arrange
        //    Author author = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
        //    string expectedCSV = "Lowan,Behold,lowanbehold.fantasy.ca,Edmonton,Canada";
        //    //Act
        //    string actual = author.ToString();

        //    //Assert
        //    actual.Should().Be(expectedCSV);
        //}
        //[Fact]
        //public void Return_Expected_Author_FullName()
        //{
        //    //Arrange
        //    Author author = new Author("Lowan", "Behold", "lowanbehold.fantasy.ca", "Edmonton", "Canada");
        //    string expectedfullname = "Behold, Lowan";
        //    //Act
        //    string actual = author.AuthorName;

        //    //Assert
        //    actual.Should().Be(expectedfullname);
        //}
        #endregion
    }
}