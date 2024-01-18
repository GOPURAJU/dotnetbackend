using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;
namespace GraphQLProject.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(ICustomerRepository menuRepository)
        {
            Field<ListGraphType<CustomerType>>("menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });
            Field<CustomerType>("menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name="menuId"})).Resolve(context =>
            {
                return menuRepository.GetMenuById(context.GetArgument<int>("menuId"));
            });
        }  
    }
}
