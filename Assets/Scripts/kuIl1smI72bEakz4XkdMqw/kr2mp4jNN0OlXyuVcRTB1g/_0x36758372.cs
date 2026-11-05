using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x36758372 : MonoBehaviour
{
    private string GetFailingUrl(UniWebViewNativeResultPayload _0xe1d969c5)
    {
        if (_0xe1d969c5 == null || _0xe1d969c5.Extra == null)
            return null;
        object _0xb317b137;
        if (!_0xe1d969c5.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xb317b137))
            return null;
        return _0xb317b137 as string;
    }

    private async Task<bool> _0xd58d13ef()
    {
        _0xc88f8b5d.Instance?._0xf0da892f();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xcab976ad) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[32] { 212, 219, 234, 252, 251, 210, 175, 218, 225, 230, 251, 246, 175, 223, 250, 252, 231, 175, 193, 224, 251, 230, 233, 230, 236, 238, 251, 230, 224, 225, 181, 175 }, 143) + string.Join(_0x9672995a._0x471e3941(new byte[1] { 63 }, 54), _0xcab976ad));
                }
#endif
            }
        };
        try
        {
            _0xd65bed32 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[31] { 171, 164, 149, 131, 132, 173, 208, 182, 145, 153, 156, 149, 148, 208, 132, 159, 208, 151, 149, 132, 208, 128, 133, 131, 152, 208, 132, 159, 155, 149, 158 }, 240));
                }
#endif
            }

            _0xd65bed32 = "";
        }

        _0xd767bc30 = !string.IsNullOrEmpty(_0xd65bed32);
        _0x34ef84e6 = _0x264c0caf();
        {
#if B_LOGS
            Debug.Log(_0x9672995a._0x471e3941(new byte[25] { 147, 156, 173, 187, 188, 149, 232, 157, 166, 161, 188, 177, 232, 152, 189, 187, 160, 232, 156, 167, 163, 173, 166, 242, 232 }, 200) + _0xd65bed32);
#endif
        }

        _0xc88f8b5d.Instance?._0xbd956398();
        return false;
    }

    private static bool IsPrivacyItemTrue(Item _0x7d7a2f03)
    {
        if (_0x7d7a2f03.Key != _0x9672995a._0x471e3941(new byte[9] { 66, 88, 123, 89, 66, 93, 74, 72, 82 }, 43))
            return false;
        try
        {
            var _0xb1bcd292 = _0x7d7a2f03.Value.GetAs<object>();
            return _0xb1bcd292 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private bool _0xf4991660 = false;
    private string _0x260b2efd = "";
    private IEnumerator _0x7514e023()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[26] { 130, 141, 188, 170, 173, 132, 249, 144, 183, 176, 173, 176, 184, 181, 176, 163, 188, 139, 188, 191, 191, 188, 171, 188, 171, 249 }, 217));
            }
#endif
        }

        bool _0xe11febe3 = false;
        InstallReferrer.GetReferrer((_0x2bb12ac5) =>
        {
            Debug.Log(_0x9672995a._0x471e3941(new byte[24] { 248, 247, 198, 208, 215, 131, 241, 198, 197, 198, 209, 209, 198, 209, 254, 131, 196, 198, 215, 131, 65, 37, 49, 131 }, 163) + _0xa922af92);
            if (_0x2bb12ac5.IsSuccess)
            {
                _0xa922af92 = _0x2bb12ac5.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x9672995a._0x471e3941(new byte[28] { 136, 135, 182, 160, 167, 243, 129, 182, 181, 182, 161, 161, 182, 161, 142, 243, 128, 166, 176, 176, 182, 160, 160, 243, 49, 85, 65, 243 }, 211) + _0xa922af92);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x9672995a._0x471e3941(new byte[27] { 17, 30, 47, 57, 62, 106, 24, 47, 44, 47, 56, 56, 47, 56, 23, 106, 12, 43, 35, 38, 47, 46, 106, 168, 204, 216, 106 }, 74) + _0x2bb12ac5);
#endif
                }

                _0xa922af92 = "";
            }

            _0x11e3816e = true;
        });
        StartCoroutine(_0x33176f98(2f));
        yield return new WaitUntil(() => _0x11e3816e);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xa922af92}");
#endif
        }

        bool _0x12e914bc = _0xa922af92.Contains(_0x9672995a._0x471e3941(new byte[6] { 175, 171, 164, 161, 172, 245 }, 200));
        _0xe11febe3 = _0x12e914bc || _0xa922af92.Contains(_0x9672995a._0x471e3941(new byte[18] { 102, 119, 119, 116, 41, 110, 105, 116, 115, 102, 96, 117, 102, 106, 41, 100, 104, 106 }, 7)) || _0xa922af92.Contains(_0x9672995a._0x471e3941(new byte[17] { 73, 88, 88, 91, 6, 78, 73, 75, 77, 74, 71, 71, 67, 6, 75, 71, 69 }, 40));
        _0x5b66c140 = _0x12e914bc ? "" : (_0xe11febe3 ? "" : _0x5b66c140);
        _0x5b66c140 = _0x5b66c140 ?? "";
        _0x68479920 = _0x68479920 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x5b66c140}");
#endif
        }
    }

    private GameObject _0x7c0451a3;
    public void _0x0fa44290()
    {
        if (_0xfcfdbefa)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[33] { 246, 249, 200, 222, 217, 240, 141, 249, 196, 192, 200, 223, 141, 194, 216, 217, 141, 128, 147, 141, 192, 194, 219, 200, 141, 217, 194, 141, 222, 206, 200, 195, 200 }, 173));
            }
#endif
        }

        _0xd8acbec7();
    }

    private void _0xf2926e1c()
    {
        _0x3c063aec = true;
        if (_0xdd10d12f != null)
            _0xdd10d12f.SetUserAgent(_0xba4ab1ff());
    }

    private int _0xbaf60fb0 = 0;
    private void _0x3d4dfdca()
    {
        if (_0x7c0451a3 != null)
            return;
        var _0x8d9a412e = _0x49041f17();
        _0x7c0451a3 = new GameObject(_0x9672995a._0x471e3941(new byte[14] { 162, 144, 151, 163, 156, 144, 130, 166, 133, 156, 155, 155, 144, 135 }, 245), typeof(RectTransform), typeof(Text));
        _0x994791b8 = _0x7c0451a3.GetComponent<RectTransform>();
        _0x994791b8.SetParent(_0x8d9a412e.transform, false);
        _0x994791b8.anchorMin = new Vector2(0.5f, 0.5f);
        _0x994791b8.anchorMax = new Vector2(0.5f, 0.5f);
        _0x994791b8.pivot = new Vector2(0.5f, 0.5f);
        _0x994791b8.sizeDelta = new Vector2(600f, 600f);
        _0x994791b8.anchoredPosition = Vector2.zero;
        _0x13a9d74a = _0x7c0451a3.GetComponent<Text>();
        _0x13a9d74a.text = _0x9672995a._0x471e3941(new byte[1] { 38 }, 9);
        _0x13a9d74a.font = Resources.GetBuiltinResource<Font>(_0x9672995a._0x471e3941(new byte[17] { 211, 250, 248, 254, 252, 230, 205, 234, 241, 235, 246, 242, 250, 177, 235, 235, 249 }, 159));
        _0x13a9d74a.fontSize = 200;
        _0x13a9d74a.alignment = TextAnchor.MiddleCenter;
        _0x13a9d74a.color = Color.white;
        _0x13a9d74a.raycastTarget = false;
        _0x7c0451a3.SetActive(false);
    }

    private Action _0x536f1f4c;
    private void _0xce5eabb9()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0x102eaa20 = "";
    private Canvas _0xc06079bb;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0xdd10d12f = null;
    private readonly string[] _0x33203e64 = new string[]
    {
        _0x9672995a._0x471e3941(new byte[60] { 199, 168, 185, 135, 23, 99, 95, 82, 23, 69, 82, 82, 91, 68, 23, 86, 69, 82, 23, 95, 88, 67, 23, 69, 94, 80, 95, 67, 23, 89, 88, 64, 23, 213, 183, 164, 23, 83, 88, 89, 213, 183, 174, 67, 23, 90, 94, 68, 68, 23, 78, 88, 66, 69, 23, 68, 71, 94, 89, 22 }, 55),
        _0x9672995a._0x471e3941(new byte[52] { 21, 122, 104, 101, 197, 172, 145, 197, 134, 138, 144, 137, 129, 197, 135, 128, 197, 156, 138, 144, 151, 197, 137, 144, 134, 142, 156, 197, 136, 138, 136, 128, 139, 145, 197, 7, 101, 118, 197, 146, 141, 156, 197, 150, 145, 138, 149, 197, 139, 138, 146, 218 }, 229),
        _0x9672995a._0x471e3941(new byte[66] { 149, 237, 214, 152, 207, 248, 87, 53, 30, 16, 87, 0, 30, 25, 4, 87, 22, 5, 18, 87, 31, 30, 3, 3, 30, 25, 16, 87, 26, 24, 5, 18, 87, 24, 17, 3, 18, 25, 87, 3, 24, 19, 22, 14, 87, 149, 247, 228, 87, 4, 3, 22, 14, 87, 30, 25, 87, 3, 31, 18, 87, 16, 22, 26, 18, 89 }, 119),
        _0x9672995a._0x471e3941(new byte[54] { 138, 229, 239, 232, 90, 46, 18, 19, 9, 90, 19, 9, 90, 10, 8, 19, 23, 31, 90, 14, 19, 23, 31, 90, 152, 250, 233, 90, 14, 18, 31, 90, 24, 31, 9, 14, 90, 10, 22, 27, 3, 31, 8, 9, 90, 10, 22, 27, 3, 90, 20, 21, 13, 84 }, 122),
        _0x9672995a._0x471e3941(new byte[48] { 151, 248, 243, 194, 71, 62, 8, 18, 21, 71, 16, 14, 9, 9, 14, 9, 0, 71, 20, 19, 21, 2, 6, 12, 71, 4, 8, 18, 11, 3, 71, 5, 2, 71, 8, 9, 2, 71, 20, 23, 14, 9, 71, 6, 16, 6, 30, 73 }, 103),
        _0x9672995a._0x471e3941(new byte[65] { 86, 57, 60, 38, 134, 236, 199, 197, 205, 214, 201, 210, 213, 134, 199, 212, 195, 134, 203, 201, 212, 195, 134, 199, 197, 210, 207, 208, 195, 134, 210, 201, 200, 207, 193, 206, 210, 134, 68, 38, 53, 134, 213, 210, 199, 223, 134, 199, 200, 194, 134, 210, 212, 223, 134, 223, 201, 211, 212, 134, 202, 211, 197, 205, 136 }, 166),
        _0x9672995a._0x471e3941(new byte[55] { 103, 8, 25, 37, 183, 210, 225, 242, 229, 238, 183, 228, 231, 254, 249, 183, 244, 248, 226, 249, 227, 228, 183, 117, 23, 4, 183, 227, 255, 242, 183, 249, 242, 239, 227, 183, 248, 249, 242, 183, 244, 248, 226, 251, 243, 183, 245, 242, 183, 238, 248, 226, 229, 228, 185 }, 151),
        _0x9672995a._0x471e3941(new byte[63] { 187, 244, 201, 182, 225, 214, 121, 9, 53, 56, 32, 60, 43, 42, 121, 43, 48, 62, 49, 45, 121, 55, 54, 46, 121, 56, 43, 60, 121, 46, 48, 55, 55, 48, 55, 62, 121, 187, 217, 202, 121, 61, 54, 55, 187, 217, 192, 45, 121, 46, 56, 53, 50, 121, 56, 46, 56, 32, 121, 32, 60, 45, 119 }, 89),
        _0x9672995a._0x471e3941(new byte[51] { 146, 253, 237, 228, 66, 45, 12, 14, 27, 66, 22, 10, 13, 17, 7, 66, 21, 10, 13, 66, 17, 22, 3, 27, 66, 11, 12, 66, 22, 10, 7, 66, 5, 3, 15, 7, 66, 21, 11, 12, 66, 22, 10, 7, 66, 18, 16, 11, 24, 7, 76 }, 98),
        _0x9672995a._0x471e3941(new byte[64] { 111, 23, 44, 98, 53, 2, 173, 192, 226, 224, 232, 227, 249, 248, 224, 173, 228, 254, 173, 232, 251, 232, 255, 244, 249, 229, 228, 227, 234, 173, 111, 13, 30, 173, 230, 232, 232, 253, 173, 254, 253, 228, 227, 227, 228, 227, 234, 173, 235, 226, 255, 173, 244, 226, 248, 255, 173, 238, 229, 236, 227, 238, 232, 163 }, 141)
    };
    private bool _0x12ad892a()
    {
        var _0x39afadb6 = _0x5babc507();
        if (_0x39afadb6 == null)
            return false;
        WLog(_0x9672995a._0x471e3941(new byte[31] { 227, 202, 217, 207, 220, 202, 217, 206, 139, 201, 202, 200, 192, 139, 134, 149, 139, 219, 196, 219, 222, 219, 139, 236, 196, 233, 202, 200, 192, 145, 139 }, 171) + _0x39afadb6.Id);
        _0x39afadb6.GoBack();
        return true;
    }

    private string _0x68479920 { get; set; }

    private void _0x8fc08c86()
    {
        WLog(_0x9672995a._0x471e3941(new byte[21] { 156, 181, 166, 176, 163, 181, 166, 177, 244, 182, 181, 183, 191, 244, 164, 166, 177, 167, 167, 177, 176 }, 212));
        if (Time.frameCount == _0xf6340792)
            return;
        _0xf6340792 = Time.frameCount;
        if (_0x4ef0576a())
            return;
        _0x9717f8b2();
    }

    private string Decrypt(string _0xa3c4b2f3, string _0x7d2809d6)
    {
        try
        {
            var _0x1cc7c0c5 = Convert.FromBase64String(_0xa3c4b2f3);
            using var _0x00c8dd0d = Aes.Create();
            _0x00c8dd0d.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x7d2809d6));
            var _0x34660bc4 = new byte[16];
            Buffer.BlockCopy(_0x1cc7c0c5, 0, _0x34660bc4, 0, 16);
            _0x00c8dd0d.IV = _0x34660bc4;
            using var _0xdb6a34b2 = new MemoryStream(_0x1cc7c0c5, 16, _0x1cc7c0c5.Length - 16);
            using var _0xb7c439e4 = new CryptoStream(_0xdb6a34b2, _0x00c8dd0d.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x10e5f1f3 = new StreamReader(_0xb7c439e4, Encoding.UTF8);
            return _0x10e5f1f3.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0xd2b2fd41 = "";
    internal bool isApplicationPause = false;
    private bool _0x9803626e()
    {
        var _0x2cb94389 = Keyboard.current;
        return _0x2cb94389 != null && _0x2cb94389.escapeKey.wasPressedThisFrame;
    }

    private string _0x8ef5e1ff()
    {
        string _0x912b3bc5 = _0x9672995a._0x471e3941(new byte[62] { 214, 213, 212, 211, 210, 209, 208, 223, 222, 221, 220, 219, 218, 217, 216, 199, 198, 197, 196, 195, 194, 193, 192, 207, 206, 205, 246, 245, 244, 243, 242, 241, 240, 255, 254, 253, 252, 251, 250, 249, 248, 231, 230, 229, 228, 227, 226, 225, 224, 239, 238, 237, 135, 134, 133, 132, 131, 130, 129, 128, 143, 142 }, 183);
        System.Random _0xd360c654 = new System.Random();
        int _0x1cd981d7 = _0xd360c654.Next(8, 16);
        return new string (Enumerable.Repeat(_0x912b3bc5, _0x1cd981d7).Select(_0x6ec0f0f4 => _0x6ec0f0f4[_0xd360c654.Next(_0x6ec0f0f4.Length)]).ToArray());
    }

    private bool _0xb7aee9cd = false;
    private bool _0x71bea450(string _0x02d2df5f)
    {
        if (string.IsNullOrEmpty(_0x02d2df5f))
            return false;
        try
        {
            using (var _0x70d5c44a = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[30] { 189, 177, 179, 240, 171, 176, 183, 170, 167, 237, 186, 240, 174, 178, 191, 167, 187, 172, 240, 139, 176, 183, 170, 167, 142, 178, 191, 167, 187, 172 }, 222)))
            using (var _0x0143e706 = _0x70d5c44a.GetStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 130, 148, 147, 147, 132, 143, 149, 160, 130, 149, 136, 151, 136, 149, 152 }, 225)))
            using (var _0xf08d6422 = _0x0143e706.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[17] { 95, 93, 76, 104, 89, 91, 83, 89, 95, 93, 117, 89, 86, 89, 95, 93, 74 }, 56)))
            using (var _0x84f37ae8 = _0xf08d6422.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[25] { 237, 239, 254, 198, 235, 255, 228, 233, 226, 195, 228, 254, 239, 228, 254, 204, 229, 248, 218, 235, 233, 225, 235, 237, 239 }, 138), _0x02d2df5f))
            {
                if (_0x84f37ae8 == null)
                    return false;
                WLog(_0x9672995a._0x471e3941(new byte[37] { 108, 71, 93, 64, 66, 74, 99, 70, 68, 74, 15, 67, 78, 90, 65, 76, 71, 15, 70, 65, 92, 91, 78, 67, 67, 74, 75, 15, 95, 78, 76, 68, 78, 72, 74, 21, 15 }, 47) + _0x02d2df5f);
                _0x84f37ae8.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[8] { 141, 136, 136, 170, 128, 141, 139, 159 }, 236), 0x10000000);
                _0x0143e706.Call(_0x9672995a._0x471e3941(new byte[13] { 42, 45, 56, 43, 45, 24, 58, 45, 48, 47, 48, 45, 32 }, 89), _0x84f37ae8);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private IEnumerator _0x33176f98(float _0xafa4772b)
    {
        yield return new WaitForSeconds(_0xafa4772b);
        if (!_0x11e3816e)
        {
            _0x11e3816e = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xa922af92}");
                }
#endif
            }
        }
    }

    private bool OpenUrlExternally(string _0x34e0ce04)
    {
        return _0x22da5c8c(_0x34e0ce04);
    }

    private Text _0x13a9d74a;
    private string _0x83e15f17 = "";
    private bool TryOpenExternalLikeChrome(string _0x975bf3fb)
    {
        if (string.IsNullOrEmpty(_0x975bf3fb))
            return false;
        if (_0x975bf3fb.StartsWith(_0x9672995a._0x471e3941(new byte[9] { 128, 135, 157, 140, 135, 157, 211, 198, 198 }, 233), StringComparison.OrdinalIgnoreCase))
            return _0x782332c3(_0x975bf3fb);
        if (_0x639e672d(_0x975bf3fb))
            return _0xe591fcf6(_0x975bf3fb, null);
        if (!_0x975bf3fb.StartsWith(_0x9672995a._0x471e3941(new byte[7] { 30, 2, 2, 6, 76, 89, 89 }, 118), StringComparison.OrdinalIgnoreCase) && !_0x975bf3fb.StartsWith(_0x9672995a._0x471e3941(new byte[8] { 234, 246, 246, 242, 241, 184, 173, 173 }, 130), StringComparison.OrdinalIgnoreCase) && !_0x975bf3fb.StartsWith(_0x9672995a._0x471e3941(new byte[11] { 124, 127, 114, 104, 105, 39, 127, 113, 124, 115, 118 }, 29), StringComparison.OrdinalIgnoreCase))
        {
            return _0x22da5c8c(_0x975bf3fb);
        }

        return false;
    }

    private IEnumerator _0xa434a978(IEnumerator _0xa11ef1d8, TaskCompletionSource<bool> _0x9c6ef0c1)
    {
        yield return _0xa11ef1d8;
        _0x9c6ef0c1.SetResult(true);
    }

    private async Task<bool> _0x96cc173d()
    {
        {
#if B_LOGS
            Debug.Log(_0x9672995a._0x471e3941(new byte[37] { 70, 73, 120, 110, 105, 64, 61, 78, 116, 122, 115, 84, 115, 72, 115, 116, 105, 100, 78, 120, 111, 107, 116, 126, 120, 110, 92, 115, 114, 115, 100, 112, 114, 104, 110, 113, 100 }, 29));
#endif
        }

        try
        {
            var _0x6cda54e3 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x6cda54e3);
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[32] { 82, 93, 108, 122, 125, 84, 41, 92, 103, 96, 125, 112, 90, 108, 123, 127, 96, 106, 108, 122, 41, 64, 103, 96, 125, 96, 104, 101, 96, 115, 108, 109 }, 9));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[20] { 17, 0, 22, 17, 101, 16, 43, 44, 49, 60, 22, 32, 55, 51, 44, 38, 32, 54, 127, 101 }, 69) + ex.Message);
#endif
            }

            _0x6176ecbe?._0xd8acbec7();
            return true;
        }

        bool _0xa78d0ef5 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xa78d0ef5 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x9672995a._0x471e3941(new byte[37] { 117, 122, 75, 93, 90, 115, 14, 125, 71, 73, 64, 3, 71, 64, 14, 111, 64, 65, 64, 87, 67, 65, 91, 93, 0, 14, 126, 66, 79, 87, 75, 92, 14, 103, 106, 20, 14 }, 46) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xf2d58065 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x9672995a._0x471e3941(new byte[25] { 165, 180, 162, 165, 209, 162, 152, 150, 159, 220, 152, 159, 209, 176, 132, 133, 153, 209, 180, 163, 163, 190, 163, 203, 209 }, 241) + ex.Message);
#endif
                }

                _0x6176ecbe?._0xd8acbec7();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x9672995a._0x471e3941(new byte[28] { 222, 207, 217, 222, 170, 217, 227, 237, 228, 167, 227, 228, 170, 216, 239, 251, 255, 239, 249, 254, 170, 207, 216, 216, 197, 216, 176, 170 }, 138) + ex.Message);
#endif
                }

                _0x6176ecbe?._0xd8acbec7();
                return true;
            }
        }
        while (!_0xa78d0ef5);
        return false;
    }

    private void _0x4d10a993()
    {
        using (var _0x2a8aa05d = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[30] { 58, 54, 52, 119, 44, 55, 48, 45, 32, 106, 61, 119, 41, 53, 56, 32, 60, 43, 119, 12, 55, 48, 45, 32, 9, 53, 56, 32, 60, 43 }, 89)))
        using (var _0xd1ce062d = _0x2a8aa05d.GetStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 219, 205, 202, 202, 221, 214, 204, 249, 219, 204, 209, 206, 209, 204, 193 }, 184)))
        using (var _0xaa010000 = _0xd1ce062d.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[9] { 183, 181, 164, 153, 190, 164, 181, 190, 164 }, 208)))
        {
            if (_0xaa010000 == null)
                return;
            using (var _0xe8a4c110 = _0xaa010000.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[9] { 182, 180, 165, 148, 169, 165, 163, 176, 162 }, 209)))
            {
                if (_0xe8a4c110 == null)
                    return;
                using (var _0xf1b348f2 = new AndroidJavaObject(_0x9672995a._0x471e3941(new byte[19] { 108, 113, 100, 45, 105, 112, 108, 109, 45, 73, 80, 76, 77, 76, 97, 105, 102, 96, 119 }, 3)))
                using (var _0x80f9af28 = _0xe8a4c110.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[6] { 192, 206, 210, 248, 206, 223 }, 171)))
                using (var _0x5c0a22ec = _0x80f9af28.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[8] { 16, 13, 28, 11, 24, 13, 22, 11 }, 121)))
                {
                    while (_0x5c0a22ec.Call<bool>(_0x9672995a._0x471e3941(new byte[7] { 66, 75, 89, 100, 79, 82, 94 }, 42)))
                    {
                        string _0x317c0ac7 = _0x5c0a22ec.Call<string>(_0x9672995a._0x471e3941(new byte[4] { 120, 115, 110, 98 }, 22));
                        using (var _0x9579484b = _0xe8a4c110.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[3] { 143, 141, 156 }, 232), _0x317c0ac7))
                        {
                            _0xf1b348f2.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[3] { 238, 235, 234 }, 158), _0x317c0ac7, _0x9579484b);
                        }
                    }

                    string _0x4729a107 = _0xf1b348f2.Call<string>(_0x9672995a._0x471e3941(new byte[8] { 227, 248, 196, 227, 229, 254, 249, 240 }, 151));
                    if (!string.IsNullOrEmpty(_0x4729a107))
                    {
                        _0x7d0bef11(_0x4729a107);
                        _0xbb8b4d8b(_0x4729a107);
                    }
                }
            }
        }
    }

    private string _0xba4ab1ff()
    {
        if (string.IsNullOrEmpty(_0x260b2efd) && _0xdd10d12f != null)
            _0x260b2efd = _0xdd10d12f.GetUserAgent();
        if (string.IsNullOrEmpty(_0x260b2efd))
            return string.Empty;
        string _0xc0622d1e = Regex.Replace(_0x260b2efd, _0x9672995a._0x471e3941(new byte[11] { 58, 21, 76, 93, 58, 21, 76, 17, 16, 58, 4 }, 102), string.Empty);
        _0xc0622d1e = Regex.Replace(_0xc0622d1e, _0x9672995a._0x471e3941(new byte[15] { 193, 238, 182, 223, 232, 244, 241, 249, 178, 198, 195, 166, 180, 192, 182 }, 157), string.Empty);
        _0xc0622d1e = Regex.Replace(_0xc0622d1e, _0x9672995a._0x471e3941(new byte[15] { 120, 75, 92, 93, 71, 65, 64, 1, 26, 114, 0, 30, 114, 93, 4 }, 46), string.Empty);
        return Regex.Replace(_0xc0622d1e, _0x9672995a._0x471e3941(new byte[6] { 145, 190, 182, 255, 225, 176 }, 205), _0x9672995a._0x471e3941(new byte[1] { 61 }, 29)).Trim();
    }

    private bool _0x5a6d7add = false;
    private string _0xed026270 = "";
    internal bool _0x639e672d(string _0xdb23ce10)
    {
        return _0xdb23ce10.StartsWith(_0x9672995a._0x471e3941(new byte[9] { 7, 11, 24, 1, 15, 30, 80, 69, 69 }, 106), StringComparison.OrdinalIgnoreCase) || _0xdb23ce10.StartsWith(_0x9672995a._0x471e3941(new byte[24] { 141, 145, 145, 149, 150, 223, 202, 202, 149, 137, 132, 156, 203, 130, 138, 138, 130, 137, 128, 203, 134, 138, 136, 202 }, 229), StringComparison.OrdinalIgnoreCase) || _0xdb23ce10.StartsWith(_0x9672995a._0x471e3941(new byte[23] { 165, 185, 185, 189, 247, 226, 226, 189, 161, 172, 180, 227, 170, 162, 162, 170, 161, 168, 227, 174, 162, 160, 226 }, 205), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x264c0caf()
    {
        float _0xd106491c = Time.realtimeSinceStartup;
        if (_0xd106491c < 0f)
            _0xd106491c = 0f;
        int _0x24ebc012 = (int)(_0xd106491c * 1000f);
        int _0xc5ff9508 = _0x24ebc012 / 60000;
        int _0xdc7fb2ef = (_0x24ebc012 / 1000) % 60;
        int _0xb940b2c6 = _0x24ebc012 % 1000;
        return string.Format(_0x9672995a._0x471e3941(new byte[21] { 231, 172, 166, 172, 172, 225, 166, 231, 173, 166, 172, 172, 225, 166, 231, 174, 166, 172, 172, 172, 225 }, 156), _0xc5ff9508, _0xdc7fb2ef, _0xb940b2c6);
    }

    private string _0x5b66c140 { get; set; }

    private void OnApplicationFocus(bool _0x857f6d6a)
    {
        isApplicationFocus = _0x857f6d6a;
        if (_0x857f6d6a && _0xfcfdbefa)
        {
            _0x4d10a993();
        }
    }

    private async Task<bool> _0xe79d3259()
    {
        {
#if B_LOGS
            Debug.Log(_0x9672995a._0x471e3941(new byte[29] { 36, 43, 26, 12, 11, 34, 95, 54, 12, 47, 13, 22, 9, 30, 28, 6, 62, 17, 27, 44, 30, 9, 26, 27, 60, 23, 26, 28, 20 }, 127));
#endif
        }

        string _0x39fb5914 = "";
        for (int _0xd59a09a6 = 0; _0xd59a09a6 < 2; _0xd59a09a6++)
        {
            if (await _0x44f481ec(1, 100))
            {
                await _0xcfd1127c(_0x9672995a._0x471e3941(new byte[7] { 107, 101, 102, 106, 98, 108, 109 }, 9));
                _0xd8acbec7();
                return true;
            }

            _0x39fb5914 = await _0xd19d13e7(1, 100);
            if (!string.IsNullOrEmpty(_0x39fb5914))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x39fb5914))
            {
                if (!string.IsNullOrEmpty(_0xd0b62d1a))
                {
                    _0x39fb5914 = _0x927a5981(_0x39fb5914, _0xd0b62d1a);
                    {
#if B_LOGS
                        Debug.Log(_0x9672995a._0x471e3941(new byte[53] { 244, 251, 202, 220, 219, 242, 143, 236, 206, 204, 199, 202, 203, 143, 201, 198, 193, 206, 195, 250, 221, 195, 143, 216, 198, 219, 199, 143, 220, 202, 193, 203, 198, 203, 143, 77, 41, 61, 143, 220, 199, 192, 216, 143, 248, 202, 205, 249, 198, 202, 216, 149, 143 }, 175) + _0x39fb5914);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x9672995a._0x471e3941(new byte[39] { 238, 225, 208, 198, 193, 232, 149, 246, 212, 214, 221, 208, 209, 149, 211, 220, 219, 212, 217, 224, 199, 217, 149, 87, 51, 39, 149, 198, 221, 218, 194, 149, 226, 208, 215, 227, 220, 208, 194 }, 181));
#endif
                    }
                }

                _0xf4991660 = true;
                _0x8ac8d075(_0x39fb5914);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[44] { 228, 235, 218, 204, 203, 226, 159, 250, 199, 220, 218, 207, 203, 214, 208, 209, 159, 200, 215, 214, 211, 218, 159, 220, 215, 218, 220, 212, 214, 209, 216, 159, 204, 222, 201, 218, 219, 159, 211, 214, 209, 212, 133, 159 }, 191) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool _0x22da5c8c(string _0x6b72abc3)
    {
        try
        {
            using (var _0xc1e7013e = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[30] { 7, 11, 9, 74, 17, 10, 13, 16, 29, 87, 0, 74, 20, 8, 5, 29, 1, 22, 74, 49, 10, 13, 16, 29, 52, 8, 5, 29, 1, 22 }, 100)))
            using (var _0x8672faef = _0xc1e7013e.GetStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 57, 47, 40, 40, 63, 52, 46, 27, 57, 46, 51, 44, 51, 46, 35 }, 90)))
            using (var _0xd6b520bc = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[15] { 60, 51, 57, 47, 50, 52, 57, 115, 51, 56, 41, 115, 8, 47, 52 }, 93)))
            using (var _0x26156a27 = _0xd6b520bc.CallStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[5] { 46, 63, 44, 45, 59 }, 94), _0x6b72abc3))
            using (var _0x161f7f1b = new AndroidJavaObject(_0x9672995a._0x471e3941(new byte[22] { 0, 15, 5, 19, 14, 8, 5, 79, 2, 14, 15, 21, 4, 15, 21, 79, 40, 15, 21, 4, 15, 21 }, 97), _0x9672995a._0x471e3941(new byte[26] { 11, 4, 14, 24, 5, 3, 14, 68, 3, 4, 30, 15, 4, 30, 68, 11, 9, 30, 3, 5, 4, 68, 60, 35, 47, 61 }, 106), _0x26156a27))
            {
                WLog(_0x9672995a._0x471e3941(new byte[26] { 36, 15, 21, 8, 10, 2, 43, 14, 12, 2, 71, 8, 23, 2, 9, 71, 2, 31, 19, 2, 21, 9, 6, 11, 93, 71 }, 103) + _0x6b72abc3);
                _0x161f7f1b.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[11] { 182, 179, 179, 148, 182, 163, 178, 176, 184, 165, 174 }, 215), _0x9672995a._0x471e3941(new byte[33] { 84, 91, 81, 71, 90, 92, 81, 27, 92, 91, 65, 80, 91, 65, 27, 86, 84, 65, 80, 82, 90, 71, 76, 27, 119, 103, 122, 98, 102, 116, 119, 121, 112 }, 53));
                _0x161f7f1b.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[8] { 144, 149, 149, 183, 157, 144, 150, 130 }, 241), 0x10000000);
                _0x8672faef.Call(_0x9672995a._0x471e3941(new byte[13] { 118, 113, 100, 119, 113, 68, 102, 113, 108, 115, 108, 113, 124 }, 5), _0x161f7f1b);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x9672995a._0x471e3941(new byte[28] { 167, 140, 150, 139, 137, 129, 168, 141, 143, 129, 196, 129, 156, 144, 129, 150, 138, 133, 136, 196, 130, 133, 141, 136, 129, 128, 222, 196 }, 228) + e.Message);
            Application.OpenURL(_0x6b72abc3);
            return true;
        }
    }

    private IEnumerator _0xd953ce11(Dictionary<string, object> _0x252c210d)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[30] { 135, 136, 185, 175, 168, 129, 252, 154, 185, 168, 191, 180, 252, 153, 164, 168, 174, 189, 252, 140, 169, 175, 180, 252, 152, 189, 168, 189, 230, 252 }, 220) + string.Join(_0x9672995a._0x471e3941(new byte[1] { 62 }, 55), _0x252c210d));
#endif
            }
        }

        string _0x111a662c = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x252c210d != null && _0x252c210d.TryGetValue(_0x9672995a._0x471e3941(new byte[16] { 208, 209, 202, 215, 216, 215, 221, 223, 202, 215, 209, 208, 250, 223, 202, 223 }, 190), out var raw))
        {
            try
            {
                var _0xd3744485 = raw?.ToString();
                var _0x50643d95 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd3744485);
                if (_0x50643d95 != null && _0x50643d95.TryGetValue(_0x9672995a._0x471e3941(new byte[6] { 19, 5, 14, 4, 9, 4 }, 96), out var val))
                {
                    _0x111a662c = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x9672995a._0x471e3941(new byte[30] { 65, 78, 127, 105, 110, 58, 74, 111, 105, 114, 71, 58, 80, 73, 85, 84, 58, 106, 123, 104, 105, 127, 58, 127, 104, 104, 117, 104, 32, 58 }, 26) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x111a662c) && _0x252c210d != null && _0x252c210d.TryGetValue(_0x9672995a._0x471e3941(new byte[6] { 118, 96, 107, 97, 108, 97 }, 5), out var lab))
        {
            _0x111a662c = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[38] { 225, 238, 223, 201, 206, 154, 234, 207, 201, 210, 231, 154, 252, 223, 206, 217, 210, 223, 222, 154, 201, 223, 212, 222, 211, 222, 154, 220, 200, 213, 215, 154, 208, 201, 213, 212, 128, 154 }, 186) + _0x111a662c);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x111a662c))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[38] { 9, 6, 55, 33, 38, 114, 2, 39, 33, 58, 15, 114, 5, 51, 59, 38, 114, 38, 61, 114, 61, 34, 55, 60, 114, 37, 59, 38, 58, 114, 33, 55, 60, 54, 59, 54, 104, 114 }, 82) + _0x111a662c);
            }
#endif
        }

        _0xd0b62d1a = _0x111a662c;
        yield return new WaitUntil(() => _0xfcfdbefa);
        var _0x1aae56a8 = _0xd19d13e7(2, 100);
        yield return new WaitUntil(() => _0x1aae56a8.IsCompleted);
        string _0x075d9f52 = _0x1aae56a8.Result;
        if (!string.IsNullOrEmpty(_0x075d9f52))
        {
            string _0x12d30677 = _0x927a5981(_0x075d9f52, _0x111a662c);
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[33] { 74, 69, 116, 98, 101, 49, 65, 100, 98, 121, 76, 49, 67, 116, 125, 126, 112, 117, 49, 70, 116, 115, 71, 120, 116, 102, 49, 102, 120, 101, 121, 43, 49 }, 17) + _0x12d30677);
#endif
            }

            _0xdd10d12f.Load(_0x12d30677);
        }
    }

    // WEB VIEW LOGIC
    public bool _0xfcfdbefa { get; set; }

    private string _0xb0ca8f18()
    {
        return _0x9672995a._0x471e3941(new byte[12] { 203, 133, 150, 141, 128, 151, 138, 140, 141, 203, 202, 152 }, 227) + _0x9672995a._0x471e3941(new byte[8] { 155, 140, 159, 205, 152, 140, 208, 202 }, 237) + WindowsDesktopUserAgent + _0x9672995a._0x471e3941(new byte[2] { 104, 116 }, 79) + _0x9672995a._0x471e3941(new byte[30] { 157, 138, 153, 203, 155, 153, 132, 159, 132, 214, 165, 138, 157, 130, 140, 138, 159, 132, 153, 197, 155, 153, 132, 159, 132, 159, 146, 155, 142, 208 }, 235) + _0x9672995a._0x471e3941(new byte[121] { 188, 175, 180, 185, 174, 179, 181, 180, 250, 190, 191, 188, 242, 181, 184, 176, 246, 177, 191, 163, 246, 172, 187, 182, 243, 161, 174, 168, 163, 161, 149, 184, 176, 191, 185, 174, 244, 190, 191, 188, 179, 180, 191, 138, 168, 181, 170, 191, 168, 174, 163, 242, 181, 184, 176, 246, 177, 191, 163, 246, 161, 189, 191, 174, 224, 188, 175, 180, 185, 174, 179, 181, 180, 242, 243, 161, 168, 191, 174, 175, 168, 180, 250, 172, 187, 182, 225, 167, 246, 185, 181, 180, 188, 179, 189, 175, 168, 187, 184, 182, 191, 224, 174, 168, 175, 191, 167, 243, 225, 167, 185, 187, 174, 185, 178, 242, 191, 243, 161, 167, 167 }, 218) + _0x9672995a._0x471e3941(new byte[26] { 44, 45, 46, 96, 56, 58, 39, 60, 39, 100, 111, 61, 59, 45, 58, 9, 47, 45, 38, 60, 111, 100, 61, 41, 97, 115 }, 72) + _0x9672995a._0x471e3941(new byte[130] { 65, 64, 67, 13, 85, 87, 74, 81, 74, 9, 2, 68, 85, 85, 115, 64, 87, 86, 76, 74, 75, 2, 9, 2, 16, 11, 21, 5, 13, 114, 76, 75, 65, 74, 82, 86, 5, 107, 113, 5, 20, 21, 11, 21, 30, 5, 114, 76, 75, 19, 17, 30, 5, 93, 19, 17, 12, 5, 100, 85, 85, 73, 64, 114, 64, 71, 110, 76, 81, 10, 16, 22, 18, 11, 22, 19, 5, 13, 110, 109, 113, 104, 105, 9, 5, 73, 76, 78, 64, 5, 98, 64, 70, 78, 74, 12, 5, 102, 77, 87, 74, 72, 64, 10, 20, 23, 21, 11, 21, 11, 21, 11, 21, 5, 118, 68, 67, 68, 87, 76, 10, 16, 22, 18, 11, 22, 19, 2, 12, 30 }, 37) + _0x9672995a._0x471e3941(new byte[30] { 137, 136, 139, 197, 157, 159, 130, 153, 130, 193, 202, 157, 129, 140, 153, 139, 130, 159, 128, 202, 193, 202, 186, 132, 131, 222, 223, 202, 196, 214 }, 237) + _0x9672995a._0x471e3941(new byte[34] { 189, 188, 191, 241, 169, 171, 182, 173, 182, 245, 254, 175, 188, 183, 189, 182, 171, 254, 245, 254, 158, 182, 182, 190, 181, 188, 249, 144, 183, 186, 247, 254, 240, 226 }, 217) + _0x9672995a._0x471e3941(new byte[30] { 203, 202, 201, 135, 223, 221, 192, 219, 192, 131, 136, 194, 206, 215, 251, 192, 218, 204, 199, 255, 192, 198, 193, 219, 220, 136, 131, 159, 134, 148 }, 175) + _0x9672995a._0x471e3941(new byte[449] { 86, 80, 91, 89, 84, 67, 80, 2, 87, 67, 70, 31, 89, 64, 80, 67, 76, 70, 81, 24, 121, 89, 64, 80, 67, 76, 70, 24, 5, 97, 74, 80, 77, 79, 75, 87, 79, 5, 14, 84, 71, 80, 81, 75, 77, 76, 24, 5, 19, 16, 18, 5, 95, 14, 89, 64, 80, 67, 76, 70, 24, 5, 101, 77, 77, 69, 78, 71, 2, 97, 74, 80, 77, 79, 71, 5, 14, 84, 71, 80, 81, 75, 77, 76, 24, 5, 19, 16, 18, 5, 95, 14, 89, 64, 80, 67, 76, 70, 24, 5, 108, 77, 86, 31, 99, 29, 96, 80, 67, 76, 70, 5, 14, 84, 71, 80, 81, 75, 77, 76, 24, 5, 16, 22, 5, 95, 127, 14, 79, 77, 64, 75, 78, 71, 24, 68, 67, 78, 81, 71, 14, 82, 78, 67, 86, 68, 77, 80, 79, 24, 5, 117, 75, 76, 70, 77, 85, 81, 5, 14, 69, 71, 86, 106, 75, 69, 74, 103, 76, 86, 80, 77, 82, 91, 116, 67, 78, 87, 71, 81, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 80, 71, 86, 87, 80, 76, 2, 114, 80, 77, 79, 75, 81, 71, 12, 80, 71, 81, 77, 78, 84, 71, 10, 89, 67, 80, 65, 74, 75, 86, 71, 65, 86, 87, 80, 71, 24, 5, 90, 26, 20, 5, 14, 64, 75, 86, 76, 71, 81, 81, 24, 5, 20, 22, 5, 14, 79, 77, 64, 75, 78, 71, 24, 68, 67, 78, 81, 71, 14, 79, 77, 70, 71, 78, 24, 5, 5, 14, 82, 78, 67, 86, 68, 77, 80, 79, 24, 5, 117, 75, 76, 70, 77, 85, 81, 5, 14, 82, 78, 67, 86, 68, 77, 80, 79, 116, 71, 80, 81, 75, 77, 76, 24, 5, 19, 23, 12, 18, 12, 18, 5, 14, 87, 67, 100, 87, 78, 78, 116, 71, 80, 81, 75, 77, 76, 24, 5, 19, 16, 18, 12, 18, 12, 18, 12, 18, 5, 95, 11, 25, 95, 95, 25, 109, 64, 72, 71, 65, 86, 12, 70, 71, 68, 75, 76, 71, 114, 80, 77, 82, 71, 80, 86, 91, 10, 82, 80, 77, 86, 77, 14, 5, 87, 81, 71, 80, 99, 69, 71, 76, 86, 102, 67, 86, 67, 5, 14, 89, 69, 71, 86, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 80, 71, 86, 87, 80, 76, 2, 87, 67, 70, 25, 95, 14, 65, 77, 76, 68, 75, 69, 87, 80, 67, 64, 78, 71, 24, 86, 80, 87, 71, 95, 11, 25, 95, 65, 67, 86, 65, 74, 10, 71, 11, 89, 95 }, 34) + _0x9672995a._0x471e3941(new byte[112] { 120, 121, 122, 52, 111, 127, 110, 121, 121, 114, 48, 59, 107, 117, 120, 104, 116, 59, 48, 45, 37, 46, 44, 53, 39, 120, 121, 122, 52, 111, 127, 110, 121, 121, 114, 48, 59, 116, 121, 117, 123, 116, 104, 59, 48, 45, 44, 36, 44, 53, 39, 120, 121, 122, 52, 111, 127, 110, 121, 121, 114, 48, 59, 125, 106, 125, 117, 112, 75, 117, 120, 104, 116, 59, 48, 45, 37, 46, 44, 53, 39, 120, 121, 122, 52, 111, 127, 110, 121, 121, 114, 48, 59, 125, 106, 125, 117, 112, 84, 121, 117, 123, 116, 104, 59, 48, 45, 44, 40, 44, 53, 39 }, 28) + _0x9672995a._0x471e3941(new byte[45] { 54, 48, 59, 57, 53, 43, 44, 38, 45, 53, 108, 45, 44, 54, 45, 55, 33, 42, 49, 54, 35, 48, 54, 127, 55, 44, 38, 39, 36, 43, 44, 39, 38, 121, 63, 33, 35, 54, 33, 42, 106, 39, 107, 57, 63 }, 66) + _0x9672995a._0x471e3941(new byte[721] { 60, 58, 49, 51, 62, 41, 58, 104, 39, 58, 33, 47, 117, 63, 33, 38, 44, 39, 63, 102, 37, 41, 60, 43, 32, 5, 45, 44, 33, 41, 102, 42, 33, 38, 44, 96, 63, 33, 38, 44, 39, 63, 97, 115, 63, 33, 38, 44, 39, 63, 102, 37, 41, 60, 43, 32, 5, 45, 44, 33, 41, 117, 46, 61, 38, 43, 60, 33, 39, 38, 96, 57, 97, 51, 62, 41, 58, 104, 59, 117, 27, 60, 58, 33, 38, 47, 96, 57, 97, 102, 60, 39, 4, 39, 63, 45, 58, 11, 41, 59, 45, 96, 97, 115, 33, 46, 96, 59, 102, 33, 38, 44, 45, 48, 7, 46, 96, 111, 56, 39, 33, 38, 60, 45, 58, 114, 104, 43, 39, 41, 58, 59, 45, 111, 97, 118, 117, 120, 52, 52, 59, 102, 33, 38, 44, 45, 48, 7, 46, 96, 111, 32, 39, 62, 45, 58, 114, 104, 38, 39, 38, 45, 111, 97, 118, 117, 120, 52, 52, 59, 102, 33, 38, 44, 45, 48, 7, 46, 96, 111, 37, 41, 48, 101, 63, 33, 44, 60, 32, 111, 97, 118, 117, 120, 52, 52, 59, 102, 33, 38, 44, 45, 48, 7, 46, 96, 111, 37, 41, 48, 101, 44, 45, 62, 33, 43, 45, 101, 63, 33, 44, 60, 32, 111, 97, 118, 117, 120, 97, 58, 45, 60, 61, 58, 38, 104, 51, 37, 41, 60, 43, 32, 45, 59, 114, 46, 41, 36, 59, 45, 100, 37, 45, 44, 33, 41, 114, 57, 100, 39, 38, 43, 32, 41, 38, 47, 45, 114, 38, 61, 36, 36, 100, 41, 44, 44, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 58, 45, 37, 39, 62, 45, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 41, 44, 44, 13, 62, 45, 38, 60, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 58, 45, 37, 39, 62, 45, 13, 62, 45, 38, 60, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 44, 33, 59, 56, 41, 60, 43, 32, 13, 62, 45, 38, 60, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 58, 45, 60, 61, 58, 38, 104, 46, 41, 36, 59, 45, 115, 53, 53, 115, 33, 46, 96, 59, 102, 33, 38, 44, 45, 48, 7, 46, 96, 111, 56, 39, 33, 38, 60, 45, 58, 114, 104, 46, 33, 38, 45, 111, 97, 118, 117, 120, 52, 52, 59, 102, 33, 38, 44, 45, 48, 7, 46, 96, 111, 32, 39, 62, 45, 58, 114, 104, 32, 39, 62, 45, 58, 111, 97, 118, 117, 120, 97, 58, 45, 60, 61, 58, 38, 104, 51, 37, 41, 60, 43, 32, 45, 59, 114, 60, 58, 61, 45, 100, 37, 45, 44, 33, 41, 114, 57, 100, 39, 38, 43, 32, 41, 38, 47, 45, 114, 38, 61, 36, 36, 100, 41, 44, 44, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 58, 45, 37, 39, 62, 45, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 41, 44, 44, 13, 62, 45, 38, 60, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 58, 45, 37, 39, 62, 45, 13, 62, 45, 38, 60, 4, 33, 59, 60, 45, 38, 45, 58, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 53, 100, 44, 33, 59, 56, 41, 60, 43, 32, 13, 62, 45, 38, 60, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 58, 45, 60, 61, 58, 38, 104, 46, 41, 36, 59, 45, 115, 53, 53, 115, 58, 45, 60, 61, 58, 38, 104, 39, 58, 33, 47, 96, 57, 97, 115, 53, 115, 53, 43, 41, 60, 43, 32, 96, 45, 97, 51, 53 }, 72) + _0x9672995a._0x471e3941(new byte[5] { 98, 54, 55, 54, 36 }, 31);
    }

    private IEnumerator _0x0af39808(string _0xdaa33728)
    {
        if (_0xdd10d12f != null && _0xfcfdbefa)
            yield break;
        _0xdd10d12f = gameObject.AddComponent<UniWebView>();
        _0x482df1c1(_0xdd10d12f);
        _0x614978d3(_0xdd10d12f);
        _0xdd10d12f.BackgroundColor = Color.clear;
        var _0xd962ec7b = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x4018bf96();
        yield return new WaitForEndOfFrame();
        _0xfcfdbefa = true;
        _0x3d4dfdca();
        _0xea788680(true);
        _0xb629a546 = false;
        _0x3c063aec = false;
        _0xd78e9b79.Clear();
        _0xf6340792 = -1;
        firstLoadShown = false;
        _0x50c7dabd = false;
        _0xb7aee9cd = false;
        _0xdd10d12f.SetUserAgent("");
        _0x3cf147e4 = Time.realtimeSinceStartup;
        _0xdd10d12f.Stop();
        _0xdd10d12f.Load(_0xdaa33728);
        _0xdd10d12f.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x9672995a._0x471e3941(new byte[25] { 134, 170, 162, 165, 235, 156, 174, 169, 157, 162, 174, 188, 235, 130, 165, 162, 191, 162, 170, 167, 235, 152, 163, 164, 188 }, 203));
    }

    private string _0xd65bed32 = "";
    private string _0xe65e31c4 = "";
    private void _0x614978d3(UniWebView _0xddea5b8a)
    {
        if (_0x1826310b)
            return;
        _0x1826310b = true;
        _0xddea5b8a.AddUrlScheme(_0x9672995a._0x471e3941(new byte[2] { 194, 209 }, 182));
        _0xddea5b8a.AddUrlScheme(_0x9672995a._0x471e3941(new byte[6] { 225, 230, 252, 237, 230, 252 }, 136));
        _0xddea5b8a.AddUrlScheme(_0x9672995a._0x471e3941(new byte[6] { 88, 84, 71, 94, 80, 65 }, 53));
        _0xddea5b8a.OnMessageReceived += (_0x1111767a, _0x009b2462) =>
        {
            if (TryOpenExternalLikeChrome(_0x009b2462.RawMessage))
            {
                _0xea788680(false);
                return;
            }
        };
        _0xddea5b8a.RegisterShouldHandleRequest(_0x9284a84f =>
        {
            string _0xd32211c9 = _0x9284a84f != null ? _0x9284a84f.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xd32211c9))
                return true;
            WLog(_0x9672995a._0x471e3941(new byte[21] { 98, 89, 94, 68, 93, 85, 121, 80, 95, 85, 93, 84, 99, 84, 64, 68, 84, 66, 69, 11, 17 }, 49) + _0xd32211c9);
            if (TryOpenExternalLikeChrome(_0xd32211c9))
            {
                _0xea788680(false);
                return false;
            }

            if (_0x9284a84f != null && _0x9284a84f.IsMainFrame && IsGoogleAuthFlowUrl(_0xd32211c9) && !_0x3c063aec)
            {
                WLog(_0x9672995a._0x471e3941(new byte[62] { 195, 239, 231, 224, 174, 217, 235, 236, 216, 231, 235, 249, 174, 234, 235, 250, 235, 237, 250, 235, 234, 174, 201, 225, 225, 233, 226, 235, 174, 239, 251, 250, 230, 174, 219, 220, 194, 174, 163, 176, 174, 252, 235, 226, 225, 239, 234, 174, 249, 231, 250, 230, 174, 201, 225, 225, 233, 226, 235, 174, 219, 207 }, 142));
                _0x3c063aec = true;
                _0xea788680(true);
                _0xdd10d12f.SetUserAgent(_0xba4ab1ff());
                _0xdd10d12f.Load(_0xd32211c9);
                return false;
            }

            return true;
        });
        _0xddea5b8a.OnLoadingErrorReceived += (_0x1111767a, _0x1b307aaa, _0x009b2462, _0x43209ca3) =>
        {
            WLog(_0x9672995a._0x471e3941(new byte[25] { 37, 9, 1, 6, 72, 63, 13, 10, 62, 1, 13, 31, 72, 45, 26, 26, 7, 26, 82, 72, 11, 7, 12, 13, 85 }, 104) + _0x1b307aaa + _0x9672995a._0x471e3941(new byte[9] { 28, 81, 89, 79, 79, 93, 91, 89, 1 }, 60) + _0x009b2462);
            string _0x25bceda2 = GetFailingUrl(_0x43209ca3);
            if (string.IsNullOrEmpty(_0x25bceda2) || IsAboutBlank(_0x25bceda2))
                return;
            _ = _0xcfd1127c(_0x9672995a._0x471e3941(new byte[8] { 190, 191, 150, 172, 187, 187, 166, 187 }, 201));
            WLog(_0x9672995a._0x471e3941(new byte[45] { 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 81, 86, 94, 91, 94, 89, 80, 23, 98, 101, 123, 23, 26, 9, 23, 88, 71, 82, 89, 23, 82, 79, 67, 82, 69, 89, 86, 91, 91, 78, 13, 23 }, 55) + _0x25bceda2);
            StopCurrentFailedLoad(_0x1111767a);
            _0xf85ef082(_0x25bceda2);
        };
        _0xddea5b8a.OnPageStarted += (_0x1111767a, _0x7bcded39) =>
        {
            _0xbaf60fb0 = 0;
            if (_0xb629a546 && IsAboutBlank(_0x7bcded39))
            {
                WLog(_0x9672995a._0x471e3941(new byte[27] { 220, 254, 233, 251, 237, 254, 225, 172, 237, 238, 227, 249, 248, 182, 238, 224, 237, 226, 231, 172, 255, 248, 237, 254, 248, 233, 232 }, 140));
                return;
            }

            WLog(_0x9672995a._0x471e3941(new byte[29] { 226, 206, 198, 193, 143, 248, 202, 205, 249, 198, 202, 216, 143, 224, 193, 255, 206, 200, 202, 252, 219, 206, 221, 219, 202, 203, 149, 143, 132 }, 175) + (Time.realtimeSinceStartup - _0x3cf147e4).ToString(_0x9672995a._0x471e3941(new byte[5] { 32, 62, 32, 32, 32 }, 16)) + _0x9672995a._0x471e3941(new byte[2] { 79, 28 }, 60) + _0x7bcded39);
            if (TryOpenExternalLikeChrome(_0x7bcded39))
            {
                StopCurrentFailedLoad(_0x1111767a);
                return;
            }

            if (ContainsIgnoreCase(_0x7bcded39, _0x9672995a._0x471e3941(new byte[8] { 1, 12, 12, 4, 75, 4, 21, 21 }, 101)) || ContainsIgnoreCase(_0x7bcded39, _0x9672995a._0x471e3941(new byte[15] { 116, 101, 125, 42, 115, 109, 96, 99, 97, 112, 42, 102, 104, 107, 99 }, 4)) || _0x7bcded39.StartsWith(_0x9672995a._0x471e3941(new byte[25] { 155, 135, 135, 131, 128, 201, 220, 220, 145, 131, 148, 159, 156, 145, 146, 159, 149, 146, 133, 221, 159, 154, 133, 150, 220 }, 243), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x1111767a);
                OpenUrlExternally(_0x7bcded39);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x7bcded39))
            {
                _0xea788680(true);
                WLog(_0x9672995a._0x471e3941(new byte[41] { 35, 11, 11, 3, 8, 1, 68, 5, 17, 16, 12, 68, 2, 8, 11, 19, 68, 0, 1, 16, 1, 7, 16, 1, 0, 68, 73, 90, 68, 15, 1, 1, 20, 68, 18, 13, 23, 13, 6, 8, 1 }, 100));
                return;
            }

            _0x50c7dabd = true;
            _0xea788680(true);
            WLog(_0x9672995a._0x471e3941(new byte[43] { 248, 202, 205, 249, 198, 202, 216, 143, 195, 192, 206, 203, 198, 193, 200, 128, 221, 202, 203, 198, 221, 202, 204, 219, 198, 193, 200, 143, 130, 145, 143, 196, 202, 202, 223, 143, 217, 198, 220, 198, 205, 195, 202 }, 175));
        };
        _0xddea5b8a.OnPageCommitted += (_0x1111767a, _0x7bcded39) =>
        {
            if (_0xb629a546 && IsAboutBlank(_0x7bcded39))
                return;
            WLog(_0x9672995a._0x471e3941(new byte[31] { 50, 30, 22, 17, 95, 40, 26, 29, 41, 22, 26, 8, 95, 48, 17, 47, 30, 24, 26, 60, 16, 18, 18, 22, 11, 11, 26, 27, 69, 95, 84 }, 127) + (Time.realtimeSinceStartup - _0x3cf147e4).ToString(_0x9672995a._0x471e3941(new byte[5] { 92, 66, 92, 92, 92 }, 108)) + _0x9672995a._0x471e3941(new byte[2] { 124, 47 }, 15) + _0x7bcded39);
            if (!firstLoadShown && IsHttpUrl(_0x7bcded39))
            {
                firstLoadShown = true;
                _0x50c7dabd = false;
                _0xea788680(false);
                _0xce5eabb9();
                _0x4018bf96();
                _0x1111767a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xcfd1127c(_0x9672995a._0x471e3941(new byte[9] { 5, 4, 45, 29, 2, 23, 28, 23, 22 }, 114));
                WLog(_0x9672995a._0x471e3941(new byte[39] { 200, 228, 236, 235, 165, 210, 224, 231, 211, 236, 224, 242, 165, 246, 237, 234, 242, 235, 165, 234, 235, 165, 230, 234, 232, 232, 236, 241, 241, 224, 225, 165, 230, 234, 235, 241, 224, 235, 241 }, 133));
            }
        };
        _0xddea5b8a.OnPageProgressChanged += (_0x1111767a, _0xd940a049) =>
        {
            if (_0xb629a546)
                return;
            if (!firstLoadShown && _0xd940a049 >= 0.65f)
            {
                firstLoadShown = true;
                _0x50c7dabd = false;
                _0xea788680(false);
                _0xce5eabb9();
                _0x4018bf96();
                _0x1111767a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xcfd1127c(_0x9672995a._0x471e3941(new byte[9] { 85, 84, 125, 77, 82, 71, 76, 71, 70 }, 34));
                WLog(_0x9672995a._0x471e3941(new byte[32] { 14, 34, 42, 45, 99, 20, 38, 33, 21, 42, 38, 52, 99, 48, 43, 44, 52, 45, 99, 33, 58, 99, 51, 49, 44, 36, 49, 38, 48, 48, 121, 99 }, 67) + _0xd940a049);
            }
        };
        _0xddea5b8a.OnPageFinished += (_0x1111767a, _0x1b307aaa, _0x7bcded39) =>
        {
            if (_0xb629a546 && IsAboutBlank(_0x7bcded39))
            {
                _0xb629a546 = false;
                WLog(_0x9672995a._0x471e3941(new byte[28] { 185, 155, 140, 158, 136, 155, 132, 201, 136, 139, 134, 156, 157, 211, 139, 133, 136, 135, 130, 201, 143, 128, 135, 128, 154, 129, 140, 141 }, 233));
                return;
            }

            WLog(_0x9672995a._0x471e3941(new byte[24] { 22, 58, 50, 53, 123, 12, 62, 57, 13, 50, 62, 44, 123, 29, 50, 53, 50, 40, 51, 62, 63, 97, 123, 112 }, 91) + (Time.realtimeSinceStartup - _0x3cf147e4).ToString(_0x9672995a._0x471e3941(new byte[5] { 114, 108, 114, 114, 114 }, 66)) + _0x9672995a._0x471e3941(new byte[7] { 146, 193, 130, 142, 133, 132, 220 }, 225) + _0x1b307aaa + _0x9672995a._0x471e3941(new byte[5] { 233, 188, 187, 165, 244 }, 201) + _0x7bcded39);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x50c7dabd = false;
                _0xea788680(false);
                _0xce5eabb9();
                _0x4018bf96();
                _0x1111767a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xcfd1127c(_0x9672995a._0x471e3941(new byte[9] { 237, 236, 197, 245, 234, 255, 244, 255, 254 }, 154));
                WLog(_0x9672995a._0x471e3941(new byte[33] { 160, 140, 132, 131, 205, 186, 136, 143, 187, 132, 136, 154, 205, 139, 132, 159, 158, 153, 205, 129, 130, 140, 137, 205, 142, 130, 128, 157, 129, 136, 153, 136, 137 }, 237));
            }
            else if (_0x50c7dabd)
            {
                _0x50c7dabd = false;
                _0xea788680(false);
                _0x1111767a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x9672995a._0x471e3941(new byte[40] { 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 204, 247, 240, 232, 191, 254, 249, 235, 250, 237, 191, 243, 240, 254, 251, 246, 241, 248, 191, 249, 246, 241, 246, 236, 247, 250, 251 }, 159));
            }
            else
            {
                _0xea788680(false);
            }

            if (_0x3c063aec && !IsGoogleAuthFlowUrl(_0x7bcded39) && !IsGoogleAuthFlowUrl(_0x7bcded39))
            {
                WLog(_0x9672995a._0x471e3941(new byte[48] { 211, 251, 251, 243, 248, 241, 180, 245, 225, 224, 252, 180, 231, 241, 241, 249, 231, 180, 242, 253, 250, 253, 231, 252, 241, 240, 180, 185, 170, 180, 230, 241, 231, 224, 251, 230, 241, 180, 240, 241, 242, 245, 225, 248, 224, 180, 193, 213 }, 148));
                _0x3c063aec = false;
                _0xdd10d12f.SetUserAgent("");
            }
        };
        _0xddea5b8a.OnShouldClose += _0x1111767a =>
        {
            WLog(_0x9672995a._0x471e3941(new byte[41] { 56, 55, 6, 16, 23, 62, 67, 46, 2, 10, 13, 67, 52, 6, 1, 53, 10, 6, 20, 67, 44, 13, 48, 11, 12, 22, 15, 7, 32, 15, 12, 16, 6, 67, 10, 13, 21, 12, 8, 6, 7 }, 99));
            _0x8fc08c86();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xddea5b8a.SetPopupPageEventEnabled(true);
        bool _0x27900e0c = false;
        bool _0x28a5f96c = false;
        _0xddea5b8a.OnMultipleWindowOpened += (_0x1111767a, _0xbb35766f) =>
        {
            _0x1111767a.ScrollTo(0, 0, false);
            WLog(_0x9672995a._0x471e3941(new byte[43] { 39, 40, 25, 15, 8, 33, 92, 49, 29, 21, 18, 92, 43, 25, 30, 42, 21, 25, 11, 92, 49, 9, 16, 8, 21, 12, 16, 25, 43, 21, 18, 24, 19, 11, 92, 51, 12, 25, 18, 25, 24, 70, 92 }, 124) + _0xbb35766f);
            var _0x92c9243b = _0xddea5b8a.GetPopupWindow(_0xbb35766f);
            if (_0x92c9243b == null)
                return;
            _0xd78e9b79.Add(_0x92c9243b);
            Debug.Log($"[Test] Popup ID: {_0x92c9243b.Id}");
            _0x92c9243b.OnPageStarted += (_0xac4fd3c3, _0x7bcded39) =>
            {
                WLog(_0x9672995a._0x471e3941(new byte[36] { 221, 210, 227, 245, 242, 219, 166, 214, 233, 246, 243, 246, 166, 209, 227, 228, 208, 239, 227, 241, 166, 201, 232, 214, 231, 225, 227, 213, 242, 231, 244, 242, 227, 226, 188, 166 }, 134) + _0x7bcded39);
                _0xbaf60fb0 = 0;
                if (string.IsNullOrEmpty(_0x7bcded39) || IsAboutBlank(_0x7bcded39))
                    return;
                if (IsGoogleAuthFlowUrl(_0x7bcded39))
                {
                    WLog(_0x9672995a._0x471e3941(new byte[57] { 122, 117, 68, 82, 85, 124, 1, 113, 78, 81, 84, 81, 1, 102, 78, 78, 70, 77, 68, 1, 64, 84, 85, 73, 1, 71, 77, 78, 86, 1, 12, 31, 1, 82, 81, 78, 78, 71, 1, 102, 78, 78, 70, 77, 68, 1, 98, 73, 83, 78, 76, 68, 1, 116, 96, 27, 1 }, 33) + _0x7bcded39);
                    _0x27900e0c = false;
                    _0xf2926e1c();
                    if (_0xac4fd3c3 != null && _0xac4fd3c3.IsAlive)
                        _0xac4fd3c3.EvaluateJavaScript(_0xe99b2c6b());
                    return;
                }

                if (_0xdd10d12f == null)
                    return;
                if (!_0x27900e0c)
                {
                    _0x27900e0c = true;
                    _0xdd10d12f.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x9672995a._0x471e3941(new byte[39] { 218, 213, 228, 242, 245, 220, 161, 209, 238, 241, 244, 241, 161, 224, 241, 241, 237, 248, 161, 214, 232, 239, 229, 238, 246, 242, 161, 229, 228, 242, 234, 245, 238, 241, 161, 212, 192, 187, 161 }, 129) + _0x7bcded39);
                }

                if (_0xac4fd3c3 != null && _0xac4fd3c3.IsAlive)
                    _0xac4fd3c3.EvaluateJavaScript(_0xb0ca8f18());
                if (!_0x28a5f96c && _0xac4fd3c3 != null && _0xac4fd3c3.IsAlive && IsHttpUrl(_0x7bcded39))
                {
                    _0x28a5f96c = true;
                }
            };
            _0x92c9243b.OnPageFinished += (_0xac4fd3c3, _0x43209ca3) =>
            {
                string _0x5a6fd73f = _0x43209ca3 != null ? _0x43209ca3.data : string.Empty;
                WLog(_0x9672995a._0x471e3941(new byte[35] { 39, 40, 25, 15, 8, 33, 92, 44, 19, 12, 9, 12, 92, 43, 25, 30, 42, 21, 25, 11, 92, 58, 21, 18, 21, 15, 20, 25, 24, 70, 92, 9, 14, 16, 65 }, 124) + _0x5a6fd73f);
                if (_0xac4fd3c3 == null || !_0xac4fd3c3.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5a6fd73f))
                {
                    _0xf2926e1c();
                    _0xac4fd3c3.EvaluateJavaScript(_0xe99b2c6b());
                    return;
                }

                if (!_0x27900e0c)
                    return;
                _0xac4fd3c3.EvaluateJavaScript(_0xb0ca8f18());
            };
        };
        _0xddea5b8a.OnMultipleWindowClosed += (_0x1111767a, _0xbb35766f) =>
        {
            _0xd78e9b79.RemoveAll(_0xf6b5a00d => _0xf6b5a00d == null || _0xf6b5a00d.Id == _0xbb35766f || !_0xf6b5a00d.IsAlive);
            _0xea788680(false);
            if (_0xd78e9b79.Count == 0 && _0xdd10d12f != null)
            {
                _0x27900e0c = false;
                _0x28a5f96c = false;
                _0x0d676a12();
            }

            WLog(_0x9672995a._0x471e3941(new byte[43] { 233, 230, 215, 193, 198, 239, 146, 255, 211, 219, 220, 146, 229, 215, 208, 228, 219, 215, 197, 146, 255, 199, 222, 198, 219, 194, 222, 215, 229, 219, 220, 214, 221, 197, 146, 241, 222, 221, 193, 215, 214, 136, 146 }, 178) + _0xbb35766f);
        };
        _0xddea5b8a.RegisterOnRequestMediaCapturePermission(_0x9284a84f =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal string _0xf4e72d4d(string _0x1ad3485e)
    {
        int _0xd4ba1490 = _0x1ad3485e.IndexOf(_0x9672995a._0x471e3941(new byte[3] { 237, 224, 185 }, 132), StringComparison.OrdinalIgnoreCase);
        if (_0xd4ba1490 < 0)
            return null;
        string _0xebdfac94 = _0x1ad3485e.Substring(_0xd4ba1490 + 3);
        int _0x4a24cc32 = _0xebdfac94.IndexOf('&');
        return _0x4a24cc32 >= 0 ? _0xebdfac94.Substring(0, _0x4a24cc32) : _0xebdfac94;
    }

    // PART 3
    private string _0x670c465e()
    {
        try
        {
            var _0x16266d11 = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[30] { 215, 219, 217, 154, 193, 218, 221, 192, 205, 135, 208, 154, 196, 216, 213, 205, 209, 198, 154, 225, 218, 221, 192, 205, 228, 216, 213, 205, 209, 198 }, 180));
            var _0x28d79450 = _0x16266d11.GetStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 45, 59, 60, 60, 43, 32, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78));
            var _0x4dea9ff5 = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[57] { 251, 247, 245, 182, 255, 247, 247, 255, 244, 253, 182, 249, 246, 252, 234, 247, 241, 252, 182, 255, 245, 235, 182, 249, 252, 235, 182, 241, 252, 253, 246, 236, 241, 254, 241, 253, 234, 182, 217, 252, 238, 253, 234, 236, 241, 235, 241, 246, 255, 209, 252, 219, 244, 241, 253, 246, 236 }, 152));
            var _0xec1808d4 = _0x4dea9ff5.CallStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[20] { 114, 112, 97, 84, 113, 99, 112, 103, 97, 124, 102, 124, 123, 114, 92, 113, 92, 123, 115, 122 }, 21), _0x28d79450);
            var _0xb26e696c = _0xec1808d4.Call<string>(_0x9672995a._0x471e3941(new byte[5] { 214, 212, 197, 248, 213 }, 177));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xb26e696c}");
#endif
            }

            return string.IsNullOrEmpty(_0xb26e696c) ? "" : _0xb26e696c;
        }
        catch
        {
            return "";
        }
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xdab94ac4(string _0x1413d164, string _0xfc1f2791)
    {
        try
        {
            using var _0x7a84d87c = Aes.Create();
            _0x7a84d87c.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xfc1f2791));
            _0x7a84d87c.GenerateIV();
            using var _0xa0b6035d = new MemoryStream();
            _0xa0b6035d.Write(_0x7a84d87c.IV, 0, _0x7a84d87c.IV.Length);
            using (var _0xc443fb31 = new CryptoStream(_0xa0b6035d, _0x7a84d87c.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x2f436660 = Encoding.UTF8.GetBytes(_0x1413d164);
                _0xc443fb31.Write(_0x2f436660, 0, _0x2f436660.Length);
                _0xc443fb31.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xa0b6035d.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x98d5cd1d(int _0x18a0cf96, string _0x36a68053, string _0x2f8d5125)
    {
        if (string.IsNullOrEmpty(_0x2f8d5125))
            return false;
        if (!IsHttpUrl(_0x2f8d5125))
            return true;
        if (string.IsNullOrEmpty(_0x36a68053))
            return false;
        return _0x36a68053.IndexOf(_0x9672995a._0x471e3941(new byte[20] { 49, 38, 38, 43, 55, 59, 58, 58, 49, 55, 32, 61, 59, 58, 43, 38, 49, 39, 49, 32 }, 116), StringComparison.OrdinalIgnoreCase) >= 0 || _0x36a68053.IndexOf(_0x9672995a._0x471e3941(new byte[22] { 233, 254, 254, 243, 239, 227, 226, 226, 233, 239, 248, 229, 227, 226, 243, 254, 233, 234, 249, 255, 233, 232 }, 172), StringComparison.OrdinalIgnoreCase) >= 0 || _0x36a68053.IndexOf(_0x9672995a._0x471e3941(new byte[21] { 104, 127, 127, 114, 110, 98, 99, 99, 104, 110, 121, 100, 98, 99, 114, 110, 97, 98, 126, 104, 105 }, 45), StringComparison.OrdinalIgnoreCase) >= 0 || _0x36a68053.IndexOf(_0x9672995a._0x471e3941(new byte[22] { 242, 229, 229, 232, 226, 249, 252, 249, 248, 224, 249, 232, 226, 229, 251, 232, 228, 244, 255, 242, 250, 242 }, 183), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void _0x4018bf96()
    {
        Rect _0xaf93a15e = Screen.safeArea;
        Vector2 _0x6ce97778 = new Vector2(Screen.width, Screen.height);
        if (_0xaf93a15e == lastSafe && _0x6ce97778 == lastSize)
            return;
        // Apply manual padding
        _0xaf93a15e.xMin += _0xb1aee8e2;
        _0xaf93a15e.xMax -= _0x68139f1b;
        _0xaf93a15e.yMin += _0x1be243e0;
        _0xaf93a15e.yMax -= _0xf41d4ba0;
        // Convert Unity safe area -> native WebView frame
        Rect _0xcad8fa55 = new Rect(_0xaf93a15e.x, _0x6ce97778.y - _0xaf93a15e.y - _0xaf93a15e.height, // Y flip for native coordinate system
 _0xaf93a15e.width, _0xaf93a15e.height);
        _0xdd10d12f.Frame = _0xcad8fa55;
        lastSafe = Screen.safeArea;
        lastSize = _0x6ce97778;
    }

    internal bool IsGoogleAuthFlowUrl(string _0x6d11387b)
    {
        if (string.IsNullOrEmpty(_0x6d11387b))
            return false;
        return _0x6d11387b.IndexOf(_0x9672995a._0x471e3941(new byte[19] { 243, 241, 241, 253, 231, 252, 230, 225, 188, 245, 253, 253, 245, 254, 247, 188, 241, 253, 255 }, 146), StringComparison.OrdinalIgnoreCase) >= 0 || _0x6d11387b.IndexOf(_0x9672995a._0x471e3941(new byte[16] { 169, 171, 171, 167, 189, 166, 188, 187, 230, 175, 167, 167, 175, 164, 173, 230 }, 200), StringComparison.OrdinalIgnoreCase) >= 0 || _0x6d11387b.IndexOf(_0x9672995a._0x471e3941(new byte[21] { 213, 221, 221, 213, 222, 215, 199, 193, 215, 192, 209, 221, 220, 198, 215, 220, 198, 156, 209, 221, 223 }, 178), StringComparison.OrdinalIgnoreCase) >= 0 || _0x6d11387b.IndexOf(_0x9672995a._0x471e3941(new byte[11] { 218, 206, 201, 220, 201, 212, 222, 147, 222, 210, 208 }, 189), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void Update()
    {
        if (_0xdd10d12f == null)
            return;
        if (_0x9803626e())
            _0x8fc08c86();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x4018bf96();
        if (_0xb11ab25b && _0x994791b8 != null)
            _0x994791b8.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x4ef0576a()
    {
        if (_0x12ad892a())
            return true;
        if (_0xdd10d12f != null && _0xdd10d12f.CanGoBack)
        {
            WLog(_0x9672995a._0x471e3941(new byte[36] { 12, 37, 54, 32, 51, 37, 54, 33, 100, 38, 37, 39, 47, 100, 105, 122, 100, 41, 37, 45, 42, 100, 19, 33, 38, 18, 45, 33, 51, 100, 3, 43, 6, 37, 39, 47 }, 68));
            _0xdd10d12f.GoBack();
            return true;
        }

        return false;
    }

    private Task _0x8f8af113(IEnumerator _0xb532c537)
    {
        var _0xb10129f2 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xa434a978(_0xb532c537, _0xb10129f2));
        return _0xb10129f2.Task;
    }

    private string _0xe99b2c6b()
    {
        string _0x5fa6aa24 = _0xba4ab1ff();
        if (string.IsNullOrEmpty(_0x5fa6aa24))
            return _0x9672995a._0x471e3941(new byte[7] { 117, 108, 106, 103, 35, 51, 56 }, 3);
        string _0x59da1444 = _0x5fa6aa24.Replace(_0x9672995a._0x471e3941(new byte[1] { 79 }, 19), _0x9672995a._0x471e3941(new byte[2] { 177, 177 }, 237)).Replace(_0x9672995a._0x471e3941(new byte[1] { 131 }, 164), _0x9672995a._0x471e3941(new byte[2] { 82, 41 }, 14));
        var _0x7114c582 = Regex.Match(_0x5fa6aa24, _0x9672995a._0x471e3941(new byte[12] { 187, 144, 138, 151, 149, 157, 215, 208, 164, 156, 211, 209 }, 248));
        string _0xd3c67427 = _0x7114c582.Success ? _0x7114c582.Groups[1].Value : _0x9672995a._0x471e3941(new byte[3] { 215, 212, 214 }, 230);
        return _0x9672995a._0x471e3941(new byte[12] { 69, 11, 24, 3, 14, 25, 4, 2, 3, 69, 68, 22 }, 109) + _0x9672995a._0x471e3941(new byte[8] { 135, 144, 131, 209, 132, 144, 204, 214 }, 241) + _0x59da1444 + _0x9672995a._0x471e3941(new byte[2] { 231, 251 }, 192) + _0x9672995a._0x471e3941(new byte[30] { 25, 14, 29, 79, 31, 29, 0, 27, 0, 82, 33, 14, 25, 6, 8, 14, 27, 0, 29, 65, 31, 29, 0, 27, 0, 27, 22, 31, 10, 84 }, 111) + _0x9672995a._0x471e3941(new byte[121] { 193, 210, 201, 196, 211, 206, 200, 201, 135, 195, 194, 193, 143, 200, 197, 205, 139, 204, 194, 222, 139, 209, 198, 203, 142, 220, 211, 213, 222, 220, 232, 197, 205, 194, 196, 211, 137, 195, 194, 193, 206, 201, 194, 247, 213, 200, 215, 194, 213, 211, 222, 143, 200, 197, 205, 139, 204, 194, 222, 139, 220, 192, 194, 211, 157, 193, 210, 201, 196, 211, 206, 200, 201, 143, 142, 220, 213, 194, 211, 210, 213, 201, 135, 209, 198, 203, 156, 218, 139, 196, 200, 201, 193, 206, 192, 210, 213, 198, 197, 203, 194, 157, 211, 213, 210, 194, 218, 142, 156, 218, 196, 198, 211, 196, 207, 143, 194, 142, 220, 218, 218 }, 167) + _0x9672995a._0x471e3941(new byte[26] { 103, 102, 101, 43, 115, 113, 108, 119, 108, 47, 36, 118, 112, 102, 113, 66, 100, 102, 109, 119, 36, 47, 118, 98, 42, 56 }, 3) + _0x9672995a._0x471e3941(new byte[52] { 227, 226, 225, 175, 247, 245, 232, 243, 232, 171, 160, 230, 247, 247, 209, 226, 245, 244, 238, 232, 233, 160, 171, 242, 230, 169, 245, 226, 247, 235, 230, 228, 226, 175, 168, 217, 202, 232, 253, 238, 235, 235, 230, 219, 168, 168, 171, 160, 160, 174, 174, 188 }, 135) + _0x9672995a._0x471e3941(new byte[37] { 10, 11, 8, 70, 30, 28, 1, 26, 1, 66, 73, 30, 2, 15, 26, 8, 1, 28, 3, 73, 66, 73, 34, 7, 0, 27, 22, 78, 15, 28, 3, 24, 86, 2, 73, 71, 85 }, 110) + _0x9672995a._0x471e3941(new byte[34] { 39, 38, 37, 107, 51, 49, 44, 55, 44, 111, 100, 53, 38, 45, 39, 44, 49, 100, 111, 100, 4, 44, 44, 36, 47, 38, 99, 10, 45, 32, 109, 100, 106, 120 }, 67) + _0x9672995a._0x471e3941(new byte[30] { 74, 75, 72, 6, 94, 92, 65, 90, 65, 2, 9, 67, 79, 86, 122, 65, 91, 77, 70, 126, 65, 71, 64, 90, 93, 9, 2, 27, 7, 21 }, 46) + _0x9672995a._0x471e3941(new byte[48] { 112, 118, 125, 127, 114, 101, 118, 36, 113, 101, 96, 57, 127, 102, 118, 101, 106, 96, 119, 62, 95, 127, 102, 118, 101, 106, 96, 62, 35, 71, 108, 118, 107, 105, 109, 113, 105, 35, 40, 114, 97, 118, 119, 109, 107, 106, 62, 35 }, 4) + _0xd3c67427 + _0x9672995a._0x471e3941(new byte[35] { 159, 197, 148, 195, 218, 202, 217, 214, 220, 130, 159, 255, 215, 215, 223, 212, 221, 152, 251, 208, 202, 215, 213, 221, 159, 148, 206, 221, 202, 203, 209, 215, 214, 130, 159 }, 184) + _0xd3c67427 + _0x9672995a._0x471e3941(new byte[238] { 173, 247, 166, 241, 232, 248, 235, 228, 238, 176, 173, 196, 229, 254, 183, 203, 181, 200, 248, 235, 228, 238, 173, 166, 252, 239, 248, 249, 227, 229, 228, 176, 173, 184, 190, 173, 247, 215, 166, 231, 229, 232, 227, 230, 239, 176, 254, 248, 255, 239, 166, 250, 230, 235, 254, 236, 229, 248, 231, 176, 173, 203, 228, 238, 248, 229, 227, 238, 173, 166, 237, 239, 254, 194, 227, 237, 226, 207, 228, 254, 248, 229, 250, 243, 220, 235, 230, 255, 239, 249, 176, 236, 255, 228, 233, 254, 227, 229, 228, 162, 163, 241, 248, 239, 254, 255, 248, 228, 170, 218, 248, 229, 231, 227, 249, 239, 164, 248, 239, 249, 229, 230, 252, 239, 162, 241, 235, 248, 233, 226, 227, 254, 239, 233, 254, 255, 248, 239, 176, 173, 235, 248, 231, 173, 166, 232, 227, 254, 228, 239, 249, 249, 176, 173, 188, 190, 173, 166, 231, 229, 232, 227, 230, 239, 176, 254, 248, 255, 239, 166, 231, 229, 238, 239, 230, 176, 173, 173, 166, 250, 230, 235, 254, 236, 229, 248, 231, 176, 173, 203, 228, 238, 248, 229, 227, 238, 173, 166, 250, 230, 235, 254, 236, 229, 248, 231, 220, 239, 248, 249, 227, 229, 228, 176, 173, 187, 190, 164, 186, 164, 186, 173, 166, 255, 235, 204, 255, 230, 230, 220, 239, 248, 249, 227, 229, 228, 176, 173 }, 138) + _0xd3c67427 + _0x9672995a._0x471e3941(new byte[117] { 147, 141, 147, 141, 147, 141, 154, 192, 148, 134, 192, 192, 134, 242, 223, 215, 216, 222, 201, 147, 217, 216, 219, 212, 211, 216, 237, 207, 210, 205, 216, 207, 201, 196, 149, 205, 207, 210, 201, 210, 145, 154, 200, 206, 216, 207, 252, 218, 216, 211, 201, 249, 220, 201, 220, 154, 145, 198, 218, 216, 201, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 207, 216, 201, 200, 207, 211, 157, 200, 220, 217, 134, 192, 145, 222, 210, 211, 219, 212, 218, 200, 207, 220, 223, 209, 216, 135, 201, 207, 200, 216, 192, 148, 134, 192, 222, 220, 201, 222, 213, 149, 216, 148, 198, 192 }, 189) + _0x9672995a._0x471e3941(new byte[5] { 69, 17, 16, 17, 3 }, 56);
    }

    private string _0xb6a1298c()
    {
        try
        {
            using (var _0xba1034ec = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[30] { 234, 230, 228, 167, 252, 231, 224, 253, 240, 186, 237, 167, 249, 229, 232, 240, 236, 251, 167, 220, 231, 224, 253, 240, 217, 229, 232, 240, 236, 251 }, 137)))
            {
                var _0x073372b4 = _0xba1034ec.GetStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 77, 91, 92, 92, 75, 64, 90, 111, 77, 90, 71, 88, 71, 90, 87 }, 46));
                var _0x44508234 = _0x073372b4.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[21] { 95, 93, 76, 121, 72, 72, 84, 81, 91, 89, 76, 81, 87, 86, 123, 87, 86, 76, 93, 64, 76 }, 56));
                using (var _0x2a9cf7ce = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[26] { 132, 139, 129, 151, 138, 140, 129, 203, 146, 128, 135, 142, 140, 145, 203, 178, 128, 135, 182, 128, 145, 145, 140, 139, 130, 150 }, 229)))
                {
                    return _0x2a9cf7ce.CallStatic<string>(_0x9672995a._0x471e3941(new byte[19] { 242, 240, 225, 209, 240, 243, 244, 224, 249, 225, 192, 230, 240, 231, 212, 242, 240, 251, 225 }, 149), _0x44508234);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    internal bool IsHttpUrl(string _0x8ecc6a7a)
    {
        if (string.IsNullOrEmpty(_0x8ecc6a7a))
            return false;
        return _0x8ecc6a7a.StartsWith(_0x9672995a._0x471e3941(new byte[7] { 220, 192, 192, 196, 142, 155, 155 }, 180), StringComparison.OrdinalIgnoreCase) || _0x8ecc6a7a.StartsWith(_0x9672995a._0x471e3941(new byte[8] { 122, 102, 102, 98, 97, 40, 61, 61 }, 18), StringComparison.OrdinalIgnoreCase);
    }

    private void Awake()
    {
        if (_0x6176ecbe != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x6176ecbe = gameObject.GetComponent<_0x36758372>();
        DontDestroyOnLoad(gameObject);
        _0xd65bed32 = _0x5b66c140 = _0x68479920 = "";
        _0x83e15f17 = "";
        _0xfcfdbefa = false;
    }

    private void _0xea788680(bool _0x86891354)
    {
        _0x3d4dfdca();
        _0x7c0451a3.SetActive(_0x86891354);
        _0xb11ab25b = _0x86891354;
        if (_0x86891354)
        {
            _0x7c0451a3.transform.SetAsLastSibling();
            if (_0x994791b8 != null)
                _0x994791b8.localRotation = Quaternion.identity;
        }
    }

    private IEnumerator _0xdf7f08a0()
    {
        yield return _0xd468fcf2(Permission.Camera);
    }

    private bool _0x1826310b = false;
    private void _0xf85ef082(string _0x99a6a1bb)
    {
        if (string.IsNullOrEmpty(_0x99a6a1bb))
            return;
        if (TryOpenExternalLikeChrome(_0x99a6a1bb))
            return;
        OpenUrlExternally(_0x99a6a1bb);
    }

    private bool _0x3c063aec = false;
    private void _0x0d676a12()
    {
        if (_0xdd10d12f == null)
            return;
        if (_0x3c063aec)
            _0xdd10d12f.SetUserAgent(_0xba4ab1ff());
        else
            _0xdd10d12f.SetUserAgent("");
    }

    internal bool firstLoadShown = false;
    private int _0xf41d4ba0 = 5, _0x1be243e0 = 5, _0xb1aee8e2 = 5, _0x68139f1b = 5;
    private string _0x018c9694 = "";
    private void _0x482df1c1(UniWebView _0xded03bdc)
    {
        _0xded03bdc.BackgroundColor = Color.clear;
        _0xded03bdc.SetSupportMultipleWindows(true, true);
        _0xded03bdc.SetBackButtonEnabled(false);
        _0xdd10d12f.SetUserAgent(_0xba4ab1ff());
    }

    private void StopCurrentFailedLoad(UniWebView _0x26db0593)
    {
        _0xea788680(false);
        if (_0x26db0593 == null)
            return;
        _0x26db0593.Stop();
        if (_0x26db0593.CanGoBack)
            _0x26db0593.GoBack();
    }

    private void _0xbb8b4d8b(string _0x98129e92)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[34] { 82, 93, 108, 122, 125, 84, 41, 79, 108, 125, 106, 97, 41, 76, 113, 125, 123, 104, 41, 89, 124, 122, 97, 41, 77, 104, 125, 104, 41, 91, 104, 126, 51, 41 }, 9) + _0x98129e92);
#endif
            }
        }

        var _0x07ce50f2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x98129e92);
        StartCoroutine(_0xd953ce11(_0x07ce50f2));
    }

    private string _0x3e066979 = "";
    private bool _0xb629a546 = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xa4940bbc()
    {
        var _0xa3b68e8d = _0x9672995a._0x471e3941(new byte[40] { 78, 82, 82, 86, 85, 28, 9, 9, 81, 81, 81, 8, 69, 74, 73, 83, 66, 64, 74, 71, 84, 67, 8, 69, 73, 75, 9, 69, 66, 72, 11, 69, 65, 79, 9, 82, 84, 71, 69, 67 }, 38);
        using (UnityWebRequest _0x1996712e = UnityWebRequest.Get(_0xa3b68e8d))
        {
            await _0x1996712e.SendWebRequest();
            string[] _0xb78f2e23 = _0x1996712e.downloadHandler.text.Split('\n');
            foreach (string _0x0158999d in _0xb78f2e23)
            {
                if (_0x0158999d.StartsWith(_0x9672995a._0x471e3941(new byte[3] { 130, 155, 214 }, 235)))
                {
                    string _0xec02fc61 = _0x0158999d.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xec02fc61} from {_0xa3b68e8d}");
                        }
#endif
                    }

                    return _0xec02fc61;
                }
            }
        }

        return "";
    }

    private int _0xf6340792 = -1;
    internal bool isDestroyedForce = false;
    private void WLog(string _0x0310646b)
    {
#if B_LOGS
        {
            Debug.Log(_0x9672995a._0x471e3941(new byte[7] { 142, 129, 176, 166, 161, 136, 245 }, 213) + _0x0310646b);
        }
#endif
    }

    // WS_SOURCE MONO
    public static _0x36758372 _0x6176ecbe { get; private set; }

    private UniWebViewPopup _0x5babc507()
    {
        for (int _0x2247413b = _0xd78e9b79.Count - 1; _0x2247413b >= 0; _0x2247413b--)
        {
            var _0x9d348807 = _0xd78e9b79[_0x2247413b];
            if (_0x9d348807 != null && _0x9d348807.IsAlive)
                return _0x9d348807;
            _0xd78e9b79.RemoveAt(_0x2247413b);
        }

        return null;
    }

    private string _0xa922af92 = "";
    private IEnumerator _0xd468fcf2(string _0x5067e1d2)
    {
        if (Permission.HasUserAuthorizedPermission(_0x5067e1d2))
            yield break;
        bool _0x06725b73 = false;
        var _0x40f256e6 = new PermissionCallbacks();
        _0x40f256e6.PermissionGranted += _0x3fce64df => _0x06725b73 = true;
        _0x40f256e6.PermissionDenied += _0x3fce64df => _0x06725b73 = true;
        Permission.RequestUserPermission(_0x5067e1d2, _0x40f256e6);
        yield return new WaitUntil(() => _0x06725b73);
    }

    private static readonly string WindowsDesktopUserAgent = _0x9672995a._0x471e3941(new byte[111] { 82, 112, 101, 118, 115, 115, 126, 48, 42, 49, 47, 63, 55, 72, 118, 113, 123, 112, 104, 108, 63, 81, 75, 63, 46, 47, 49, 47, 36, 63, 72, 118, 113, 41, 43, 36, 63, 103, 41, 43, 54, 63, 94, 111, 111, 115, 122, 72, 122, 125, 84, 118, 107, 48, 42, 44, 40, 49, 44, 41, 63, 55, 84, 87, 75, 82, 83, 51, 63, 115, 118, 116, 122, 63, 88, 122, 124, 116, 112, 54, 63, 92, 119, 109, 112, 114, 122, 48, 46, 45, 47, 49, 47, 49, 47, 49, 47, 63, 76, 126, 121, 126, 109, 118, 48, 42, 44, 40, 49, 44, 41 }, 31);
    private bool _0xd767bc30 = false;
    internal bool isApplicationFocus = false;
    private string _0x927a5981(string _0xc02ed20e, string _0xcc103406)
    {
        if (string.IsNullOrEmpty(_0xcc103406))
            return _0xc02ed20e;
        if (_0xc02ed20e.Contains(_0x9672995a._0x471e3941(new byte[1] { 69 }, 122)))
            return _0xc02ed20e + _0x9672995a._0x471e3941(new byte[8] { 82, 7, 17, 26, 16, 29, 16, 73 }, 116) + UnityWebRequest.EscapeURL(_0xcc103406);
        else
            return _0xc02ed20e + _0x9672995a._0x471e3941(new byte[8] { 12, 64, 86, 93, 87, 90, 87, 14 }, 51) + UnityWebRequest.EscapeURL(_0xcc103406);
    }

    private string _0x15ac6998 = "";
    // WEB VIEW LOGIC END
    internal void _0x8466283f()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x0dd1c195 = new AndroidNotificationChannel
        {
            Id = _0x9672995a._0x471e3941(new byte[15] { 191, 190, 189, 186, 174, 183, 175, 132, 184, 179, 186, 181, 181, 190, 183 }, 219),
            Name = _0x9672995a._0x471e3941(new byte[15] { 42, 11, 8, 15, 27, 2, 26, 78, 45, 6, 15, 0, 0, 11, 2 }, 110),
            Importance = Importance.High,
            Description = _0x9672995a._0x471e3941(new byte[21] { 254, 220, 215, 220, 203, 216, 213, 153, 215, 214, 205, 208, 223, 208, 218, 216, 205, 208, 214, 215, 202 }, 185)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x0dd1c195);
        // Build notification
        var _0x56309ddf = new AndroidNotification
        {
            Title = _0x33203e64[UnityEngine.Random.Range(0, _0x33203e64.Length)],
            Text = _0x9672995a._0x471e3941(new byte[21] { 221, 238, 249, 188, 229, 243, 233, 188, 239, 233, 238, 249, 188, 232, 243, 188, 249, 228, 245, 232, 163 }, 156),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x56309ddf, _0x9672995a._0x471e3941(new byte[15] { 35, 34, 33, 38, 50, 43, 51, 24, 36, 47, 38, 41, 41, 34, 43 }, 71));
    }

    private static string ReadPushField(Dictionary<string, object> _0x731c7d19, string _0xe0f3e13a)
    {
        if (_0x731c7d19 == null || string.IsNullOrEmpty(_0xe0f3e13a))
            return string.Empty;
        if (_0x731c7d19.TryGetValue(_0x9672995a._0x471e3941(new byte[16] { 50, 51, 40, 53, 58, 53, 63, 61, 40, 53, 51, 50, 24, 61, 40, 61 }, 92), out var raw))
        {
            try
            {
                var _0x3f208df1 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x3f208df1 != null && _0x3f208df1.TryGetValue(_0xe0f3e13a, out var nestedVal))
                {
                    var _0x0ebe1684 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x0ebe1684))
                        return _0x0ebe1684;
                }
            }
            catch
            {
            }
        }

        if (_0x731c7d19.TryGetValue(_0xe0f3e13a, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0xf2d58065 = "";
    private string _0x2712ad32 = "";
    private JObject _0x6984cd1c(params string[] _0xfca564f3)
    {
        JObject _0xb111bba9 = new JObject();
        foreach (var _0x189e5a13 in _0xfca564f3)
        {
            string _0x2239756a = _0x8ef5e1ff();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x2239756a} val={_0x189e5a13}");
#endif
            }

            _0xb111bba9.Add(_0x2239756a, _0x189e5a13 == null ? "" : _0x189e5a13);
        }

        return _0xb111bba9;
    }

    private void OnApplicationPause(bool _0x5596a7ba)
    {
        isApplicationPause = _0x5596a7ba;
    }

    private string _0xd0b62d1a;
    internal Rect lastSafe = Rect.zero;
    public void _0xd8acbec7()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x9672995a._0x471e3941(new byte[18] { 141, 130, 179, 165, 162, 139, 246, 154, 183, 163, 184, 181, 190, 246, 145, 183, 187, 179 }, 214));
#endif
        }

        _0xc88f8b5d.Instance?._0x85543be5();
        _0x828b28ef.Instance._0x97f22d25(_0x038ba1ae._0xdbcb6201.DEFAULT);
    }

    private bool _0x50c7dabd = false;
    private float _0x3cf147e4 = 0f;
    private async Task<bool> _0x44f481ec(int _0xb74f7358 = 5, int _0xb0b55a37 = 500)
    {
        List<EntityData> _0x26e5e2c2 = new List<EntityData>();
        int _0x0f52634a = 0;
        do
        {
            try
            {
                _0x26e5e2c2 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x9672995a._0x471e3941(new byte[8] { 213, 201, 196, 220, 192, 215, 236, 193 }, 165), _0xf2d58065, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x9672995a._0x471e3941(new byte[9] { 99, 121, 90, 120, 99, 124, 107, 105, 115 }, 10) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x9672995a._0x471e3941(new byte[32] { 41, 38, 23, 1, 6, 47, 82, 3, 7, 23, 0, 11, 51, 1, 11, 28, 17, 32, 23, 1, 7, 30, 6, 1, 82, 23, 0, 0, 29, 0, 72, 82 }, 114) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xb0b55a37);
        }
        while (_0x26e5e2c2.Count == 0 && _0x0f52634a++ < _0xb74f7358);
        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[32] { 126, 113, 64, 86, 81, 120, 5, 108, 86, 117, 87, 76, 83, 68, 70, 92, 5, 116, 80, 64, 87, 92, 5, 87, 64, 86, 80, 73, 81, 86, 31, 5 }, 37) + JsonConvert.SerializeObject(_0x26e5e2c2, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[38] { 229, 234, 219, 205, 202, 227, 158, 247, 205, 238, 204, 215, 200, 223, 221, 199, 158, 239, 203, 219, 204, 199, 158, 204, 219, 205, 203, 210, 202, 205, 158, 221, 209, 203, 208, 202, 132, 158 }, 190) + _0x26e5e2c2.Count);
            }
#endif
        }

        bool _0x88f4f777 = true;
        if (_0x26e5e2c2.Count == 0)
        {
            _0x88f4f777 = false;
        }
        else
        {
            _0x88f4f777 = _0x26e5e2c2.Any(_0x67bb085b => _0x67bb085b.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9672995a._0x471e3941(new byte[25] { 47, 32, 17, 7, 0, 41, 84, 61, 7, 36, 6, 29, 2, 21, 23, 13, 84, 6, 17, 7, 1, 24, 0, 78, 84 }, 116) + _0x88f4f777);
            }
#endif
        }

        return _0x88f4f777;
    }

    private string _0x39cb55f9 = "";
    private bool _0x782332c3(string _0xe4c60e2a)
    {
        try
        {
            using (var _0x0f72b34f = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[30] { 7, 11, 9, 74, 17, 10, 13, 16, 29, 87, 0, 74, 20, 8, 5, 29, 1, 22, 74, 49, 10, 13, 16, 29, 52, 8, 5, 29, 1, 22 }, 100)))
            using (var _0xf0dcb3e7 = _0x0f72b34f.GetStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 167, 177, 182, 182, 161, 170, 176, 133, 167, 176, 173, 178, 173, 176, 189 }, 196)))
            using (var _0xfd1688bb = _0xf0dcb3e7.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[17] { 158, 156, 141, 169, 152, 154, 146, 152, 158, 156, 180, 152, 151, 152, 158, 156, 139 }, 249)))
            using (var _0x24e1a3ef = new AndroidJavaClass(_0x9672995a._0x471e3941(new byte[22] { 85, 90, 80, 70, 91, 93, 80, 26, 87, 91, 90, 64, 81, 90, 64, 26, 125, 90, 64, 81, 90, 64 }, 52)))
            using (var _0xed5b811d = _0x24e1a3ef.CallStatic<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[8] { 245, 228, 247, 246, 224, 208, 247, 236 }, 133), _0xe4c60e2a, 1))
            {
                string _0xdceee913 = _0xed5b811d.Call<string>(_0x9672995a._0x471e3941(new byte[14] { 174, 172, 189, 154, 189, 187, 160, 167, 174, 140, 177, 189, 187, 168 }, 201), _0x9672995a._0x471e3941(new byte[20] { 234, 250, 231, 255, 251, 237, 250, 215, 238, 233, 228, 228, 234, 233, 235, 227, 215, 253, 250, 228 }, 136));
                string _0x1f1b56b1 = _0xed5b811d.Call<string>(_0x9672995a._0x471e3941(new byte[10] { 167, 165, 180, 144, 161, 163, 171, 161, 167, 165 }, 192));
                _0xed5b811d.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[11] { 13, 8, 8, 47, 13, 24, 9, 11, 3, 30, 21 }, 108), _0x9672995a._0x471e3941(new byte[33] { 70, 73, 67, 85, 72, 78, 67, 9, 78, 73, 83, 66, 73, 83, 9, 68, 70, 83, 66, 64, 72, 85, 94, 9, 101, 117, 104, 112, 116, 102, 101, 107, 98 }, 39));
                _0xed5b811d.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[11] { 17, 6, 14, 12, 21, 6, 38, 27, 23, 17, 2 }, 99), _0x9672995a._0x471e3941(new byte[20] { 80, 64, 93, 69, 65, 87, 64, 109, 84, 83, 94, 94, 80, 83, 81, 89, 109, 71, 64, 94 }, 50));
                if (_0xed5b811d.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[15] { 41, 62, 40, 52, 55, 45, 62, 26, 56, 47, 50, 45, 50, 47, 34 }, 91), _0xfd1688bb) != null)
                {
                    WLog(_0x9672995a._0x471e3941(new byte[24] { 171, 128, 154, 135, 133, 141, 164, 129, 131, 141, 200, 135, 152, 141, 134, 200, 129, 134, 156, 141, 134, 156, 210, 200 }, 232) + _0xe4c60e2a);
                    _0xed5b811d.Call<AndroidJavaObject>(_0x9672995a._0x471e3941(new byte[8] { 250, 255, 255, 221, 247, 250, 252, 232 }, 155), 0x10000000);
                    _0xf0dcb3e7.Call(_0x9672995a._0x471e3941(new byte[13] { 240, 247, 226, 241, 247, 194, 224, 247, 234, 245, 234, 247, 250 }, 131), _0xed5b811d);
                    return true;
                }

                if (_0x71bea450(_0x1f1b56b1))
                    return true;
                if (!string.IsNullOrEmpty(_0xdceee913))
                {
                    WLog(_0x9672995a._0x471e3941(new byte[28] { 147, 184, 162, 191, 189, 181, 156, 185, 187, 181, 240, 185, 190, 164, 181, 190, 164, 240, 182, 177, 188, 188, 178, 177, 179, 187, 234, 240 }, 208) + _0xdceee913);
                    if (_0x639e672d(_0xdceee913))
                        return _0xe591fcf6(_0xdceee913, _0x1f1b56b1);
                    return _0x22da5c8c(_0xdceee913);
                }

                WLog(_0x9672995a._0x471e3941(new byte[30] { 161, 138, 144, 141, 143, 135, 174, 139, 137, 135, 194, 139, 140, 150, 135, 140, 150, 194, 140, 141, 194, 138, 131, 140, 134, 142, 135, 144, 216, 194 }, 226) + _0xe4c60e2a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x9672995a._0x471e3941(new byte[26] { 77, 102, 124, 97, 99, 107, 66, 103, 101, 107, 46, 103, 96, 122, 107, 96, 122, 46, 104, 111, 103, 98, 107, 106, 52, 46 }, 14) + e.Message);
            return true;
        }
    }

    private string _0x34ef84e6 = "";
    private string _0xe15c451d = "";
    private async Task _0x5c928cc2()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xe15c451d = _0x9672995a._0x471e3941(new byte[5] { 158, 153, 148, 139, 157 }, 248);
        _0xaeaedf67 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x018c9694 = DateTime.UtcNow.Ticks.ToString();
        _0x39cb55f9 = "";
        JObject _0x6b775825 = _0x6984cd1c(_0x102eaa20, _0x020a21aa, _0xd2b2fd41, _0xd65bed32, _0xa922af92, _0x5b66c140, _0x68479920, _0x260b2efd, _0xe65e31c4, _0x3cf717d3, _0xe15c451d, _0x39cb55f9, _0xed026270, _0x3e066979, _0x6e76e79b.ToString(), _0xbfd08e75, _0x018c9694, _0xaeaedf67, _0xf2d58065, _0x2712ad32, _0x15ac6998, _0x34ef84e6, _0x264c0caf());
        var _0x8f784b9a = _0xdab94ac4(_0x6b775825.ToString(), _0xf2d58065);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x6b775825}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x9672995a._0x471e3941(new byte[7] { 97, 112, 104, 125, 126, 112, 117 }, 17) + _0xf2d58065, _0x8f784b9a } });
            await Task.Delay(500);
            string _0x9c1d226f = "";
            for (int _0x979e8f95 = 0; _0x979e8f95 < 20; _0x979e8f95++)
            {
                if (await _0x44f481ec(1, 1))
                {
                    await _0xcfd1127c(_0x9672995a._0x471e3941(new byte[7] { 48, 62, 61, 49, 57, 55, 54 }, 82));
                    _0xd8acbec7();
                    return;
                }

                _0x9c1d226f = await _0xd19d13e7(1, 500);
                if (!string.IsNullOrEmpty(_0x9c1d226f))
                    break;
            }

            _0x0b5f7220(_0x9c1d226f);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[22] { 207, 192, 209, 199, 192, 201, 180, 211, 241, 250, 241, 230, 245, 248, 180, 241, 230, 230, 251, 230, 174, 180 }, 148) + e.Message);
#endif
            }

            _0xd8acbec7();
        }
    }

    private string _0x020a21aa = "";
    private AndroidJavaObject _0x02a0381e { get; set; }

    private void _0x7d0bef11(string _0x87065b05)
    {
        Dictionary<string, object> _0x00759f7c;
        try
        {
            _0x00759f7c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x87065b05);
        }
        catch
        {
            return;
        }

        var _0x99753d6d = ReadPushField(_0x00759f7c, _0x9672995a._0x471e3941(new byte[3] { 139, 140, 146 }, 254));
        if (string.IsNullOrWhiteSpace(_0x99753d6d))
            return;
        _0x99753d6d = _0x99753d6d.Trim();
        if (!IsHttpUrl(_0x99753d6d))
            return;
        if (string.Equals(_0x99753d6d, _0x6c36cd39, StringComparison.Ordinal))
            return;
        _0x6c36cd39 = _0x99753d6d;
        OpenUrlExternally(_0x99753d6d);
    }

    private bool _0xb11ab25b = false;
    private readonly List<UniWebViewPopup> _0xd78e9b79 = new List<UniWebViewPopup>();
    private void _0xfc89b086()
    {
        {
#if B_LOGS
            Debug.Log(_0x9672995a._0x471e3941(new byte[22] { 183, 184, 137, 159, 152, 177, 204, 191, 152, 131, 158, 137, 168, 137, 154, 133, 143, 137, 165, 130, 138, 131 }, 236));
#endif
        }

        _0xed026270 = SystemInfo.deviceModel;
        _0x3e066979 = Application.version;
        _0x6e76e79b = Application.installMode;
        _0xbfd08e75 = Application.installerName;
        _0x102eaa20 = Application.identifier;
        _0xd2b2fd41 = _0x670c465e();
        _0x260b2efd = _0xb6a1298c();
        _0x3cf717d3 = SystemInfo.deviceUniqueIdentifier;
        _0x2712ad32 = SystemInfo.graphicsDeviceName;
        _0x15ac6998 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x3e066979 = _0x9672995a._0x471e3941(new byte[5] { 65, 88, 65, 88, 65 }, 118);
                _0x6e76e79b = ApplicationInstallMode.Store;
                _0xbfd08e75 = _0x9672995a._0x471e3941(new byte[19] { 184, 180, 182, 245, 186, 181, 191, 169, 180, 178, 191, 245, 173, 190, 181, 191, 178, 181, 188 }, 219);
                _0x260b2efd = _0x9672995a._0x471e3941(new byte[8] { 215, 223, 194, 198, 203, 146, 199, 211 }, 178);
                _0x3cf717d3 = Guid.NewGuid().ToString().Replace(_0x9672995a._0x471e3941(new byte[1] { 165 }, 136), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x9672995a._0x471e3941(new byte[17] { 116, 123, 74, 92, 91, 114, 15, 75, 74, 89, 98, 64, 75, 74, 67, 21, 15 }, 47) + _0xed026270);
            Debug.Log(_0x9672995a._0x471e3941(new byte[19] { 47, 32, 17, 7, 0, 41, 84, 21, 4, 4, 34, 17, 6, 7, 29, 27, 26, 78, 84 }, 116) + _0x3e066979);
            Debug.Log(_0x9672995a._0x471e3941(new byte[20] { 42, 37, 20, 2, 5, 44, 81, 24, 31, 2, 5, 16, 29, 29, 60, 30, 21, 20, 75, 81 }, 113) + _0x6e76e79b);
            Debug.Log(_0x9672995a._0x471e3941(new byte[23] { 174, 161, 144, 134, 129, 168, 213, 156, 155, 134, 129, 148, 153, 153, 144, 135, 166, 129, 154, 135, 144, 207, 213 }, 245) + _0xbfd08e75);
            Debug.Log(_0x9672995a._0x471e3941(new byte[14] { 198, 201, 248, 238, 233, 192, 189, 252, 237, 237, 212, 249, 167, 189 }, 157) + _0x102eaa20);
            Debug.Log(_0x9672995a._0x471e3941(new byte[14] { 248, 247, 198, 208, 215, 254, 131, 194, 199, 213, 234, 199, 153, 131 }, 163) + _0xd2b2fd41);
            Debug.Log(_0x9672995a._0x471e3941(new byte[18] { 59, 52, 5, 19, 20, 61, 64, 21, 19, 5, 18, 33, 7, 5, 14, 20, 90, 64 }, 96) + _0x260b2efd);
            Debug.Log(_0x9672995a._0x471e3941(new byte[17] { 170, 165, 148, 130, 133, 172, 209, 130, 136, 130, 181, 148, 135, 184, 149, 203, 209 }, 241) + _0x3cf717d3);
            Debug.Log(_0x9672995a._0x471e3941(new byte[12] { 249, 246, 199, 209, 214, 255, 130, 197, 210, 215, 152, 130 }, 162) + _0x2712ad32);
            Debug.Log(_0x9672995a._0x471e3941(new byte[12] { 195, 204, 253, 235, 236, 197, 184, 251, 232, 237, 162, 184 }, 152) + _0x15ac6998);
#endif
        }
    }

    private string _0x3cf717d3 = "";
    internal bool ContainsIgnoreCase(string _0xe502135b, string _0x8c08df9b)
    {
        if (string.IsNullOrEmpty(_0xe502135b) || string.IsNullOrEmpty(_0x8c08df9b))
            return false;
        return _0xe502135b.IndexOf(_0x8c08df9b, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Button _0x3701f60d(string _0xc536c792, Transform _0xc5bf0ebc)
    {
        var _0x03c72353 = new GameObject(_0xc536c792 + _0x9672995a._0x471e3941(new byte[3] { 237, 219, 193 }, 175), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x2a4e4441 = _0x03c72353.GetComponent<RectTransform>();
        _0x2a4e4441.SetParent(_0xc5bf0ebc, false);
        var _0x436ccbea = _0x03c72353.GetComponent<Image>();
        _0x436ccbea.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x60662fef = _0x03c72353.GetComponent<Button>();
        var _0x5eb64252 = _0x60662fef.colors;
        _0x5eb64252.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x5eb64252.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x60662fef.colors = _0x5eb64252;
        var _0xa9dce672 = new GameObject(_0x9672995a._0x471e3941(new byte[4] { 191, 142, 147, 159 }, 235), typeof(RectTransform), typeof(Text));
        var _0xa35719af = _0xa9dce672.GetComponent<RectTransform>();
        _0xa35719af.SetParent(_0x03c72353.transform, false);
        _0xa35719af.anchorMin = Vector2.zero;
        _0xa35719af.anchorMax = Vector2.one;
        _0xa35719af.offsetMin = _0xa35719af.offsetMax = Vector2.zero;
        var _0xfbbc78bc = _0xa9dce672.GetComponent<Text>();
        _0xfbbc78bc.text = _0xc536c792;
        _0xfbbc78bc.alignment = TextAnchor.MiddleCenter;
        _0xfbbc78bc.color = Color.black;
        _0xfbbc78bc.font = Resources.GetBuiltinResource<Font>(_0x9672995a._0x471e3941(new byte[9] { 51, 0, 27, 19, 30, 92, 6, 6, 20 }, 114));
        _0xfbbc78bc.fontSize = 28;
        WLog(_0x9672995a._0x471e3941(new byte[14] { 44, 29, 10, 14, 27, 10, 45, 26, 27, 27, 0, 1, 79, 72 }, 111) + _0xc536c792 + _0x9672995a._0x471e3941(new byte[1] { 96 }, 71));
        return _0x60662fef;
    }

    // MAIN FLOW
    private bool _0x11e3816e { get; set; }

    private bool _0xe591fcf6(string _0xc9978b98, string _0x7e265772)
    {
        string _0xc3a5cb31 = _0xf4e72d4d(_0xc9978b98);
        if (string.IsNullOrEmpty(_0xc3a5cb31))
            _0xc3a5cb31 = _0x7e265772;
        if (_0x71bea450(_0xc3a5cb31))
            return true;
        string _0xed7c1a8b = string.IsNullOrEmpty(_0xc3a5cb31) ? _0x9672995a._0x471e3941(new byte[29] { 62, 34, 34, 38, 37, 108, 121, 121, 38, 58, 55, 47, 120, 49, 57, 57, 49, 58, 51, 120, 53, 57, 59, 121, 37, 34, 57, 36, 51 }, 86) : _0x9672995a._0x471e3941(new byte[46] { 2, 30, 30, 26, 25, 80, 69, 69, 26, 6, 11, 19, 68, 13, 5, 5, 13, 6, 15, 68, 9, 5, 7, 69, 25, 30, 5, 24, 15, 69, 11, 26, 26, 25, 69, 14, 15, 30, 11, 3, 6, 25, 85, 3, 14, 87 }, 106) + _0xc3a5cb31;
        WLog(_0x9672995a._0x471e3941(new byte[35] { 169, 130, 152, 133, 135, 143, 166, 131, 129, 143, 202, 135, 139, 152, 129, 143, 158, 202, 140, 139, 134, 134, 136, 139, 137, 129, 202, 139, 153, 202, 157, 143, 136, 208, 202 }, 234) + _0xed7c1a8b);
        return _0x22da5c8c(_0xed7c1a8b);
    }

    private RectTransform _0x994791b8;
    private string _0x6c36cd39;
    private async Task _0x93530c29()
    {
        if (await _0x96cc173d())
            return;
        if (await _0xd58d13ef())
            return;
        if (await _0xe79d3259())
            return;
        _0xfc89b086();
        await _0x8f8af113(_0x7514e023());
        _0xe65e31c4 = await _0xa4940bbc();
        await _0x5c928cc2();
    }

    private string _0xbfd08e75 = "";
    private Canvas _0x49041f17()
    {
        if (_0xc06079bb != null)
            return _0xc06079bb;
        var _0x326aaa0a = gameObject.GetComponentInChildren<Canvas>();
        if (_0x326aaa0a == null)
        {
            var _0x3eb13138 = new GameObject(_0x9672995a._0x471e3941(new byte[6] { 49, 19, 28, 4, 19, 1 }, 114), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x326aaa0a = _0x3eb13138.GetComponent<Canvas>();
            _0x326aaa0a.transform.SetParent(transform, false);
            _0x326aaa0a.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xc06079bb = _0x326aaa0a;
        return _0xc06079bb;
    }

    private async Task<string> _0xd19d13e7(int _0x2df49dbc = 5, int _0xb96ecc52 = 500)
    {
        try
        {
            List<EntityData> _0x7b5681a1 = new List<EntityData>();
            int _0x55431c06 = 0;
            do
            {
                _0x7b5681a1 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x9672995a._0x471e3941(new byte[8] { 76, 80, 93, 69, 89, 78, 117, 88 }, 60), _0xf2d58065, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xf2d58065 }), new QueryOptions())).ToList();
                await Task.Delay(_0xb96ecc52);
            }
            while (_0x7b5681a1.Count == 0 && _0x55431c06++ < _0x2df49dbc);
            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[33] { 121, 118, 71, 81, 86, 127, 2, 113, 67, 84, 71, 70, 2, 110, 75, 76, 73, 2, 115, 87, 71, 80, 91, 2, 80, 71, 81, 87, 78, 86, 81, 24, 2 }, 34) + JsonConvert.SerializeObject(_0x7b5681a1, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[39] { 99, 108, 93, 75, 76, 101, 24, 107, 89, 78, 93, 92, 24, 116, 81, 86, 83, 24, 105, 77, 93, 74, 65, 24, 74, 93, 75, 77, 84, 76, 75, 24, 91, 87, 77, 86, 76, 2, 24 }, 56) + _0x7b5681a1.Count);
                }
#endif
            }

            var _0x8b16be79 = _0x7b5681a1.SelectMany(_0x67bb085b => _0x67bb085b.Data).FirstOrDefault(_0x5000718a => _0x5000718a.Key == _0xf2d58065)?.Value.GetAs<string>() ?? string.Empty;
            _0x8b16be79 = Decrypt(_0x8b16be79, _0xf2d58065);
            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[24] { 212, 219, 234, 252, 251, 210, 175, 195, 224, 238, 235, 175, 252, 238, 249, 234, 235, 175, 227, 230, 225, 228, 181, 175 }, 143) + _0x8b16be79);
                }
#endif
            }

            return _0x8b16be79;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9672995a._0x471e3941(new byte[39] { 67, 76, 125, 107, 108, 69, 56, 95, 125, 108, 56, 119, 106, 56, 104, 121, 106, 107, 125, 56, 107, 121, 110, 125, 124, 56, 116, 113, 118, 115, 56, 126, 121, 113, 116, 125, 124, 34, 56 }, 24) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xd8acbec7();
    }

    private void _0x9717f8b2()
    {
        if (_0xb7aee9cd)
        {
            WLog(_0x9672995a._0x471e3941(new byte[18] { 129, 188, 173, 176, 228, 165, 168, 182, 161, 165, 160, 189, 228, 183, 172, 171, 179, 170 }, 196));
            return;
        }

        _0xea788680(false);
        WLog(_0x9672995a._0x471e3941(new byte[46] { 46, 2, 10, 13, 67, 52, 6, 1, 53, 10, 6, 20, 67, 51, 22, 16, 11, 67, 45, 12, 23, 10, 5, 10, 0, 2, 23, 10, 12, 13, 67, 75, 11, 2, 17, 7, 20, 2, 17, 6, 67, 1, 2, 0, 8, 74 }, 99));
        ++_0xbaf60fb0;
        _0x8466283f();
        if (_0xbaf60fb0 <= 1)
            return;
        if (_0x56a3b226())
        {
            WLog(_0x9672995a._0x471e3941(new byte[37] { 86, 107, 122, 103, 51, 96, 120, 122, 99, 99, 118, 119, 51, 62, 45, 51, 99, 124, 99, 102, 99, 96, 51, 96, 103, 122, 127, 127, 51, 124, 99, 118, 125, 118, 119, 41, 51 }, 19) + _0xd78e9b79.Count);
            return;
        }

        Application.Quit();
    }

    private void _0x0b5f7220(string _0xdffcd748)
    {
        bool _0x9fa96ebf = !string.IsNullOrEmpty(_0xdffcd748);
        if (_0x9fa96ebf)
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[13] { 107, 100, 85, 67, 68, 109, 16, 99, 88, 95, 71, 10, 16 }, 48) + _0xdffcd748);
#endif
            }

            _0x8ac8d075(_0xdffcd748);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[39] { 162, 173, 156, 138, 141, 164, 217, 191, 152, 149, 149, 155, 152, 154, 146, 217, 27, 127, 107, 217, 190, 152, 148, 156, 217, 209, 151, 150, 217, 159, 144, 151, 152, 149, 217, 172, 171, 181, 208 }, 249));
#endif
            }

            _0xd8acbec7();
            return;
        }
    }

    private string _0xaeaedf67 = "";
    private async Task _0xcfd1127c(string _0x9fe85a73)
    {
        if (_0x5a6d7add || string.IsNullOrEmpty(_0xf2d58065) || string.IsNullOrEmpty(_0x9fe85a73) || _0xf4991660)
            return;
        _0x5a6d7add = true;
        try
        {
            JObject _0xc83547ad = _0x6984cd1c(_0x9fe85a73, _0xf2d58065, _0x264c0caf());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x9fe85a73} payload: {_0xc83547ad}");
                }
#endif
            }

            var _0xf1879f73 = _0xdab94ac4(_0xc83547ad.ToString(), _0xf2d58065);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x9672995a._0x471e3941(new byte[4] { 42, 41, 39, 34 }, 70) + _0xf2d58065, _0xf1879f73 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x9672995a._0x471e3941(new byte[24] { 75, 68, 85, 67, 68, 77, 48, 92, 127, 113, 116, 48, 96, 113, 99, 99, 48, 117, 98, 98, 127, 98, 42, 48 }, 16) + e.Message);
#endif
            }
        }
    }

    private async void Start()
    {
        await _0x93530c29();
    }

    private void _0x8ac8d075(string _0x71eea1a6)
    {
        _0x4d10a993();
        StartCoroutine(_0x0af39808(_0x71eea1a6));
    }

    internal bool IsAboutBlank(string _0x3e684086)
    {
        if (string.IsNullOrEmpty(_0x3e684086))
            return false;
        return _0x3e684086.StartsWith(_0x9672995a._0x471e3941(new byte[11] { 141, 142, 131, 153, 152, 214, 142, 128, 141, 130, 135 }, 236), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x56a3b226()
    {
        _0xd78e9b79.RemoveAll(_0xf6b5a00d => _0xf6b5a00d == null || !_0xf6b5a00d.IsAlive);
        return _0xd78e9b79.Count > 0;
    }

    private ApplicationInstallMode _0x6e76e79b = ApplicationInstallMode.Unknown;
}

internal static class _0x9672995a
{
    internal static string _0x471e3941(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}