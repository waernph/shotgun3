class InputChecker
{
    public bool UserInput(char input)
    {
        switch (input)
        {
            case 's':
                return true;

            case 'l':
                return true;

            case 'b':
                return true;

            case 'h':
                return true;

            default:
                return false;
        }
    }

    //Metod för att skicka vidare input ifall de möter alla vilkor, skott och input
    /*     public string ValidInput(charInput)
        {

        } */
}
