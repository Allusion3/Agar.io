using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{

    public List<Material> mats = new List<Material>();

    //Anything in this function will be called once when the player is created.
    void Awake()
    {
        GetComponent<Renderer>().material = mats[Random.Range(0, mats.Count)];
    }

}
