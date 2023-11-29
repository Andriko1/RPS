using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    ARTrackedImageManager m_TrackedImageManager;
    [SerializeField]List<ARTrackedImage> trackedImages;

    void Awake()
    {
        m_TrackedImageManager = GameObject.FindWithTag("Origin").GetComponent<ARTrackedImageManager>();
    }

    private void Start()
    {
        trackedImages = new List<ARTrackedImage>();
    }

    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            trackedImages.Add(newImage);
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            // Handle updated event
        }

        foreach (var removedImage in eventArgs.removed)
        {
            trackedImages.Remove(removedImage);
            eventArgs.removed.Remove(removedImage);
            Destroy(removedImage);
        }
    }
}
