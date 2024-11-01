using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;
using BookSystem;

namespace BookWebApp.Components.Pages
{
    public partial class ReviewCollections : ComponentBase
    {
        
        private string ISBN = "";
        private string Title = "";
        private string Author = "";
        private string Reviewer = "";
        private string Comment = "";
        private RatingType Rating;

        private string feedback = "";
        private Dictionary<string, string> errormsgs = new();
        private Author _author = new Author();

        
        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        public IWebHostEnvironment webHostEnvironment { get; set; }

        [Inject]
        private NavigationManager navigationManager { get; set; }

        
        

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        // Method to retrieve the innermost exception message
        private Exception GetInnerException(Exception ex)
        {
            while (ex.InnerException != null)
                ex = ex.InnerException;
            return ex;
        }

        // Validate and collect review data
        private void OnCollect()
        {
            feedback = "";
            errormsgs.Clear();

            // Validation checks
            if (string.IsNullOrWhiteSpace(ISBN))
                errormsgs.Add("ISBN", "ISBN is required.");
            if (string.IsNullOrWhiteSpace(Title))
                errormsgs.Add("Title", "Title is required.");
            if (string.IsNullOrWhiteSpace(Author))
                errormsgs.Add("Author", "Author is required.");
            if (string.IsNullOrWhiteSpace(Reviewer))
                errormsgs.Add("Reviewer", "Reviewer name is required.");
            if (string.IsNullOrWhiteSpace(Comment))
                errormsgs.Add("Comment", "Comment is required.");
            if (Rating == RatingType.MustHave) 
                errormsgs.Add("Rating", "Please select a valid rating.");

            if (errormsgs.Count == 0)
            {
                try
                {
                   
                    var review = new Review(ISBN, Title, Author, Reviewer, Rating, Comment);
                    feedback = $"Entered review for '{Title}' by {Author}";

                    
                    string appPathName = webHostEnvironment.ContentRootPath;
                    string csvFilePathName = Path.Combine(appPathName, "Data/TestData.csv");
                    string line = $"{review}\n";
                    File.AppendAllText(csvFilePathName, line);
                }
                catch (Exception ex)
                {
                    errormsgs.Add($"System Error", GetInnerException(ex).Message);
                }
            }
        }

        // Clear form fields and reset validation errors
        private async Task OnClear()
        {
            feedback = "";
            if (await JSRuntime.InvokeAsync<bool>("confirm", "Clearing will lose all unsaved data. Are you sure?"))
            {
                errormsgs.Clear();
                ISBN = "";
                Title = "";
                Author = "";
                Reviewer = "";
                Comment = "";
            }
        }

        // Navigate to the report page
        private void GoToReport()
        {
            navigationManager.NavigateTo("reviewReport");
        }
    }
}
