using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue distinct items (Low: 1, High: 5, Medium: 3) and Dequeue.
    // Expected Result: "High" is returned first because it has the highest priority value.
    // Defect(s) Found: The original loop condition skipped the last item, and it didn't remove items from the list.

    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 7);
        priorityQueue.Enqueue("High", 10);
        priorityQueue.Enqueue("Medium", 9);
        Assert.AreEqual("High", priorityQueue.Dequeue());
        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with identical high priorities (FirstHigh: 5, SecondHigh: 5) to verify FIFO tie-breaking.
    // Expected Result: "FirstHigh" is returned first because it arrived closest to the front.
    // Defect(s) Found: Found: The original code used ">=" comparison, which broke FIFO rules by picking the newest tie instead of the oldest.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstHigh", 5);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("SecondHigh", 5);

        Assert.AreEqual("FirstHigh", priorityQueue.Dequeue());
        //Assert.Fail("Implement the test case and then remove this.");
    }
    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Attempt to call Dequeue on a completely empty queue.
    // Expected Result: Throws an InvalidOperationException with the exact message "The queue is empty."
    // Defect(s) Found: Verified that exception handing behaves correctly when no items remain.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}


