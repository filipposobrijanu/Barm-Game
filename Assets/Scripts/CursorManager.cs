using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    [SerializeField] private Texture2D cursor;
    [SerializeField] private  Texture2D cursor1;

    private Vector2 cursorhotspot;

    public void CursorTex()
    {

        cursorhotspot = new Vector2(cursor.width/2, cursor.height/2);
        Cursor.SetCursor(cursor, cursorhotspot, CursorMode.Auto);


    }

    public void CursorTex1()
    {


        cursorhotspot = new Vector2(cursor.width / 2, cursor.height / 2);
        Cursor.SetCursor(cursor1, cursorhotspot, CursorMode.Auto);


    }

}
