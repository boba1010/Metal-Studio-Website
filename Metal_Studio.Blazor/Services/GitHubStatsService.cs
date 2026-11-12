using Metal_Studio.Blazor.Models;
using Octokit;

namespace Metal_Studio.Blazor.Services;

public class GitHubStatsService(GitHubClient github)
{
    private const string Username = "boba1010";

    public async Task<GitHubStats?> GetStatsAsync()
    {
        var user = await github.User.Get(Username);
        var repos = await github.Repository.GetAllForUser(Username);

        try
        {
            var stats = new GitHubStats
            {
                PublicRepos = user.PublicRepos,
                Followers = user.Followers,
                TotalStars = repos.Sum(r => r.StargazersCount),
                TopLanguage = repos
                    .Where(r => r.Language != null)
                    .GroupBy(r => r.Language)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault()?.Key ?? "N/A"
            };

            return stats;
        }
        catch (RateLimitExceededException)
        {
            return null;
        }
    }
}
