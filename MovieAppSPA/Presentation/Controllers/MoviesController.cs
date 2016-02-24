using MovieAppSPA.Services;
using MovieAppSPA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieAppSPA.Presentation.Controllers {
    public class MoviesController : ApiController {

        private MovieService _service;

        public MoviesController(MovieService service) {
            _service = service;
        }

        // GET api/<controller>
        public IEnumerable<MovieDTO> Get() {
            return _service.List();
        }

        // GET api/<controller>/5
        public MovieDTO Get(int id) {
            return _service.Find(id);
        }

        // POST api/<controller>
        [Authorize]
        public HttpResponseMessage Post(MovieDTO movie) {
            
            if (ModelState.IsValid) {

                movie = _service.AddOrUpdate(movie);
                return Request.CreateResponse(HttpStatusCode.Created, movie);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {

            _service.Delete(id);
        }
    }
}