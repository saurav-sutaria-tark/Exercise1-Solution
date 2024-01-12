namespace Exercise1_Solution.Solutions
{
    internal class HuffmanDecoding
    {
        public String Decode(String archive, String[] dictionary)
        {
            Dictionary <String,int> map = new Dictionary<String, int>();
            for(int i = 0; i < dictionary.Length; i++)
            {
                map[dictionary[i]] = i;
         
            }
            String decodedString = "";
            String buffer = "";
            foreach(char s in archive)
            {
                buffer += s;
                if (map.ContainsKey(buffer))
                {
                    decodedString += (char)((map[buffer]) + 'A');
                    buffer = "";
                }
            }
            return decodedString;
        }
    }
}
