bool a() 
{ 
    Console.WriteLine("a was executed."); 
    return false;
}
bool b() 
{ 
    Console.WriteLine("b was executed."); 
    return true;
}
Console.WriteLine(a() && b());

// bool a() 
// { 
//     Console.WriteLine("a was executed."); 
//     return false;
// }
// bool b() 
// { 
//     Console.WriteLine("b was executed."); 
//     return true;
// }
Console.WriteLine(a() || b());