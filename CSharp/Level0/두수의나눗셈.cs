using System;

public class Solution {
    public int solution(int num1, int num2) {
        float divide = (float)num1 / (float)num2;
        float mult1000 = divide * 1000f;
        
        int answer =  (int)mult1000;
        return answer;
    }
}
