namespace FinancialPlanning.Domain;

public class Project
{
    public Guid Id { get; set; }

    public required string Shifr { get; set; }

    public required string Name { get; set; }

    public required decimal Budget { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<ProjectStage> ProjectStages { get; set; } = [];
}