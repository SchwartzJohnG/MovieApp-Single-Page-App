using AutoMapper;
using MovieAppSPA.Domain.Models;
using MovieAppSPA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAppSPA.App_Start {
    public class AutoMapperConfig {
        public static void RegisterMaps() {

            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MovieDTO, Movie>();
        }
    }
}