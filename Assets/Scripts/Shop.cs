using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandartTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standarTurretPrefab);
    }

    public void PurchaseMissleLauncher()
    {
        buildManager.SetTurretToBuild(buildManager.missleLauncherPrefab);
    }
}
