open System

// Eine Variable/Funktion, welche ein String defniert
let ausgabe1="Hello World from F#! Geben Sie etwas ein und drücken Sie ENTER:"
// Eine Funktion "ausgabe2" mit einem Parameter "eingabeVonKonsole"
let ausgabe2 eingabeVonKonsole="Ihre Eingabe : " + eingabeVonKonsole

[<EntryPoint>]
let main argv =                    
    Console.WriteLine(ausgabe1)   
    
    // Der MEthode "WriteLine" wird die Methode "ausgabe2" übergeben. Dieser wird als Parameter die Funktion "ReadLine"
    // übergeben
    Console.WriteLine(ausgabe2(Console.ReadLine()))

    0 // return an integer exit code

