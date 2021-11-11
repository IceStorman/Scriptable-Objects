using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
    [SerializeField]
    private Text swordName;
    [SerializeField]
    private Text description;
    [SerializeField]
    private Image icon;
    [SerializeField]
    private Text goldCost;
    [SerializeField]
    private Text attackDamage;

    public void UpdateDisplayUI(SwordData swordData)
    {
        swordName.text = swordData.swordName;
        description.text = swordData.description;
        icon.sprite = swordData.icon;
        goldCost.text = swordData.goldCost.ToString();
        attackDamage.text = swordData.attackDamage.ToString();
    }
}
