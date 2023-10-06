#include <iostream>
using namespace std;

int main() {
    int num, sum = 0;
    cout << " Yeak Adad 4 Raghami Vared Konid : " << endl;
    cin >> num;

    sum += num % 10; // ??? ????
    num /= 10;

    sum += num % 10; // ??? ?????
    num /= 10;

    sum += num % 10; // ??? ?????
    num /= 10;

    sum += num; // ??? ???????

    cout << " Majmo Argham = " << sum << endl;

    return 0;
}