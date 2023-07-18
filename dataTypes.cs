
//      VARIABLE DECLEARTION : 

// 1.   datatype variable_name;
//      datatype variable_name = value;

        int x = 10;
        Console.WriteLine(x);


// 2.var keyword :
//      datatype variable_name;-------> WRONG, here must be initialize it decleared.
//      datatype variable_name = value;
//      var b;  // WRONG

        var y = 20;     // CORRECT
//        y = "de";     NOT CHANGE DATATYPE
        Console.WriteLine(y);
        Console.WriteLine(y.GetType());



// 3.object keyword :
//      onject variable_name;
//      object variable_name = value;

//      object b;
//      object b = 10;

        object a;     // CORRECT
        a = "de";     // CHANGES ACCEPTABLE 
        a = 5;
        Console.WriteLine(a);

        object b = 10;
//        Console.WriteLine(b*a);             // NOT USED DIRECTLY BECAUSE IT IS AN OBJECT.

        Console.WriteLine((int)b * (int)a);  // CORRECT WAY TO USE.



// 4.dynamic keyword: 
//      dynamic variable_name;
//      dynamic variable_name = 45;

        dynamic z ;
        z = 10;
        z = "Deepak";   // CHANGES ACCEPTABLE 
        Console.WriteLine(z.GetType());

// --------------------------------------------------------------------------------------------------------------

//    TYPECASTING:- 

//    THERE ARE FOUR WAYS :-


// 1. using parse method:-
        string s = "100";
        Console.WriteLine(s);
        int t = 50;
        Console.WriteLine(t + s); // OUTPIT IS 50100. THIS IS CONCATENATION.
        
        Console.WriteLine(t+ int.Parse(s)); // AFTER TYPECASTING OUTPUT IS 150 . THIS IS PERFECT ADDITION.
        Console.WriteLine(t + decimal.Parse(s));



// 2. using convert method:- 
        string u = "10";
        Console.WriteLine(u);
        int v = 80;

        Console.WriteLine(v + Convert.ToInt32(u)); // AFTER TYPECASTING OUTPUT IS 90 . THIS IS PERFECT ADDITION.
        Console.WriteLine(v + Convert.ToDecimal(u));



// 3. using convert method:- 
//      String m = "60m";       // IT IS NOT CONVERTABLE THEN STATUS WILL BE FALSE AND VALUE WILL 0.

        string m = "100";       // IT IS CONVERTABLE THEN STATUS WILL BE TRUE.
        Console.WriteLine(m);

        int n;
        bool sts = int.TryParse (m, out n);
        Console.WriteLine(sts);
        Console.WriteLine(n);



// 4. using ToString method:-
        int j = 10;
        int k = 30;
        Console.WriteLine (j + k);                        // THIS IS ADDITION.
        Console.WriteLine(j.ToString() + k.ToString());  //  AFTER TYPECASTING OUTPUT IS 1030. THIS IS PERFECET CONCATENATION.
        
    









