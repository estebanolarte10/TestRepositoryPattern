namespace Domain.Models
{
    public class LeaderBoardItem
    {
        private string _name;
        private int _score;
        public LeaderBoardItem(string name, int score)
        {
            _name = name;
            _score = score;
            ValidateName();
            ValidateScore();
        }

        private void ValidateName()
        {
            if (string.IsNullOrEmpty(_name))
            {
                throw new EmptyNameException("The name cannot be empty.");
            }
        }
        private void ValidateScore()
        {
            if (_score < 0)
            {
                throw new NegativeScoreException("The score cannot be negative");
            }
        }
        public string GetName()
        {
            return _name;
        }
        public int GetScore()
        {
            return _score;
        }
    }
}