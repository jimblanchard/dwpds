using System;
using System.Web;

namespace nothinbutdotnetstore.web.core
{
  public class WebRequestFactory : ICreateRequests
  {
    public IContainRequestInformation create_request_from(HttpContext context)
    {
      return new RequestInformation();
    }
  }
}