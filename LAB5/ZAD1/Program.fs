// For more information see https://aka.ms/fsharp-console-apps
let rec function_f n =
    if n = 1 then 1
    else 2*function_f(n - 1) + n
let function_result = 0
let list = [1;2;3;4;5;6;7;8;9;10] //Deklarowanie listy argumentów.
for i in list do //Deklarowanie pętli for
    printfn "%d" (function_f(i)) //wyświetlanie wartości na konsoli
        
let rec Func(n,m) =
    if n < m then
    raise (System.Exception "n < m") // funkcja, która zwraca wyjątek
    elif (n = m || m = 0) then 1
    else Func(n-1,m) + Func(n-1,m-1)
let Func_result = Func(5,3)
System.Console.WriteLine(Func_result)