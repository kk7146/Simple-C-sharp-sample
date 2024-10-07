public class Enemy
{
    private Player player;
    
    public void att(Player target)
    {
        target.TakeHealth(10);
    }
}

public class Player : MonoBehaviour
{
    public string ID = "123"
    private int HP = 1000;

    public Player dc()
    {
        Player c = new Player();
        c.ID = ID;
        c.HP = HP;
        return c;
    }
    public void TakeHealth(int num1)
    {
        HP -= num1;
    }
    public void RecoverHealth(int num1)
    {
        HP += num1;
    }
    public int getHP()
    {
        return HP;
    }
    public int setHP(int HP)
    {
        this.HP = HP;
    }
}

public class contr : MonoBehaviour
{
    private Player p1;
    private Player p2;

    private void Awake()
    {
        p1 = new Player("1", 1000)
        p2 = p1.dc();
        p2.ID = "2";
    }
}