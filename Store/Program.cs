using System.Collections.Specialized;

int pengar = 5000;

Console.WriteLine("Välkommen till affären");
Console.WriteLine("");

while (pengar > 0) {
    Console.WriteLine("Du har " + pengar + "kr");
    Console.WriteLine();
    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. Ett svärd (500kr)");
    Console.WriteLine("2. En trolldryck (30kr)");
    Console.WriteLine("3. Knark (250kr)");
    Console.WriteLine("4. Läkemedel (80kr)");
    string val = Console.ReadLine();
    Console.Clear();
    int valnmr = 0;
    bool success = int.TryParse(val, out valnmr);
    if (success == false || valnmr > 4) {
        Console.Clear();
        Console.WriteLine("Skriv in en siffra eller så finns inte den artikeln du söker efter");
        Console.WriteLine("");
    }
    if (valnmr == 1) {
        if (pengar >= 500) {
            Console.WriteLine("Hur många vill du köpa?");
            string antal = Console.ReadLine();
            int antalnmr = 0;
            bool success2 = int.TryParse(antal, out antalnmr);
            if (success2 == false) {
                Console.WriteLine("Skriv in en siffra idiot");
            }
            if (antalnmr * 500 <= pengar) {
                int finalprice = antalnmr * 500;
            pengar -= finalprice;
            Console.WriteLine("Du har köpt " + antalnmr + " svärd, tryck för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            } else {
                Console.Clear();
                Console.WriteLine("Du har inte råd med detta föremål");
                Console.WriteLine();
            }
        
        } else {
            Console.Clear();
            Console.WriteLine("Du har inte råd med detta föremål");
            Console.WriteLine();
        }   
    }

    if (valnmr == 2) {
        if (pengar >= 30) {
            Console.WriteLine("Hur många vill du köpa?");
            string antal = Console.ReadLine();
            int antalnmr = 0;
            bool success2 = int.TryParse(antal, out antalnmr);
            if (success2 == false) {
                Console.WriteLine("Skriv in en siffra idiot");
            }
            if (antalnmr * 30 <= pengar) {
                int finalprice = antalnmr * 30;
            pengar -= finalprice;
            Console.WriteLine("Du har köpt " + antalnmr + " trolldryck, tryck för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            } else {
                Console.Clear();
                Console.WriteLine("Du har inte råd med detta föremål");
                Console.WriteLine();
            }
        
        } else {
            Console.Clear();
            Console.WriteLine("Du har inte råd med detta föremål");
            Console.WriteLine();
        }   
    }

    if (valnmr == 3) {
        if (pengar >= 250) {
            Console.WriteLine("Hur många vill du köpa?");
            string antal = Console.ReadLine();
            int antalnmr = 0;
            bool success2 = int.TryParse(antal, out antalnmr);
            if (success2 == false) {
                Console.WriteLine("Skriv in en siffra idiot");
            }
            if (antalnmr * 250 <= pengar) {
                int finalprice = antalnmr * 250;
            pengar -= finalprice;
            Console.WriteLine("Du har köpt " + antalnmr + " knark, tryck för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            } else {
                Console.Clear();
                Console.WriteLine("Du har inte råd med detta föremål");
                Console.WriteLine();
            }
        
        } else {
            Console.Clear();
            Console.WriteLine("Du har inte råd med detta föremål");
            Console.WriteLine();
        }   
    }

    if (valnmr == 4) {
        if (pengar >= 80) {
            Console.WriteLine("Hur många vill du köpa?");
            string antal = Console.ReadLine();
            int antalnmr = 0;
            bool success2 = int.TryParse(antal, out antalnmr);
            if (success2 == false) {
                Console.WriteLine("Skriv in en siffra idiot");
            }
            if (antalnmr * 80 <= pengar) {
                int finalprice = antalnmr * 80;
            pengar -= finalprice;
            Console.WriteLine("Du har köpt " + antalnmr + " läkemedel, tryck för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            } else {
                Console.Clear();
                Console.WriteLine("Du har inte råd med detta föremål");
                Console.WriteLine();
            }
        
        } else {
            Console.Clear();
            Console.WriteLine("Du har inte råd med detta föremål");
            Console.WriteLine();
        }   
    }
}
if (pengar == 0 || pengar > 30 ) {
    Console.Clear();
    Console.WriteLine("Du har inte råd med någonting i affären, gå ut");
}


Console.ReadLine();