using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {

    //Variables
    public LayerMask mask;
    Objects obj;
    public InventoryManager inventory;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Lanzamos continuamente un rayo para controlar la posicion del raton
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask);

        //Pintamos el rayo
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.magenta);
        if (hit)
        {
            obj = hit.transform.GetComponent<Objects>();
            if (obj)
            {
                Debug.Log("harl");

                if (typeof(Interactable) == obj.GetType())
                {
                    Interactable interactable = (Interactable)obj; //conversion a tipo interactable
                    Debug.Log("inter");
                }

                if(typeof(Collectible) == obj.GetType())
                {
                    Collectible collectible = (Collectible)obj; //conversion a tipo collectible

                    Debug.Log(collectible.PopUp());
                    collectible.gameObject.SetActive(false);
                    inventory.AddItem(collectible.id);
                    Debug.Log("coll");
                }
            }

        }
    }
}
