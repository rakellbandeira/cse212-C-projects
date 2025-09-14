using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);
        
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
       /*  Assert.Fail("Implement the test case and then remove this."); */
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        /* Assert.Fail("Implement the test case and then remove this."); */

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");

        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Actual message: '{e.Message}'");
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}