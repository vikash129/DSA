using System ;

class PriorityQueue
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



class Program
{
    static void Main(string[] args)
    {

PriorityQueue priority_queue = new PriorityQueue();


    while (true)
    {
            Console.WriteLine("Enter '1' to Enqueue:");
            Console.WriteLine("Enter '2' to Dequeue:");
            Console.WriteLine("Enter '3' to Peek:");
            Console.WriteLine("Enter '4' to check if element contains :"); 
            Console.WriteLine("Enter '5' Size:");
            Console.WriteLine("Enter '6' Reverse:");
            Console.WriteLine("Enter '7' Center");
            Console.WriteLine("Enter '8' Iterator");
            Console.WriteLine("Enter '9' Print Queue ");

            char command = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (command)
            {
                case '1':
                    Console.WriteLine("Enter value to enqueue :");
                    int valueToInsert = int.Parse(Console.ReadLine());
                    priority_queue.Enqueue(valueToInsert);
                    Console.WriteLine("Enqueued {0}.", valueToInsert);
                    priority_queue.Print();
                    break;
                case '2':                                        
                    int remove = priority_queue.Dequeue() ; 
                        if(remove==-1){
                        Console.WriteLine("priority_queue is empty");
                         }
                        else{
                         Console.WriteLine("Dequeued : {0} .", remove);
                        priority_queue.Print();
                
                        }
                    break;
                case '3':
                    Console.WriteLine("{0} peek is .", priority_queue.Peek());
                    break;
                case '4':
                Console.WriteLine("Enter element  : ");
                    int target =  int.Parse(Console.ReadLine());

                    if(priority_queue.Contains(target)){
                Console.WriteLine("Element is present");

                    }
                    else{
                Console.WriteLine("Element is not present");

                    }
                    break;

                case '5':
                    Console.WriteLine("Size is {0}", priority_queue.Size()) ;
                    break;
                case '6':
                    Console.WriteLine("Reverse of priority_queue is ") ;
                    priority_queue.Reverse();
                    priority_queue.Print();
                    break;
                case '7':
                    Console.WriteLine("Center is {0}", priority_queue.Center()) ;
                     break;
                case '8':
                    Console.WriteLine("After Sorteing : ") ;
                    priority_queue.Sort();
                    priority_queue.Print();
                    break;

                case '9':
                Console.WriteLine("priority_queue is : ") ;
                    priority_queue.Print();
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    
    }
}

