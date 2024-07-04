namespace search;

public class Searcher
{
    public void LinealSearchByName(List<User> users, string name)
    {
        foreach (var item in users)
        {
            if (item.first_name == name){
                Console.WriteLine($"User found \nid: {item.id}\nname: {item.first_name}");
                break;
            } 
        }
    }
}
