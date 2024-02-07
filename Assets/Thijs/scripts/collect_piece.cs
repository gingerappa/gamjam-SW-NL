using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_piece : MonoBehaviour
{
    public static int piecesCollected;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "piece")
        {
            piecesCollected++;
            Debug.Log(piecesCollected);
            Destroy(collision.gameObject);
        }
    }
}

