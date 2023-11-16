namespace TLab_10
{
    internal interface ICipher
    {
        string Encode();
        string Decode();
    }
    internal class ACipher : ICipher
    {
        private string text;
        public string Text
        {
            get{return text;}
            set{text = value;}
        }
        private string result;
        public string Result
        {
            get{return result;}
            set{result = value;}
        }
        public ACipher(string text)
        {
            this.text = text;
        }
        public string Encode()
        {
            char[] arrtext = text.ToCharArray();

            for (int i = 0; i < arrtext.Length; i++)
            {
                if (arrtext[i] == 'z')
                {
                    arrtext[i] = 'a';
                }
                else if (arrtext[i] == 'я')
                {
                    arrtext[i] = 'а';
                }
                else if (char.IsLetter(arrtext[i]))
                {
                    arrtext[i] = (char)(((int)(arrtext[i]))+1);
                }
            }
            result = new string(arrtext);
            return new string(arrtext);
        }
        public string Decode()
        {
            char[] arrtext = result.ToCharArray();

            for (int i = 0; i < arrtext.Length; i++)
            {
                if (arrtext[i] == 'a')
                {
                    arrtext[i] = 'z';
                }
                else if (arrtext[i] == 'а')
                {
                    arrtext[i] = 'я';
                }
                else if (char.IsLetter(arrtext[i]))
                {
                    arrtext[i] = (char)(((int)(arrtext[i]))-1);
                }
            }

            return new string(arrtext);
        }

    }
    internal class BCipher : ICipher
    {
        private string text;
        public string Text
        {
            get{return text;}
            set{text = value;}
        }
        private string result;
        public string Result
        {
            get{return result;}
            set{result = value;}
        }
        public BCipher(string text)
        {
            this.text = text;
        }
        public string Encode()
        {
            char[] arrtext = text.ToCharArray();

            for (int i = 0; i < arrtext.Length; i++)
            {
                if ((int)(arrtext[i]) >= 1072 && (int)(arrtext[i]) <= 1103)
                {
                    arrtext[i] = (char)(1103 - ((int)(arrtext[i]) - 1072));
                }
                else if (char.IsLetter(arrtext[i]))
                {
                    arrtext[i] = (char)(122 - ((int)(arrtext[i]) - 97));
                }
            }
            result = new string(arrtext);
            return new string(arrtext);
        }
        public string Decode()
        {
            char[] arrtext = result.ToCharArray();

            for (int i = 0; i < arrtext.Length; i++)
            {
                if ((int)(arrtext[i]) >= 1072 && (int)(arrtext[i]) <= 1103)
                {
                    arrtext[i] = (char)(1103 - ((int)(arrtext[i]) - 1072));
                }
                else if (char.IsLetter(arrtext[i]))
                {
                    arrtext[i] = (char)(122 - ((int)(arrtext[i]) - 97));
               }
            }
            return new string(arrtext);
        }
    }
}