using UnityEngine;

public class MoverComando : IComando
{
    private readonly Transform transform;
    private readonly float input;

    public MoverComando(PlayerMovement playerMovement, float input)
    {
        this.transform = transform;
        this.input = input;
    }

    public void Execute()
    {
        playerMovement.SetStrategy(new DesplazamientoLateral());
    }
    
}
