using UnityEngine;

public class FloatEffect : MonoBehaviour
{
    public float floatHeight = 0.1f; // Altura de flotado
    public float floatSpeed = 1.0f; // Velocidad de flotado
    private Vector3 originalPosition; // Posici�n original del objeto

    void Start()
    {
        // Almacenar la posici�n original del objeto
        originalPosition = transform.position;
    }

    void Update()
    {
        // Utilizar la funci�n Mathf.Sin para generar una oscilaci�n en el eje y
        float yPos = originalPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(originalPosition.x, yPos, originalPosition.z);
    }
}

