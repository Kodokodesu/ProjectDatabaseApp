namespace AzureWebsite.Api.Models
{
    public class Project
    {
        protected Project()
        {
            CreatedOn = DateTime.UtcNow;
        }

        public Project(string projectName, string projectDescription, string? projectDeadline = null) : this()
        {
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectDeadline = projectDeadline;
        }

        public int Id { get; protected set; }
        public string ProjectName { get; protected set; }
        public string ProjectDescription { get; protected set; }
        public DateTime CreatedOn { get; protected set; }
        public string? ProjectDeadline { get; protected set; }
    }
}