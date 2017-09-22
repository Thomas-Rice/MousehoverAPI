using NUnit.Framework;

namespace MouseHoverAPI.Models
{
    [TestFixture]
    public class MouseHoverShould
    {

        [TestCase("0,0 N; M", ExpectedResult = "0,1 N")]
        [TestCase("0,1 N; M", ExpectedResult = "0,2 N")]
        [TestCase("1,1 N; M", ExpectedResult = "1,2 N")]
        [TestCase("1,1 N; MMM", ExpectedResult = "1,4 N")]
        public string MoveForwardStep(string input)
        {
            return MovementCalculator.Move(input);
        }


        [TestCase("1,1 N; R", ExpectedResult = "1,1 E")]
        [TestCase("1,1 N; RR", ExpectedResult = "1,1 S")]
        [TestCase("1,1 N; RRR", ExpectedResult = "1,1 W")]
        [TestCase("1,1 N; RRRR", ExpectedResult = "1,1 N")]
        [TestCase("1,1 N; RRRRR", ExpectedResult = "1,1 E")]
        public string ChangeDirectionClockwise(string input)
        {
            return MovementCalculator.Move(input);
        }

        [TestCase("1,1 N; L", ExpectedResult = "1,1 W")]
        [TestCase("1,1 N; LL", ExpectedResult = "1,1 S")]
        [TestCase("1,1 N; LLL", ExpectedResult = "1,1 E")]
        [TestCase("1,1 N; LLLL", ExpectedResult = "1,1 N")]
        [TestCase("1,1 N; LLLLL", ExpectedResult = "1,1 W")]
        public string ChangeDirectionAntiClockwise(string input)
        {
            return MovementCalculator.Move(input);
        }

        [TestCase("1,1 N; MRM", ExpectedResult = "2,2 E")]
        [TestCase("1,1 N; MMMRRMMM", ExpectedResult = "1,1 S")]
        [TestCase("1,1 N; MMMRRMMMR", ExpectedResult = "1,1 W")]
        [TestCase("1,1 N; MMMRRMMMRMMRM", ExpectedResult = "-1,2 N")]
        [TestCase("1,1 N; MLM", ExpectedResult = "0,2 W")]
        [TestCase("1,1 N; MLMLM", ExpectedResult = "0,1 S")]
        public string MoveTurnMove(string input)
        {
            return MovementCalculator.Move(input);
        }

        [TestCase("1,1 E; MRM", ExpectedResult = "2,0 S")]
        [TestCase("1,2 S; MRM", ExpectedResult = "0,1 W")]
        [TestCase("3,2 W; MRM", ExpectedResult = "2,3 N")]
        [TestCase("3,2 W; MRM", ExpectedResult = "2,3 N")]
        public string MoveTurnMoveFromDifferentStartingDirection(string input)
        {
            return MovementCalculator.Move(input);
        }

        [TestCase("3,2 E; MRMMRM", ExpectedResult = "3,0 W")]
        [TestCase("3,2 E; MRMMRMLM", ExpectedResult = "3,-1 S")]
        public string MoveTurnMoveMoveTurnMoveFromDifferentStartingDirection(string input)
        {
            return MovementCalculator.Move(input);
        }

    }
}
