using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;
    public Toggle _toggle;

    // Start is called before the first frame update
    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }

    private Color GetRandomColor()
    {
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f));
    }

    private MaterialPropertyBlock _propBlock;

    void Update()
    {
        //FOCUS ON MATERIAL MEMORY

        //pattern
        //updating data on the instance

        //TEST

        //if (_toggle.toggled)
        //{
        //    _renderer.GetPropertyBlock(_propBlock);
        //    _propBlock.SetColor(name: "_Color", value: GetRandomColor());
        //    _renderer.SetPropertyBlock(_propBlock);
        //}
           _renderer.material.color = GetRandomColor(); //gets color for each and every cube
    }
}
