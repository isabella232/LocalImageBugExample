using ReactNative;
using ReactNative.Modules.Core;
using RNFS;
using ReactNative.Shell;
using System.Collections.Generic;

namespace LocalImageBugExample
{
    class MainPage : ReactPage
    {
        public override string MainComponentName
        {
            get
            {
                return "LocalImageBugExample";
            }
        }

#if BUNDLE
        public override string JavaScriptBundleFile
        {
            get
            {
                return "ms-appx:///ReactAssets/index.windows.bundle";
            }
        }
#endif

        public override List<IReactPackage> Packages
        {
            get
            {
                return new List<IReactPackage>
                {
                    new MainReactPackage(),
                    new RNFSPackage(),
                };
            }
        }

        public override bool UseDeveloperSupport
        {
            get
            {
#if !BUNDLE || DEBUG
                return true;
#else
                return false;
#endif
            }
        }
    }

}
