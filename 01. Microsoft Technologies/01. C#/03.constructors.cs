/**
* A constructor is like a method with the same name as a class, but it's a unique method.
* Even if it's not created, the compiler creates a default constructor in memory at the time of creating an object of the class.
* The constructor is used ot initialize the object with some default values.
* There are 4 types of constructors
*/

 public class Student
    {
        private int rollNumber { get; set; }
        private string fullName { get; set; }         
        
        // 1. default constructor          
        public Student()          
        {             
            //code goes here          
        }          
        
        // 2. parameterized constructor          
        public Student(int rNum, string fName)          
        {              
            this.rollNumber = rNum;              
            this.fullName = fName;          
        }          
        
        // 3. static constructor          
        static Student()          
        {              
            //code goes here          
        }          
        
        // 4. copy constructor          
        public Student(Student student)          
        {              
            rollNumber = student.rollNumber;              
            fullName = student.fullName;          
        }   
    }