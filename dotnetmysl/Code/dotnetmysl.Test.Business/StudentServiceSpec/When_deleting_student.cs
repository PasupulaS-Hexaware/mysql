using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetmysl.Entities.Entities;

namespace dotnetmysl.Test.Business.StudentServiceSpec
{
    public class When_deleting_student : UsingStudentServiceSpec
    {
        private bool _result;

        private int Id = 1;

        public override void Context()
        {
            base.Context();

            _studentRepository.Delete(Id).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Delete(Id);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _studentRepository.Received(1).Delete(Id);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<bool>();

            _result.ShouldBe(true);
        }
    }
}
