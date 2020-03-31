using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using Microsoft.AspNetCore.Server.HttpSys;

namespace eProdaja.WebAPI.Filters
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            
            swaggerDoc.SecurityRequirements = new List<OpenApiSecurityRequirement>
            {
                new OpenApiSecurityRequirement
                {
                    {new OpenApiSecurityScheme()
                    {
                        Type=SecuritySchemeType.Http,
                        Scheme = AuthenticationSchemes.Basic.ToString(),
                        In=ParameterLocation.Header,
                        Name="Authorization",
                    }, new List<string>()}
                }
            };
        }
    }
}