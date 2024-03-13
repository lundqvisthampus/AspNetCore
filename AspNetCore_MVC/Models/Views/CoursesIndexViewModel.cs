using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;

namespace AspNetCore_MVC.Models.Views;

public class CoursesIndexViewModel
{
    public List<SingleCourseViewModel> Courses { get; set; } = new List<SingleCourseViewModel>
    {
        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
        },

        new SingleCourseViewModel
        {
        ControllerName = "Home",
        ActionName = "Index",
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }
       }
    };
    public CoursesWorkWithUsViewModel WorkWithUs { get; set; } = new CoursesWorkWithUsViewModel
    {
        Text = "Ready to get started?",
        Header = "Take Your <span>Skills</span> to the Next Level",
        ImageUrl = "/images/work-with-us.svg",
        ImageAltText = "Woman at a desk with her laptop",
        ButtonAction = "Index",
        ButtonController = "Contact",
        ButtonText = "Work with us"
    };
    public SingleCourseViewModel SingleCourse { get; set; } = new SingleCourseViewModel 
    {
        CourseImgUrl = "/images/course-img.svg",
        Title = "Fullstack Web Developer Course from Scratch",
        Ingress = "Egestas feugiat lorem eu neque suspendisse ullamcorper scelerisque aliquam mauris.",
        Description = "Suspendisse natoque sagittis, consequat turpis. Sed tristique tellus morbi magna. At vel senectus accumsan, arcu mattis id tempor. Tellus sagittis, euismod porttitor sed tortor est id. Feugiat velit velit, tortor ut. Ut libero cursus nibh lorem urna amet tristique leo. Viverra lorem arcu nam nunc at ipsum quam. A proin id sagittis dignissim mauris condimentum ornare. Tempus mauris sed dictum ultrices.",
        StarsAmount = 4,
        ReviewsAmount = "1.2K",
        LikesAmount = "5K",
        HoursContent = "148",
        IsBestSeller = true,
        IsDigital = true,

        Author = new CourseAuthorViewModel
        {
            AuthorName = "Albert Flores",
            AuthorBigImgUrl = "/images/author-big-picture.svg",
            AuthorImgUrl = "/images/author-img.svg",
            AuthorDescription = "Dolor ipsum amet cursus quisque porta adipiscing. Lorem convallis malesuada sed maecenas. Ac dui at vitae mauris cursus in nullam porta sem. Quis pellentesque elementum ac bibendum. Nunc aliquam in tortor facilisis. Vulputate eget risus, metus phasellus. Pellentesque faucibus amet, eleifend diam quam condimentum convallis ultricies placerat. Duis habitasse placerat amet, odio pellentesque rhoncus, feugiat at. Eget pellentesque tristique felis magna fringilla.",
            FacebookSubscribers = "180k",
            FacebookUrl = "#",
            YoutubeSubscribers = "240k",
            YoutubeUrl = "#",
        },

        Learning = new List<CourseLearningViewModel>
        {
            new CourseLearningViewModel
            {
                Content = "Sed lectus donec amet eu turpis interdum.",
            },

            new CourseLearningViewModel
            {
                Content = "Nulla at consectetur vitae dignissim porttitor.",
            },

            new CourseLearningViewModel
            {
                Content = "Phasellus id vitae dui aliquet mi.",
            },

            new CourseLearningViewModel
            {
                Content = "Integer cursus vitae, odio feugiat iaculis aliquet diam, et purus.",
            },

            new CourseLearningViewModel
            {
                Content = "In aenean dolor diam tortor orci eu.",
            }
        },

        Includes = new CourseIncludesViewModel
        {
            HoursOfContent = "148",
            AmountOfArticles = "18",
            DownloadableResources = "25",
            LifetimeAccess = true,
            Certificate = true,
            Price = "28.99",
            ReducedPrice = "49.00"
        },

        Details = new List<CourseDetailsViewModel>
        {
            new CourseDetailsViewModel
            {
                Title = "Introduction. Getting started",
                Description = "Nulla faucibus mauris pellentesque blandit faucibus non. Sit ut et at suspendisse gravida hendrerit tempus placerat.",
            },

            new CourseDetailsViewModel
            {
                Title = "The ultimate HTML developer: advanced HTML",
                Description = "Lobortis diam elit id nibh ultrices sed penatibus donec. Nibh iaculis eu sit cras ultricies. Nam eu eget etiam egestas donec scelerisque ut ac enim. Vitae ac nisl, enim nec accumsan vitae est.",
            },

            new CourseDetailsViewModel
            {
                Title = "CSS & CSS3: basic",
                Description = "Duis euismod enim, facilisis risus tellus pharetra lectus diam neque. Nec ultrices mi faucibus est. Magna ullamcorper potenti elementum ultricies auctor nec volutpat augue.",
            },

            new CourseDetailsViewModel
            {
                Title = "JavaScript basics for beginners",
                Description = "Morbi porttitor risus imperdiet a, nisl mattis. Amet, faucibus eget in platea vitae, velit, erat eget velit. At lacus ut proin erat.",
            },

            new CourseDetailsViewModel
            {
                Title = "Understanding APIs",
                Description = "Risus morbi euismod in congue scelerisque fusce pellentesque diam consequat. Nisi mauris nibh sed est morbi amet arcu urna. Malesuada feugiat quisque consectetur elementum diam vitae. Dictumst facilisis odio eu quis maecenas risus odio fames bibendum.",
            },

            new CourseDetailsViewModel
            {
                Title = "C# and .NET from beginner to advanced",
                Description = "Quis risus quisque diam diam. Volutpat neque eget eu faucibus sed urna fermentum risus. Est, mauris morbi nibh massa.",
            }
        }

    };
}
