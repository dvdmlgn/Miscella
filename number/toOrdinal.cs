public static class Number {
    private static string[] singles = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    private static string[] teens   = {"", "eleven", "tweleve", "thir", "", "fiv"};
    private static string[] tens    = {"ten", "twenty"};
    private static string[] suffies = {"teen", "ty", "hundred"};
    private static string   nil     = "zero";

    private static string[] denominations = {"thousand", "million", "billion", "trillion"};


    public static string ToOrdinal(int number) {
        string numberString = number.ToString();
        //int[] denominationGroupings = DenominatonParse(numberString);
    }


    private static string[] DenominationParse(string number) {

    }

    private static string GroupingToText(string number) {
        int    length            = number.Length;
        int    lastNumber        = numbers.Length - 1;
        char[] numbers           = number.ToCharArray();
        bool   containsTeenValue = DoesContainTeenValue(ref numbers, ref lastNumber);
        string text              = "";

        switch(length) {
            case 1:

                break;

            case 2:
                text = (containsTeenValue) ? TeenToText()
                                           : TenToText() + SingleToText();
                break;

            case 3:

                break;
        }

        return text;
    }

    private static bool DoesContainTeenValue(ref char[] numbers, ref int lastNumber) {
        int middleNumber = lastNumber - 1;

        return (numbers.Length > 1 
                && numbers[middleNumber] == '1' 
                && numbers[lastNumber] != '0') 
                ? true : false ;
    }

    private static string SingleToText() {

    }

    private static string TeenToText(ref char lastNumber) {
        switch(lastNumber) {
            case '1':
            case '2':
                
                break;

            case '3':
            case '5':
                
                break;

            default:
                
                break;
        }
    }

    private static string TeenToText(ref char number) {

    }


}