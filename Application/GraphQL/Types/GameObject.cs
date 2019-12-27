using HotChocolate.Types;

namespace Application.GraphQL.Types
{
    public class GameObject : ObjectType<Domain.GameObject>
    {
        protected override void Configure(IObjectTypeDescriptor<Domain.GameObject> descriptor)
        {
            descriptor.Field("testt").Resolver("success");
            descriptor.Authorize();
            descriptor.Field("test").Resolver("success").Authorize();
        }
    }
}