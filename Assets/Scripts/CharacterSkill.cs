using UnityEngine;

public class CharacterSkill : MonoBehaviour
{
    public string Name;
    public float Points;
    public float AppliedPoints;

    public bool IsLearned => (int)(AppliedPoints / Points) == 1;

    public void Train(int p_modifier)
    {
        AppliedPoints += 1 * p_modifier;

        if (AppliedPoints >= Points)
        {
            AppliedPoints = Points;
        }
    }
}
