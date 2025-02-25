﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

#nullable disable

namespace Microsoft.Build.UnitTests
{
    /// <summary>
    /// Tests that Microsoft.Common.props successfully imports project extensions written by package management systems.
    /// </summary>
    sealed public class ProjectExtensionsTargetsImportTest : ProjectExtensionsImportTestBase
    {
        protected override string CustomImportProjectPath => Path.Combine(ObjectModelHelpers.TempProjectDir, "obj", $"{Path.GetFileName(_projectRelativePath)}.custom.targets");

        protected override string ImportProjectPath => Path.Combine(Path.GetDirectoryName(_projectRelativePath), "obj", $"{Path.GetFileName(_projectRelativePath)}.custom.targets");

        protected override string PropertyNameToEnableImport => "ImportProjectExtensionTargets";

        protected override string PropertyNameToSignalImportSucceeded => "WasProjectExtensionTargetsImported";
    }
}