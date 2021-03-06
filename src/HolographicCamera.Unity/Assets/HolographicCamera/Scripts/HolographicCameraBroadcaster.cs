// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace Microsoft.MixedReality.SpectatorView
{
    /// <summary>
    /// Represents the network listener for the camera pose provider app.
    /// </summary>
    public class HolographicCameraBroadcaster : NetworkManager<HolographicCameraBroadcaster>
    {
        [SerializeField]
        [Tooltip("The port that the listening socket should be bound to.")]
        private int listeningPort = 7502;

        protected override int RemotePort => listeningPort;

        protected override void Awake()
        {
            base.Awake();
            connectionManager.StartListening(listeningPort);
        }
    }
}