#include <iostream>

using namespace std;


class Node
{
    public:
	int data;
	Node* left = NULL;
    Node* right = NULL;

    Node(int val){
        data  = val ;
    }
};


int main()
{
    Node *root  =new Node(1) ;

    root->left  =new Node(2) ;
    root->right  =new Node(3) ;

    root->left->left = new Node(5);
    root->left->right = new Node(5);

    root->right->left = new Node(12);
    root->right->right = new Node(43);
return 0;
}