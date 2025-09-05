public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //This function will take the parameters and pass them into a for loop
        //Iterating through the counter until the limit (length parameter)
        //and adding the result to a new array.

        double[] multiples = new double[length];
        
        for (int i = 0; i< length; ++i)
        {
            multiples[i] = number * (i + 1);
        }

        Console.WriteLine(multiples);

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //Splitpoint is being calculated first, so then the new list gets
        //new elements from the for loops that iterates throught the param data list
        //starting from the splitpoint and adidng them to the list in the new order

        List<int> rotatedData = new List<int>();
        int splitPoint = data.Count - amount;

        //The last elements first
        for (int i = splitPoint; i < data.Count; i++)
        {
            rotatedData.Add(data[i]);
        }

        //Now same logic applied here, but starting on 0 till the splitPoint

        //The first elements last
        for (int i= 0; i < splitPoint; i++)
        {
            rotatedData.Add(data[i]);
        }
    

    }
}
