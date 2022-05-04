public class God
{
    public static Human[] Create()
    {
        var man = new Man();
        var woman = new Woman();
        var array = new Human[] { man, woman };
        return array;
    }
}

public class human
{

}

public class Woman : Human
{


}

public class Man : Human
{


}
