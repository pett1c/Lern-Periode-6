using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int _band;
    public float _startScale, _scaleMultiplier;
    public bool _useBuffer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float previousScaleY = transform.localScale.y;
        if (_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._bandBuffer64[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
        }
        if (!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._freqBand64[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
        }
        transform.position += Vector3.up * (transform.localScale.y - previousScaleY) * 0.5f;
    }
}
