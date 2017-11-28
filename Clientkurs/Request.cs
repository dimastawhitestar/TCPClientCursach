namespace Clientkurs
{
    enum TypeRequest
    {
        boolRequest = 0,
        clientInfoRequest = 1,
        massIdCategories = 2,
        categorieInfo = 3,
        massIdProducts = 4,
        productInfo = 5
    }

    public class Request
    {
        public int typeRequest;
    }

    public class BoolRequest : Request
    {
        public bool flag;
    }

    public class ClientInfoRequest : BoolRequest
    {
        public string firstname;
        public string surname;
        public int money;
        public string address;
        public string email;
    }

    public class MassIdCategoriesRequest : Request
    {
        public int[] idMass;
    }

    public class CategorieInfoRequest : BoolRequest
    {
        public string name;
    }

    public class MassIdProductsRequest : Request
    {
        public int[] idMass;
    }

    public class ProductInfoRequest : BoolRequest
    {
        public string name;
        public int price;
        public int idCategorie;
        public string description;
    }
}
