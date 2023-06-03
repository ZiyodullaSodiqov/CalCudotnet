using System;

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
    System.Console.Write("son: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    string meassage = firstNumber >= 0 ? "1-raqam postive" : "1-raqam negative";


    System.Console.WriteLine(meassage);
    
    System.Console.Write("+ - * / %");

    System.Console.WriteLine("Operationni tanlang: ");
    string opiration = Console.ReadLine();

    System.Console.Write("A raqamni kiriting: ");
    int raqamOne = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("B raqamni kiriting: ");
    int raqamTwo = Convert.ToInt32(Console.ReadLine());

    switch(opiration) {
        case "+":
            System.Console.WriteLine($"{raqamOne} + {raqamTwo} = {raqamOne + raqamTwo}");
            break;

        case "-":
            System.Console.WriteLine($"{raqamOne} - {raqamTwo} = {raqamOne - raqamTwo}");
            break;

        default:
            System.Console.WriteLine("Operation not Found");
            break;
    }