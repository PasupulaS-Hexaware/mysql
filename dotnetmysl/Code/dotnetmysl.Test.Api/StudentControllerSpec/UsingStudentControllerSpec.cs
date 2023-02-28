using NSubstitute;
using dotnetmysl.Test.Framework;
using dotnetmysl.Api.Controllers;
using dotnetmysl.Business.Interfaces;


namespace dotnetmysl.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            subject = new StudentController(_studentService);

        }

    }
}
