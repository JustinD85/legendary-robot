using Application.GraphQL.Types;

namespace Application.Types
{
    public class Query
    {
        public GameObject GameObject() => new GameObject();
        public Value Value() => new Value();

    }
}