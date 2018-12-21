using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Toast.Library.RNToastLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNToastLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNToastLibraryModule"/>.
        /// </summary>
        internal RNToastLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNToastLibrary";
            }
        }
    }
}
