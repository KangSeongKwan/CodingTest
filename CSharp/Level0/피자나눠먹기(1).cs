using System;

public class Solution {
    public int solution(int n) {
        int count = 0;
        if(n%7 == 0)
        {
            count = n / 7;
        }
        else if(n%7 != 0)
        {
            count = (n/7) + 1;
        }
        
        if(n == 1)
        {
            count = 1;
        }
        
        int answer = count;
        return answer;
    }
}
