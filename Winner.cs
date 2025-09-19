using System.Formats.Asn1;

class Winner
{
    public static string WinnerIs(int player1Choice, int player2Choice)
    {
        string winner = "NoOne";
        if (player1Choice == 1)
        {
            if (player2Choice == 1)
                winner = "skjut - skjut";
            else if (player2Choice == 2)
                winner = "Spelare 1";
            else if (player2Choice == 3)
                winner = "skjut - block";
        }
        else if (player1Choice == 2)
        {
            if (player2Choice == 1)
                winner = "Spelare 2";
            else if (player2Choice == 2)
                winner = "Ladda - Ladda";
            else if (player2Choice == 3)
                winner = "ladda - block";
        }
        else if (player1Choice == 3)
        {
            if (player2Choice == 1)
                winner = "block - skjut";
            else if (player2Choice == 2)
                winner = "block - ladda";
            else if (player2Choice == 3)
                winner = "block -block";
        }
        else if (player1Choice == 4)
        {
            winner = "Spelare 1";
        }
        else if (player2Choice == 4)
        {
            winner = "Spelare 2";
        }

        else if (player1Choice == 4 && player2Choice == 4)
        {
            int randomWinner = RandomHelper.WinnerRandom12();
            if (randomWinner == 1)
            {
                winner = "Spelare 1";
            }
            else if (randomWinner == 2)
            {
                winner = "Spelare 2";
            }
        }
        return winner;
    }
}
