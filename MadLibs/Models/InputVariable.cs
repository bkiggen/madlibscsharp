

namespace MadLibs.Models
{
    public class InputVariable
    {
        private string _noun1;
        private string _noun2;
        private string _verb3;
        private string _verb1;
        private string _verb2;

        public string GetNoun1()
        {
            return _noun1;
        }
        public string GetNoun2()
        {
            return _noun2;
        }
        public string GetVerb3()
        {
            return _verb3;
        }
        public string GetVerb1()
        {
            return _verb1;
        }
        public string GetVerb2()
        {
            return _verb2;
        }
        public void SetNoun1(string newWord)
        {
            _noun1 = newWord;
        }
        public void SetNoun2(string newWord)
        {
            _noun2 = newWord;
        }
        public void SetVerb1(string newWord)
        {
            _verb1 = newWord;
        }
        public void SetVerb2(string newWord)
        {
            _verb2 = newWord;
        }
        public void SetVerb3(string newWord)
        {
            _verb3 = newWord;
        }
    }
}