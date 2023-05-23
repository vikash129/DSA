#include <iostream>
using namespace std;

void printstars_1(int N){
    if(N>1){
        printstars_1(N-1);
    }
        cout<<"*" <<endl;
};

void printstars_2(int N){
        cout<<"*" <<endl;
 if(N>1){
        printstars_2(N-1);
    }
};
int main()
{
   printstars_2(4);
   cout <<endl;
   printstars_1(4);

    return 0;
}