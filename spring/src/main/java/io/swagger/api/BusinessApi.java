/**
 * NOTE: This class is auto generated by the swagger code generator program (2.4.10).
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */
package io.swagger.api;

import io.swagger.model.Business;
import io.swagger.model.Error;
import io.swagger.annotations.*;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RequestPart;
import org.springframework.web.multipart.MultipartFile;

import javax.validation.Valid;
import javax.validation.constraints.*;
import java.util.List;
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T04:19:29.518Z")

@Api(value = "business", description = "the business API")
public interface BusinessApi {

    @ApiOperation(value = "Create business", nickname = "createBusiness", notes = "", response = Business.class, tags={ "Business", })
    @ApiResponses(value = { 
        @ApiResponse(code = 201, message = "ok", response = Business.class),
        @ApiResponse(code = 200, message = "error", response = Error.class, responseContainer = "List") })
    @RequestMapping(value = "/business",
        produces = { "application/json" }, 
        consumes = { "application/json" },
        method = RequestMethod.POST)
    ResponseEntity<Business> createBusiness(@ApiParam(value = "" ,required=true )  @Valid @RequestBody Business bussines);


    @ApiOperation(value = "Delete business by id", nickname = "deleteBusinessById", notes = "", tags={ "Business", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "ok"),
        @ApiResponse(code = 200, message = "error", response = Error.class, responseContainer = "List") })
    @RequestMapping(value = "/business/{id}",
        produces = { "application/json" }, 
        consumes = { "application/json" },
        method = RequestMethod.DELETE)
    ResponseEntity<Void> deleteBusinessById(@ApiParam(value = "",required=true) @PathVariable("id") String id);


    @ApiOperation(value = "Get business by id", nickname = "getBusinessById", notes = "", response = Business.class, tags={ "Business", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "ok", response = Business.class),
        @ApiResponse(code = 200, message = "error", response = Error.class, responseContainer = "List") })
    @RequestMapping(value = "/business/{id}",
        produces = { "application/json" }, 
        consumes = { "application/json" },
        method = RequestMethod.GET)
    ResponseEntity<Business> getBusinessById(@ApiParam(value = "",required=true) @PathVariable("id") String id);


    @ApiOperation(value = "Get businesses", nickname = "getBusinesses", notes = "", response = Business.class, responseContainer = "List", tags={ "Business", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "ok", response = Business.class, responseContainer = "List"),
        @ApiResponse(code = 200, message = "error", response = Error.class, responseContainer = "List") })
    @RequestMapping(value = "/business",
        produces = { "application/json" }, 
        consumes = { "application/json" },
        method = RequestMethod.GET)
    ResponseEntity<List<Business>> getBusinesses();


    @ApiOperation(value = "Update business by id", nickname = "updateBusinessById", notes = "", response = Business.class, tags={ "Business", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "ok", response = Business.class),
        @ApiResponse(code = 200, message = "error", response = Error.class, responseContainer = "List") })
    @RequestMapping(value = "/business/{id}",
        produces = { "application/json" }, 
        consumes = { "application/json" },
        method = RequestMethod.PUT)
    ResponseEntity<Business> updateBusinessById(@ApiParam(value = "",required=true) @PathVariable("id") String id,@ApiParam(value = "" ,required=true )  @Valid @RequestBody Business bussines);

}