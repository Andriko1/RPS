using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureSelector : MonoBehaviour
{
    private int _currentFurniIndex;
    [SerializeField] public GameObject[] FurniturePrefabs;
    private Image _currentFurniPreview;

    private void Awake()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextFurni()
    {
        if (_currentFurniIndex < FurniturePrefabs.Length - 1)
        {
            _currentFurniIndex++;
        }
        else
        {
            _currentFurniIndex = 0;
        }
    }

    public void PreviousFurni()
    {
        if (_currentFurniIndex > 0)
        {
            _currentFurniIndex--;
        }
        else
        {
            _currentFurniIndex = FurniturePrefabs.Length - 1;
        }
    }
}
