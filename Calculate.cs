using System ;
 class Calculate
 { 
   public static void Main()
 { 
    try{
  throw new Exception() ;
     }
 catch(Exception e) 
 { 
 Console.WriteLine("exception ");
   try{
    throw new Exception();
   }
catch(Exception e) 
 {
 Console.WriteLine("handled now"); 
 }
}
 finally 
 { 
  Console.WriteLine("Exception over in finally");
 } 
 
   Console.WriteLine("Exception over");	
    
 } 
 } 