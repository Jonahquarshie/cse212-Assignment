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
        // Written Plan:
        // 1. Initialize a fixed-size container (array of doubles) to store the result, setting its capacity to the requested length.
        // 2. Set up a loop that counts upward from 0 to represent each position (index) in our container.
        // 3. For each position, compute a multiple of the base number. 
        // 4. Save the calculated value directly into the container at the current position index.
        // 5. Once every position has been filled, pass back the fully populated container.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; 
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
        // Written Plan:
        // 1. Verify if the list is valid and if a rotation is actually required.
        // 2. Identify where the split needs to happen. 
        // 3. Copy the items starting from that calculated split point all the way to the end of the list.
        // 4. Remove those exact same rear items from their original spots in the primary list to make room at the front.
        // 5. Take the items from the temporary storage collection and place them all together at the absolute beginning (index 0) of the primary list.

        if (data == null || data.Count == 0 || amount == data.Count)
        {
            return;
        }

        // Calculate starting index of the section to slide to the front
        int startingIndex = data.Count - amount;

        // Pull out the elements from the back end
        List<int> shiftingSegment = data.GetRange(startingIndex, amount);

        // Remove the pulled elements from their original positions
        data.RemoveRange(startingIndex, amount);

        // Inject the segment directly onto the front of the list
        data.InsertRange(0, shiftingSegment);
    }
}
