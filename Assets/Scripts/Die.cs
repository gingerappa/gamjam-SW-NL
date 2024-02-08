using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject Jumpscare;
    public GameObject Scaresound;
    // Start is called before the first frame update
    void Start()
    {
        //Scaresound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Jumpscare.SetActive(true);
            Scaresound.SetActive(true);
        }
    }
}
