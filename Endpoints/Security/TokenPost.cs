﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IWantApp.Endpoints.Security;
 
public class TokenPost
{
    public static string Template => "/token";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Hendle => Action;

    [AllowAnonymous]
    public static IResult Action(LoginRequest loginRequest,IConfiguration configuration, UserManager<IdentityUser> userManager)
    {
        var user = userManager.FindByEmailAsync(loginRequest.Email).Result;

        if (user == null)
        {
            Results.BadRequest();
        }

        if(!userManager.CheckPasswordAsync(user, loginRequest.Password).Result)
        {
            Results.BadRequest();
        }

        var key = Encoding.ASCII.GetBytes(configuration["JwtBearerTokenSettings:SecretKey"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Email, loginRequest.Email),
            }),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            Audience = configuration["JwtBearerTokenSettings:Audience"],
            Issuer = configuration["JwtBearerTokenSettings:Issuer"]
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return Results.Ok(new
        {
            token = tokenHandler.WriteToken(token)
        });
    }
}
