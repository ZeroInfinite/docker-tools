// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.CommandLine;

namespace Microsoft.DotNet.ImageBuilder.Commands
{
    public abstract class DockerRegistryOptions : Options
    {
        public string Password { get; set; }
        public string RepoOwner { get; set; }
        public string Username { get; set; }

        protected DockerRegistryOptions()
        {
        }

        public override void ParseCommandLine(ArgumentSyntax syntax)
        {
            base.ParseCommandLine(syntax);

            string password = null;
            syntax.DefineOption(
                "password",
                ref password,
                "Password for the Docker Registry the images are pushed to");
            Password = password;

            string repoOwner = null;
            syntax.DefineOption(
                "repo-owner",
                ref repoOwner,
                "An alternative repo owner which overrides what is specified in the manifest");
            RepoOwner = repoOwner;

            string username = null;
            syntax.DefineOption(
                "username",
                ref username,
                "Username for the Docker Registry the images are pushed to");
            Username = username;
        }
    }
}
