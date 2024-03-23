public class Solution
{
    // Method to check if the courses can be finished given prerequisites
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // Initialize a dictionary to represent the graph of courses and their prerequisites
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        // Initialize sets to keep track of visited nodes and nodes in the current traversal path
        HashSet<int> visited = new HashSet<int>();
        HashSet<int> run = new HashSet<int>();

        // Building the graph from the given prerequisites
        foreach (int[] prereq in prerequisites)
        {
            int course = prereq[0]; // Current course
            int prerequisite = prereq[1]; // Prerequisite course

            // If the course is not already a key in the graph, add it with an empty list of prerequisites
            if (!graph.ContainsKey(course))
            {
                graph[course] = new List<int>();
            }

            // Add the prerequisite to the list of prerequisites for the current course
            graph[course].Add(prerequisite);
        }

        // Loop through all courses in the graph
        foreach (int course in graph.Keys)
        {
            // Check if the course has not been visited and if it has a cycle
            if (!visited.Contains(course) && HasCycle(course))
                return false;
        }

        // Helper method to check for cycles starting from a specific course
        bool HasCycle(int course)
        {
            // If the course is not a key in the graph, there's no cycle involving it
            if (!graph.ContainsKey(course))
            {
                return false;
            }

            // Mark the course as visited and add it to the current traversal path
            visited.Add(course);
            run.Add(course);

            // Loop through the prerequisites of the current course
            foreach (int prereq in graph[course])
            {
                // If the prerequisite hasn't been visited, recursively check for cycles starting from it
                if (!visited.Contains(prereq))
                {
                    if (HasCycle(prereq))
                    {
                        return true;
                    }
                }
                // If the prerequisite is in the current traversal path, there's a cycle
                else if (run.Contains(prereq))
                {
                    return true;
                }
            }

            // Remove the course from the current traversal path
            run.Remove(course);

            // No cycle found starting from this course
            return false;
        }

        // No cycle found in any course, so it's possible to finish all courses
        return true;
    }
}
