using System;

public class Solution {
    public int[] solution(int n) {
        int numCount = 0;
        int arrayAssign = 0;
        for(int i=0; i<=n; i++)
        {
            if(i%2 != 0)
            {
                numCount++;
            }
        }
        int[] numbers = new int[numCount];
        
        for(int i=0; i<=n; i++)
        {
            if(i%2 != 0)
            {
                numbers[arrayAssign] = i;
                arrayAssign++;
            }
        }
        
        int[] answer = numbers;
        return answer;
    }
}
