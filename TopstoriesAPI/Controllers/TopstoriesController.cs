using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TopstoriesAPI.Model.Dtos;
using TopstoriesAPI.Model;
using TopstoriesAPI.Repository.IRepository;

namespace TopstoriesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopstoriesController : Controller
    {
        private ITopstoriesRepository _tsRepo;
        private readonly IMapper _mapper;
        private readonly HttpClient client;

        public TopstoriesController(ITopstoriesRepository tsRepo, IMapper mapper)
        {
            _tsRepo = tsRepo;
            _mapper = mapper;

            client = new HttpClient();
        }

        [HttpPost("{nykey}")]
        public async Task<IActionResult> CreateTopstories(string nykey)
        {
            try
            {
                if (nykey != null && nykey != "")
                {
                    RootDto objRootDto = await getArticaleData(nykey);

                    if (objRootDto != null)
                    {
                        Root objRoot = _mapper.Map<Root>(objRootDto);

                        if (objRoot != null)
                        {
                            if (!_tsRepo.CreateTopStories(objRoot))
                            {
                                return StatusCode(500);
                            }
                            return StatusCode(201);
                        }
                        else
                        {
                            return StatusCode(400);
                        }
                    }
                    else
                        return StatusCode(400);
                }
                else
                    return StatusCode(400);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Unauthorized")
                    return Unauthorized();

                return BadRequest();
            }
        }
        [NonAction]
        public async Task<RootDto> getArticaleData(string nykey)
        {
            RootDto objTopstoriesDto = new RootDto();
            try
            {
                var url = string.Format(Constants.TopstoriesAPIPath, nykey);

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();

                    objTopstoriesDto = JsonSerializer.Deserialize<RootDto>(stringResponse,
                        new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTopstoriesDto;
        }
    }
}
