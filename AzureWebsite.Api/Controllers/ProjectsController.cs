using System.Data.Common;
using AzureWebsite.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureWebsite.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly ILogger<ProjectsController> logger;
    private readonly ProjectsDb db;

    public ProjectsController(ILogger<ProjectsController> logger, ProjectsDb db)
    {
        this.logger = logger;
        this.db = db;
    }

    [HttpGet(Name = "GetProjects")]
    public async Task<IEnumerable<Project>> Get()
    {
        // var mock = new List<Project>
        // {
        //     new Project(projectName: "PillowPal", projectDescription: "an application that helps you fall asleep", projectDeadline: "02.03.2024"),
        //     new Project(projectName: "Tasty&Health", projectDescription: "an application supporting a healthy lifestyle")
        // };

        // return mock;

        var projects = await db.Projects.ToListAsync();
        return projects;
    }
}
