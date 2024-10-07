public abstract class Entity
{
     public string ID;
    protected int HP;
    protected int dg;

    public abstract void att(int dmage)
     public void Init()
    {
        ID = "None";
    }
    public void RHP(int hp)
    {
        HP = hp;
    }
    public void TakeHealth(int num1)
    {
        HP -= num1;
    }
}
public class Player : Entity
{    public Player dc(string id, int hp)
    {
        base.ID = id;
        HP = hp;
        RHP(1000);
        Init();
    }
}

public class Enemy
{   
    public void td(Player target)
    {
        Debug.Log($"0")
    }
    public void att(int dmage)
    {
        Debug.Log($"Attack")
    }
}

public class G : Enemy
{   
    public void td(int dmage)
    {
        Debug.Log($"G : (damage)")
    }
     public void att(int dmage)
    {
        Debug.Log($"1)")
    }
}

public class S : Enemy
{   
    public void td(int dmage)
    {
        Debug.Log($"S : (damage)")
    }
    public void att(int dmage)
    {
        Debug.Log($"2")
    }
}

public class D : Enemy
{
    public void td(int dmage)
    {
        Debug.Log($"D : (damage)")
    }   
    public void att(int dmage)
    {
        Debug.Log($"3")
    }
}

public class contr : MonoBehaviour
{
    private void Awake()
    {
        Entity entity = new S;
        if (entity is S)
            Debug.Log("1");
        G gob = entity as G;
        if (gob == null)
            Debug.Log("2");
    }
}

public class Entity
{
	public virtual void TakeDamage(int damage)
	{
		Debug.Log($"Entity: (damage)");
	}
}
public class Moving Entity: Entity
{
	public override void TakeDamage(int damage)
	{
		Debug.Log($"Entity: (damage)");
	}
}
public class Player: MovingEntity
{
	public override void TakeDamage(int damage)
	{
		Debug.Log($"Entity: (damage)");
	}
}


public class MovingEntity: Entity
{
    public sealed override void TakeDamage(int damage)
    {
        Debug.Log($"Entity: (damage)");
    }
}