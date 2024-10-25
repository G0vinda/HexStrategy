using System.Linq;
using HexSystem;
using UnityEngine;

namespace Unit
{
    public class UnitController : MonoBehaviour
    {
        [SerializeField] private MapCreator mapCreator;
    
        private global::Unit.Unit _selectedUnit;

        public void HandleHexClick(Hexagon clickedHex)
        {
            if (_selectedUnit != null)
            {
                if (CanMoveOnHex(clickedHex))
                {
                    SetUnitMovement(clickedHex);
                }
            }
            else
            {
                SetSelectedUnit(clickedHex);
            }
        }

        public void DeselectUnit()
        {
            _selectedUnit = null;
        }

        private void SetSelectedUnit(Hexagon clickedHex)
        {
            _selectedUnit = clickedHex.units.FirstOrDefault();
        }

        private void SetUnitMovement(Hexagon clickedHex)
        {
            var currentUnitCoordinates = _selectedUnit.NextWaypoint.Coordinates;
            var clickedCoordinates = clickedHex.Coordinates;
                
            var newUnitPath = mapCreator.Grid.GetPathBetween(currentUnitCoordinates, clickedCoordinates);
            _selectedUnit.SetAllWaypoints(newUnitPath.Select(hex => new global::Unit.Unit.Waypoint(hex.Coordinates, hex.transform.position)).ToList());
        }

        private bool CanMoveOnHex(Hexagon hexagon)
        {
            return hexagon.isTraversable;
        }
    }
}
