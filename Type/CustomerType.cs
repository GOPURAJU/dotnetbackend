using GraphQL.Types;
using GraphQLProject.Models;
namespace GraphQLProject.Type
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(m => m.CustomerID);
            Field(m => m.FirstName);
            Field(m => m.LastName);
            Field(m => m.Email);
            Field(m => m.Mobile);
        }
    }
}
