using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objects : MonoBehaviour {

    public string popUp; //recuadro de informacion emergente al pasar sobre el objeto
    public string name;
    public Texture2D sprite;

    public string PopUp()
    {
        return popUp;
    }
}
