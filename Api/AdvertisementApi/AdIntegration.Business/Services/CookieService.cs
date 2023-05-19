using AdIntegration.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services
{
    public class CookieService : ICookieService
    {
        private readonly CookieOptions _cookieOptions;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger _logger;

        public CookieService(CookieOptions cookieOptions, IHttpContextAccessor contextAccessor)
        {
            _cookieOptions = cookieOptions;
            _contextAccessor = contextAccessor;
        }

        public void DeleteAllCookies(IEnumerable<string> cookiesToDelete)
        {
            throw new NotImplementedException();
        }

        public void DeleteCookie(string key)
        {
            throw new NotImplementedException();
        }

        public string GetCookie(string key)
        {
            return _contextAccessor.HttpContext.Request.Cookies[key];
        }

        public string GetUserCountry()
        {
            throw new NotImplementedException();
        }

        public string GetUserIP()
        {
            string userIp = "unknown";

            try
            {
                userIp = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
                return userIp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string GetUserOS()
        {
            throw new NotImplementedException();
        }

        public void SetCookie(string key, string value, int? expireTime, bool isSecure, bool isHttpOnly)
        {
            _cookieOptions.Expires = expireTime.HasValue ? DateTime.Now.AddMinutes(expireTime.Value) : DateTime.Now.AddMilliseconds(10);
            _cookieOptions.Secure = isSecure;
            _cookieOptions.HttpOnly = isHttpOnly;
            _cookieOptions.IsEssential = true;
            _contextAccessor.HttpContext.Response.Cookies.Append(key, value, _cookieOptions);
        }

        public void SetCookie(string key, string value, int? expireTime)
        {
            if (expireTime.HasValue)
            {
                _cookieOptions.Secure = true;
                _cookieOptions.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            }
            else
            {
                _cookieOptions.Secure = true;
                _cookieOptions.Expires = DateTime.Now.AddMilliseconds(10);
            }
            _cookieOptions.HttpOnly = true;
            _cookieOptions.SameSite = SameSiteMode.Strict;
            _contextAccessor.HttpContext.Response.Cookies.Append(key, value, _cookieOptions);
        }
    }
}
