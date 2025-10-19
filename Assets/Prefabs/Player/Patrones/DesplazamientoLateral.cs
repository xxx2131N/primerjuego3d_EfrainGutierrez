using UnityEngine;

public class DesplazamientoLateral : IMovimientoEstrategico
{
    public void Move(Transform transform, float speed)
    {
        float direccion = Input.GetAxis("Horizontal");
        transform.Translate(direccion * speed * Time.deltaTime, 0, 0);
    }
}
