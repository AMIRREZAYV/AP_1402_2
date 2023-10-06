#include <iostream>
using namespace std;

bool IsPrime (int num){
    if (num <= 1){
        return false;
    }
    for(int i = 2 ; i < num ; i++){
            if (num % i == 0){
                return false;
            }
        }
return true;
}


int main(){

    int num1 , num2 ;

    cout << " 2 Adad Vared Konid : " << endl;
    cin >> num1 >> num2 ;

    for (int i = num1 + 1 ; i < num2 ; i++){

        if(IsPrime(i) == true){
            cout << i << " " ;
        }
    }
return 0;

}
