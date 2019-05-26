using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour {

    public GameObject ui;
    private Node target;
    public Text upgradeCost;
    public Button upgradeButton;
    public Text sellAmount;
    
    public void SetTarget(Node _target)
    {
        this.target = _target;
        transform.position = target.GetBuildPosition();

        // Galim ateity implementuot daugiau UPDEITU nes dabar tik vienas.
        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "MAX";
            upgradeButton.interactable = false;
        }

        // Galim stringa permest kaip private charą, jei reiktų pakeist į kokius eurus, kad nereiktų ieškot.
        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    // Atnaujinti turreta.
    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    // Parduoti turret Upgrade() ir Sell() onClick eventai nurodyti inspektoriuj.
    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
