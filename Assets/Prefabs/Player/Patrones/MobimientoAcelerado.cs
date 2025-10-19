using UnityEngine;

public class MovimientoAcelerado : IMovimientoEstrategico
{
    private float aceleracion = 10f;
    private float velocidadActual = 0f;

    public void Move(Transform transform, float speed)
    {
        velocidadActual += Input.GetAxis("Horizontal") * aceleracion * Time.deltaTime;
        velocidadActual = Mathf.Clamp(velocidadActual, -speed, speed);
        transform.Translate(velocidadActual * Time.deltaTime, 0, 0);
    }
}
