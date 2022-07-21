using Inventory_System.Model;
using Inventory_System.Model.Helper;
using Inventory_System.Models;

namespace Inventory_System
{
  public static class Factory
    {
        /// <summary>
        /// Create sql connection instace
        /// </summary>
        /// <returns></returns>
        public static ISqlHelper CreateSqlConHelper()
        {
            return  new SqlHelper();
        }
        /// <summary>
        /// Create new users instance
        /// </summary>
        /// <returns></returns>
        public static IUsers CreateNewUsers()
        {
            return  new Users();
        }
        /// <summary>
        /// create new category
        /// </summary>
        /// <returns></returns>
        public static Category CreateCategory()
        {
            return new Category();
        }
        /// <summary>
        /// Create new products instance
        /// </summary>
        /// <returns></returns>
        public static Products CreateProducts()
        {
            return  new Products();
        }
        /// <summary>
        /// create new customer instance
        /// </summary>
        /// <returns></returns>
        public static Customer CreateCustomer()
        {
            return  new Customer();
        }
        /// <summary>
        /// create new cheque instance
        /// </summary>
        /// <returns></returns>
        public static Cheque CreateCheque()
        {
            return  new Cheque();
        }
        /// <summary>
        /// create new sales
        /// </summary>
        /// <returns></returns>
        public static Sales CreateSales()
        {
            return  new Sales();
        }
        /// <summary>
        /// Create new staff instance
        /// </summary>
        /// <returns></returns>
        public static Staff CreateStaff()
        {
            return  new Staff();
        }
        /// <summary>
        /// Create new user activity instance
        /// </summary>
        /// <returns></returns>
        public static UserActivity CreateActivity()
        {
            return  new UserActivity();
        }
        /// <summary>
        /// Create an interface of users
        /// </summary>
        /// <returns></returns>
        public static IUsers CreateUser()
        {
            return new Users();
        }
    }
}
