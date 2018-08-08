﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Definitions.InputSystem;
using Microsoft.MixedReality.Toolkit.Internal.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem.Handlers;

namespace Microsoft.MixedReality.Toolkit.Internal.Interfaces.Devices
{
    /// <summary>
    /// Basic interface for synchronizing to a controller pose.
    /// </summary>
    public interface IMixedRealityControllerPoseSynchronizer : IMixedRealitySpatialInputHandler
    {
        /// <summary>
        /// The controller handedness to synchronize with.
        /// </summary>
        Handedness Handedness { get; }

        /// <summary>
        /// Should this <see cref="UnityEngine.GameObject"/> clean itself up when it's controller is lost?
        /// </summary>
        bool DestroyOnSourceLost { get; set; }

        /// <summary>
        /// The current controller reference.
        /// </summary>
        IMixedRealityController Controller { get; set; }

        /// <summary>
        /// Should the Transform's position be driven from the source pose or from input handler?
        /// </summary>
        bool UseSourcePoseData { get; set; }

        /// <summary>
        /// The input action that will drive the Transform's pose, position, or rotation.
        /// </summary>
        MixedRealityInputAction PoseAction { get; set; }
    }
}
