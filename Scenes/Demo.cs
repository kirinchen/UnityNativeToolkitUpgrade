using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Demo : MonoBehaviour {
    public Text pathText;
    public Image image;

    void Start() {
        NativeToolkit.OnImagePicked += ImagePicked;
    }

    public void OnPickImagePress() {
        NativeToolkit.PickImage();
        pathText.text = "testing";
    }

    void ImagePicked(Texture2D myImg, string path) {
        pathText.text = path;
        Sprite s = Sprite.Create(myImg, new Rect(0, 0, myImg.width, myImg.height), Vector2.zero);
        image.sprite = s;
    }
}
