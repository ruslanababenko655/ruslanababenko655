using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x85a24e0c : MonoBehaviour
{
    private Vector3 _0xef7e507e { get; set; }

    private Color _0xa5dd9f6a = Color.white;
    private Vector3 _0x56652d55 { get; set; }
    private float _0xd1ea64b7 { get; set; }

    private static _0x85a24e0c _0x03c7d080;
    //public bool executeInUpdate;
    private float _0xa43cacc9 { get; set; }

    private float _0x70eeb6fa = 1;
    private Vector3 _0xdce35f5b { get; set; }

    public enum _0x0ad443ea
    {
        Landscape,
        Portrait
    }

    private _0x0ad443ea _0x5afca990 = _0x0ad443ea.Portrait;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xa5dd9f6a;
        Matrix4x4 _0x53f24bab = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xb143bc69.orthographic)
        {
            float _0xe449ff91 = this._0xb143bc69.farClipPlane - this._0xb143bc69.nearClipPlane;
            float _0xaa56348a = (this._0xb143bc69.farClipPlane + this._0xb143bc69.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xaa56348a), new Vector3(this._0xb143bc69.orthographicSize * 2 * this._0xb143bc69.aspect, this._0xb143bc69.orthographicSize * 2, _0xe449ff91));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xb143bc69.fieldOfView, this._0xb143bc69.farClipPlane, this._0xb143bc69.nearClipPlane, this._0xb143bc69.aspect);
        }

        Gizmos.matrix = _0x53f24bab;
    }

    private void _0x096df032()
    {
        float _0xf0dc1056, _0x59fa316b, _0xa643810b, _0x5fc5d557;
        if (this._0x5afca990 == _0x0ad443ea.Landscape)
            this._0xb143bc69.orthographicSize = 1f / this._0xb143bc69.aspect * this._0x70eeb6fa / 2f;
        else
            this._0xb143bc69.orthographicSize = this._0x70eeb6fa / 2f;
        this._0xd1ea64b7 = 2f * this._0xb143bc69.orthographicSize;
        this._0xa43cacc9 = this._0xd1ea64b7 * this._0xb143bc69.aspect;
        float _0xab39a693 = this._0xb143bc69.transform.position.x;
        float _0xf8b3d718 = this._0xb143bc69.transform.position.y;
        _0xf0dc1056 = _0xab39a693 - this._0xa43cacc9 / 2;
        _0x59fa316b = _0xab39a693 + this._0xa43cacc9 / 2;
        _0xa643810b = _0xf8b3d718 + this._0xd1ea64b7 / 2;
        _0x5fc5d557 = _0xf8b3d718 - this._0xd1ea64b7 / 2;
        this._0xa5f9d8d3 = new Vector3(_0xf0dc1056, _0x5fc5d557, 0);
        this._0x56652d55 = new Vector3(_0xab39a693, _0x5fc5d557, 0);
        this._0xef7e507e = new Vector3(_0x59fa316b, _0x5fc5d557, 0);
        this._0xa606c296 = new Vector3(_0xf0dc1056, _0xf8b3d718, 0);
        this._0xdce35f5b = new Vector3(_0xab39a693, _0xf8b3d718, 0);
        this._0x0a1ef10a = new Vector3(_0x59fa316b, _0xf8b3d718, 0);
        this._0x527167c3 = new Vector3(_0xf0dc1056, _0xa643810b, 0);
        this._0x8b92210c = new Vector3(_0xab39a693, _0xa643810b, 0);
        this._0x6900ab97 = new Vector3(_0x59fa316b, _0xa643810b, 0);
    }

    private Vector3 _0x0a1ef10a { get; set; }
    private Vector3 _0x527167c3 { get; set; }

    private new Camera _0xb143bc69;
    private Vector3 _0x6900ab97 { get; set; }
    private Vector3 _0x8b92210c { get; set; }
    private Vector3 _0xa5f9d8d3 { get; set; }
    private Vector3 _0xa606c296 { get; set; }

    private void Awake()
    {
        this._0xb143bc69 = this.GetComponent<Camera>();
        _0x03c7d080 = this;
        this._0x096df032();
    }
}