using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Objects {

    GameObject container;

    void Start()
    {
        container = FindObjectOfType<Objects>().gameObject;
    }
}
