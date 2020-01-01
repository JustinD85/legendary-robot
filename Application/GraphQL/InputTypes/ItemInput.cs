using System;

namespace Application.GraphQL.InputTypes
{
    public class ItemInput
    {
        public Guid id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

    }
}