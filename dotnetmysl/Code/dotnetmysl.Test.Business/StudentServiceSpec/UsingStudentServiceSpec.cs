using NSubstitute;
using dotnetmysl.Test.Framework;
using dotnetmysl.Business.Services;
using dotnetmysl.Data.Interfaces;

namespace dotnetmysl.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
