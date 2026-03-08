// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Xml.Linq;

namespace BuildBoss
{
    internal readonly struct InternalsVisibleTo(string targetAssembly, string publicKey, string loadsWithinVisualStudio, string workItem)
    {
        public string TargetAssembly { get; } = targetAssembly;
        public string PublicKey { get; } = publicKey;
        public string LoadsWithinVisualStudio { get; } = loadsWithinVisualStudio;
        public string WorkItem { get; } = workItem;

        public override string ToString()
        {
            var element = new XElement("InternalsVisibleTo");
            if (TargetAssembly is not null)
            {
                element.Add(new XAttribute("Include", TargetAssembly));
            }

            if (PublicKey is not null)
            {
                element.Add(new XAttribute("Key", PublicKey));
            }

            if (LoadsWithinVisualStudio is not null)
            {
                element.Add(new XAttribute("LoadsWithinVisualStudio", LoadsWithinVisualStudio));
            }

            if (WorkItem is not null)
            {
                element.Add(new XAttribute("WorkItem", WorkItem));
            }

            return element.ToString();
        }
    }
}
