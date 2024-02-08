using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; // Reference to the UI text element to display the timer
    private float timer = 300f; // 5 minutes in seconds
    private bool isRunning = false;

    public Color flashColor = Color.red;
    public float flashInterval = 0.5f; // Flash interval in seconds

    void Start()
    {
        // Optionally, you can start the timer automatically when the game begins
        StartTimer();
    }

    void Update()
    {
        if (isRunning)
        {
            // Update the timer
            timer -= Time.deltaTime;

            // Format and display the timer
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            timerText.text = $"{minutes:00}:{seconds:00}";

            // Flash the text between white and red
            FlashText();
        }
    }

    void FlashText()
    {
        float lerpTime = Mathf.PingPong(Time.time / flashInterval, 1);
        timerText.color = Color.Lerp(Color.white, flashColor, lerpTime);
    }

    public void StartTimer()
    {
        // Start the timer
        isRunning = true;
    }

    public void StopTimer()
    {
        // Stop the timer
        isRunning = false;
    }

    public void ResetTimer()
    {
        // Reset the timer to 5 minutes
        timer = 300f;
    }
}
