public class TimeMap
{
    Dictionary<string, List<(string message, int timestamp)>> keys;

    public TimeMap()
    {
        keys = new Dictionary<string, List<(string value, int timestamp)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!keys.ContainsKey(key))
        {
            keys[key] = new List<(string message, int timestamp)>();
        }
        keys[key].Add((value, timestamp));
    }

    public string Get(string key, int timestamp)
    {
        if (!keys.ContainsKey(key))
        {
            return "";
        }

        var fileCabinet = keys[key];

        int leftPointer = 0;
        int rightPointer = fileCabinet.Count - 1;
        int middle;

        while (leftPointer <= rightPointer)
        {
            middle = (leftPointer + rightPointer) / 2;

            if (fileCabinet[middle].timestamp == timestamp)
            {
                return fileCabinet[middle].message;
            }

            if (fileCabinet[middle].timestamp < timestamp)
            {
                leftPointer = middle + 1;
            }
            else
            {
                rightPointer = middle - 1;
            }
        }

        if (rightPointer < 0)
        {
            return "";
        }
        return fileCabinet[rightPointer].message;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
