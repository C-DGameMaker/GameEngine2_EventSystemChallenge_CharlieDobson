using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class EventSystem : MonoBehaviour
{
    public GameObject cube;
    public TextMeshProUGUI textToChange;
    private bool canSpin;

    public void Start()
    {
        canSpin = false;
    }

    public void CubeSpinning(InputAction.CallbackContext context)
    {
        canSpin = !canSpin;
    }

    public void ChangeText(InputAction.CallbackContext context)
    {
        if(canSpin == true)
        {
            textToChange.text = "The Cube is spinning";
        }
        else
        {
            textToChange.text = "The Cube is not spinning";
        }
    }

    public void Update()
    {
        if(canSpin == true)
        {
            cube.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}
