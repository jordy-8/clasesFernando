using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiradaCamara : MonoBehaviour
{
    [SerializeField]
    private float speed = 100f;

    [SerializeField]
    Transform Jugador;

    float RotacionX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        RotacionX -= MouseY;
        RotacionX = Mathf.Clamp(RotacionX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(RotacionX, 0f, 0f);
        Jugador.Rotate(Vector3.up * MouseX);
    }
}
