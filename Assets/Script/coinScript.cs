using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        ScoreTextScript.coinAmount += 1;
        Destroy(gameObject);
    }
}
