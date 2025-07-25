namespace FinancialPlanning.Domain;

public class WorkComplect
{
    public Guid Id { get; set; }

    public required ProjectStage ProjectStage { get; set; }

    public required string Name { get; set; }

    public required Guid DepartmentId { get; set; }

    public int LaborCost { get; set; }

    public bool IsComplete { get; set; } = false;
}
