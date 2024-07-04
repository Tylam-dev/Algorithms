namespace Algorithms;

public class Searcher
{
    public void LinealSearchById(List<User> users, int id)
    {
        foreach (var item in users)
        {
            if (item.id == id){
                Console.WriteLine($"User found \nid: {item.id}\nname: {item.first_name}");
                break;
            } 
        }
    }
    public void BinarySearchById(List<User> users, int id)
    {
        int left= 1;
        int right = users.Count();
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (users[mid].id == id) 
            {
                Console.WriteLine($"User found \nid: {users[mid].id}\nname: {users[mid].first_name}");
                return;
            }
            if(users[mid].id < id)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        Console.WriteLine("No se encontro el usuario");
    }
}
