using System.Security.Cryptography.X509Certificates;
using Ammo;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public Turret turret;
    public Turret turret1;
    public int turretUnlockCost;
    public int fasterDopperMoney = 100;
    public int fasterDopperAmmo = 100;
    public int fasterTurret = 100;
    public IMoney Imoney;
    public GameObject MoneyCounter;
    public GameObject SpawnerObject;
    public GameObject SpawnerObject1;
    public GameObject TurretSpeed;
    private SpawnerMoney spawnerScript;
    private SpawnerMoney spawnerScript1;
    
    
    private void Start()
    {
        Imoney = MoneyCounter.GetComponent<MoneyCounter>();
        spawnerScript = SpawnerObject.GetComponent<SpawnerMoney>(); 
        spawnerScript1 = SpawnerObject1.GetComponent<SpawnerMoney>(); 
        turret = TurretSpeed.GetComponent<Turret>();
    }
    public void UnlockTurret()
    {
        Debug.Log("Player's current money: " + Imoney.GetMoney());
        Debug.Log("UnlockTurret called");
        if (Imoney.GetMoney() >= turretUnlockCost)
        {
            Imoney.SetMoney(Imoney.GetMoney() - turretUnlockCost);
            Debug.Log("UnlockTurret er unlocked og klar at skyde");
            turret.SetEnableShooting(true);
            turret1.SetEnableShooting(true);
        }
        else
        {
            Debug.Log("No Money unlock turret");
        }
    }

    public void FasterMoneyDrop1()
    {
        Debug.Log("Spillers penge FasterMoneyDrop1: " + Imoney.GetMoney());
        if (Imoney.GetMoney() >= fasterDopperMoney)
        {
            Imoney.SetMoney(Imoney.GetMoney() - fasterDopperMoney);
            Debug.Log("After if");
            float reducedInterval = spawnerScript.spawnInterval * 0.8f; // Reducer SpawnInterval med 20%
            spawnerScript.spawnInterval = reducedInterval;
            Debug.Log("SpawnInterval : " + reducedInterval);
        }
        else
        {
            Debug.Log("No Money unlock turret");
        }
    }
    
    public void FasterAmmoDrop()
    {
        Debug.Log("Spillers penge FasterAmmoDrop1: " + Imoney.GetMoney());
        if (Imoney.GetMoney() >= fasterDopperAmmo)
        {
            Imoney.SetMoney(Imoney.GetMoney() - fasterDopperAmmo);
            Debug.Log("After if");
            float reducedInterval = spawnerScript1.spawnInterval * 0.8f; // Reducer SpawnInterval med 20%
            spawnerScript1.spawnInterval = reducedInterval;
            Debug.Log("SpawnInterval : " + reducedInterval);
        }
        else
        {
            Debug.Log("No Money unlock turret");
        }
    }
    
    public void FasterTurretShoot()
    {
        Debug.Log("Player's current money before FasterShooting: " + Imoney.GetMoney());
        if (Imoney.GetMoney() >= fasterTurret)
        {
            Imoney.SetMoney(Imoney.GetMoney() - fasterTurret);
            Debug.Log("After if");
            float reducedInterval = turret.fireRate * 2; // Reducer SpawnInterval med 20%
            turret.fireRate = reducedInterval;
            Debug.Log("SpawnInterval reduced to: " + reducedInterval);
        }
        else
        {
            Debug.Log("Not enough money to unlock turret");
        }
    }
    
   

   
}