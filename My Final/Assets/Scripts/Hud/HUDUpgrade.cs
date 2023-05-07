using UnityEngine;

public class HUDUpgrade : MonoBehaviour
{
    public UpgradeManager upgradeManager;

    public void OnTurretUnlockButtonClicked()
    {
        upgradeManager.UnlockTurret();
    }
    public void OnMoneyDropSpeedButtonClicked()
    {
        upgradeManager.FasterMoneyDrop1();
    }
    public void OnAmmoSpeedButtonClicked()
    {
        upgradeManager.FasterAmmoDrop();
    }
    
    public void OnTurretSpeedButtonClicked()
    {
        upgradeManager.FasterTurretShoot();
    }
    
    
}