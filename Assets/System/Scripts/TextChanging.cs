using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TextChanging : MonoBehaviour
{
    public TextMeshProUGUI textToChange;

    [SerializeField] bool canSpin;

    private void Start()
    {
        canSpin = false;
    }

    public void ChangeText(InputAction.CallbackContext context)
    {
        canSpin = !canSpin;

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
