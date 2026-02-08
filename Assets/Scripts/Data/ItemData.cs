using UnityEngine;

[CreateAssetMenu(menuName ="DQ-Like/Items/ItemData", fileName ="Item_")]


public class ItemData : ScriptableObject
{
    public string ItemName;

    [TextArea(2,4)]
    public string Description;

    //任意だがUIで使うアイコン
    public Sprite Icon;
}
