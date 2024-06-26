public class TimeMap
{
    // Declare a dictionary to store keys and corresponding list of messages with timestamps.
    Dictionary<string, List<(string message, int timestamp)>> keys;

    // Constructor initializing the dictionary.
    public TimeMap()
    {
        keys = new Dictionary<string, List<(string value, int timestamp)>>();
    }

    // Method to add a new entry to the dictionary.
    public void Set(string key, string value, int timestamp)
    {
        // If the dictionary doesn't contain the key, create a new list for it.
        if (!keys.ContainsKey(key))
        {
            keys[key] = new List<(string message, int timestamp)>();
        }
        // Add the value and timestamp to the list associated with the key.
        keys[key].Add((value, timestamp));
    }

    // Method to retrieve the value associated with a given key and timestamp.
    public string Get(string key, int timestamp)
    {
        // If the dictionary doesn't contain the key, return an empty string.
        if (!keys.ContainsKey(key))
        {
            return "";
        }

        // Get the list of messages associated with the key.
        var fileCabinet = keys[key];

        // Initialize pointers for binary search.
        int leftPointer = 0;
        int rightPointer = fileCabinet.Count - 1;
        int middle;

        // Perform binary search on the list.
        while (leftPointer <= rightPointer)
        {
            middle = (leftPointer + rightPointer) / 2;

            // If the timestamp at the middle position matches the target timestamp, return the corresponding message.
            if (fileCabinet[middle].timestamp == timestamp)
            {
                return fileCabinet[middle].message;
            }

            // If the timestamp at the middle position is less than the target timestamp, move the left pointer to the right of the middle.
            if (fileCabinet[middle].timestamp < timestamp)
            {
                leftPointer = middle + 1;
            }
            // If the timestamp at the middle position is greater than the target timestamp, move the right pointer to the left of the middle.
            else
            {
                rightPointer = middle - 1;
            }
        }

        // If rightPointer is less than 0, it means all timestamps in the list are greater than the target timestamp, return an empty string.
        if (rightPointer < 0)
        {
            return "";
        }
        // Otherwise, return the message corresponding to the timestamp at rightPointer.
        return fileCabinet[rightPointer].message;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
