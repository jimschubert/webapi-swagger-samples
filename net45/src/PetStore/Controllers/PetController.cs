using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Petstore.Models;
using Swashbuckle.Swagger.Annotations;

namespace PetStore.Controllers
{
    /// <summary>
    /// Everything about your Pets not description
    /// </summary>
    /// <remarks></remarks>
    [RoutePrefix("api/pet")]
    [Description("Everything about your Pets")]
    public class PetController : ApiController
    {
        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <returns></returns>
        [HttpGet]
        [Route("findByStatus")]
        [SwaggerResponse(HttpStatusCode.OK, type: typeof(Pet[]), description: "successful operation")]
        [SwaggerResponse(HttpStatusCode.BadRequest, description: "Invalid status value")]
        public IHttpActionResult FindByStatus([FromUri]string[] status)
        {
            string exampleJson = null;

            // if example template:
            exampleJson = @"
                    [
                        {
                        'id': 0,
                        'category': {
                        'id': 0,
                            'name': 'string'
                        },
                        'name': 'doggie',
                        'photoUrls': [
                            'string'
                        ],
                        'tags': [
                            {
                            'id': 0,
                            'name': 'string'
                            }
                        ],
                        'status': 'available'
                        }
                    ]";

            IEnumerable<Pet> example = exampleJson != null
                ? JsonConvert.DeserializeObject<Collection<Pet>>(exampleJson)
                : Enumerable.Empty<Pet>();

            return Ok(example);
        }

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <param name="petId">ID of pet to return</param>
        /// <returns></returns>
        /// <remarks>Returns a single pet</remarks>
        [HttpGet]
        [Route("{petId}")]
        [SwaggerResponse(HttpStatusCode.OK, type: typeof(Pet), description: "successful operation")]
        [SwaggerResponse(HttpStatusCode.BadRequest, description: "Invalid ID supplied")]
        [SwaggerResponse(HttpStatusCode.NotFound, description: "Pet not found")]
        public IHttpActionResult Get(long petId)
        {
            string exampleJson = null;

            // if example in template:
            exampleJson = @"{
                  'id': 0,
                  'category': {
                                'id': 0,
                    'name': 'string'
                  },
                  'name': 'doggie',
                  'photoUrls': [
                    'string'
                  ],
                  'tags': [
                    {
                      'id': 0,
                      'name': 'string'
                    }
                  ],
                  'status': 'available'
                }";

            if (exampleJson == null)
            {
                return NotFound();
            }

            return Ok(JsonConvert.DeserializeObject<Pet>(exampleJson));
        }

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <param name="pet">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, type: typeof(Pet), description: "successful operation")]
        [SwaggerResponse(HttpStatusCode.MethodNotAllowed, description: "Invalid input")]
        public IHttpActionResult Post(Pet pet)
        {
            return Ok();
        }
        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <param name="pet">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        [HttpPut]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, type: typeof(Pet), description: "successful operation")]
        [SwaggerResponse(HttpStatusCode.BadRequest, description: "Invalid ID supplied")]
        [SwaggerResponse(HttpStatusCode.NotFound, description: "Pet not found")]
        [SwaggerResponse(HttpStatusCode.MethodNotAllowed, description: "Validation exception")]
        public IHttpActionResult Put(Pet pet)
        {
            return Ok();
        }

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <param name="petId">Pet id to delete</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{petId}")]
        [SwaggerResponse(HttpStatusCode.OK, description: "successful operation")]
        [SwaggerResponse(HttpStatusCode.BadRequest, description: "Invalid ID supplied")]
        [SwaggerResponse(HttpStatusCode.NotFound, description: "Pet not found")]
        public IHttpActionResult Delete(long petId)
        {
            return Ok();
        }
    }
}
