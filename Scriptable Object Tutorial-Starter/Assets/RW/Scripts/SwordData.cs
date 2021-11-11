using UnityEngine;

[CreateAssetMenu(fileName = "NewSwordData", menuName = "SwordData", order = 51)]
public class SwordData : ScriptableObject
{
    public string swordName;
    public string description;
    public Sprite icon;
    public int goldCost;
    public int attackDamage;
}
