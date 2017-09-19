using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindVehicleApp.Data;
using AutoMapper;
using FindVehicleApp.Controllers.Resources;
using FindVehicleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FindVehicleApp.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeature()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}