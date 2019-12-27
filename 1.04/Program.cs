using System;

namespace Less01_task02 
{ 
    class Program 
    { 
        public static void Main() 
        { 
            MyClass myClass = new MyClass(); 
            Console.WriteLine(myClass.X); 
        } 
    } 
    
    class MyClass 
    { 
        int x; 
        public int X 
        { 
            get { 
                return x; 
            } 
        } 
        public MyClass(int x) 
        { 
            this.x = x; 
        } 
        
        public MyClass() 
        { } 
    } 
}