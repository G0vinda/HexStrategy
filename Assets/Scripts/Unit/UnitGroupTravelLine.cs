using System.Collections.Generic;
using Player;
using UnityEngine;

namespace Unit
{
    [RequireComponent(typeof(LineRenderer))]
    public class UnitGroupTravelLine : MonoBehaviour
    {
        [Header("References")] 
        [SerializeField] private MeshRenderer lineEndPoint;
        [SerializeField] private LineRenderer lineRenderer;
    
        [Header("Settings")]
        [SerializeField] private Vector3 lineOffset;
    
        private PlayerColor _playerColor;
        
        private const float HighlightedLineWidth = .15f;
        private const float DefaultLineWidth = .1f;
        private const float DefaultEndPointScale = .2f;
        private const float HighlightedEndPointScale = .25f;
        private bool _isHighlighted;

        private void Awake()
        {
            lineRenderer = GetComponent<LineRenderer>();
        }

        public void Initialize(PlayerColor playerColor)
        {
            _playerColor = playerColor;
            lineRenderer.material = playerColor.travelLineMaterial;
            lineEndPoint.material = playerColor.travelEndPointMaterial;
        }

        public void SetAllPositions(Vector3[] positions)
        {
            lineRenderer.positionCount = positions.Length;
            for (var i = 0; i < positions.Length; i++)
            {
                lineRenderer.SetPosition(i, positions[i] + lineOffset);
            }
        
            UpdateEndPointPosition();
            gameObject.SetActive(true);
        }

        public void SetFirstNodePosition(Vector3 position)
        {
            lineRenderer.SetPosition(0, position + lineOffset);
        
            UpdateEndPointPosition();
        }

        public void EnableHighlight()
        {
            if (_isHighlighted) return;
            
            lineRenderer.material = _playerColor.highlightedTravelLineMaterial;
            lineRenderer.startWidth = HighlightedLineWidth;
            lineRenderer.endWidth = HighlightedLineWidth;
            
            lineEndPoint.material = _playerColor.highlightedTravelEndPointMaterial;
            lineEndPoint.transform.localScale = new Vector3(HighlightedEndPointScale, 0.02f, HighlightedEndPointScale);
            
            //OffsetLineAndEndpoint(1);
            
            _isHighlighted = true;
        }
        
        public void DisableHighlight()
        {
            if(!_isHighlighted) return;
            
            lineRenderer.material = _playerColor.travelLineMaterial;
            lineRenderer.startWidth = DefaultLineWidth;
            lineRenderer.endWidth = DefaultLineWidth;
            
            lineEndPoint.material = _playerColor.travelEndPointMaterial;
            lineEndPoint.transform.localScale = new Vector3(DefaultEndPointScale, 0.02f, DefaultEndPointScale);
            
            //OffsetLineAndEndpoint(-1);
            _isHighlighted = false;
        }

        private void OffsetLineAndEndpoint(int sign)
        {
            for (var i = 0; i < lineRenderer.positionCount; i++)
            {
                lineRenderer.SetPosition(i, lineRenderer.GetPosition(i) + sign * lineOffset);
            }

            lineEndPoint.transform.position += lineOffset;
        }
        
        private void UpdateEndPointPosition()
        {
            if (lineRenderer.positionCount <= 1)
                return;
        
            lineEndPoint.transform.position = lineRenderer.GetPosition(lineRenderer.positionCount - 1);
        }
    }
}
