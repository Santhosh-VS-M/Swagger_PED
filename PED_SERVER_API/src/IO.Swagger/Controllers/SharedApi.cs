/*
 * PED Test API
 *
 * PED Test API
 *
 * OpenAPI spec version: 1.0.0
 * 
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
    public class SharedApiController : ControllerBase
    { 
        /// <summary>
        /// Get all Reason Codes
        /// </summary>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/SSDMUKK/Swagger_PED/1.0.0/reasoncodes")]
        [ValidateModelState]
        [SwaggerOperation("ReasonCodes")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ReasonCode>), description: "")]
        public virtual IActionResult ReasonCodes()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ReasonCode>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"reasonCodeName\" : \"reasonCodeName\",\n  \"groupId\" : 6,\n  \"reasonCodeId\" : 0\n}, {\n  \"reasonCodeName\" : \"reasonCodeName\",\n  \"groupId\" : 6,\n  \"reasonCodeId\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ReasonCode>>(exampleJson)
                        : default(List<ReasonCode>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get all States
        /// </summary>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/SSDMUKK/Swagger_PED/1.0.0/states")]
        [ValidateModelState]
        [SwaggerOperation("States")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<State>), description: "OK")]
        public virtual IActionResult States()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<State>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"stateName\" : \"stateName\",\n  \"stateId\" : 0.8008281904610115,\n  \"stateCode\" : \"stateCode\"\n}, {\n  \"stateName\" : \"stateName\",\n  \"stateId\" : 0.8008281904610115,\n  \"stateCode\" : \"stateCode\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<State>>(exampleJson)
                        : default(List<State>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
