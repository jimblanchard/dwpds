using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof (ViewSubDepartments))]
  public class ViewSubDepartmentsSpecs
  {
    public abstract class concern : Observes<IProcessAnApplicationSpecificBehaviour, ViewSubDepartments>
    {

    }

    public class when_run : concern
    {
      private Establish c = () =>
                              {
                                display_engine = depends.on<ICanRenderInformation>();
                                store_catalog = depends.on<ICanFindDetailsInTheStore>();
                                request = fake.an<IContainRequestInformation>();
                                dept = fake.an<DepartmentItem>();
                                the_sub_departments = new List<DepartmentItem> { new DepartmentItem() };

                                store_catalog.setup(x => x.get_sub_departments_for_department(dept)).Return(the_sub_departments);
                              };
      private Because b = () =>
                          sut.run(request);

      private It should_get_the_list_of_sub_departments_for_the_department = () =>
                                                                               { };
      It should_tell_the_display_engine_to_display_the_departments = () =>
        display_engine.received(x => x.display(the_sub_departments));

      
      private static IContainRequestInformation request;
      private static ICanRenderInformation display_engine;
      private static ICanFindDetailsInTheStore store_catalog;
      private static IEnumerable<DepartmentItem> the_sub_departments;
      private static DepartmentItem dept;
    }
  }
}
