string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation = 0;
int stringCounts = myStrings.Length;
string myString  = ""; 

 for (int i = 0; i <= stringCounts; i++)
 {
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
 }
  
   //var isTrue = myStrings[0].IndexOf(".", 0, myStrings.Length);

    Console.WriteLine(myStrings[0]);
    
