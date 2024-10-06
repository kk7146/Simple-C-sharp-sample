public class Calculator
{
    private void Awake()
    {
        Multiple(3, 4);
        Multiple(5, 8);
        Multiple(4, 6);

        int a = Max(10, 20);
        Debug.Log(Max(100, 200));
        Max(5, 10);

        int b, c;
        Swap(b, c);
    }

    public int Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    public int Max(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        return num2;
    }
    public int Add(int num1, int num2)
    {
        int result= num1 + num2;
        return result;
    }

     public float Add(float num1, float num2)
    {
        float result= num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"(num1) X (num2) = (result)");
    }
    public void Divide(int num1, int num2)
    {
        if (num2 == 9)
            return;
        float result = num1 / num2;
        Debug.Log($"(num1) / (num2) = (result)");
    }

    public void Player(string ID = "1", int health = 1)
    {
    }

}