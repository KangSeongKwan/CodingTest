using System;

public class Solution {
    public int solution(int[] array) {
        int temp = 0;
        int middle = array.Length / 2;
        //Sort Array
        Array.Sort(array);

        int answer = array[middle];
        return answer;
    }
}
