using System.Web;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.specs.utility;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  public class WebRequestFactorySpecs
  {
    [Subject(typeof (WebRequestFactory))]
    public abstract class concern : Observes<ICreateRequests, WebRequestFactory>
    {

    }

    public class when_asked_for_request_data : concern
    {
      Establish c =
        () =>
          {
            context = ObjectFactory.web.create_http_context();
          };

      Because b =
        () =>
          {
            request = sut.create_request_from(context);
          };
                  

      It should_return_an_IContainRequestInformation_that_you_know_contains_the_information =
        () =>
          {
            request.ShouldNotBeNull();
          };

      static HttpContext context;
      static IContainRequestInformation request;
    }
  }
}
