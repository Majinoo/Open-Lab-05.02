namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            if (sentence.EndsWith("??"))
            {
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    if (sentence[i].ToString() == "?")
                    {
                        sentence = sentence.Remove(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }
                return sentence + "?";
            }
            else if (sentence.EndsWith("!!"))
            {
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    if (sentence[i].ToString() == "!")
                    {
                        sentence = sentence.Remove(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }
                return sentence + "!";
            }
            else
            {
                return sentence;
            }
        }
    }
}