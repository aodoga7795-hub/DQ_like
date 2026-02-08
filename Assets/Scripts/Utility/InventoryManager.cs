using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    private List<ItemData> items = new List<ItemData>();

    private void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// インベントリにアイテムを追加する
    /// </summary>
    /// <param name="item"></param>
    public void Add(ItemData item)
    {
        if(item == null) {
            return;
        }
        //アイテムデータをインベントリーに追加
        items.Add(item);
        Debug.Log($"[インベントリー]アイテム追加:{item.ItemName}");
        
    }

    /// <summary>
    /// 引数のアイテムを持っているかどうか
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Has(ItemData item)
    {
        return items.Contains(item);

    }

    /// <summary>
    /// ほかのClassからItemsを見たい時に呼ぶ
    /// </summary>
    /// <returns></returns>
    public IReadOnlyList<ItemData> GetAll()
    {
        return items;
    }

}
