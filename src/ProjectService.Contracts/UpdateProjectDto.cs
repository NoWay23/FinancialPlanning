namespace ProjectService.Contracts;

public record class UpdateProjectDto(string shifr, string name, decimal budget, DateTime startDate, DateTime endDate, Guid[] projectStageIds);
