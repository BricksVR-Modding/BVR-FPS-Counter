using MelonLoader;
using UnityEngine;
using TMPro;

namespace FPSmod
{
    public static class BuildInfo
    {
        public const string Name = "FPS Counter"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for counting how many frames you have."; // Description for the Mod.  (Set as null if none)
        public const string Author = "ATXLtheAxolotl"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.0.1"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class FPSmod : MelonMod
    { 
        public GameObject userID;
        public GameObject clonedID;
        public GameObject menuBoard;
        public GameObject background;
        public float fps;
        int interval = 1;
        float nextTime = 0;
        public int fpsDisplay;

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            menuBoard = GameObject.Find("MenuBoard");
            userID = GameObject.Find("MenuBoard/UserID");
            background = GameObject.Find("MenuBoard/Background");
            clonedID = GameObject.Instantiate(userID);
            clonedID.transform.SetParent(menuBoard.transform, false);
            clonedID.transform.position = new Vector3(-0.08f, 92.26f, 3.0491f);
            clonedID.transform.localScale = new Vector3(2f, 2f, 2f);
            clonedID.transform.SetAsFirstSibling();
            background.transform.SetAsFirstSibling();
        }

        public override void OnUpdate()
        {
            if (Time.time >= nextTime)
            {

                GetFPS();

                nextTime += interval;

            }
        }
        public void GetFPS()
        {
            fps = (int)(1f / Time.unscaledDeltaTime);
            clonedID.GetComponent<TMP_Text>().text = "FPS: " + fps;
        }
    }
}