open System

let ausgabe1="Hello World from F#!"
let ausgabe2 eingabeVonKonsole="Ihre Eingabe " + eingabeVonKonsole

[<EntryPoint>]
let main argv =                    
    Console.WriteLine(ausgabe1)   
    Console.WriteLine(ausgabe2(Console.ReadLine()))
    0 // return an integer exit code

