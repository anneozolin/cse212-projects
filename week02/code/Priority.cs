public static class Priority {
    public static void Test() {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Case 1
        // Scenario: Enqueue values with different priorities
        // Expected Result: Values should be dequeued in order of their priorities
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Apple", 3);
        priorityQueue.Enqueue("Banana", 1);
        priorityQueue.Enqueue("Blackberry", 2);
        // Console.WriteLine($"Enqueue: {priorityQueue}");

        // Dequeue items and print the result
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Apple
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Blackberry
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Banana

        // Defect(s) Found: The node with highest priority is returned all times

        Console.WriteLine("---------");

        // Test Case 2
        // Scenario: Enqueue values with the same priority
        // Expected Result: Values should be dequeued in the order they were enqueued
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Blueberry", 1);
        priorityQueue.Enqueue("Cherry", 1);
        priorityQueue.Enqueue("Coconut", 1);
        // Console.WriteLine($"Enqueue: {priorityQueue}");

        // Dequeue items and print the result
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Blueberry
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Cherry
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Coconut

        // Defect(s) Found: Elements with same priority where not dequeued as FIFO.

        Console.WriteLine("---------");

        // Test Case 3
        // Scenario: Enqueue items with random priorities and dequeue them
        // Expected Result: Values should be dequeued in descending order of their priorities
        Console.WriteLine("Test 3");

        priorityQueue.Enqueue("Grape", 5);
        priorityQueue.Enqueue("Kiwi", 2);
        priorityQueue.Enqueue("Mango", 7);
        priorityQueue.Enqueue("Orange", 3);
        Console.WriteLine($"Enqueue: {priorityQueue}");

        // Dequeue items and print the result
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Mango
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Grape
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Orange
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Kiwi

        Console.WriteLine("---------");

        // Test Case 4
        // Scenario: Attempt to dequeue from an empty queue
        // Expected Result: "The queue is empty." message should be displayed, and the dequeue operation should return null
        Console.WriteLine("Test 4");

        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: The queue is empty.
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: null

        // Defect(s) Found: No defects found.

        Console.WriteLine("---------");
    }
}