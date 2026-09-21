using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Makes it so the cube can Rotate 
/// </summary>
public class CubeRotation : MonoBehaviour
{
    // A bool is used to determine when the cube can spin
    [SerializeField] bool canSpin;

    // In start, we set the bool to false as we don't want it spinning automatically
    private void Start()
    {
        canSpin = false;
    }

    // This uses the Event system. This will trigger only when the targetted button is hit
    // This causes the bool to change to whatever it is not. 
    public void CubeSpinning(InputAction.CallbackContext context)
    {
        canSpin = !canSpin;
    }

    // The update checks if the cube can spin, and if the bool is true
    // It rotates the cube.
    public void Update()
    {
        if (canSpin == true)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}
