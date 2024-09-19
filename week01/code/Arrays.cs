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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Initializes a new array of type 'double' called 'multiples' with a size of 'length'.
        double[] multiples = new double[length];

        // Fills the 'multiples' array with the 'length' multiples of 'number'.
        // The loop starts at 1 and runs until 'length', multiplying 'i' by 'number' in each 
        // iteration. The result is assigned to the corresponding position in the 'multiples' array.
        // Example: if 'length' is 3 and 'number' is 5, the array will contain [5, 10, 15].
        for (int i = 1; i <= length; i++) multiples[i - 1] = i * number;

        // Return the 'multiples' array.
        return multiples;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Retrieves the last 'amount' number of elements from the 'data' list.
        // The GetRange() method extracts a range of elements from the list starting at 
        // 'data.Count - amount' (which is the index of the first element in the last 'amount' 
        // elements) and retrieves 'amount' elements. The result is stored in the 'getRight' list.
        // Example: if 'data' is [1, 2, 3, 4, 5, 6] and 'amount' is 3, this will return the last 
        // 3 elements from the list [4, 5, 6].
        List<int> getRight = data.GetRange(data.Count - amount, amount);

        // Removes the last 'amount' elements from the 'data' list.
        // The RemoveRange() method deletes a range of elements, starting at the index 
        // 'data.Count - amount' (which is the first element in the last 'amount' elements),
        // and removes 'amount' number of elements from that point.
        // Example: if 'data' is [1, 2, 3, 4, 5, 6] and 'amount' is 3, it will remove the last 
        // 3 elements from the list, leaving the first three elements [1, 2, 3].
        data.RemoveRange(data.Count - amount, amount);

        // Inserts the elements from the 'getRight' list at the beginning of the 'data' list.
        // The InsertRange() method adds a collection of elements (in this case, 'getRight') 
        // starting at the specified index, which is 0. This means the entire 'getRight' 
        // list will be inserted at the front of 'data', shifting the existing elements 
        // in 'data' to the right.
        // Example: if 'data' contains [1, 2, 3] and 'getRight' contains [4, 5, 6], after 
        // the insertion, 'data' will become [4, 5, 6, 1, 2, 3].
        data.InsertRange(0, getRight);
    }
}
