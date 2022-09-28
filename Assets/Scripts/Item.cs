using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType { None, Wood, String, Coal, Metal_scrap, Gummy_bear, Rose_petal, Paper, Cotton, Glass, Playing_card }
    public ItemType itemType; 
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Wood: return ItemAssets.Instance.woodSprite;
            case ItemType.Metal_scrap: return ItemAssets.Instance.metalSprite;
            case ItemType.String: return ItemAssets.Instance.stringSprite;
            case ItemType.Coal: return ItemAssets.Instance.coalSprite;





        }
    }

}
