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
    public GameObject buildEffect;


    private Node selectedNode;
    private TurretBlueprint turretToBuild;
    public NodeUI nodeUI;

    public bool CanBuild {  get { return turretToBuild != null; } }                    // Geras dalykelis.
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    // Paspaudzia ant kvadratuko musu ;).
    public void SelectNode(Node node)
    {
        if (node == selectedNode)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    // Paspaudzia kazkur kitur ;).
    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
