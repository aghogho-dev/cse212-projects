using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the values and priorities: (Study 30 mins, 2), (Sleep 4 hours, 5), (Play Game, 0)
    // Expected Result: [Study 30 minutes (Pri:2), Sleep 4 hours (Pri:5), Play Game (Pri:0)]
    // Defect(s) Found: 
    /*
            No defects
    */
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Study 30 minutes", 2);
        priorityQueue.Enqueue("Sleep 4 hours", 5);
        priorityQueue.Enqueue("Play Game", 0);

        string expectedResult = "[Study 30 minutes (Pri:2), Sleep 4 hours (Pri:5), Play Game (Pri:0)]";

        Assert.AreEqual(expectedResult, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Deque items with the values and priorities: (Study 30 minutes, 2), (Sleep 4 hours, 5), (Play Game, 0)
    // Expected Result: Sleep 4 hours, Study 30 minutes, Play Game
    // Defect(s) Found: 
    /*
            The highest priority values are correctly identified but not removed.
            Use RemoveAt to remove by adding the code to PriorityQueue - Dequeue:
                 _queue.RemoveAt(highPriorityIndex);
    */
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Study 30 minutes", 2);
        priorityQueue.Enqueue("Sleep 4 hours", 5);
        priorityQueue.Enqueue("Play Game", 0);

        var dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Sleep 4 hours", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Study 30 minutes", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Play Game", dequeueValue);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue an Empty Queue
    // Expected Result: The queue is empty
    // Defect(s) Found: 
    /*
        No defects
    */

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }



    [TestMethod]
    // Scenario:  Deque items with the values and priorities: (Attend class, 10), (Study 30 minutes, 2), (Sleep 4 hours, 5), (Play Game, 0), (Do research, 5)
    // Expected Result: Attend class, Sleep 4 hours, Do research, Study 30 minutes, Play Game, Watch Movie
    // Defect(s) Found: 
    /* 
        There were defects related to how the items were returned
        because of wrong signs in the for loop and if statement
        inside the Dequeue method
    */
    public void TestPriorityQueue_4()
    {
        // There are some problems here
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Attend class", 10);
        priorityQueue.Enqueue("Study 30 minutes", 2);
        priorityQueue.Enqueue("Sleep 4 hours", 5);
        priorityQueue.Enqueue("Play Game", 0);
        priorityQueue.Enqueue("Watch Movies", 0);
        priorityQueue.Enqueue("Do research", 5);

        var dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Attend class", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Do research", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Sleep 4 hours", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Study 30 minutes", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Watch Movies", dequeueValue);

        dequeueValue = priorityQueue.Dequeue();
        Assert.AreEqual("Play Game", dequeueValue);

    }


}