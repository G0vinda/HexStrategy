using System;
using GameEvent;
using UnityEngine;
using Random = UnityEngine.Random;
using HexSystem;

public class MapCreator : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private Hexagon grassTilePrefab;
    [SerializeField] private Hexagon mountainTilePrefab;
    [SerializeField] private Unit testUnit;
    
    public HexagonGrid Grid;

    [Header("Settings")]
    [SerializeField] private float spacing;
    [Range(0f, 1f)]
    [SerializeField] private float mountainChance;

    public const float tileWidth = 1;
    
    private float _horizontalSpacing;
    private float _verticalSpacing;

    private Vector3 _qOffset;
    private Vector3 _rOffset;
    
    private void Awake()
    {
        _horizontalSpacing = tileWidth + spacing;

        var tileHeight = 2 * tileWidth / Mathf.Sqrt(3) + spacing;
        _verticalSpacing = 0.75f * tileHeight + spacing;

        _qOffset = new Vector3(_horizontalSpacing, 0, 0);
        _rOffset = new Vector3(0.5f * _horizontalSpacing, 0, _verticalSpacing);

        Grid = new HexagonGrid();
    }

    private void OnEnable()
    {
        GameEvents.Unit.OnUnitNextHexReached += OnUnitNexHexReached;
    }
    
    private void OnDisable()
    {
        GameEvents.Unit.OnUnitNextHexReached -= OnUnitNexHexReached;
    }

    private void Start()
    {
        CreateRingMap(3);
        Grid.AddUnitToHexagon(new AxialCoordinate(0, 0), testUnit);
    }

    private void CreateRingMap(int rings)
    {
        var rotation180 = Quaternion.Euler(0, 180, 0);
        
        for (var ring = 0; ring <= rings; ring++)
        {
            for (var q = -ring; q <= ring; q++)
            {
                for (var r = -ring; r <= ring; r++)
                {
                    var s = -q - r;
                    
                    if (Math.Abs(q) > ring || Math.Abs(r) > ring || Math.Abs(s) > ring) continue;
                    if (Math.Abs(q) != ring && Math.Abs(r) != ring && Math.Abs(s) != ring) continue;

                    var coord = new AxialCoordinate(q, r);
                    var hexPosition = _qOffset * q + _rOffset * r;
                    
                    var randomTilePrefab = Random.Range(0f, 1f) <= mountainChance ? mountainTilePrefab : grassTilePrefab;
                    var randomTileRotation = Random.Range(0, 2) == 0 ? rotation180 : Quaternion.identity;
                    
                    var newHex = Instantiate(randomTilePrefab, hexPosition, randomTileRotation, transform);
                    newHex.Initialize(coord);
                    Grid.Add(newHex);
                }
            }
        }
    }

    private void OnUnitNexHexReached(Unit unit, AxialCoordinate coordinate)
    {
        Grid.UpdateUnitHexagon(unit, coordinate);
        Debug.Log(coordinate);
    }
}
