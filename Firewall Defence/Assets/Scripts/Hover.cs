﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : Singleton <Hover>
{
    private SpriteRenderer spriteRenderer;

    private SpriteRenderer range;
    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.range = transform.GetChild(0).GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowMouse();
    }

    private void FollowMouse()
    {
        if(spriteRenderer.enabled)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        
    }

    public void Activate(Sprite sprite)
    {
        this.spriteRenderer.sprite = sprite;
        spriteRenderer.enabled = true;
        range.enabled = true;
    }

    public void Deactivate()
    {
        spriteRenderer.enabled = false;
        GameManagment.Instance.ClickButton = null;
        range.enabled = false;
    }
}
