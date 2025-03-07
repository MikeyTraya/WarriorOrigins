using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarriorOrigins
{
    public class MouseCursor : MonoBehaviour
    {
        public enum State
        {
            MainMenu,
            Game,
        }

        public State state;

        [SerializeField] private Texture2D gameCursorTexture;
        [SerializeField] private Texture2D mainMenuCursorTexture0;
        [SerializeField] private Texture2D mainMenuCursorTexture1;

        private Vector2 cursorHotspot;

        void Update()
        {
            switch (state)
            {
                case State.MainMenu:
                    cursorHotspot = new Vector2(gameCursorTexture.width / 100, gameCursorTexture.height / 100);
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (mainMenuCursorTexture0 != mainMenuCursorTexture1)
                        {
                            Cursor.SetCursor(mainMenuCursorTexture1, cursorHotspot, CursorMode.Auto);
                        }
                        else
                        {
                            Cursor.SetCursor(mainMenuCursorTexture0, cursorHotspot, CursorMode.Auto);
                        }
                    }else if (Input.GetMouseButtonUp(0))
                    {
                        Cursor.SetCursor(mainMenuCursorTexture0, cursorHotspot, CursorMode.Auto);
                    }
                    break;
                case State.Game:
                    cursorHotspot = new Vector2(gameCursorTexture.width / 2, gameCursorTexture.height / 2);
                    Cursor.SetCursor(gameCursorTexture, cursorHotspot, CursorMode.Auto);
                    break;
                default:
                    break;
            }
        }
    }
}
