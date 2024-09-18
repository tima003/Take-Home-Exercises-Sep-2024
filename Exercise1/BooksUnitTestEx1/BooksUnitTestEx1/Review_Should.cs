//using BookSystem;
using FluentAssertions;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace BooksUnitTestEx1
{
    public class Review_Should
    {
        #region Constructor
        //[Fact]
        //public void Create_a_Good_Review()
        //{
        //    //Given - Arrange
        //    string expectedISBN = "978-0-7653-8669-4";
        //    RatingType expectedRating = RatingType.Buy;
        //    string expectedcomment = "... great read for a lazy day by the pool";
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");

        //    //When - Act

        //    Review actual = new Review("978-0-7653-8669-4", reviewer,
        //        RatingType.Buy, "... great read for a lazy day by the pool");

        //    //Then - Assert
        //    actual.ISBN.Should().Be(expectedISBN);
        //    actual.Reviewer.Should().Be(reviewer);
        //    actual.Rating.Should().Be(expectedRating);
        //    actual.Comment.Should().Be(expectedcomment);

        //}

        //[Theory]
        //[InlineData(null, "... great read for a lazy day by the pool")]
        //[InlineData("", "... great read for a lazy day by the pool")]
        //[InlineData("   ", "... great read for a lazy day by the pool")]
        //[InlineData("978-0-7653-8669-4", null)]
        //[InlineData("978-0-7653-8669-4", "")]
        //[InlineData("978-0-7653-8669-4", "   ")]
      
        //public void Throw_Exception_For_Bad_Data_Using_Constructor_With_Reviewer(string isbn,
        //            string comment)
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");

        //    //Act
        //    Action action = () => new Review(isbn, reviewer, RatingType.Buy, comment);

        //    //Assert
        //    action.Should().Throw<ArgumentException>();
        //}

        //[Fact]
        //public void Throw_Exception_For_Bad_Data_Using_Constructor_Without_Reviewer()
        //{
        //    //Arrange

        //    //Act
        //    Action action = () => new Review("978-0-7653-8669-4", null, RatingType.Buy,
        //                                        "... great read for a lazy day by the pool");

        //    //Assert
        //    action.Should().Throw<ArgumentException>();
        //}
        #endregion
        
        #region Properties
        //[Fact]
        //public void Allow_Change_To_ISBN()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");

        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                        "... great read for a lazy day by the pool");
        //    string expectedisbn = "111-0-7653-2222-4";
        //    //Act
        //    actual.ISBN = "111-0-7653-2222-4";

        //    //Assert
        //    actual.ISBN.Should().Be(expectedisbn);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_ISBN(string isbn)
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");

        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                        "... great read for a lazy day by the pool");
        //    //Act
        //    Action action = () => actual.ISBN = isbn;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}

        //[Fact]
        //public void Allow_Change_To_Reviewer()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                       "... great read for a lazy day by the pool");
        //    Reviewer expectedreviewer = new Reviewer("Bob", "Bee", "BBee@somewhere.net", "Fantasy Worlds");
        //    //Act
        //    actual.Reviewer = expectedreviewer;

        //    //Assert
        //    actual.Reviewer.Should().Be(expectedreviewer);
        //}

        //[Fact]
        //public void Throw_Exception_For_Changing_Reviewer()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                      "... great read for a lazy day by the pool");

        //    //Act
        //    Action action = () => actual.Reviewer = null;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}
        //[Fact]
        //public void Allow_Change_To_RatingType()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                       "... great read for a lazy day by the pool");
        //    RatingType expectedrating = RatingType.MustHave;
        //    //Act
        //    actual.Rating = RatingType.MustHave; ;

        //    //Assert
        //    actual.Rating.Should().Be(expectedrating);
        //}
        //[Fact]
        //public void Allow_Change_To_Comment()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                       "... great read for a lazy day by the pool");
        //    string expectedcomment = "complex, entertaining, a puzzle to solve";
        //    //Act
        //    actual.Comment = "complex, entertaining, a puzzle to solve";

        //    //Assert
        //    actual.Comment.Should().Be(expectedcomment);
        //}
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("   ")]
        //public void Throw_Exception_For_Changing_Comment(string comment)
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    Review actual = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                      "... great read for a lazy day by the pool");

        //    //Act
        //    Action action = () => actual.Comment = comment;

        //    //Assert
        //    action.Should().Throw<ArgumentException>().WithMessage("*is required*");
        //}
        #endregion
        
        #region Methods
        //[Fact]
        //public void Return_Expected_CSV_String()
        //{
        //    //Arrange
        //    Reviewer reviewer = new Reviewer("Lowan", "Behold", "LBehold@somewhere.net", "Fantasy Worlds");
        //    Review review = new Review("978-0-7653-8669-4", reviewer, RatingType.Buy,
        //                                    "... great read for a lazy day by the pool");
        //    string expectedCSV = "978-0-7653-8669-4,Lowan,Behold,LBehold@somewhere.net,Fantasy Worlds,Buy,... great read for a lazy day by the pool";
        //    //Act
        //    string actual = review.ToString();

        //    //Assert
        //    actual.Should().Be(expectedCSV);
        //}
       
        #endregion

    }
}
