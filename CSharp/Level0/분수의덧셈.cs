using System;

public class Solution {
    public int[] solution(int denum1, int num1, int denum2, int num2)     
    {
        // 입력받은 두 분모의 최대공약수를 구한다.
		int gcd1 = gcd(num1, num2);
        
        // 입력받은 두 분모의 최소공배수를 구한다.
		int lcm1 = lcm(num1, num2, gcd1);
        
        // 분모에 어떤 수를 곱해야 최소공배수가 나오는지 확인한 후 분자를 분모에 맞춰준다.
		int mul1 = lcm1 / num1;
		denum1 *= mul1;
		int mul2 = lcm1 / num2;
		denum2 *= mul2;
        
        // 두 분자를 더한다.
		int denum = denum1 + denum2;
		
        // 기약분수를 구해야 하므로, 합한 분자와 분모의 최대공약수를 구한다.
		int gcd2 = gcd(denum, lcm1);
        
        // 최대공약수로 나눠준다.
		int[] answer = {denum / gcd2, lcm1 / gcd2};
        
        return answer;
    }
    // 최대공약수
    public int gcd(int num1, int num2) {
		
		bool stop = false;
		int temp1 = num1;
		int temp2 = num2;
		
		while (!stop) {
			if (temp2 == 0) {
				break;
			}
			
			if (temp2 != 0 || temp1 % temp2 != 0) {
				int temp = temp1;
				temp1 = temp2;
				temp2 = temp % temp2;
			} else {
				stop = true;
			}
		}
		
		return temp1; 
	}
    
    // 최소공배수
    public int lcm(int num1, int num2, int gcd) {
		return (num1 * num2) / gcd;
	}
}
