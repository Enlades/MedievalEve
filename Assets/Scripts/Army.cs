using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public Character Owner;
    public List<ArmyUnit> AssignedUnits;

    public void Init()
    {
        AssignedUnits = new List<ArmyUnit>();
    }

    public void AssignUnit(ArmyUnit p_unit)
    {
        AssignedUnits.Add(p_unit);
    }
}