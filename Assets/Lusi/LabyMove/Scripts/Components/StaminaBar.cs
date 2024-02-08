using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public float stamina;
    float maxStamina;

    public Slider staminaBar;
    public float dValue;

    public Color normalColor = Color.green; // Color when stamina is not depleted
    public Color depletedColor = Color.red; // Color when stamina is depleted

    // Reference to the player movement script
    public FirstPersonMovement playerMovement;

    private bool canUseShift = true; // Flag to control Shift key usage

    // Start is called before the first frame update
    void Start()
    {
        maxStamina = stamina;
        staminaBar.maxValue = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        if (canUseShift && playerMovement.canRun && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.LeftShift))
        {
            DecreaseEnergy();
        }
        else if (stamina < maxStamina)
        {
            IncreaseEnergy();
        }

        staminaBar.value = stamina;

        // Change color based on stamina status
        if (stamina <= 0)
        {
            staminaBar.fillRect.GetComponent<Image>().color = depletedColor; // Change to depleted color
            playerMovement.canRun = false;
        }
        else if (stamina >= maxStamina)
        {
            staminaBar.fillRect.GetComponent<Image>().color = normalColor; // Change to normal color
            playerMovement.canRun = true;
        }
    }

    private void DecreaseEnergy()
    {
        if (stamina > 0)
        {
            stamina -= dValue * Time.deltaTime;
            if (stamina < 0)
            {
                stamina = 0;
            }
        }
    }

    private void IncreaseEnergy()
    {
        stamina += dValue * Time.deltaTime;
        if (stamina > maxStamina)
        {
            stamina = maxStamina;
        }
    }
}
