#include <iostream>
#include <vector>
#include <math.h>
using namespace std;

// approch 1 -  by btute -> Order : O(N * sqrt(N))
// vector<int> primeRange(int M, int N)
// {
//     vector<int> result;

//     if(M==1) M+=1 ;


//     for (int i = M; i <= N; i++)
//     {
//         int prime = 1 ;
//         for (int j = 2; j <= sqrt(i); j++)
//         {
//             if (i % j == 0){
//                 prime=0;
//                 break;
//             }
//         }
//         if(prime)
//             result.push_back(i);
//     }

//     return result;
// }


// approch 2 -  by sieve of erotesthesness
vector<int> primeRange(int M, int N)
{
    
 if(M==1) M+=1 ;

 int *prime = new int[N+1];

    vector<int> result;

    for (int i = M; i <= N; i++)
        prime[i] = 1;


    for (int i = M; i <= N; i++)
    {
        if (prime[i] == 1)
        {
            for (int j = i * i; j <= N; j += i)
            {
                // cout << j << endl;
                prime[j] = 0;
            }
        }
    }

    for (int i = M; i <= N; i++)
    {
        if (prime[i])
            result.push_back(i);
    }
    delete[] prime;

    return result;
}

int main()
{
    int n, m;
    cin >> m >> n;

    vector<int> result = primeRange(m, n);

    for (int i = 0; i < result.size(); i++)
        cout << result[i] << " ";
}

/*
erp
asd@ASD123
*/