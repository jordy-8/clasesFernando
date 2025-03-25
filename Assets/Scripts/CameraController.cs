using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Sensibilidad del mouse
    public Transform playerBody; // Referencia al cuerpo del jugador (para rotar en el eje Y)

    private float xRotation = 0f;

    void Start()
    {
        // Bloquear el cursor en el centro de la pantalla y hacerlo invisible
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Obtener el movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotar la cámara en el eje X (arriba y abajo)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limitar la rotación para que no gire demasiado

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotar el cuerpo del jugador en el eje Y (izquierda y derecha)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}