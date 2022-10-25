using System;

public class Solution {
    public int solution(int n) {
        int pizBox = 6;
        while (pizBox % n != 0)
        {
            pizBox += 6;
        }
        return (pizBox / 6);
    }
}
