using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearCon : MonoBehaviour
{
    private int DetonatorsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DetonatorsCollected++;
        }
        if(DetonatorsCollected >= 5)
        {
            Win();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Detonator"))
        {
            DetonatorsCollected++;
        }  
    }
    void Win()
    {
        SceneManager.LoadScene("WinScene");
    }
}
