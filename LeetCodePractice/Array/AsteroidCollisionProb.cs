namespace LeetCodePractice.Recursion;

public class AsteroidCollisionProb
{
    public int[] AsteroidCollisionAttemp1(int[] asteroids)
    {
        var stackValue = new Stack<int>();
        for (int i = 0; i < asteroids.Length; i++)
        {
            if (stackValue.Count > 0)
            {
                var peekedValue = stackValue.Peek();
                if (peekedValue * asteroids[i] > 0)
                {
                    stackValue.Push(asteroids[i]);
                }
                else if (Math.Abs(peekedValue) == Math.Abs(asteroids[i]) && peekedValue * asteroids[i] < 0)
                {
                    stackValue.Pop();
                }
                else
                {
                    var poppedValue = stackValue.Pop();
                    var valueToPush = Math.Abs(poppedValue) > Math.Abs(asteroids[i]) ? poppedValue : asteroids[i];
                    while (stackValue.Count > 0 && valueToPush * stackValue.Peek() < 0)
                    {
                        poppedValue = stackValue.Pop();
                        valueToPush = Math.Abs(poppedValue) > Math.Abs(valueToPush) ? poppedValue : valueToPush;
                    }
                    stackValue.Push(valueToPush);
                }
            }
            else
            {
                stackValue.Push(asteroids[i]);
            }
        }

        var resultArray = new int[stackValue.Count];
        for (int i = stackValue.Count-1; i >= 0; i--)
        {
            resultArray[i] = stackValue.Pop();
        }

        return resultArray;
    }

    public int[] AsteroidCollision(int[] asteroids)
    {
        var stackValue = new Stack<int>();
        
        // Go through the array and
        for (int i = 0; i < asteroids.Length; i++)
        {
            if (stackValue.TryPop(out var poppedValue))
            {
                // if value in stack * the current index value < 0 it means it is colliding
                if (poppedValue * asteroids[i] < 0)
                {
                    // if both values are equal then discard one and pop other
                    if (Math.Abs(poppedValue) == Math.Abs(asteroids[i]))
                    {
                        break;
                    }
                    var valueToPush = Math.Abs(poppedValue) > Math.Abs(asteroids[i]) ? poppedValue : asteroids[i];

                    while (stackValue.TryPeek(out var poppedValueInner))
                    {
                        if (poppedValueInner * valueToPush > 0)
                        {
                            break;
                        }
                        else if (Math.Abs(poppedValueInner) == valueToPush && (poppedValueInner * valueToPush < 0))
                        {
                            stackValue.Pop();
                            break;
                        }
                        else if ((poppedValueInner * valueToPush < 0))
                        {
                            stackValue.Pop();
                            valueToPush = Math.Abs(poppedValueInner) > Math.Abs(valueToPush) ? poppedValueInner : valueToPush;
                        }
                    }
                    stackValue.Push(valueToPush);
                }
                else
                {
                    stackValue.Push(poppedValue);
                    stackValue.Push(asteroids[i]);
                }
                
            }
            else
            {
                stackValue.Push(asteroids[i]);
            }
        }
        var resultArray = new int[stackValue.Count];
        for (int i = stackValue.Count-1; i >= 0; i--)
        {
            resultArray[i] = stackValue.Pop();
        }

        return resultArray;
    }
}