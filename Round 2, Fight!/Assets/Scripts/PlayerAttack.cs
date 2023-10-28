using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public GameObject[] hitColliders;
    public string attackDir = "neutral";
    public void LightAttack(InputAction.CallbackContext context)
    {

    }
    public void GetAttackDir(InputAction.CallbackContext context)
    {
        Vector2 tempDir;
        tempDir = context.ReadValue<Vector2>();
        if (Mathf.Abs(tempDir.x) > Mathf.Abs(tempDir.y))
        {
            switch (tempDir.x)
            {
                case > 0:
                    attackDir = "right";
                    break;
                case < 0:
                    attackDir = "left";
                    break;
            }
        }
        else
        {
            switch (tempDir.y)
            {
                case > 0:
                    attackDir = "up";
                    break;
                case < 0:
                    attackDir = "down";
                    break;
                default:
                    attackDir = "neutral";
                    break;
            }
        }
    }
}
