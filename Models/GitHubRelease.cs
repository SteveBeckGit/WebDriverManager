using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_Framework.Selenium.WebDriverManager.Models
{
    public partial class GitHubRelease
    {
        public Uri Url { get; set; }
        public Uri AssetsUrl { get; set; }
        public string UploadUrl { get; set; }
        public Uri HtmlUrl { get; set; }
        public long Id { get; set; }
        public string NodeId { get; set; }
        public string TagName { get; set; }
        public TargetCommitish TargetCommitish { get; set; }
        public string Name { get; set; }
        public bool Draft { get; set; }
        public Author Author { get; set; }
        public bool Prerelease { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset PublishedAt { get; set; }
        public Asset[] Assets { get; set; }
        public Uri TarballUrl { get; set; }
        public Uri ZipballUrl { get; set; }
        public string Body { get; set; }
    }

    public partial class Asset
    {
        public Uri Url { get; set; }
        public long Id { get; set; }
        public string NodeId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public Author Uploader { get; set; }
        public ContentType ContentType { get; set; }
        public State State { get; set; }
        public long Size { get; set; }
        public long DownloadCount { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public Uri browser_download_url { get; set; }
    }

    public partial class Author
    {
        public Login Login { get; set; }
        public long Id { get; set; }
        public NodeId NodeId { get; set; }
        public Uri AvatarUrl { get; set; }
        public string GravatarId { get; set; }
        public Uri Url { get; set; }
        public Uri HtmlUrl { get; set; }
        public Uri FollowersUrl { get; set; }
        public string FollowingUrl { get; set; }
        public GistsUrl GistsUrl { get; set; }
        public string StarredUrl { get; set; }
        public Uri SubscriptionsUrl { get; set; }
        public Uri OrganizationsUrl { get; set; }
        public Uri ReposUrl { get; set; }
        public EventsUrl EventsUrl { get; set; }
        public Uri ReceivedEventsUrl { get; set; }
        public TypeEnum Type { get; set; }
        public bool SiteAdmin { get; set; }
    }

    public enum ContentType { ApplicationGzip, ApplicationXGzip, ApplicationXZipCompressed, ApplicationZip, TextPlain };

    public enum State { Uploaded };

    public enum EventsUrl { HttpsApiGithubComUsersAndreasttEventsPrivacy, HttpsApiGithubComUsersAutomatedTesterEventsPrivacy, HttpsApiGithubComUsersJgrahamEventsPrivacy, HttpsApiGithubComUsersWhimbooEventsPrivacy };

    public enum GistsUrl { HttpsApiGithubComUsersAndreasttGistsGistId, HttpsApiGithubComUsersAutomatedTesterGistsGistId, HttpsApiGithubComUsersJgrahamGistsGistId, HttpsApiGithubComUsersWhimbooGistsGistId };

    public enum Login { Andreastt, AutomatedTester, Jgraham, Whimboo };

    public enum NodeId { Mdq6VxNlcjEyOdUxOa, Mdq6VxNlcjEyOtYwMw, Mdq6VxNlcjI5NDg2Na, Mdq6VxNlcjM5OtEyMa };

    public enum TypeEnum { User };

    public enum TargetCommitish { Cd8F8A78420Fa4Ee315052513Ef926C81C6Ae74D, Master, Release, The17945Ac838449Dda1Defc8Cda0C6Dadb042519B2 };
}
