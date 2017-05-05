using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objects : MonoBehaviour {

    public string pu;
    public string name;
    public Texture2D sprite;

    public string PopUp()
    {
        return pu;
    }
}
