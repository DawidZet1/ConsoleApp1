int age = 23;
string name = "Dawid";
bool male = true;

string result = "Nazywam się_" + name + "_i mam_" + age + "_lata";
string result1 = "Jestem mężczyzną po 20";
string result2 = "Jestem mężczyzną w wieku 20-25 lat";
string result3 = "Jestem kimś innym";
if (male) ;
{
    if (age > 20)
    
        Console.WriteLine(result1);
    
    else if (age > 25) ;
    
        Console.WriteLine(result2);
        if (name == "Dawid") ;
        
            Console.WriteLine(result);
        
    
}