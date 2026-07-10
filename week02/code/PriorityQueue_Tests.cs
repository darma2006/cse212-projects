using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities.
    // Expected Result: The item with the highest priority should be removed first.
    // Defect(s) Found:
    // The queue returned the wrong item because it did not correctly search
    // the entire queue for the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("Tim", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Sue", result);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The first item with the highest priority (FIFO)
    // should be removed first.
    // Defect(s) Found:
    // The queue removed the last item with the highest priority instead
    // of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("Tim", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Bob", result);
    }

    [TestMethod]
    // Scenario: Remove from an empty queue.
    // Expected Result: InvalidOperationException with the message
    // "The queue is empty."
    // Defect(s) Found:
    // Verify the correct exception is thrown.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}