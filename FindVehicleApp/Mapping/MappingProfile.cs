using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindVehicleApp.Controllers.Resources;
using FindVehicleApp.Models;
using AutoMapper;


namespace FindVehicleApp.Mapping
{
    public class MappingProfile : Profile
    {
      public MappingProfile()
      {
          CreateMap<Make, MakeResource>();
          CreateMap<Model, ModelResource>();
          CreateMap<Feature, FeatureResource>();
       }
  }
}
