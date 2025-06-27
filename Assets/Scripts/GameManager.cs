using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController Player;
    public Army DebugArmy;
    public ArmyUnit[] DebugUnits;
    
    private void Awake()
    {
        Player.Init();
        
        DebugArmy.Init();

        for (int i = 0; i < DebugUnits.Length; i++)
        {
            DebugArmy.AssignUnit(DebugUnits[i]);
        }
    }
}
