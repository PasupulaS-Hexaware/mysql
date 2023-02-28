using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using dotnetmysl.Entities.Entities;

namespace dotnetmysl.Test.Api.EntityControllerSpec
{
    public class When_getting_all_entity : UsingEntityControllerSpec
    {
        private ActionResult<IEnumerable<Entity>> _result;

        private IEnumerable<Entity> _all_entity;
        private Entity _entity;

        public override void Context()
        {
            base.Context();

            _entity = new Entity{
                enname = "enname"
            };

            _all_entity = new List<Entity> { _entity};
            _entityService.GetAll().Returns(_all_entity);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _entityService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<Entity>>();

            List<Entity> resultList = resultListObject as List<Entity>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_entity);
        }
    }
}
