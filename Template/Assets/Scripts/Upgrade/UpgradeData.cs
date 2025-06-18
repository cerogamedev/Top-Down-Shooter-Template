using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeData", menuName = "Upgrades/Upgrade")]
public class UpgradeData : ScriptableObject
{
    public string upgradeName;
    public string description;
    public Sprite icon;
    public UpgradeType type;
    public float value;
}

public enum UpgradeType
{
    FireRate,
    Damage,
    MaxHealth
}
