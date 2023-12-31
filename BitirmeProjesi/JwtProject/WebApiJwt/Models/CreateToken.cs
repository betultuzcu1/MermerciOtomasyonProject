﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
	public class CreateToken
	{
		public void TokenCreate() 
		{
			var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
			SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
			SigningCredentials credentials=new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
			JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost",audience: "http://localhost",notBefore:DateTime.Now,expires:DateTime.Now.AddSeconds(15),signingCredentials:credentials);
			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			handler.WriteToken(token);
		}
		public void TokenCreateAdmin()
		{
			var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
			SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
			SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			List<Claim> claims = new List<Claim>()
			{
				new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Role,"Yönetici")
			};
			JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddSeconds(15), signingCredentials: credentials,claims:claims);
			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			handler.WriteToken(token);
		}
	}
}
