using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject food;
    public float speed;

    void Start()
    {
        InvokeRepeating("GenerateFood", 0, speed);
        InvokeRepeating("GenerateEnemy", 0, speed / 2);
    }
    void GenerateFood()
    {
        //Gets camera width
        int x = Random.Range(0, Camera.main.pixelWidth);

        //Gets camera height
        int y = Random.Range(0, Camera.main.pixelHeight);

        //
        Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));

        target.z = 0;

        //generate (gameobject, location, no rotation)
        Instantiate(food, target, Quaternion.identity);
    }

    void GenerateEnemy()
    {
        //Gets camera width
        int x = Random.Range(0, Camera.main.pixelWidth);

        //Gets camera height
        int y = Random.Range(0, Camera.main.pixelHeight);

        //
        Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));

        target.z = 0;

        //generate (gameobject, location, no rotation)
        Instantiate(food, target, Quaternion.identity);
    }
}
