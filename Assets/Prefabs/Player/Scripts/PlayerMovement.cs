using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    private Vector3 fuerzaPorAplicar;   
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo; 
    private float velocidadLateral;

    void Start()
    {
        fuerzaPorAplicar = new Vector3(0,0,300f); 
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f; 
        velocidadLateral = 2f;
    }
    private void Update()
    {
        float direccion = Input.GetAxis("Horizontal");
        transform.Translate(direccion * velocidadLateral * Time.deltaTime, 0, 0);
    }
    
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
          
        }
    }
}
