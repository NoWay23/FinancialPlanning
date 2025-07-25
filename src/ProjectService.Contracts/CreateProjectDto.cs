namespace ProjectService.Contracts;

public record class CreateProjectDto(string shifr, string name, decimal budget, DateTime startDate, DateTime endDate, Guid[] projectStageIds);
