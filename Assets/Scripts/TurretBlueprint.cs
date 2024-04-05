using UnityEngine;

[System.Serializable]
public class TurretBlueprint
{
    public GameObject prefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeCost;

    private Node target;

    public float GetSellAmount(Node _target)
    {
        target = _target;
        bool turret = _target.isUpgraded;
        if (turret)
        {
            return upgradeCost * 0.8f;
        }
        else
        {
            return cost * 0.8f;
        }
    }
}
