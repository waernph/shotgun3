## Beskrivning av projekt
En inlämningsuppgift som går ut på att skapa spelet Shotgun. 
Shotgun är likt sten, sax, påse men det läggs även till ett fjärde alternativ
när vissa vilkor är uppfylda.

## Logik för spelet.
Skjuta -Förlorar ett skott. Kan bara användas om skott finns.
Ladda - Du laddar ett skott. Du förlorar om motståndare väljer skjut.
Blocka - Du blockar eventuella skott från motståndare. Du varken förlorar eller laddar skott.
Hagelgevär(shotgun) - Du vinner oavsett om motståndaren blockar. 
                      Väljer båda hagelgevär slumpas en vinnare.
                      Vilkoret är att du måste ha 3 skott.

## Struktur
Program.cs - Huvudfilen där spelet körs. Spelare instansieras. Text för att presentera vinnare. Fråga om att starta om spelet.

Player.cs - Innehåller spelar-klass. Här sköts alla val som görs. Här bestäms även om spelare ska få mata in val själv elelr om datorn slumpar fram det. Även inmatningsfel hanteras här.

Graphics.cs - Innehåller enbart logotyp för spel.

RandomHelper.cs - innehåller statiska metoder för att få slumpmässiga int för datorn val.

ShotsLeft.cs - Hanterar skotten. Om det ska subbtraheras, adderas men också för returnera antal skott för spelare.

Winner.cs - Avgör vem som vinner och eturnerar i form av string.

## git
Git har använts för att versionshantera, både lokalt men också pushat mot GitHub.
