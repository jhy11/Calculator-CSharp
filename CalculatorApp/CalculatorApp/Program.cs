// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("사칙연산 계산기");
    Console.WriteLine("첫번째 숫자: ");
    double number1;
    while (!double.TryParse(Console.ReadLine(), out number1))
    {
        Console.WriteLine("유효한 숫자를 입력하세요.");
    }
    Console.WriteLine("연산자 (+, -, *, /) 중 하나 입력: ");
    string operation = Console.ReadLine();

    Console.WriteLine("두번째 숫자: ");
    double number2;
    while (!double.TryParse(Console.ReadLine(), out number2))
    {
        Console.WriteLine("유효한 숫자를 입력하세요.");
    }
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            break;
        case "-":
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            break;
        case "*":
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            break;
        case "/":
            if (number2 == 0)
            {
                Console.WriteLine("0으로 나눌 수 없습니다.");
            }
            else
            {
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            }
            break;
        default:
            Console.WriteLine("유효하지 않은 연산자입니다.");
            break;
    }
    Console.WriteLine("계속하려면 아무 키나 누르세요... 종료하려면 'exit'를 입력하세요.");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit") break;
}
