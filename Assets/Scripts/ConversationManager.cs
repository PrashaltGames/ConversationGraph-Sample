using System;
using System.Collections;
using System.Collections.Generic;
using ConversationGraph.Runtime.Core.Components;
using UnityEngine;

public class ConversationManager : MonoBehaviour
{
    [SerializeField] private ConversationSystem _system;

    private void Start()
    {
        _system.StartConversation();
    }
}
