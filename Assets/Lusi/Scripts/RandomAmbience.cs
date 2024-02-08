using System.Collections;
using UnityEngine;

public class RandomAmbience : MonoBehaviour
{
    public AudioClip[] ambienceSounds; // Array of ambience sounds to choose from
    public AudioSource audioSource; // Reference to the AudioSource component

    public float minDelay = 5f; // Minimum delay between sounds
    public float maxDelay = 20f; // Maximum delay between sounds

    void Start()
    {
        // Start the coroutine to play random sounds
        StartCoroutine(PlayRandomAmbience());
    }

    IEnumerator PlayRandomAmbience()
    {
        while (true)
        {
            // Wait for a random delay between minDelay and maxDelay
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            // Choose a random ambience sound from the array
            AudioClip randomSound = ambienceSounds[Random.Range(0, ambienceSounds.Length)];

            // Assign the chosen sound to the audio source and play it
            audioSource.clip = randomSound;
            audioSource.Play();
        }
    }
}
