using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{

    public string tag;
    public float increase;
    public Text letters;

    private int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == tag)
        {
            transform.localScale += new Vector3(increase, increase, increase);

            //destroy the food since we ate it
            Destroy(other.gameObject);
            
            //once eaten increase score by 10
            score += 10;
            letters.text = "SCORE: " + score;
        }
    }
}
