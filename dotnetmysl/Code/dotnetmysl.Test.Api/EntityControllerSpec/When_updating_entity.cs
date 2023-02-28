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
    public class When_updating_entity : UsingEntityControllerSpec
    {
        private ActionResult<Entity > _result;
        private Entity _entity;

        public override void Context()
        {
            base.Context();

            _entity = new Entity
            {
                enname = "enname"
            };

            _entityService.Update( _entity).Returns(_entity);
            
        }
        public override void Because()
        {
            _result = subject.Update( _entity);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _entityService.Received(1).Update( _entity);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Entity>();

            var resultList = resultListObject as Entity;

            resultList.ShouldBe(_entity);
        }
    }
}
