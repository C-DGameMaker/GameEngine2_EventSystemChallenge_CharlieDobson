using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// This is used to determine whether or not to change the text
/// and what it should say at the bottom of the screen
/// </summary>
public class TextChanging : MonoBehaviour
{
    // This is used to find and change the text of the text object we want 
    // the text to change on
    public TextMeshProUGUI textToChange;

    // A bool is used to determine when the cube can spin
    [SerializeField] bool canSpin;

    // In start, we set the bool to false as we don't want it spinning automatically
    private void Start()
    {
        canSpin = false;
    }

    // This uses the Event system. This will trigger only when the targetted button is hit
    public void ChangeText(InputAction.CallbackContext context)
    {
        // First, it sets the canSpin bool to whatever the opposite of it was
        canSpin = !canSpin;

        // Then it checks the bool current property.
        // If it's true, it switches the text to say "The Cube is spinning"
        // If false, it switches the text to say "The Cube is not spinning"
        if (canSpin == true)
        {
            textToChange.text = "The Cube is spinning";
        }
        else
        {
            textToChange.text = "The Cube is not spinning";
        }
    }
}
