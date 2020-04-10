# Unity ECS Offsets

##### What is this?:

If you want access to Unity ECS internal data to for example work with chunks and archetypes directly, then this gives you the required offsets. 

Example generated code:

        public struct ChunkOffsets
        {           
            public const int _0000_ArchetypePtr_Archetype_8 = 0;
            public const int _0008_Entity_metaChunkEntity_Index_4 = 8;
            public const int _0012_Entity_metaChunkEntity_Version_4 = 12;
            public const int _0016_Int32_Count_4 = 16;
            public const int _0020_Int32_Capacity_4 = 20;
            public const int _0024_Int32_ManagedArrayIndex_4 = 24;
            public const int _0028_Int32_ListIndex_4 = 28;
            public const int _0032_Int32_ListWithEmptySlotsIndex_4 = 32;
            public const int _0036_UInt32_Flags_4 = 36;
            public const int _0040_UInt64_SequenceNumber_8 = 40;
            public const int _0048_Byte_Buffer_m_value_1 = 48;
            public const int _0049_Byte_Buffer_m_value_1 = 49;
            public const int _0050_Byte_Buffer_m_value_1 = 50;
            public const int _0051_Byte_Buffer_m_value_1 = 51;
        }

Which can then be used directly or fed into your own imposter structs:

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct ChunkImposter
    {
        [FieldOffset(ChunkOffsets._0000_ArchetypePtr_Archetype_8)]
        [NativeDisableUnsafePtrRestriction]
        public ArchetypeImposter* Archetype;

        [FieldOffset(ChunkOffsets._0008_Entity_metaChunkEntity_Index_4)]
        public Entity metaChunkEntity;

        [FieldOffset(ChunkOffsets._0016_Int32_Count_4)]
        public int Count;

        [FieldOffset(ChunkOffsets._0020_Int32_Capacity_4)]
        public int Capacity;

        [FieldOffset(ChunkOffsets._0024_Int32_ManagedArrayIndex_4)]
        public int ManagedArrayIndex;

        [FieldOffset(ChunkOffsets._0028_Int32_ListIndex_4)]
        public int ListIndex;

        [FieldOffset(ChunkOffsets._0032_Int32_ListWithEmptySlotsIndex_4)]
        public int ListWithEmptySlotsIndex;

        [FieldOffset(ChunkOffsets._0036_UInt32_Flags_4)]
        public uint Flags;

        [FieldOffset(ChunkOffsets._0040_UInt64_SequenceNumber_8)]
        public ulong SequenceNumber;

        [FieldOffset(ChunkOffsets._0048_Byte_Buffer_m_value_1)]
        public fixed byte Buffer[4];
    }

##### Also included:

* Imposters for ChunkArchetype, Chunk, Archetype etc.
* Utilty extension for working with entities/components directly


##### Updating for a new version of Entities:

There is a menu item under the 'DOTS' group that triggers the offsets file to be updated to the currently installed version of the Entities package.

<img src="https://i.imgur.com/3mko0XC.png" target="_blank" />

##### Written using the following versions:

* Unity 2020.1.0b5

##### Note:

Be aware that some structs have different fields based on the #define for safety checks. Although it seems that most of these conditional members are placed towards the end and important fields first, which reduces the chance of this being an issue.
