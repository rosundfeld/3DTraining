using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // O objeto que a câmera deve seguir
    public Vector3 offset = new Vector3(0, 5, -10); // Distância da câmera em relação ao alvo
    public float smoothSpeed = 0.125f; // Suavidade do movimento

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Opcional: faz a câmera olhar para o alvo
    }
}
