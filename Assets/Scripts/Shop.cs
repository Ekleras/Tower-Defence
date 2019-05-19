using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standartTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandartTurret()
    {
        buildManager.SelectTurretToBuild(standartTurret);
    }

    public void SelectMissileLauncher()
    {
        buildManager.SelectTurretToBuild(missileLauncher);
    }
}
