using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_piece : MonoBehaviour
{
    public static int piecesCollected;
    public GameObject particlePrefab;
    private void OnTriggerEnter(Collider collision)
    {
        if (gameObject.tag == "piece" && collision.gameObject.tag == "player")
        {
            piecesCollected++;
            Debug.Log(piecesCollected);
            GameObject particle = Instantiate(particlePrefab, gameObject.transform.position, Quaternion.identity);
            particle.GetComponent<ParticleSystem>().Play();
            Destroy(particle, 1);
            Destroy(gameObject);
        }
    }
}

