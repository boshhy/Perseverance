// Overview
public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // The code implements a cycle detection algorithm to determine whether a set of courses can be 
        // completed given their prerequisites. It constructs a directed graph where courses are nodes 
        // and prerequisites are edges. Then, it performs a depth-first search to check for cycles, 
        // utilizing sets to keep track of visited nodes and nodes in the current traversal path. 
        // If a cycle is detected, the function returns false; otherwise, it returns true.
    }
}

// Comments
public class Solution
{
    // Method to check if the courses can be finished given prerequisites
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // Initialize a dictionary to represent the graph of courses and their prerequisites

        // Initialize sets to keep track of visited nodes and nodes in the current traversal path

        // Building the graph from the given prerequisites
        //     Extract the current course from the prerequisite array
        //     Extract the prerequisite course from the prerequisite array

        //     If the course is not already a key in the graph, add it with an empty list of prerequisites

        //     Add the prerequisite to the list of prerequisites for the current course

        // Loop through all courses in the graph
        //     Check if the course has not been visited and if it has a cycle

        // Helper method to check for cycles starting from a specific course
        //     If the course is not a key in the graph, there's no cycle involving it

        //     Mark the course as visited and add it to the current traversal path

        //     Loop through the prerequisites of the current course
        //         If the prerequisite hasn't been visited, recursively check for cycles starting from it
        //         If the prerequisite is in the current traversal path, there's a cycle

        //     Remove the course from the current traversal path

        //     No cycle found starting from this course

        // No cycle found in any course, so it's possible to finish all courses
    }
}

// Pseudocode
public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // graph = Create an empty dictionary to represent the graph of courses and their prerequisites
        // visited = Create an empty set to track visited nodes during DFS
        // run = Create an empty set to track nodes in the current traversal path

        // For each prerequisite in prerequisites:
        //     course = Get the current course from the prerequisite
        //     prerequisite = Get the prerequisite course from the prerequisite

        //     If course is not in graph:
        //         Add course to graph with an empty list

        //     Add prerequisite to the list of prerequisites for the current course in graph

        // For each course in graph:
        //     If course is not visited and HasCycle returns true:
        //         Return false

        // Function HasCycle(course):
        //     If course is not in graph:
        //         Return false

        //     Add course to visited set
        //     Add course to run set

        //     For each prerequisite in the list of prerequisites for course in graph:
        //         If prerequisite is not visited:
        //             If HasCycle(prerequisite) returns true:
        //                 Return true
        //         Else if prerequisite is in run:
        //             Return true

        //     Remove course from run set
        //     Return false

        // Return true
    }
}