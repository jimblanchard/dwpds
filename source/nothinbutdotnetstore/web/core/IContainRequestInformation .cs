namespace nothinbutdotnetstore.web.core
{
  public interface IContainRequestInformation
  {
    InputModel map<InputModel>() where InputModel : new();
  }
}