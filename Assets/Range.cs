using UnityEngine;
[System.Serializable]
public class Range{
    public float Value;
    public float Variability;
    public float GetRand()
    {
        return Random.Range(Value - Variability, Value + Variability);
    }
    public Range(float Number, float Variability = 0f)
    {
        this.Value = Number;
        this.Variability = Variability;
    }
}
