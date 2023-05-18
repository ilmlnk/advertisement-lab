namespace AdIntegration.Business.Interfaces;

public interface ICookieService
{
    void SetCookie(string key, string value, int? expireTime, bool isSecure, bool isHttpOnly);
    void SetCookie(string key, string value, int? expireTime);
    void DeleteCookie(string key);
    void DeleteAllCookies(IEnumerable<string> cookiesToDelete);
    string GetCookie(string key);
    string GetUserIP();
    string GetUserCountry();
    string GetUserOS();
}
