using Implementation.Common.Interfaces;
using Match3.Core.Interfaces;
using Match3.Core.Models;
using Match3.Core.Structs;

namespace Implementation.Common.SequenceDetectors
{
    public class HorizontalLineDetector : LineDetector
    {
        private readonly GridPosition[] _lineDirections;

        public HorizontalLineDetector()
        {
            _lineDirections = new[] { GridPosition.Left, GridPosition.Right };
        }

        public override ItemSequence<IUnityItem> GetSequence(IGameBoard<IUnityItem> gameBoard,
            GridPosition gridPosition)
        {
            return GetSequenceByDirection(gameBoard, gridPosition, _lineDirections);
        }
    }
}