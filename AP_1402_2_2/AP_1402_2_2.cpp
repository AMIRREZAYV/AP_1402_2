#include <iostream>
using namespace std;

int MajmoArgham(int num) {

    int sum = 0;

    while (num > 0) {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int main() {

    int num1, num2, num3;

    cout << " 3 Adad Vared Konid: " << endl;
    cin >> num1 >> num2 >> num3;

    for (int i = num1 + 1 ; i < num2 ; i++) {
        if (MajmoArgham(i) == num3) {
            cout << i << endl;
        }
    }

    return 0;
}
