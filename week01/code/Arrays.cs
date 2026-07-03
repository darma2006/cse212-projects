public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create array
        // 2. Loop
        // 3. Fill multiples
        // 4. Return array

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Find split point
        // 2. Copy last part
        // 3. Remove last part
        // 4. Insert at front

        int split = data.Count - amount;

        List<int> temp = data.GetRange(split, amount);

        data.RemoveRange(split, amount);

        data.InsertRange(0, temp);
    }
}
