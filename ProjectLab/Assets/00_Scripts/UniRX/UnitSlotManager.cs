using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.InputSystem;

public class UnitSlotManager : MonoBehaviour
{
    private List<Unit> _units = new();

    private readonly ReactiveProperty<int> _changedUnitCount = new();
    public IReadOnlyReactiveProperty<int> ChangedUnitCount => _changedUnitCount;


    private void Awake()
    {
        SetUpAction();
    }


    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            SpawnUnit(new());
        }
    }

    public void SpawnUnit(Unit unit)
    {
        _units.Add(unit);
        _changedUnitCount.Value = _units.Count;
    }

    private void SetUpAction()
    {
        _changedUnitCount.Subscribe(OnChangedUnitCount).AddTo(this);
    }
    
    private void OnChangedUnitCount(int count)
    {
        Debug.Log($"Changed UnitCount => {count}");
    }
    
    
}
