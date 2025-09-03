using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // O objeto que a c�mera deve seguir
    public Vector3 offset = new Vector3(0, 5, -10); // Dist�ncia da c�mera em rela��o ao alvo
    public float smoothSpeed = 0.125f; // Suavidade do movimento

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Opcional: faz a c�mera olhar para o alvo
    }
}
