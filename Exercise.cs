using System.Linq;

namespace RTSExercise;

public class Exercise
{
    /// <summary>
    /// Using Linq, the method will determine how many of the input list values are above or below the target number.
    /// </summary>
    /// <param name="listOfNumbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static (int above, int below) aboveBelow(List<int> listOfNumbers, int target)
    {
        if (listOfNumbers.Count == 0) return new();

        var above = listOfNumbers.Where(i => i > target).Count();
        var below = listOfNumbers.Where(i => i < target).Count();

        return new(above, below);
    }

    /// <summary>
    /// Using the % operator, we rotate the input string to the right by the input number.
    /// </summary>
    /// <param name="stringToRotate"></param>
    /// <param name="rotate"></param>
    /// <returns></returns>
    public static string stringRotation(string stringToRotate, int rotate)
    {
        if (string.IsNullOrEmpty(stringToRotate) || stringToRotate.Length == 1) return stringToRotate;
        
        var rotateRemainder = rotate % stringToRotate.Length;
        if (rotateRemainder == 0) return stringToRotate;

        var rotateAdjusted = stringToRotate.Length - rotateRemainder;
        var frontString = stringToRotate.Substring(0, rotateAdjusted);
        var endString = stringToRotate.Substring(rotateAdjusted);

        return endString + frontString;
    }
}