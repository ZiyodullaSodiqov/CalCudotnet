using System;
using Calcu.Classes;

 string password = "";

    do{
        Console.WriteLine("Enter Password: ");
        password = Console.ReadLine();

    }while(password !=  "zsm");

//     int firstNumber = Convert.ToInt32(Console.ReadLine());
//     int secondNumber = Convert.ToInt32(Console.ReadLine());

//     System.Console.WriteLine($"Add {firstNumber + secondNumber}");

// System.Console.Write("Ismingiz: ");
// string name = System.Console.ReadLine();
// System.Console.WriteLine($"Hello {name}");

// int kescha = 2;

// System.Console.Write("Yoshingiz: ");
// int yoshim = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Yoshingiz farqi: {yoshim - kescha}");

// System.Console.Write("Raqam A: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Raqam B: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// if(numberOne == numberTwo) {
//     System.Console.WriteLine("Sonlar teng");
// } else {
//     System.Console.WriteLine("Sonlari teng emas");
// }

// int numberOne  = Convert.ToInt32(Console.ReadLine());


    // int counter = 2;

    // while(counter < numberOne){
    //     Console.WriteLine(counter);
    //     counter += 2;
    // }


    // string password = "";

    // do{
    //     Console.WriteLine("Enter Password: ");
    //     password = Console.ReadLine();

    // }while(password !=  "pass$0");
    // System.Console.Write("Yoshingiz: ");
    // int raqamPop = Convert.ToInt32(Console.ReadLine());

    // System.Console.Write("Ismingiz: ");
    // string names = Console.ReadLine();

    // if(raqamPop > 18 ){
    //     Console.Write($"Yoshingiz {raqamPop} tog`ri keladi  {names}");
    // }else{
    //     Console.WriteLine($"Yoshingiz {raqamPop} tog`ri kelmaydi {names}");
    // }if(raqamPop == 18){
    //     Console.WriteLine($"{raqamPop} dan katta bo`lishingiz kerak {names}");
    // }
    // System.Console.Write("son: ");
    // int firstNumber = Convert.ToInt32(Console.ReadLine());
    // string meassage = firstNumber >= 0 ? "1-raqam postive" : "1-raqam negative";


    // System.Console.WriteLine(meassage);
    
    // System.Console.Write("+ - * / %");

    // System.Console.WriteLine("Operationni tanlang: ");
    // string opiration = Console.ReadLine();

    // System.Console.Write("A raqamni kiriting: ");
    // int raqamOne = Convert.ToInt32(Console.ReadLine());
    // System.Console.Write("B raqamni kiriting: ");
    // int raqamTwo = Convert.ToInt32(Console.ReadLine());

    // switch(opiration) {
    //     case "+":
    //         System.Console.WriteLine($"{raqamOne} + {raqamTwo} = {raqamOne + raqamTwo}");
    //         break;

    //     case "-":
    //         System.Console.WriteLine($"{raqamOne} - {raqamTwo} = {raqamOne - raqamTwo}");
    //         break;

    //     default:
    //         System.Console.WriteLine("Operation not Found");
    //         break;
    // }

        
       

        Animal kescha = new Animal();
        string agesAsstring = Console.ReadLine();
        System.Console.WriteLine("Conwerting...");
        int age = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Yoshingiz");
        kescha.Age = -3;
        int AgeDifference = age - kescha.Age;
        System.Console.WriteLine($"karochi farq qilekan {kescha.AgeDifference}");

    // string result = opiration switch
    // {
    //     "+" => $"{raqamOne} + {raqamTwo} = {raqamOne + raqamTwo}",
    //     "/" => $"{raqamOne} / {raqamTwo} = {raqamOne / raqamTwo}",
    //     "_" => "Operation not found"  
    // };

    // System.Console.Write(result);

    // System.Console.WriteLine("Son yozda: ");
    // int son = Convert.ToInt32(Console.ReadLine());

    // string[] friends = {"friend1" , "friend2", "friend3", "friend4"};
    // int[] frAge = {10,20,30,40};
    // string[] adress = {"Qarshi" , "Samarqand", "Namangan", "Farg`ona"};

    // Console.WriteLine(friends[son] + frAge[son]  + adress[son]);


    // foreach(string element in friends) {
    //     System.Console.WriteLine(element);
    // }

    // for (int i = 1; i <= 10; i++) {
    //  System.Console.WriteLine(i);   
    // }

    // for(int itarator = 1; itarator <= 10; itarator++){
    //     for(int inneritarator = 1; inneritarator <= 10; inneritarator++){
    //         System.Console.WriteLine($"{itarator} x {inneritarator} = {itarator * inneritarator}");
    //     }
    //     System.Console.WriteLine("\n");
    // }
