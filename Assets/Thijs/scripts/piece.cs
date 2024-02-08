using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour
{
    public static int piecesCollected;
    public GameObject particlePrefab;
    public AudioSource audioSource; // Add this variable to hold the AudioSource component
    private Vector3 basePos;

    private void Awake()
    {
        basePos = transform.position;
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    public void Update()
    {
        Vector3 pos = transform.position;
        pos.y = basePos.y + (0.2f * Mathf.Cos(Time.time * 2f));
        transform.position = pos;

        transform.Rotate(0, 45 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (gameObject.tag == "piece" && collision.gameObject.tag == "Player")
        {
            piecesCollected++;
            Debug.Log("Pieces collected: " + piecesCollected);
            GameObject particle = Instantiate(particlePrefab, gameObject.transform.position, Quaternion.identity);
            particle.GetComponent<ParticleSystem>().Play();
            Destroy(particle, 1);
            Destroy(gameObject);

            
        }
    }
}
