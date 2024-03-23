public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        HashSet<int> visited = new HashSet<int>();
        HashSet<int> run = new HashSet<int>();

        foreach (int[] prereq in prerequisites)
        {
            int course = prereq[0];
            int prerequisite = prereq[1];

            if (!graph.ContainsKey(course))
            {
                graph[course] = new List<int>();
            }

            graph[course].Add(prerequisite);
        }

        foreach (int course in graph.Keys)
        {
            if (!visited.Contains(course) && HasCycle(course))
                return false;
        }

        bool HasCycle(int course)
        {
            if (!graph.ContainsKey(course))
            {
                return false;
            }

            visited.Add(course);
            run.Add(course);

            foreach (int prereq in graph[course])
            {
                if (!visited.Contains(prereq))
                {
                    if (HasCycle(prereq))
                    {
                        return true;
                    }
                }
                else if (run.Contains(prereq))
                {
                    return true;
                }
            }

            run.Remove(course);

            return false;
        }

        return true;
    }
}
