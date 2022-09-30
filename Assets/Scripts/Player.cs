using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;

    private Inventory inventory;

    [SerializeField] private Rigidbody rb;

    [SerializeField]
    private float moveSpeed = 5f;

    bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        //   ItemWorld.SpawnItemWorld(new Vector3(0, 3, 100), new Item { itemType = Item.ItemType.Wood, amount = 1 });
        //   ItemWorld.SpawnItemWorld(new Vector3(0, -3, 100), new Item { itemType = Item.ItemType.Coal, amount = 1 });
        //   ItemWorld.SpawnItemWorld(new Vector3(0, -1, 100), new Item { itemType = Item.ItemType.String, amount = 1 });
    }

    private void Update()
    {
        isMoving = false;
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * moveSpeed;
            isMoving = true;
            rb.constraints = RigidbodyConstraints.None;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * moveSpeed;
            isMoving = true;
            rb.constraints = RigidbodyConstraints.None;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.up * moveSpeed;
            isMoving = true;
            rb.constraints = RigidbodyConstraints.None;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.up * moveSpeed;
            isMoving = true;
            rb.constraints = RigidbodyConstraints.None;
        }



        if (!isMoving)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        }


    }

}
