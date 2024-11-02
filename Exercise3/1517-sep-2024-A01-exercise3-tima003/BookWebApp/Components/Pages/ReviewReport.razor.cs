using System.Net.NetworkInformation;
using System.Diagnostics.Eventing.Reader;
using BookSystem;
using Microsoft.AspNetCore.Components;

namespace BookWebApp.Components.Pages
{
    public partial class ReviewReport : ComponentBase
    {
        private string feedback = "";
        private List<string> errormsgs { get; set; } = new List<string>();
        private List<Review> reviews = null;
        private Review review = null;

        private Exception GetInnerException(Exception ex)
        {
            //drill down into your Exception until there are no more inner exceptions
            //at this point you have the "real" error
            while (ex.InnerException != null)
                ex = ex.InnerException;
            return ex;

        }

        protected override void OnInitialized()
        {
            Reading();
            base.OnInitialized();
        }

        private void Reading()
        {
            feedback = "";
            errormsgs.Clear();


            string filepathname = @"./Data/";
            string[] filenames = new string[] { "TestData.csv" };
            string filename = @$"{filepathname}{filenames[0]}";



            Array userdata = null;

            try
            {
                if (System.IO.File.Exists(filename))
                {

                    reviews = new List<Review>();


                    userdata = System.IO.File.ReadAllLines(filename);


                    foreach (string line in userdata)
                    {
                        review = Review.Parse(line);
                        reviews.Add(review);
                    }
                }
                else
                {
                    throw new Exception($"File {filenames[0]} does not exist");
                }
            }
            catch (Exception ex)
            {
                errormsgs.Add(GetInnerException(ex).Message);
            }

        }

    }
}

