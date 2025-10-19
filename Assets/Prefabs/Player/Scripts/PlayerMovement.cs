using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    private Vector3 fuerzaPorAplicar;   
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    private float velocidadLateral;
    private IMovimientoEstrategico estrategia;

    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 15f;
        SetStrategy(new MovimientoAcelerado());
    }

    private void Update()
    {
        estrategia.Move(transform, velocidadLateral);
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
    
    public void SetStrategy(IMovimientoEstrategico estrategia)
    {
        this.estrategia = estrategia;
    }
}
