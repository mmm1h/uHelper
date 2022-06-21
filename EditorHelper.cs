using UnityEngine;
using UnityEditor;
using System.IO;

namespace uHelper
{

    // ⣿⣿⣿⣿⣿⣿⣿⡇⡌⡰⢃⡿⡡⠟⣠⢹⡏⣦⢸⣿⣿⣿⣿⣿⣿
    // ⣿⣿⣿⣿⣿⣿⡿⢰⠋⡿⢋⣐⡈⣽⠟⢀⢻⢸⡂⣿⣿⣿⣿⣿⣿
    // ⣿⣿⣿⣿⣿⣋⠴⢋⡘⢰⣄⣀⣅⣡⠌⠛⠆⣿⡄⣿⣿⣿⣿⣿⣿
    // ⣿⣿⣿⣿⣿⣿⣶⣁⣐⠄⠹⣟⠯⢿⣷⠾⠁⠥⠃⣹⣿⣿⣿⣿⣿
    // ⣿⣿⣿⣿⠟⠋⡍⢴⣶⣶⣶⣤⣭⡐⢶⣾⣿⣶⡆⢨⠛⠻⣿⣿⣿
    // ⣿⣿⣿⢏⣘⣚⣣⣾⣿⣿⣿⣿⣿⣿⢈⣿⣿⣿⣧⣘⠶⢂⠹⣿⣿
    // ⣿⣿⠃⣾⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⡀⢿⣿⣿⣿⣿⣿⣿⡇⣿⣿
    // ⣿⣿⡄⣿⣿⣿⣿⣿⣿⡯⠄⠄⠾⠿⠿⢦⣝⠻⣿⣿⣿⣿⠇⣿⣿
    // ⣿⣿⣷⣜⠿⢿⣿⡿⠟⣴⣾⣿⡇⢰⣾⣦⡹⣷⣮⡙⢟⣩⣾⣿⣿
    // ⣿⣿⣿⣿⣿⣆⢶⣶⣦⢻⣿⣿⣷⢸⣿⣿⣷⣌⠻⡷⣺⣿⣿⣿⣿
    // ⣿⣿⣿⣿⣿⣿⡜⢿⣿⡎⢿⣿⣿⡬⣿⣿⣿⡏⢦⣔⠻⣿⣿⣿⣿
    // ⣿⣿⣿⣿⣿⣿⣿⠎⠻⣷⡈⢿⣿⡇⢛⣻⣿⣿⢸⣿⣷⠌⡛⢿⣿
    // ⣿⣿⣿⣿⣿⣿⡏⢰⣷⡙⢷⣌⢻⣿⣿⣿⣿⣿⢸⡿⢡⣾⣿⡶⠻
    // ⣿⣿⣿⣿⣿⡟⣰⣶⣭⣙⠊⣿⣷⣬⣛⠻⣿⣿⠈⣴⣿⣿⣿⠃⠄
    // ⣿⣿⣿⣿⡟⠄⠹⢿⣿⣿⣿⣤⠻⠟⠋⠡⠘⠋⢸⣿⣿⡿⠁⠄⠄
    // ⣿⣿⣿⣿⠁⠄⠄⠄⠙⢻⣿⣿⣇⠄⠄⠄⠄⠄⣺⡿⠛⠄⠄⠄⠄
    // ⣿⣿⣿⡏⠄⠄⠄⠄⠄⠄⠄⠉⠻⠷⠄⢠⣄⠄⠋⠄⠄⠄⠄⠄⠄
    // ⣿⣿⣿⣿⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠸⣿⠄⠄⠄⠄⠄⠄⠄⠄

    class EditorHelper
    {
        [MenuItem("叶芯蕊/创建文件夹")]
        public static void CreateFolder()
        {
            string path = Application.dataPath;
            Directory.CreateDirectory(path + "/BaseResources");
            Directory.CreateDirectory(path + "/BaseResources/Animation");
            Directory.CreateDirectory(path + "/BaseResources/Material");
            Directory.CreateDirectory(path + "/BaseResources/Prefab");
            Directory.CreateDirectory(path + "/BaseResources/Scenes");
            Directory.CreateDirectory(path + "/BaseResources/Shader");
            Directory.CreateDirectory(path + "/BaseResources/Texture");
            Directory.CreateDirectory(path + "/BaseResources/Mesh");

            AssetDatabase.Refresh();
        }

        [MenuItem("叶芯蕊/创建材质球X5")]
        public static void CreateMaterial()
        {

            string path = Application.dataPath + "/BaseResources/Material";
            for (int i = 0; i < 5; i++)
            {
                Material mat = new Material(Shader.Find("Standard"));
                AssetDatabase.CreateAsset(mat, string.Format("Assets/BaseResources/Material/mat_{0}.mat", System.Guid.NewGuid()));
            }
            Debug.Log("创建材质球X5");
            AssetDatabase.Refresh();
        }

    }
}
