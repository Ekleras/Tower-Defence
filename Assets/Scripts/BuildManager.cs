using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More Than One Build Manager In Scene");
            return;
        }
        instance = this;
    }

    public GameObject standarTurretPrefab;
    public GameObject missileLauncherPrefab;


    private TurretBlueprint turretToBuild;

    public bool CanBuild {  get { return turretToBuild != null; } }

    public void BuildTurretOn(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Turret built! Money left:" + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
