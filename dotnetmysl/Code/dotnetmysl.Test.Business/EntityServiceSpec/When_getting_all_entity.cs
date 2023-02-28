using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetmysl.Entities.Entities;

namespace dotnetmysl.Test.Business.EntityServiceSpec
{
    public class When_getting_all_entity : UsingEntityServiceSpec
    {
        private IEnumerable<Entity> _result;

        private IEnumerable<Entity> _all_entity;
        private Entity _entity;

        public override void Context()
        {
            base.Context();

            _entity = new Entity{
                enname = "enname"
            };

            _all_entity = new List<Entity> { _entity};
            _entityRepository.GetAll().Returns(_all_entity);
        }
        public override void Because()
        {
            _result = subject.GetAll();
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _entityRepository.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Entity>>();

            List<Entity> resultList = _result as List<Entity>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_entity);
        }
    }
}
