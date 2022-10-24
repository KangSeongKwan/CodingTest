using System;

public class Solution {
    public int solution(int num1, int num2) {
        int exceptionValue = 99999999;
        
        if(num1 > 50000 && num1 < -50000)
        {
            return exceptionValue;
        }
        if(num2 > 50000 && num2 < -50000)
        {
            return exceptionValue;
        }
        
        int answer = 0;
        answer = num1 + num2;
        return answer;
    }
}
