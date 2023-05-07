using UnityEngine;

public class GameHandler : MonoBehaviour, IGameHandler
{
    private int money;

    public int GetMoney()
    {
        return money;
    }

    public void SetMoney(int newMoney)
    {
        money = newMoney;
    }
}
