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
    public class MenuApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="0">ok</response>
        [HttpPost]
        [Route("/sergioadonis/restaurant-orders-api/v1/menus")]
        [ValidateModelState]
        [SwaggerOperation("AddMenu")]
        [SwaggerResponse(statusCode: 0, type: typeof(MenuObjectResult), description: "ok")]
        public virtual IActionResult AddMenu([FromBody]Menu body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(MenuObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"result\" : {\n    \"requestId\" : \"requestId\",\n    \"errorCode\" : \"errorCode\",\n    \"message\" : \"message\"\n  },\n  \"menu\" : {\n    \"restaurantId\" : 123\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MenuObjectResult>(exampleJson)
                        : default(MenuObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpDelete]
        [Route("/sergioadonis/restaurant-orders-api/v1/menus/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteMenu")]
        [SwaggerResponse(statusCode: 0, type: typeof(MenuObjectResult), description: "ok")]
        public virtual IActionResult DeleteMenu([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(MenuObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"result\" : {\n    \"requestId\" : \"requestId\",\n    \"errorCode\" : \"errorCode\",\n    \"message\" : \"message\"\n  },\n  \"menu\" : {\n    \"restaurantId\" : 123\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MenuObjectResult>(exampleJson)
                        : default(MenuObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/menus/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetMenuById")]
        [SwaggerResponse(statusCode: 0, type: typeof(MenuObjectResult), description: "ok")]
        public virtual IActionResult GetMenuById([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(MenuObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"result\" : {\n    \"requestId\" : \"requestId\",\n    \"errorCode\" : \"errorCode\",\n    \"message\" : \"message\"\n  },\n  \"menu\" : {\n    \"restaurantId\" : 123\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MenuObjectResult>(exampleJson)
                        : default(MenuObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="restaurantId"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/menus")]
        [ValidateModelState]
        [SwaggerOperation("GetMenus")]
        [SwaggerResponse(statusCode: 0, type: typeof(MenuArrayResult), description: "ok")]
        public virtual IActionResult GetMenus([FromQuery]int? limit, [FromQuery]int? skip, [FromQuery]CommonPropspropertiesid restaurantId)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(MenuArrayResult));
            string exampleJson = null;
            exampleJson = "{\n  \"result\" : {\n    \"requestId\" : \"requestId\",\n    \"errorCode\" : \"errorCode\",\n    \"message\" : \"message\"\n  },\n  \"menus\" : [ {\n    \"restaurantId\" : 123\n  }, {\n    \"restaurantId\" : 123\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MenuArrayResult>(exampleJson)
                        : default(MenuArrayResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpPut]
        [Route("/sergioadonis/restaurant-orders-api/v1/menus/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateMenu")]
        [SwaggerResponse(statusCode: 0, type: typeof(MenuObjectResult), description: "ok")]
        public virtual IActionResult UpdateMenu([FromBody]Menu body, [FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(MenuObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"result\" : {\n    \"requestId\" : \"requestId\",\n    \"errorCode\" : \"errorCode\",\n    \"message\" : \"message\"\n  },\n  \"menu\" : {\n    \"restaurantId\" : 123\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<MenuObjectResult>(exampleJson)
                        : default(MenuObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
