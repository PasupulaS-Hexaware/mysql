using NSubstitute;
using dotnetmysl.Test.Framework;
using dotnetmysl.Api.Controllers;
using dotnetmysl.Business.Interfaces;


namespace dotnetmysl.Test.Api.EntityControllerSpec
{
    public abstract class UsingEntityControllerSpec : SpecFor<EntityController>
    {
        protected IEntityService _entityService;

        public override void Context()
        {
            _entityService = Substitute.For<IEntityService>();
            subject = new EntityController(_entityService);

        }

    }
}
