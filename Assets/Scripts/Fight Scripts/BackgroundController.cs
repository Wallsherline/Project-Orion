using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private RawImage backgroundPiece;
    [SerializeField]
    private float _x, _y;

    // Update is called once per frame
    void Update()
    {
        backgroundPiece.uvRect = new Rect(backgroundPiece.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backgroundPiece.uvRect.size);
    }
}
