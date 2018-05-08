﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using SixLabors.ImageSharp.Memory;

namespace SixLabors.ImageSharp.Formats.Jpeg.PdfJsPort.Components
{
    /// <summary>
    /// The collection of tables used for fast AC entropy scan decoding.
    /// </summary>
    internal sealed class FastACTables : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FastACTables"/> class.
        /// </summary>
        /// <param name="memoryManager">The memory manager used to allocate memory for image processing operations.</param>
        public FastACTables(MemoryManager memoryManager)
        {
            this.Tables = memoryManager.AllocateClean2D<short>(512, 4);
        }

        /// <summary>
        /// Gets the collection of tables.
        /// </summary>
        public Buffer2D<short> Tables { get; }

        /// <inheritdoc />
        public void Dispose()
        {
            this.Tables?.Dispose();
        }
    }
}