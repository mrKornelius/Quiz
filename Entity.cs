namespace Quiz;
public class Entity
{
    private static int _id = 0;
    public int id;

    public Entity()
    {
        id = _id++;
    }
}
