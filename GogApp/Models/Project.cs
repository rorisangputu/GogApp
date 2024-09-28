using System;

namespace GogApp.Models;

public class Project
{
    public int Id { get; set; }
    public required string? Title { get; set; }

    // New properties added
    public string? Description { get; set; }
    public string? Details { get; set; }

    // Collection of reports related to the project
    public ICollection<Report>? Reports { get; set; }

    // Collection of donations related to the project
    public ICollection<Donation>? Donations { get; set; }

    [ForeignKey("AppUser")]
    public required string? ManagerId { get; set; }
    public AppUser? Manager { get; set; }

    public ICollection<ProjectVolunteer>? ProjectVolunteers { get; set; }
    public ICollection<ProjectTask>? ProjectTasks { get; set; }
}
