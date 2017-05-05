using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {

    //Variables
    public LayerMask mask;
    Interactable inter;

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
            inter = hit.transform.GetComponent<Interactable>();
            if (inter)
            {
                Debug.Log(inter.PopUp());
                Destroy(inter.gameObject);
            }
        }
    }
}
