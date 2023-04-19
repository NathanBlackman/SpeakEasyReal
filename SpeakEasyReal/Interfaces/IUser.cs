using SpeakEasyReal.Models;

namespace SpeakEasyReal.Interfaces
{
    public interface IUser
    {
        public List<User> GetAllUsers();

        public User GetUserById(string firebaseId);
        public User UpdateUser(User user);
        public User CreateUser(User user);
        public User DeleteUser(User user);
    }
}
