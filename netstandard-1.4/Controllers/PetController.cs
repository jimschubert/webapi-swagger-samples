using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Petstore.Models;

namespace Petstore.Controllers
{
    /// <summary>
    /// Everything about your Pets not description
    /// </summary>
    /// <remarks></remarks>
    [Route("api/[controller]")]
    [Description("Everything about your Pets")]
    public class PetController : Controller
    {
        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <returns></returns>
        [HttpGet]
        [Route("findByStatus")]
        public IActionResult FindByStatus(string[] status)
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

            return new ObjectResult(example);
        }

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <param name="petId">ID of pet to return</param>
        /// <returns></returns>
        /// <remarks>Returns a single pet</remarks>
        [HttpGet]
        [Route("{petId}")]
        public IActionResult Get(long petId)
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
                return HttpNotFound();
            }

            return new ObjectResult(JsonConvert.DeserializeObject<Pet>(exampleJson));
        }

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <param name="pet">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        [HttpPost]
        public Pet Post(Pet pet)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <param name="pet">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        [HttpPut]
        [Route("")]
        public void Put(Pet pet)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <param name="petId">Pet id to delete</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{petId}")]
        public void Delete(long petId)
        {
            throw new NotImplementedException();
        }
    }
}
