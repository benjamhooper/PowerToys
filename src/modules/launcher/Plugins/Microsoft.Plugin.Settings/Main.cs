// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using Wox.Plugin;

namespace Microsoft.Plugin.Settings
{
    public class Main : IPlugin, IPluginI18n
    {
        public void Init(PluginInitContext context)
        {
            throw new NotImplementedException();
        }

        public List<Result> Query(Query query)
        {
            throw new NotImplementedException();
        }

        public string GetTranslatedPluginDescription()
        {
            throw new NotImplementedException();
        }

        public string GetTranslatedPluginTitle()
        {
            throw new NotImplementedException();
        }
    }
}
