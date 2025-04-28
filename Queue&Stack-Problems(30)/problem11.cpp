#include <iostream>
#include <stack>

using namespace std;

/*
        - Problem Statement: 
            Write a C++ program that uses a stack to determine if the input string of parentheses is balanced or not.

        - Example Input/Output: 
            (()
            Not Balanced
            )(
            Not Balanced
            ((()))
            Balanced
*/

bool isBalanced(string str) {

    stack<char> s;
    for (char &c : str) {

        if (c == '(') {
            s.push(c);
        }
	    else if (c == ')') {
            if (s.empty()) {
                return false;
            }
            s.pop();
        }
    }
    return s.empty();

}

int main() {
    

    cout << isBalanced("(())()(");
    return 0;
}

