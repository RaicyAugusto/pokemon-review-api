using PokemonReviewApp.Models;

namespace PokemonreviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
        bool CreateReviewer (Reviewer reviewer);    
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();

    }
}
