using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public List<CharacterSkill> CurrentSkills;

    public virtual void Init()
    {
        CurrentSkills = new List<CharacterSkill>();
    }
}
