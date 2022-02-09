using CwkSocial.Api.Contracts.UserProfile.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1;

[ApiVersion("1.0")]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class UserProfilesController : Controller
{
    private readonly IMediator _mediator;
    public UserProfilesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<OkResult> GetAllProfiles()
    {
        return await Task.FromResult(Ok());
    }

    [HttpPost]
    public async Task<OkResult> CreateUserProfile([FromBody] UserProfileCreate profile)
    {
        return await Task.FromResult(Ok());
    }
}