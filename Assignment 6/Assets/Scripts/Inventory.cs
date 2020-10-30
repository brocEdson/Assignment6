/* Broc Edson
 * Assignment 6
 * Uses the inventory item class in the editor
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]private InventoryItem item;
    public List<InventoryItem> inventory;

    // Start is called before the first frame update
    void Start()
    {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
