﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverOver : MonoBehaviour
{
    public Sprite hoveredImage; 
    public Sprite RegImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnPointerEnter()
    {
        GetComponent<Image>().sprite = hoveredImage;

    }
    private void OnPointerExit()
    {
        GetComponent<Image>().sprite = RegImage;
    }
}
