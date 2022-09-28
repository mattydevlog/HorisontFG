using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;

    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(0, 3), new Item { itemType = Item.ItemType.Wood, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(0, -3), new Item { itemType = Item.ItemType.Coal, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(0, -1), new Item { itemType = Item.ItemType.String, amount = 1 });
    }


}
