// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.SpectatorView
{
    public class SpatialLocalizationInitializationSettings : Singleton<SpatialLocalizationInitializationSettings>
    {
        [Tooltip("List of SpatialLocalizationInitializers that will be tried when a Spectator connects to a User. The first SpatialLocalizationInitializer in the list that is supported by both devices will be tried.")]
        [SerializeField]
        private SpatialLocalizationInitializer[] prioritizedInitializers = null;

        public SpatialLocalizationInitializer[] PrioritizedInitializers => prioritizedInitializers;
    }
}