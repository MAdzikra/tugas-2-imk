using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform cameraHolder;
    [SerializeField] float mouseSensitivity = 2.5f;
    float verticalLookRotatuion;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);
        verticalLookRotatuion -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
        verticalLookRotatuion = Mathf.Clamp(verticalLookRotatuion, -90f, 90f);
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotatuion, 0, 0);
    }
}
