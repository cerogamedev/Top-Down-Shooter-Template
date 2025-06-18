using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;

    [SerializeField] private GameObject upgradePanel;
    [SerializeField] private List<UpgradeData> allUpgrades;
    [SerializeField] private UpgradeButton[] buttons;

    void Awake()
    {
        Instance = this;
    }

    public void ShowUpgrades()
    {
        Time.timeScale = 0f;
        upgradePanel.SetActive(true);

        var chosen = GetRandomUpgrades(3);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetUpgrade(chosen[i]);
        }
    }

    public void ApplyUpgrade(UpgradeData upgrade)
    {
        switch (upgrade.type)
        {
            case UpgradeType.FireRate:
                FindFirstObjectByType<WeaponHandler>().fireRate *= 1f - (upgrade.value / 100f);
                break;
            case UpgradeType.Damage:
                // bullet prefab içinde damage güncellemesi gerekir
                break;
            case UpgradeType.MaxHealth:
                // PlayerStats.Instance.IncreaseMaxHealth(upgrade.value);
                break;
        }

        upgradePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private List<UpgradeData> GetRandomUpgrades(int count)
    {
        List<UpgradeData> result = new();
        List<UpgradeData> copy = new(allUpgrades);

        for (int i = 0; i < count; i++)
        {
            int index = Random.Range(0, copy.Count);
            result.Add(copy[index]);
            copy.RemoveAt(index);
        }

        return result;
    }
}
