namespace Sort.Extensions
{
    public class Util
    {
        public Util()
        {
            
        }

        public static bool IsValidOption(string option) {

            bool escolhaValida = int.TryParse(option, out int optionChoosed);

            if (!escolhaValida || optionChoosed < 1 || optionChoosed > 3)
                return false;

            return true;
        }
    }
}
