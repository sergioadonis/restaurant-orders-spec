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
    public class CategoryApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="0">ok</response>
        [HttpPost]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories")]
        [ValidateModelState]
        [SwaggerOperation("AddCategory")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult AddCategory([FromBody]Category body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"category\" : {\n    \"restaurants\" : [ {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpDelete]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteCategory")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult DeleteCategory([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"category\" : {\n    \"restaurants\" : [ {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories")]
        [ValidateModelState]
        [SwaggerOperation("GetCategories")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryArrayResult), description: "ok")]
        public virtual IActionResult GetCategories([FromQuery]int? limit, [FromQuery]int? skip)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryArrayResult));
            string exampleJson = null;
            exampleJson = "{\n  \"categories\" : [ \"\", \"\" ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryArrayResult>(exampleJson)
                        : default(CategoryArrayResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpGet]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetCategoryById")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult GetCategoryById([FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"category\" : {\n    \"restaurants\" : [ {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <response code="0">ok</response>
        [HttpPut]
        [Route("/sergioadonis/restaurant-orders-api/v1/categories/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateCategory")]
        [SwaggerResponse(statusCode: 0, type: typeof(CategoryObjectResult), description: "ok")]
        public virtual IActionResult UpdateCategory([FromBody]Category body, [FromRoute][Required]CommonPropspropertiesid id)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(CategoryObjectResult));
            string exampleJson = null;
            exampleJson = "{\n  \"category\" : {\n    \"restaurants\" : [ {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    }, {\n      \"address\" : {\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"description\" : \"description\",\n        \"state\" : \"state\",\n        \"line2\" : \"line2\",\n        \"line1\" : \"line1\"\n      },\n      \"geoLocation\" : {\n        \"latitud\" : 0,\n        \"longitud\" : 6\n      },\n      \"contact\" : {\n        \"whatsapp\" : \"7788-9900\",\n        \"phoneNumber\" : \"2222-5555\",\n        \"facebook\" : \"facebook\",\n        \"email\" : \"correo@ejemplo.com\"\n      },\n      \"schedules\" : [ {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      }, {\n        \"name\" : \"name\",\n        \"closeTime\" : \"closeTime\",\n        \"days\" : \"days\",\n        \"openTime\" : \"openTime\"\n      } ],\n      \"categoryId\" : 123,\n      \"tags\" : [ \"Mexican\", \"Japan\", \"Favorite\" ]\n    } ]\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CategoryObjectResult>(exampleJson)
                        : default(CategoryObjectResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
