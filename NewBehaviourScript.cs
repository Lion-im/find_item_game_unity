using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


// Игра найди вещь
// Камера закреплена и смотрит только в одну сторону не меняя позицию, сверху слева написаны
// предметы которые нужно найти, когда ты все нашёл то появляется фраза что ты выиграл.
//
public class Collect : MonoBehaviour{
    public TextMeshProUGUI text_obj;
    public TextMeshProUGUI text_win;
    public GameObject cube;

    static int count = 4;
    void OnMouseDown()
    {
        count = count - 1;
        print(count);
        if(count<=0){
            text_win.text = "Ты выиграл!";
        }
        Destroy(gameObject);
        text_obj.fontStyle = FontStyles.Strikethrough;
    }

}