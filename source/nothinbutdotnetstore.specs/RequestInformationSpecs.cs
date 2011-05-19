using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  public class RequestInformationSpecs
  {
    [Subject(typeof (RequestInformation))]
    public abstract class concern : Observes<IContainRequestInformation, RequestInformation>
    {

    }

    public class asked_to_map : concern
    {
      Because b =
        () =>
          {
            departmentItem = sut.map<DepartmentItem>();
          };
                  

      It should_return_an_instance_of_the_appropriate_type =
        () =>
          {
            departmentItem.ShouldNotBeNull();
          };

      static DepartmentItem departmentItem;
    }
  }
}
