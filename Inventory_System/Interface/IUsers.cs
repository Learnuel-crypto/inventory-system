namespace Inventory_System.Model
{
    public interface IUsers
    {
        string FirstAnswer { get; set; }
        string FirstQuestion { get; set; }
        bool IsLogin { get; }
        string NewPassword { get; set; }
        string Newusername { get; set; }
        string SecondAnswer { get; set; }
        string SecondQuestion { get; set; }
        string UserID { get; set; }
        string Username { get; set; }

        void Delete(IUsers user); 
        bool IfUsersExist();
        bool Login(string username, string password);
        
        void ResetPassword(IUsers user);
        void ResetPassword(IUsers user, string loggedUserID);
        void ResetUsername(IUsers user, string loggedUserID);
       
       void ForgottonPassword(IUsers user);
        string newRole { get; set; }
    }
}