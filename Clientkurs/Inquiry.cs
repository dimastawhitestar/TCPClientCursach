namespace Clientkurs
{
    enum TypeInquiry
    {
        authorization = 0,
        registration = 1,
        clientInfo = 2,
        massIdCategories = 3,
        categorieInfo = 4,
        massIdProducts = 5,
        productInfo = 6,
        buy = 7
    }

    public class Inquiry
    {
        public int typeInquiry;
    }

    public class AutorizationInquiry : Inquiry
    {
        public string login;
        public string password;
        public bool server;
    }

    public class RegistrationInquiry : Inquiry
    {
        public string login;
        public string password;
        public string firstname;
        public string surname;
        public string address;
        public string email;
    }

    public class CategorieInfoInquiry : Inquiry
    {
        public int id;
    }

    public class MassIdProductsInquiry : Inquiry
    {
        public int indexStart;
        public int count;
        public int idCategorie;
        public string search;
    }

    public class ProductInfoInquiry : Inquiry
    {
        public int id;
    }

    public class BuyInquiry : Inquiry
    {
        public int[] idMassProduct;
    }
}
