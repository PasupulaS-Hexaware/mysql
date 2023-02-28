using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetmysl.Entities.Entities;

namespace dotnetmysl.Test.Business.EntityServiceSpec
{
    public class When_saving_entity : UsingEntityServiceSpec
    {
        private Entity _result;

        private Entity _entity;

        public override void Context()
        {
            base.Context();

            _entity = new Entity
            {
                enname = "enname"
            };

            _entityRepository.Save(_entity).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Save(_entity);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _entityRepository.Received(1).Save(_entity);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Entity>();

            _result.ShouldBe(_entity);
        }
    }
}
