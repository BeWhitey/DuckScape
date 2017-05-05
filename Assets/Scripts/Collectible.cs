using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Objects
{
    GameObject container;
    public int id;

    void Start()
    {
        //container = FindObjectOfType<Objects>().gameObject;
    }
}
