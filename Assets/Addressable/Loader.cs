using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Study.H_Addressable
{
    public class AssetRefererenceAudioClip : AssetReferenceT<AudioClip>
    {
        public AssetRefererenceAudioClip(string guid) : base(guid){}
    }
    public class Loader : MonoBehaviour
    {
        [SerializeField] private AssetReference _reference;
        [SerializeField] private AssetReferenceGameObject _objectReference;
        [SerializeField] private AssetRefererenceAudioClip _clipReference;
        [SerializeField] private AssetLabelReference _labelReference;
        
        [SerializeField] private string _assetPath;

        private GameObject _spawnedGameObject;

        private AsyncOperationHandle _handle;

        private void Start()
        {
            LoadAsset();
        }

        private void LoadAsset()
        {
            // _objectReference.LoadAssetAsync<GameObject>().Completed += (handle =>
            Addressables.LoadAssetAsync<GameObject>(_labelReference).Completed += (handle =>
            // _reference.LoadAssetAsync<GameObject>().Completed += (handle =>
            // Addressables.LoadAssetAsync<GameObject>(_assetPath).Completed += (handle =>
            {
                _handle = handle;
                if (handle.Status == AsyncOperationStatus.Succeeded)
                {
                    _spawnedGameObject = Instantiate(handle.Result);
                }
                else
                {
                    Debug.Log("Load failed!");
                }
            });

            // Addressables.InstantiateAsync(_objectReference);
        }

        private void ReleaseAsset()
        {
            if (_spawnedGameObject)
                Addressables.ReleaseInstance(_spawnedGameObject);
            // if (_spawnedGameObject)
            //     Addressables.Release(_handle);
        }
    }

}
