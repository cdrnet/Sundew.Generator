﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MsBuildWriterSetup.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Generator.Tests
{
    using Sundew.Generator.Core;
    using Sundew.Generator.Output;

    public class MsBuildWriterSetup : IMsBuildWriterSetup
    {
        public MsBuildWriterSetup()
        {
        }

        public MsBuildWriterSetup(string target, string path, TypeOrObject<IWriter> outputter, bool addFilesToProject)
        {
            this.Target = target;
            this.Path = path;
            this.Writer = outputter;
            this.AddFilesToProject = addFilesToProject;
        }

        public string Target { get; init; }

        public string Path { get; }

        public TypeOrObject<IWriter> Writer { get; init; }

        public bool AddFilesToProject { get; init; }
    }
}