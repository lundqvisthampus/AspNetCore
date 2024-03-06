using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;

namespace AspNetCore_MVC.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Ultimate Task Management Assistant";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel 
    {
        Title = "Task Management Assistant You Gonna Love",
        FirstText = "We offer you a new generation of task management system.",
        SecondText = "Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        Brands = new List<ImageViewModel>
        {
            new() { ImageUrl = "images/brandlogo1.svg", AltText = "Brand Name 1"},
            new() { ImageUrl = "images/brandlogo2.svg", AltText = "Brand Name 2"},
            new() { ImageUrl = "images/brandlogo3.svg", AltText = "Brand Name 3"},
            new() { ImageUrl = "images/brandlogo4.svg", AltText = "Brand Name 4"}
        }
    };

    public ToolsViewModel Features { get; set; } = new ToolsViewModel
    {
        Title = "What Do You Get With Our Tool?",
        Description = "Make sure all your tasks are organized so you can set the priorities and focus on important.",
        Tools = new List<ToolViewModel>
        {
            new ToolViewModel 
            { 
                ControllerName = "Tools", 
                ActionName = "Index", 
                Icon = "fa-regular fa-comments-question-check", 
                Id = "tool-1", 
                Title = "Comment on Tasks", 
                Text = "Id mollis consectetur congue egestas egestas suspendisse blandit justo." 
            },

            new ToolViewModel
            {
                ControllerName = "Tools",
                ActionName = "Index",
                Icon = "fa-regular fa-display-chart-up",
                Id = "tool-2",
                Title = "Tasks Analytics",
                Text = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate."
            },

            new ToolViewModel
            {
                ControllerName = "Tools",
                ActionName = "Index",
                Icon = "fa-regular fa-user-group-simple",
                Id = "tool-3",
                Title = "Multiple Assignees",
                Text = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris."
            },

            new ToolViewModel
            {
                ControllerName = "Tools",
                ActionName = "Index",
                Icon = "fa-regular fa-bell-ring",
                Id = "tool-4",
                Title = "Notifications",
                Text = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra."
            },

            new ToolViewModel
            {
                ControllerName = "Tools",
                ActionName = "Index",
                Icon = "fa-regular fa-memo-circle-check",
                Id = "tool-5",
                Title = "Sections & Subtasks",
                Text = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus."
            },

            new ToolViewModel
            {
                ControllerName = "Tools",
                ActionName = "Index",
                Icon = "fa-sharp fa-regular fa-shield-check",
                Id = "tool-6",
                Title = "Data Security",
                Text = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras."
            },
        }
    };

    public ManageWorkViewModel ManageWork { get; set; } = new ManageWorkViewModel
    {
        ImageViewModel = new ImageViewModel { ImageUrl = "images/Taskmanager.svg", AltText = "Application Image"},
        Title = "Manage Your Work",
        Features = new List<ManagingFeaturesViewModel>
        {
            new ManagingFeaturesViewModel { Icon = "fa-sharp fa-regular fa-circle-check", Text = "Powerful project management"},
            new ManagingFeaturesViewModel { Icon = "fa-sharp fa-regular fa-circle-check", Text = "Transparent work management"},
            new ManagingFeaturesViewModel { Icon = "fa-sharp fa-regular fa-circle-check", Text = "Manage work & focus on the most important tasks"},
            new ManagingFeaturesViewModel { Icon = "fa-sharp fa-regular fa-circle-check", Text = "Track your progress with interactive charts"},
            new ManagingFeaturesViewModel { Icon = "fa-sharp fa-regular fa-circle-check", Text = "Easiest way to track time spent on tasks"},
        },
        Link = new LinkViewModel { ControllerName = "Learn", ActionName="Index", Text = "Learn more", Icon = "fa-solid fa-arrow-right" }
    };

    public OurAppViewModel OurApp { get; set; } = new OurAppViewModel
    {
        Title = "Download Our App for Any Devices:",
        Image = new ImageViewModel { ImageUrl = "images/AppImg.svg", AltText = "Image of application"},
        AppStoresList = new List<DownloadAppViewModel>
        {
            new DownloadAppViewModel { Store = "App Store", AppTitle = "Editor's Choice", RatingText = "rating 4.7, 187K+ reviews", StarsAmount = 5, StoreImage = new ImageViewModel { ImageUrl = "images/appstore.svg", AltText = "App store image"} },
            new DownloadAppViewModel { Store = "Google Play", AppTitle = "App of the Day", RatingText = "rating 4.8, 30K+ reviews", StarsAmount = 5, StoreImage = new ImageViewModel { ImageUrl = "images/googleplay.svg", AltText = "Google play image"} }
        }
    };

    public IntegrateViewModel Integrate { get; set; } = new IntegrateViewModel
    {
        Title = "Integrate Top Work Tools",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin volutpat mollis egestas. Nam luctus facilisis ultrices. Pellentesque volutpat ligula est. Mattis fermentum, at nec lacus.",
        Applications = new List<IntegrationAppViewModel>
        {
            new IntegrationAppViewModel 
            { 
                Text = "Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", 
                Link = "google.com", 
                Image = new ImageViewModel { ImageUrl = "images/google.svg", AltText = "Google icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "In eget a mauris quis. Tortor dui tempus quis integer est sit natoque placerat dolor.",
                Link = "zoom.us",
                Image = new ImageViewModel { ImageUrl = "images/zoom.svg", AltText = "Zoom icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
                Link = "slack.com",
                Image = new ImageViewModel { ImageUrl = "images/slack.svg", AltText = "Slack icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "Rutrum interdum tortor, sed at nulla. A cursus bibendum elit purus cras praesent.",
                Link = "gmail.com",
                Image = new ImageViewModel { ImageUrl = "images/gmail.svg", AltText = "Gmail icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "Congue pellentesque amet, viverra curabitur quam diam scelerisque fermentum urna.",
                Link = "trello.com",
                Image = new ImageViewModel { ImageUrl = "images/trello.svg", AltText = "Trello icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
                Link = "mailchimp.com",
                Image = new ImageViewModel { ImageUrl = "images/mailchimp.svg", AltText = "MailChimp icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "Ut in turpis consequat odio diam lectus elementum. Est faucibus blandit platea.",
                Link = "dropbox.com",
                Image = new ImageViewModel { ImageUrl = "images/dropbox.svg", AltText = "Dropbox icon image"}
            },

            new IntegrationAppViewModel
            {
                Text = "Faucibus cursus maecenas lorem cursus nibh. Sociis sit risus id. Sit facilisis dolor arcu.",
                Link = "evernote.com",
                Image = new ImageViewModel { ImageUrl = "images/evernote.svg", AltText = "Evernote icon image"}
            },
        } 
    };

    public NewsletterViewModel NewsLetter { get; set; } = new NewsletterViewModel
    {
        Title = "Don't Want to Miss Anything?",
        Image  = new ImageViewModel { ImageUrl = "images/arrows.svg", AltText = "Purple arrows image"},
        Checkboxes = new List<NewsCheckboxViewModel>
        {
            new NewsCheckboxViewModel { Name = "daily", Text = "Daily Newsletter"},
            new NewsCheckboxViewModel { Name = "adupdates", Text = "Advertising Updates"},
            new NewsCheckboxViewModel { Name = "weekreview", Text = "Week in Review"},
            new NewsCheckboxViewModel { Name = "events", Text = "Event Updates"},
            new NewsCheckboxViewModel { Name = "startups", Text = "Startups Weekly"},
            new NewsCheckboxViewModel { Name = "podcasts", Text = "Podcasts"}
        }
    };
}
