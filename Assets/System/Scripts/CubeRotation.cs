using UnityEngine;
using UnityEngine.InputSystem;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] bool canSpin;

    private void Start()
    {
        canSpin = false;
    }

    public void CubeSpinning(InputAction.CallbackContext context)
    {
        canSpin = !canSpin;
    }

    public void Update()
    {
        if (canSpin == true)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}
