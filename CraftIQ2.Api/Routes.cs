namespace CraftIQ2.Api
{
    public class Routes
    {
        public class CategoriesRoutes
        {
            public const string BaseUrl = "/category";
            public const string Delete = BaseUrl + "/{categoryId}";
            public const string ReadById = BaseUrl + "/{categoryId}";
            public const string Update = BaseUrl + "/{categoryId}";

        }
    }
}
