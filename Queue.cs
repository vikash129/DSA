using System ;

class Queue
{
  private  int top = -1 ;
  private  int front = -1 ;

   private int[] arr  = new int[100];

   public void Enqueue(int value){

    if(top==-1){
        front = 0 ;
        top = 0 ;
    }
    else{
            this.top = this.top + 1 ;
    }
    arr[this.top] = value;
}

   public int Dequeue(){

    if (front == -1){
        return -1;
    }

    if(front == top ){
        front = -1 ; 
        top = -1 ;
    }
    else{
    this.front = this.front+1;
    }
    
    int frontvalue = arr[front] ;

    return frontvalue;
}


  public  int Peek(){
    if(top == -1){
        Console.WriteLine("Queue is empty");
        return -1;
    }

    return arr[front];
}



  public  bool Contains(int target){
    for (int i = front; i <= top; i++)
    {
        if(arr[i] == target) return true ; 
    }
return false ;
}

// 3 4 5 6
//   f    t
  public  int Size(){
    return (top-front)+1;
}

   public int Center(){
    int centerpos = (top-front) / 2 ; 
    return arr[centerpos];
}
   public void Sort(){}
   public void Reverse(){}
   public void Iterator(){} 

  public  void Print() {
     for (int i = front; i <= top; i++)
    {
       Console.Write("{0} " , arr[i] ) ; 
    }
    Console.WriteLine();
}
};

