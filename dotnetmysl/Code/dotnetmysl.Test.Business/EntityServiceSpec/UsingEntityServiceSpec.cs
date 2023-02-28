using NSubstitute;
using dotnetmysl.Test.Framework;
using dotnetmysl.Business.Services;
using dotnetmysl.Data.Interfaces;

namespace dotnetmysl.Test.Business.EntityServiceSpec
{
    public abstract class UsingEntityServiceSpec : SpecFor<EntityService>
    {
        protected IEntityRepository _entityRepository;

        public override void Context()
        {
            _entityRepository = Substitute.For<IEntityRepository>();
            subject = new EntityService(_entityRepository);

        }

    }
}
