using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

[Serializable]
public class AccelerationDataPerSec : KeyedCollection<string, AccelerationData>
{
    public AccelerationDataPerSec() { }
    public AccelerationDataPerSec(IEnumerable<AccelerationData> items)
    {
        foreach (var item in items)
        {
            base.Add(item);
        }
    }

    protected override string GetKeyForItem(AccelerationData item) =>
        item.Key;

    public void MergeAccelo(AccelerationDataPerSec items)
    {
        foreach (var item in items)
        {
            if (Contains(item.Key))
            {
                var val = base[item.Key];
                val.Count += item.Count;
                val.Average += item.Average;
            }
            else
                base.Add(item);
        }
    }

    public override string ToString() =>
        string.Join("\r\n", this);
}