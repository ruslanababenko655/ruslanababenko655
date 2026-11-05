using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xbc1b0717 : MonoBehaviour
{
    private Touch? _0x4bc86ead()
    {
        if (!_0x42666298.Instance._0x980e6851)
            return null;
        foreach (Touch _0x14801ba0 in Touch.activeTouches)
            if (_0x14801ba0.ended)
                if (this._0x9649715a(_0x14801ba0))
                    return _0x14801ba0;
        return null;
    }

    private static _0xbc1b0717 _0x1457c809;
    private Touch? _0xad194d3b()
    {
        if (!_0x42666298.Instance._0x980e6851)
            return null;
        foreach (Touch _0x2a1b3c72 in Touch.activeTouches)
            if (!_0x2a1b3c72.ended)
                if (this._0x9649715a(_0x2a1b3c72))
                    return _0x2a1b3c72;
        return null;
    }

    private Touch? _0x7ca42017(Bounds _0xc5ca06a9, TouchPhase _0xd90f43b6)
    {
        if (!_0x42666298.Instance._0x980e6851)
            return null;
        foreach (Touch _0xdc290e41 in Touch.activeTouches)
            if (_0xdc290e41.phase == _0xd90f43b6)
            {
                Vector3 _0xabd0cc9e = Camera.main.ScreenToWorldPoint(_0xdc290e41.screenPosition);
                Vector3 _0x4f6bb984 = new(_0xabd0cc9e.x, _0xabd0cc9e.y, _0xc5ca06a9.center.z);
                if (_0xc5ca06a9.Contains(_0x4f6bb984) && this._0x9649715a(_0xdc290e41))
                    return _0xdc290e41;
            }

        return null;
    }

    private Touch? _0x39b1455d(Bounds _0xbe0f8108)
    {
        if (!_0x42666298.Instance._0x980e6851)
            return null;
        foreach (Touch _0xa5ad246b in Touch.activeTouches)
            if (_0xa5ad246b.ended)
            {
                Vector3 _0x9e4f6a5f = Camera.main.ScreenToWorldPoint(_0xa5ad246b.screenPosition);
                Vector3 _0xd801bc6d = new(_0x9e4f6a5f.x, _0x9e4f6a5f.y, _0xbe0f8108.center.z);
                if (_0xbe0f8108.Contains(_0xd801bc6d) && this._0x9649715a(_0xa5ad246b))
                    return _0xa5ad246b;
            }

        return null;
    }

    private bool _0x82f9af04(Touch? _0x50fb5fea, Bounds _0x3c052fba, TouchPhase _0xac1e653e)
    {
        if (!_0x42666298.Instance._0x980e6851)
        {
            _0x50fb5fea = null;
            return false;
        }

        if (_0x50fb5fea != null)
            if (_0x50fb5fea.Value.phase == _0xac1e653e)
            {
                Vector3 _0x4b22a2bc = Camera.main.ScreenToWorldPoint(_0x50fb5fea.Value.screenPosition);
                Vector3 _0x41d434c4 = new(_0x4b22a2bc.x, _0x4b22a2bc.y, _0x3c052fba.center.z);
                if (_0x3c052fba.Contains(_0x41d434c4) && this._0x9649715a(_0x50fb5fea.Value))
                    return true;
            }

        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x1457c809 = this.gameObject.GetComponent<_0xbc1b0717>();
    }

    public BoxCollider2D CameraTouchBounds;
    private void _0x267c2373(Touch? _0x0f878e7a)
    {
        if (!_0x42666298.Instance._0x980e6851)
        {
            _0x0f878e7a = null;
            return;
        }

        int _0x6b1365ab = _0x0f878e7a.Value.touchId;
        _0x0f878e7a = Touch.activeTouches.FirstOrDefault(_0xbeaaa010 => _0xbeaaa010.touchId == _0x6b1365ab);
        if (!this._0x9649715a(_0x0f878e7a.Value))
            _0x0f878e7a = null;
    }

    private bool _0x9649715a(Touch? _0xd9b54ed1)
    {
        if (!_0xd9b54ed1.HasValue)
            return false;
        Vector3 _0x3e72e376 = Camera.main.ScreenToWorldPoint(_0xd9b54ed1.Value.screenPosition);
        Vector3 _0x66bf262a = _0x3e72e376;
        _0x66bf262a.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x66bf262a))
            return true;
        _0xd9b54ed1 = null;
        return false;
    }

    private Touch? _0x0ad863fc(Bounds _0x97a093c9)
    {
        if (!_0x42666298.Instance._0x980e6851)
            return null;
        foreach (Touch _0xc911af1b in Touch.activeTouches)
            if (!_0xc911af1b.ended)
            {
                Vector3 _0x2abab868 = Camera.main.ScreenToWorldPoint(_0xc911af1b.screenPosition);
                Vector3 _0x9671f8ff = new(_0x2abab868.x, _0x2abab868.y, _0x97a093c9.center.z);
                if (_0x97a093c9.Contains(_0x9671f8ff) && this._0x9649715a(_0xc911af1b))
                    return _0xc911af1b;
            }

        return null;
    }
}