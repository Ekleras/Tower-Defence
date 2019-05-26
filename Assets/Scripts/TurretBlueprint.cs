using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TurretBlueprint  {

    public GameObject prefab;
    public int cost;

    public int upgradeCost;
    public GameObject upgradedPrefab;

    // Parduoda uz dvigubai pigiau. Reikes paskaiciuot ir apibendrint kiek monstrai duoda ir pns.
    public int GetSellAmount()
    {
        return cost / 2;
    }
	
}
