using Metal_Studio.Models;

namespace Metal_Studio.Repos;

public static class ProjectsRepo
{
    public static List<Project> Projects { get; } = 
    [
        new()
        {
            Title = "Vulcan",
            Description = "Cross platform low level graphics API",
            GithubUrl = "https://github.com/boba1010/vulcan",
            Technologies =
            [
                new("C#"),
                new("Silk.NET"),
            ],
            Images = []
        },
        new()
        {
            Title = "WinUI Installer",
            Description = "A Native WinUI 3 Installer built with full native controls",
            GithubUrl = "https://github.com/boba1010/winui-installer",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
            ],
            Images =
            [
                new("WinUI Installer app", "images/winuiinstallerapp.png"),
            ],
        },
        new()
        {
            Title = "<Codebase/>",
            Description = "Interactive C# learning platform available on desktop, web, and mobile.",
            GithubUrl = "https://github.com/boba1010/CSharp_Interactive_learning_Platform",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
                //new() { BadgeTitle = ".NET MAUI" },
                //new() { BadgeTitle = "Blazor" },
                new("ASP.NET"),
            ],
            Images =
            [
                new("Codebase WinUI app", "images/codebasewinuiapp.png"),
                //new("Codebase MAUI app", "images/codebasemauiapp.png"),
                //new("Codebase Blazor app", "images/codebaseblazorapp.png"),
            ],
        },
        new()
        {
            Title = "Nativefy",
            Description = "Serverless youtube client",
            GithubUrl = "https://github.com/boba1010/nativefy",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
            ],
            Images =
            [
                new("Nativefy", "images/nativefy-1.png"),
                new("Nativefy", "images/nativefy-2.png"),
                new("Nativefy", "images/nativefy-3.png"),
            ],
        },
        new()
        {
            Title = "Visual Block Studio",
            Description = "Xaml Visual Editor",
            GithubUrl = "https://github.com/boba1010/visual-block-studio/tree/VBS_Gen2",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
            ],
            Images =
            [
                new("Visual Block Studio", "images/vbs-1.png"),
                new("Visual Block Studio", "images/vbs-2.png"),
                new("Visual Block Studio", "images/vbs-3.png"),
                new("Visual Block Studio", "images/vbs-4.png"),
                new("Visual Block Studio", "images/vbs-5.png"),
                new("Visual Block Studio", "images/vbs-6.png"),
            ],
        },
        new()
        {
            Title = "Crafty",
            Description = "Voxel game",
            GithubUrl = "https://github.com/boba1010/crafty-game-engine",
            Technologies =
            [
                new("C#"),
                new("Vulcan"),
            ],
            Images =
            [
                new("Crafty", "images/crafty-1.png"),
                new("Crafty", "images/crafty-2.png"),
                new("Crafty", "images/crafty-3.png"),
            ],
        },
        new()
        {
            Title = "Crafty Website",
            Description = "Blazor WASM",
            GithubUrl = "https://github.com/boba1010/Crafty_Website",
            Technologies =
            [
                new("C#"),
                new("Blazor"),
            ],
            Images =
            [
                new("Crafty", "images/crafty_website-1.png"),
                new("Crafty", "images/crafty_website-2.png"),
                new("Crafty", "images/crafty_website-3.png"),
                new("Crafty", "images/crafty_website-4.png"),
                new("Crafty", "images/crafty_website-5.png"),
                new("Crafty", "images/crafty_website-6.png"),
            ],
        },
        new()
        {
            Title = "Nativefy",
            Description = "Blazor WASM",
            GithubUrl = "https://github.com/boba1010/Nativefy_Website",
            Technologies =
            [
                new("C#"),
                new("Blazor"),
            ],
            Images =
            [
                new("Nativefy", "images/nativefy_website-1.png"),
                new("Nativefy", "images/nativefy_website-2.png"),
                new("Nativefy", "images/nativefy_website-3.png"),
                new("Nativefy", "images/nativefy_website-4.png"),
                new("Nativefy", "images/nativefy_website-5.png"),
                new("Nativefy", "images/nativefy_website-6.png"),
                new("Nativefy", "images/nativefy_website-7.png"),
                new("Nativefy", "images/nativefy_website-8.png"),
            ],
        },
        new()
        {
            Title = "Crafty Launcher",
            Description = "WinUI 3 Application",
            GithubUrl = "https://github.com/boba1010/Crafty.Launcher",
            Technologies =
            [
                new("WinUI3"),
                new("C#"),
            ],
            Images =
            [
                new("Nativefy", "images/crafty_launcher-1.png"),
                new("Nativefy", "images/crafty_launcher-2.png"),
                new("Nativefy", "images/crafty_launcher-3.png"),
                new("Nativefy", "images/crafty_launcher-4.png"),
                new("Nativefy", "images/crafty_launcher-5.png"),
                new("Nativefy", "images/crafty_launcher-6.png"),
                new("Nativefy", "images/crafty_launcher-7.png"),
                new("Nativefy", "images/crafty_launcher-8.png"),
            ],
        }
    ];

    public static List<Project> FeaturedProjects { get; } = 
    [
        new()
        {
            Title = "Vulcan",
            Description = "Cross platform low level graphics API",
            GithubUrl = "https://github.com/boba1010/vulcan",
            Technologies =
            [
                new("C#"),
                new("Silk.NET"),
            ],
            Images = []
        },
        new()
        {
            Title = "WinUI Installer",
            Description = "A Native WinUI 3 Installer built with full native controls",
            GithubUrl = "https://github.com/boba1010/winui-installer",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
            ],
            Images =
            [
                new("WinUI Installer app", "images/winuiinstallerapp.png"),
            ],
        },
        new()
        {
            Title = "<Codebase/>",
            Description = "Interactive C# learning platform available on desktop, web, and mobile.",
            GithubUrl = "https://github.com/boba1010/CSharp_Interactive_learning_Platform",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
                //new() { BadgeTitle = ".NET MAUI" },
                //new() { BadgeTitle = "Blazor" },
                new("ASP.NET"),
            ],
            Images =
            [
                new("Codebase WinUI app", "images/codebasewinuiapp.png"),
                //new("Codebase MAUI app", "images/codebasemauiapp.png"),
                //new("Codebase Blazor app", "images/codebaseblazorapp.png"),
            ],
        },
        new()
        {
            Title = "Nativefy",
            Description = "Serverless youtube client",
            GithubUrl = "https://github.com/boba1010/nativefy",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
            ],
            Images =
            [
                new("Nativefy", "images/nativefy-1.png"),
                new("Nativefy", "images/nativefy-2.png"),
                new("Nativefy", "images/nativefy-3.png"),
            ],
        },
        new()
        {
            Title = "Visual Block Studio",
            Description = "Xaml Visual Editor",
            GithubUrl = "https://github.com/boba1010/visual-block-studio/tree/VBS_Gen2",
            Technologies =
            [
                new("WinUI 3"),
                new("C#"),
            ],
            Images =
            [
                new("Visual Block Studio", "images/vbs-1.png"),
                new("Visual Block Studio", "images/vbs-2.png"),
                new("Visual Block Studio", "images/vbs-3.png"),
                new("Visual Block Studio", "images/vbs-4.png"),
                new("Visual Block Studio", "images/vbs-5.png"),
                new("Visual Block Studio", "images/vbs-6.png"),
            ],
        },
        new()
        {
            Title = "Crafty",
            Description = "Voxel game",
            GithubUrl = "https://github.com/boba1010/crafty-game-engine",
            Technologies =
            [
                new("C#"),
                new("Vulcan"),
            ],
            Images =
            [
                new("Crafty", "images/crafty-1.png"),
                new("Crafty", "images/crafty-2.png"),
                new("Crafty", "images/crafty-3.png"),
            ],
        }
    ];
}
