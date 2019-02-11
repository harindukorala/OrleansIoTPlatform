using System;

[Serializable]
public class AccelerationData
{
    public AccelerationData(string key, int count, double average)
    {
        Key = key;
        Count = count;
        Average = average;

    }

    public readonly string Key;
    public int Count { get; set; }
    public double Average { get; set; }

    public override string ToString() =>
            $"{Key}: {Count} {Average / Count}";
}