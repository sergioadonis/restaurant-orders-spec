/*
 * Restaurant Orders
 *
 * Simple API to manage restaurant orders
 *
 * OpenAPI spec version: v1
 * Contact: sergio.adonis@outlook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RestaurantApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="0">Default response</response>
        [HttpPost]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants")]
        [ValidateModelState]
        [SwaggerOperation("AddRestaurant")]
        [SwaggerResponse(statusCode: 0, type: typeof(InlineResponseDefault1), description: "Default response")]
        public virtual IActionResult AddRestaurant([FromBody]Restaurant body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault1));
            string exampleJson = null;
            exampleJson = "{\n  \"objectId\" : 123\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponseDefault1>(exampleJson)
                        : default(InlineResponseDefault1);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">Default response</response>
        [HttpDelete]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteRestaurant")]
        [SwaggerResponse(statusCode: 0, type: typeof(InlineResponseDefault1), description: "Default response")]
        public virtual IActionResult DeleteRestaurant([FromRoute][Required]Id id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault1));
            string exampleJson = null;
            exampleJson = "{\n  \"objectId\" : 123\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponseDefault1>(exampleJson)
                        : default(InlineResponseDefault1);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetRestaurantById")]
        [SwaggerResponse(statusCode: 0, type: typeof(InlineResponseDefault3), description: "ok")]
        public virtual IActionResult GetRestaurantById([FromRoute][Required]Id id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault3));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"restaurant\" : {\n      \"menus\" : [ null, null ],\n      \"category\" : {\n        \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n        \"name\" : \"Name of object\",\n        \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n        \"id\" : 123\n      },\n      \"products\" : [ null, null ]\n    }\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponseDefault3>(exampleJson)
                        : default(InlineResponseDefault3);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="categoryId"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants")]
        [ValidateModelState]
        [SwaggerOperation("GetRestaurants")]
        [SwaggerResponse(statusCode: 0, type: typeof(InlineResponseDefault), description: "ok")]
        public virtual IActionResult GetRestaurants([FromQuery]int? limit, [FromQuery]int? skip, [FromQuery]Id categoryId)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : [ {\n    \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n    \"name\" : \"Name of object\",\n    \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n    \"id\" : 123\n  }, {\n    \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",\n    \"name\" : \"Name of object\",\n    \"description\" : \"This is a description for this object, could be Markdown sintax.\",\n    \"id\" : 123\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponseDefault>(exampleJson)
                        : default(InlineResponseDefault);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <response code="0">Default response</response>
        [HttpPut]
        [Route("/sergioadonis/restaurant-orders-api/v1/restaurants/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateRestaurant")]
        [SwaggerResponse(statusCode: 0, type: typeof(InlineResponseDefault1), description: "Default response")]
        public virtual IActionResult UpdateRestaurant([FromBody]Restaurant body, [FromRoute][Required]Id id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault1));
            string exampleJson = null;
            exampleJson = "{\n  \"objectId\" : 123\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponseDefault1>(exampleJson)
                        : default(InlineResponseDefault1);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}