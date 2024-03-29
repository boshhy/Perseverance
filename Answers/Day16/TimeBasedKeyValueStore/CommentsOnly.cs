// Overview
public class TimeMap
{

    public TimeMap()
    {
        // Initializes an empty dictionary to store keys and their associated lists of messages with timestamps.
    }

    public void Set(string key, string value, int timestamp)
    {
        // Accepts a key, value, and timestamp, and adds them to the internal dictionary. 
        // If the key doesn't exist, it creates a new list for it and then adds the value 
        // with its corresponding timestamp to the list.
    }

    public string Get(string key, int timestamp)
    {
        // Looks up the specified key in the internal dictionary and retrieves the message associated with the closest 
        // timestamp less than or equal to the given timestamp using binary search. If no matching timestamp is found, 
        // it returns the message associated with the closest smaller timestamp, 
        // or an empty string if no such timestamp exists.
    }
}

// Comments
public class TimeMap
{
    // Declare a dictionary to store keys and corresponding list of messages with timestamps.

    // Constructor initializing the dictionary.
    public TimeMap()
    {

    }

    // Method to add a new entry to the dictionary.
    public void Set(string key, string value, int timestamp)
    {
        // If the dictionary doesn't contain the key, create a new list for it.
        // Add the value and timestamp to the list associated with the key.
    }

    // Method to retrieve the value associated with a given key and timestamp.
    public string Get(string key, int timestamp)
    {
        // If the dictionary doesn't contain the key, return an empty string.

        // Get the list of messages associated with the key.

        // Initialize pointers for binary search.

        // Perform binary search on the list.
        //     If the timestamp at the middle position matches the target timestamp, return the corresponding message.

        //     If the timestamp at the middle position is less than the target timestamp, move the left pointer to the right of the middle.
        //     If the timestamp at the middle position is greater than the target timestamp, move the right pointer to the left of the middle.

        // If rightPointer is less than 0, it means all timestamps in the list are greater than the target timestamp, return an empty string.
        // Otherwise, return the message corresponding to the timestamp at rightPointer.
    }
}

// Pseudocode
public class TimeMap
{
    // Dictionary<string, List<(string message, int timestamp)>> keys;
    public TimeMap()
    {
        //  keys = Initialize new Dictionary<string, List<(string value, int timestamp)>>
    }

    public void Set(string key, string value, int timestamp)
    {
        // If key not in keys:
        //     Create new list for key in keys
        // Append (value, timestamp) to keys[key]
    }

    public string Get(string key, int timestamp)
    {
        // If key not in keys:
        //     Return ""

        // fileCabinet = keys[key]
        // leftPointer = 0
        // rightPointer = length of fileCabinet - 1

        // While leftPointer <= rightPointer:
        //     middle = (leftPointer + rightPointer) / 2

        //     If fileCabinet[middle].timestamp equals timestamp:
        //         Return fileCabinet[middle].message

        //     If fileCabinet[middle].timestamp < timestamp:
        //         leftPointer = middle + 1
        //     Else:
        //         rightPointer = middle - 1

        // If rightPointer < 0:
        //     Return ""
        // Return fileCabinet[rightPointer].message
    }
}

