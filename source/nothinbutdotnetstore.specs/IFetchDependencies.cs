using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.infrastructure;
 using nothinbutdotnetstore.infrastructure.container;

namespace nothinbutdotnetstore.specs
{   
  public class FetchDependenciesSpecs
  {
    public abstract class concern : Observes<IFetchDependencies,
                                      FetchDependencies>
    {
        
    }

    [Subject(typeof(FetchDependencies))]
    public class when_requesting_a_dependent_type_instance : concern
    {
      Establish c = 
        () =>
          {
            thisIsABogusInstance = fake.an<IAmABogusInterface>();
            sut.setup(x => x.an<IAmABogusInterface>()).Return(thisIsABogusInstance);
          };
      Because b =
        () =>
          {
            result = sut.an<IAmABogusInterface>();
          };

      It should_return_an_instance_of_the_requested_type =
        () =>
          {
            result.ShouldBeAn<IAmABogusInterface>();
          };

      static IAmABogusInterface result;
      static IAmABogusInterface thisIsABogusInstance;
    }
  }

  internal interface IAmABogusInterface
  {
  }
}
