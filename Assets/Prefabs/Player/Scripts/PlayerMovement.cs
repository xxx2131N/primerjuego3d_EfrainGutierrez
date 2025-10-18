using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    private Vector3 fuerzaPorAplicar;   
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo; 


    void Start()
    {
        fuerzaPorAplicar = new Vector3(0,0,300f); 
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f; 
        
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
