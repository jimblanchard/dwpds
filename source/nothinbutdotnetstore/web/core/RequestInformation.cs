using System;

namespace nothinbutdotnetstore.web.core
{
  public class RequestInformation : IContainRequestInformation
  {
    public InputModel map<InputModel>() where InputModel : new()
    {
      return new InputModel();
    }
  }
}