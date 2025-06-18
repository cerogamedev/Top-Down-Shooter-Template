using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Text titleText;
    public Text descText;
    public Image iconImage;
    private UpgradeData upgrade;

    public void SetUpgrade(UpgradeData data)
    {
        upgrade = data;
        titleText.text = data.upgradeName;
        descText.text = data.description;
        iconImage.sprite = data.icon;
    }

    public void OnClick()
    {
        UpgradeManager.Instance.ApplyUpgrade(upgrade);
    }
}
