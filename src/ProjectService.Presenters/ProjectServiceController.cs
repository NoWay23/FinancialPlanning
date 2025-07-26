namespace ProjectService.Presenters;

using Microsoft.AspNetCore.Mvc;
using ProjectService.Contracts;

[ApiController]
[Route("[controller]")]
public class ProjectServiceController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProjectDto request, CancellationToken cancellationToken)
    {
        return Ok("Project Created");
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GetProjectDto request, CancellationToken cancellationToken)
    {
        return Ok("Projects get");
    }

    [HttpGet("{projectId:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid projectId, GetProjectDto getProjectDto, CancellationToken cancellationToken)
    {
        return Ok("Project get by id");
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromRoute] Guid projectId, [FromBody] UpdateProjectDto request, CancellationToken cancellationToken)
    {
        return Ok("Project updated");
    }

    [HttpDelete("{projectId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid projectId)
    {
        return Ok("Project delete");
    }
}
