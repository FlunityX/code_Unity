using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_manager : MonoBehaviour
{
    [SerializeField] Texture2D cursorTexture;
    public Vector2 hotpot;
    // Start is called before the first frame update
    void Start()
    {
        hotpot = new Vector2(cursorTexture.width/3, cursorTexture.height/3);
        Cursor.SetCursor(cursorTexture, hotpot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
