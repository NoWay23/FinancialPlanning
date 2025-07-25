namespace FinancialPlanning.Domain;

public enum Status
{
    Planning,
    Active,
    Complete,
}

public class ProjectStage
{
    public Guid Id { get; set; }

    public required Project Project { get; set; }

    public required string Name { get; set; }

    public decimal Cost { get; set; }

    public int Deadline { get; set; }

    public Status Status { get; set; } = Status.Planning;

    public List<Guid> WorkComplects { get; set; } = [];
}
