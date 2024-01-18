using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Services;
using GraphQLProject.Type;
using GraphQLProject.Models;

namespace GraphQLProject.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(ICustomerRepository menuRepository) {
            Field<CustomerType>("createMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menu" })).Resolve(context =>
            {
                return menuRepository.AddMenu(context.GetArgument<Customer>("menu"));
            });
            Field<CustomerType>("updateMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                var menu = context.GetArgument<Customer>("menu");
                var menuId = context.GetArgument<int>("menuId");
                return menuRepository.UpdateMenu(menuId, menu);
            });
            Field<StringGraphType>("deleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuid" })).Resolve(context =>
            {
                var menuId = context.GetArgument<int>("menuId");
                menuRepository.DeleteMenu(menuId);
                return "Delete Successfully!";

            });
        }
    }
}
