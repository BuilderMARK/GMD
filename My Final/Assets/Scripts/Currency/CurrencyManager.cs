using UnityEngine;

public class CurrencyManager : MonoBehaviour, IMoney
{
    private int money;
    private void Start()
    {
    }

    public int GetMoney()
    {
        return money;
    }

    public void SetMoney(int amount)
    {
        money = amount;
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }

    public bool CanAfford(int amount)
    {
        return money >= amount;
    }

    public void SpendMoney(int amount)
    {
        if (CanAfford(amount))
        {
            money -= amount;
        }
    }
}