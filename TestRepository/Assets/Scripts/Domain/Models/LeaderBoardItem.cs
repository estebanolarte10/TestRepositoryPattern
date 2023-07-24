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