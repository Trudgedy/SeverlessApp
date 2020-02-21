using System;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestyController : ControllerBase
	{
		[HttpGet("GetName/{name}")]
		public String GetName(String name)
		{
			return name;
		}
	}
}