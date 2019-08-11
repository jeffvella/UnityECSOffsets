using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
#endif

namespace Unity.Entities.Unsafe
{

    #region Auto-Generated Content

        // Entities: 0.1.1-preview

        public struct ArchetypeChunkOffsets
        {           
            public const int _0000_ChunkPtr_m_Chunk_8 = 0;
            public const int _0008_EntityComponentStorePtr_entityComponentStore_8 = 8;
        }

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

        public struct EntityComponentStoreOffsets
        {           
            public const int _0000_Int32Ptr_m_VersionByEntity_8 = 0;
            public const int _0008_ArchetypePtrPtr_m_ArchetypeByEntity_8 = 8;
            public const int _0016_EntityInChunkPtr_m_EntityInChunkByEntity_8 = 16;
            public const int _0024_NumberedWordsPtr_m_NameByEntity_8 = 24;
            public const int _0032_Int32Ptr_m_ComponentTypeOrderVersion_8 = 32;
            public const int _0040_ChunkAllocator_m_ArchetypeChunkAllocator_m_FirstChunk_8 = 40;
            public const int _0048_ChunkAllocator_m_ArchetypeChunkAllocator_m_LastChunk_8 = 48;
            public const int _0056_ChunkAllocator_m_ArchetypeChunkAllocator_m_LastChunkUsedSize_4 = 56;
            public const int _0064_UnsafeChunkPtrList_m_EmptyChunks_Ptr_8 = 64;
            public const int _0072_UnsafeChunkPtrList_m_EmptyChunks_Length_4 = 72;
            public const int _0076_UnsafeChunkPtrList_m_EmptyChunks_Capacity_4 = 76;
            public const int _0080_UnsafeChunkPtrList_m_EmptyChunks_Allocator_4 = 80;
            public const int _0088_UnsafeArchetypePtrList_m_Archetypes_Ptr_8 = 88;
            public const int _0096_UnsafeArchetypePtrList_m_Archetypes_Length_4 = 96;
            public const int _0100_UnsafeArchetypePtrList_m_Archetypes_Capacity_4 = 100;
            public const int _0104_UnsafeArchetypePtrList_m_Archetypes_Allocator_4 = 104;
            public const int _0112_UnsafeUintList_hashes_Ptr_8 = 112;
            public const int _0120_UnsafeUintList_hashes_Length_4 = 120;
            public const int _0124_UnsafeUintList_hashes_Capacity_4 = 124;
            public const int _0128_UnsafeUintList_hashes_Allocator_4 = 128;
            public const int _0136_UnsafeArchetypePtrList_archetypes_Ptr_8 = 136;
            public const int _0144_UnsafeArchetypePtrList_archetypes_Length_4 = 144;
            public const int _0148_UnsafeArchetypePtrList_archetypes_Capacity_4 = 148;
            public const int _0152_UnsafeArchetypePtrList_archetypes_Allocator_4 = 152;
            public const int _0160_ArchetypeListMap_m_TypeLookup_emptyNodes_4 = 160;
            public const int _0164_ArchetypeListMap_m_TypeLookup_skipNodes_4 = 164;
            public const int _0168_Int32_m_ManagedArrayIndex_4 = 168;
            public const int _0176_UnsafeAppendBuffer_m_ManagedArrayFreeIndex_Ptr_8 = 176;
            public const int _0184_UnsafeAppendBuffer_m_ManagedArrayFreeIndex_Size_4 = 184;
            public const int _0188_UnsafeAppendBuffer_m_ManagedArrayFreeIndex_Capacity_4 = 188;
            public const int _0192_UnsafeAppendBuffer_m_ManagedArrayFreeIndex_Alignment_4 = 192;
            public const int _0196_UnsafeAppendBuffer_m_ManagedArrayFreeIndex_Allocator_4 = 196;
            public const int _0200_UnsafeAppendBuffer_CommandBuffer_Ptr_8 = 200;
            public const int _0208_UnsafeAppendBuffer_CommandBuffer_Size_4 = 208;
            public const int _0212_UnsafeAppendBuffer_CommandBuffer_Capacity_4 = 212;
            public const int _0216_UnsafeAppendBuffer_CommandBuffer_Alignment_4 = 216;
            public const int _0220_UnsafeAppendBuffer_CommandBuffer_Allocator_4 = 220;
            public const int _0224_UInt64_m_NextChunkSequenceNumber_8 = 224;
            public const int _0232_Int32_m_NextFreeEntityIndex_4 = 232;
            public const int _0236_UInt32_m_GlobalSystemVersion_4 = 236;
            public const int _0240_Int32_m_EntitiesCapacity_4 = 240;
            public const int _0244_UInt32_m_ArchetypeTrackingVersion_4 = 244;
            public const int _0248_Int32_m_LinkedGroupType_4 = 248;
            public const int _0252_Int32_m_ChunkHeaderType_4 = 252;
            public const int _0256_Int32_m_PrefabType_4 = 256;
            public const int _0260_Int32_m_CleanupEntityType_4 = 260;
            public const int _0264_Int32_m_DisabledType_4 = 264;
            public const int _0268_Int32_m_EntityType_4 = 268;
            public const int _0272_ComponentType_m_ChunkHeaderComponentType_TypeIndex_4 = 272;
            public const int _0276_ComponentType_m_ChunkHeaderComponentType_AccessModeType_4 = 276;
            public const int _0280_ComponentType_m_EntityComponentType_TypeIndex_4 = 280;
            public const int _0284_ComponentType_m_EntityComponentType_AccessModeType_4 = 284;
            public const int _0288_TypeInfoPtr_m_TypeInfos_8 = 288;
            public const int _0296_EntityOffsetInfoPtr_m_EntityOffsetInfos_8 = 296;
        }

        public struct UnsafeChunkPtrListOffsets
        {           
            public const int _0000_ChunkPtrPtr_Ptr_8 = 0;
            public const int _0008_Int32_Length_4 = 8;
            public const int _0012_Int32_Capacity_4 = 12;
            public const int _0016_Allocator_Allocator_4 = 16;
        }

        public struct UnsafeArchetypePtrListOffsets
        {           
            public const int _0000_ArchetypePtrPtr_Ptr_8 = 0;
            public const int _0008_Int32_Length_4 = 8;
            public const int _0012_Int32_Capacity_4 = 12;
            public const int _0016_Allocator_Allocator_4 = 16;
        }

        public struct UnsafeUintListOffsets
        {           
            public const int _0000_UInt32Ptr_Ptr_8 = 0;
            public const int _0008_Int32_Length_4 = 8;
            public const int _0012_Int32_Capacity_4 = 12;
            public const int _0016_Allocator_Allocator_4 = 16;
        }

        public struct ArchetypeListMapOffsets
        {           
            public const int _0000_UnsafeUintList_hashes_Ptr_8 = 0;
            public const int _0008_UnsafeUintList_hashes_Length_4 = 8;
            public const int _0012_UnsafeUintList_hashes_Capacity_4 = 12;
            public const int _0016_UnsafeUintList_hashes_Allocator_4 = 16;
            public const int _0024_UnsafeArchetypePtrList_archetypes_Ptr_8 = 24;
            public const int _0032_UnsafeArchetypePtrList_archetypes_Length_4 = 32;
            public const int _0036_UnsafeArchetypePtrList_archetypes_Capacity_4 = 36;
            public const int _0040_UnsafeArchetypePtrList_archetypes_Allocator_4 = 40;
            public const int _0048_Int32_emptyNodes_4 = 48;
            public const int _0052_Int32_skipNodes_4 = 52;
        }

        public struct UnsafeAppendBufferOffsets
        {           
            public const int _0000_VoidPtr_Ptr_8 = 0;
            public const int _0008_Int32_Size_4 = 8;
            public const int _0012_Int32_Capacity_4 = 12;
            public const int _0016_Int32_Alignment_4 = 16;
            public const int _0020_Allocator_Allocator_4 = 20;
        }

        public struct ChunkAllocatorOffsets
        {           
            public const int _0000_BytePtr_m_FirstChunk_8 = 0;
            public const int _0008_BytePtr_m_LastChunk_8 = 8;
            public const int _0016_Int32_m_LastChunkUsedSize_4 = 16;
        }

        public struct ArchetypeOffsets
        {           
            public const int _0000_ArchetypeChunkData_Chunks_p_8 = 0;
            public const int _0008_ArchetypeChunkData_Chunks_data_8 = 8;
            public const int _0016_ArchetypeChunkData_Chunks_Capacity_4 = 16;
            public const int _0020_ArchetypeChunkData_Chunks_Count_4 = 20;
            public const int _0024_ArchetypeChunkData_Chunks_SharedComponentCount_4 = 24;
            public const int _0028_ArchetypeChunkData_Chunks_EntityCountIndex_4 = 28;
            public const int _0032_ArchetypeChunkData_Chunks_Channels_4 = 32;
            public const int _0040_UnsafeChunkPtrList_ChunksWithEmptySlots_Ptr_8 = 40;
            public const int _0048_UnsafeChunkPtrList_ChunksWithEmptySlots_Length_4 = 48;
            public const int _0052_UnsafeChunkPtrList_ChunksWithEmptySlots_Capacity_4 = 52;
            public const int _0056_UnsafeChunkPtrList_ChunksWithEmptySlots_Allocator_4 = 56;
            public const int _0064_UnsafeUintList_hashes_Ptr_8 = 64;
            public const int _0072_UnsafeUintList_hashes_Length_4 = 72;
            public const int _0076_UnsafeUintList_hashes_Capacity_4 = 76;
            public const int _0080_UnsafeUintList_hashes_Allocator_4 = 80;
            public const int _0088_UnsafeChunkPtrList_chunks_Ptr_8 = 88;
            public const int _0096_UnsafeChunkPtrList_chunks_Length_4 = 96;
            public const int _0100_UnsafeChunkPtrList_chunks_Capacity_4 = 100;
            public const int _0104_UnsafeChunkPtrList_chunks_Allocator_4 = 104;
            public const int _0112_ChunkListMap_FreeChunksBySharedComponents_emptyNodes_4 = 112;
            public const int _0116_ChunkListMap_FreeChunksBySharedComponents_skipNodes_4 = 116;
            public const int _0120_Int32_EntityCount_4 = 120;
            public const int _0124_Int32_ChunkCapacity_4 = 124;
            public const int _0128_Int32_BytesPerInstance_4 = 128;
            public const int _0136_ComponentTypeInArchetypePtr_Types_8 = 136;
            public const int _0144_Int32_TypesCount_4 = 144;
            public const int _0148_Int32_NonZeroSizedTypesCount_4 = 148;
            public const int _0152_Int32Ptr_Offsets_8 = 152;
            public const int _0160_Int32Ptr_SizeOfs_8 = 160;
            public const int _0168_Int32Ptr_BufferCapacities_8 = 168;
            public const int _0176_Int32Ptr_TypeMemoryOrder_8 = 176;
            public const int _0184_Int32Ptr_ManagedArrayOffset_8 = 184;
            public const int _0192_Int32_NumManagedArrays_4 = 192;
            public const int _0196_Int32_FirstSharedComponent_4 = 196;
            public const int _0200_Int32_NumSharedComponents_4 = 200;
            public const int _0208_ArchetypePtr_InstantiableArchetype_8 = 208;
            public const int _0216_ArchetypePtr_SystemStateResidueArchetype_8 = 216;
            public const int _0224_ArchetypePtr_MetaChunkArchetype_8 = 224;
            public const int _0232_EntityPatchInfoPtr_ScalarEntityPatches_8 = 232;
            public const int _0240_Int32_ScalarEntityPatchCount_4 = 240;
            public const int _0248_BufferEntityPatchInfoPtr_BufferEntityPatches_8 = 248;
            public const int _0256_Int32_BufferEntityPatchCount_4 = 256;
            public const int _0260_Boolean_SystemStateCleanupComplete_1 = 260;
            public const int _0261_Boolean_SystemStateCleanupNeeded_1 = 261;
            public const int _0262_Boolean_Disabled_1 = 262;
            public const int _0263_Boolean_Prefab_1 = 263;
            public const int _0264_Boolean_HasChunkComponents_1 = 264;
            public const int _0265_Boolean_HasChunkHeader_1 = 265;
            public const int _0266_Boolean_ContainsBlobAssetRefs_1 = 266;
        }

        public struct ChunkListMapOffsets
        {           
            public const int _0000_UnsafeUintList_hashes_Ptr_8 = 0;
            public const int _0008_UnsafeUintList_hashes_Length_4 = 8;
            public const int _0012_UnsafeUintList_hashes_Capacity_4 = 12;
            public const int _0016_UnsafeUintList_hashes_Allocator_4 = 16;
            public const int _0024_UnsafeChunkPtrList_chunks_Ptr_8 = 24;
            public const int _0032_UnsafeChunkPtrList_chunks_Length_4 = 32;
            public const int _0036_UnsafeChunkPtrList_chunks_Capacity_4 = 36;
            public const int _0040_UnsafeChunkPtrList_chunks_Allocator_4 = 40;
            public const int _0048_Int32_emptyNodes_4 = 48;
            public const int _0052_Int32_skipNodes_4 = 52;
        }

        public struct ArchetypeChunkDataOffsets
        {           
            public const int _0000_ChunkPtrPtr_p_8 = 0;
            public const int _0008_Int32Ptr_data_8 = 8;
            public const int _0016_Int32_Capacity_4 = 16;
            public const int _0020_Int32_Count_4 = 20;
            public const int _0024_Int32_SharedComponentCount_4 = 24;
            public const int _0028_Int32_EntityCountIndex_4 = 28;
            public const int _0032_Int32_Channels_4 = 32;
        }

        public struct EntityOffsets
        {           
            public const int _0000_Int32_Index_4 = 0;
            public const int _0004_Int32_Version_4 = 4;
        }

        public struct ComponentTypeOffsets
        {           
            public const int _0000_Int32_TypeIndex_4 = 0;
            public const int _0004_AccessMode_AccessModeType_4 = 4;
        }

        public struct ComponentTypesOffsets
        {           
            public const int _0000_ResizableArray64Byte_tInt32__m_sorted_m_Length_4 = 0;
            public const int _0004_Int32_m_Buffer_m_value_4 = 4;
            public const int _0008_Int32_m_Buffer_m_value_4 = 8;
            public const int _0012_Int32_m_Buffer_m_value_4 = 12;
            public const int _0016_Int32_m_Buffer_m_value_4 = 16;
            public const int _0020_Int32_m_Buffer_m_value_4 = 20;
            public const int _0024_Int32_m_Buffer_m_value_4 = 24;
            public const int _0028_Int32_m_Buffer_m_value_4 = 28;
            public const int _0032_Int32_m_Buffer_m_value_4 = 32;
            public const int _0036_Int32_m_Buffer_m_value_4 = 36;
            public const int _0040_Int32_m_Buffer_m_value_4 = 40;
            public const int _0044_Int32_m_Buffer_m_value_4 = 44;
            public const int _0048_Int32_m_Buffer_m_value_4 = 48;
            public const int _0052_Int32_m_Buffer_m_value_4 = 52;
            public const int _0056_Int32_m_Buffer_m_value_4 = 56;
            public const int _0060_Int32_m_Buffer_m_value_4 = 60;
            public const int _0064_Masks_m_masks_m_BufferMask_2 = 64;
            public const int _0066_Masks_m_masks_m_SystemStateComponentMask_2 = 66;
            public const int _0068_Masks_m_masks_m_SharedComponentMask_2 = 68;
            public const int _0070_Masks_m_masks_m_ZeroSizedMask_2 = 70;
        }

        public struct EntityCommandBufferOffsets
        {           
            public const int _0000_EntityCommandBufferDataPtr_m_Data_8 = 0;
            public const int _0008_AtomicSafetyHandle_m_Safety0_versionNode_8 = 8;
            public const int _0016_AtomicSafetyHandle_m_Safety0_version_4 = 16;
            public const int _0024_AtomicSafetyHandle_m_BufferSafety_versionNode_8 = 24;
            public const int _0032_AtomicSafetyHandle_m_BufferSafety_version_4 = 32;
            public const int _0040_AtomicSafetyHandle_m_ArrayInvalidationSafety_versionNode_8 = 40;
            public const int _0048_AtomicSafetyHandle_m_ArrayInvalidationSafety_version_4 = 48;
            public const int _0056_Int32_m_SafetyReadOnlyCount_4 = 56;
            public const int _0060_Int32_m_SafetyReadWriteCount_4 = 60;
            public const int _0064_DisposeSentinel_m_DisposeSentinel_8 = 64;
            public const int _0072_Int32_SystemID_4 = 72;
        }

        public struct AtomicSafetyHandleOffsets
        {           
            public const int _0000_IntPtr_versionNode_8 = 0;
            public const int _0008_Int32_version_4 = 8;
        }

        public struct EntityQueryDataOffsets
        {           
            public const int _0000_ComponentTypePtr_RequiredComponents_8 = 0;
            public const int _0008_Int32_RequiredComponentsCount_4 = 8;
            public const int _0016_Int32Ptr_ReaderTypes_8 = 16;
            public const int _0024_Int32_ReaderTypesCount_4 = 24;
            public const int _0032_Int32Ptr_WriterTypes_8 = 32;
            public const int _0040_Int32_WriterTypesCount_4 = 40;
            public const int _0048_ArchetypeQueryPtr_ArchetypeQuery_8 = 48;
            public const int _0056_Int32_ArchetypeQueryCount_4 = 56;
            public const int _0064_UnsafeMatchingArchetypePtrList_MatchingArchetypes_ListData_8 = 64;
            public const int _0072_UnsafeMatchingArchetypePtrList_MatchingArchetypes_entityComponentStore_8 = 72;
        }

        public struct UnsafeMatchingArchetypePtrListOffsets
        {           
            public const int _0000_UnsafePtrListPtr_ListData_8 = 0;
            public const int _0008_EntityComponentStorePtr_entityComponentStore_8 = 8;
        }

        public struct EntityQueryFilterOffsets
        {           
            public const int _0000_FilterType_Type_4 = 0;
            public const int _0004_UInt32_RequiredChangeVersion_4 = 4;
            public const int _0008_SharedComponentData_Shared_Count_4 = 8;
            public const int _0012_Int32_IndexInEntityQuery_m_value_4 = 12;
            public const int _0016_Int32_IndexInEntityQuery_m_value_4 = 16;
            public const int _0020_Int32_SharedComponentIndex_m_value_4 = 20;
            public const int _0024_Int32_SharedComponentIndex_m_value_4 = 24;
            public const int _0028_ChangedFilter_Changed_Count_4 = 28;
            public const int _0032_Int32_IndexInEntityQuery_m_value_4 = 32;
            public const int _0036_Int32_IndexInEntityQuery_m_value_4 = 36;
        }

    #endregion Auto-Generated Content

#if UNITY_EDITOR


    /// <summary>
    /// This file re-writes itself with the current offsets when the Editor menu option 'DOTS->Update Offsets' is used.
    /// Note: this file can be placed anywhere in your project, and be called any file name.
    /// </summary>
    public static class OffsetsGenerator
    {
        private static void Update(bool forceUpdate = false, [CallerFilePath] string executingFilePath = "")
        {
            var items = new Dictionary<Type, TypeLayoutUtility.TypeInfo>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var versions = new List<string>();
            var hash = 0;

            foreach (var assembly in assemblies)
            {
                if (assembly.GetName().Name == "Unity.Entities")
                {
                    var id = assembly.ManifestModule.ModuleVersionId;
                    var packageInfo = UnityEditor.PackageManager.PackageInfo.FindForAssembly(assembly);
                    versions.Add($"// Entities: {packageInfo.version}");

                    hash = packageInfo.version.GetHashCode();
                    if (!forceUpdate && EditorPrefs.GetInt(SettingsKey) == hash)
                        return;

                    GetOffsets(items, assembly.GetType("Unity.Entities.ArchetypeChunk"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.Chunk"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.EntityComponentStore"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.Archetype"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.Entity"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.ComponentType"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.ComponentTypes"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.EntityCommandBuffer"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.EntityQueryData"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.EntityQueryFilter"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.ExclusiveTransation"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.DynamicBuffer"));
                    GetOffsets(items, assembly.GetType("Unity.Entities.BufferFromEntity"));


                    break;
                }
            }

            GenerateFile(items.Values.ToList(), versions, hash, executingFilePath);
        }

        private static void GetOffsets(Dictionary<Type, TypeLayoutUtility.TypeInfo> items, Type type, bool expandPointers = true, bool expandLayouts = true)
        {
            if (type == null || items.ContainsKey(type))
                return;

            var typeInfo = TypeLayoutUtility.CreateTypeInfo(type);
            items.Add(type, typeInfo);

            if (expandLayouts)
            {
                foreach (var layout in typeInfo.Layouts)
                {
                    if (layout.Type != null && !items.ContainsKey(layout.Type))
                    {
                        items.Add(layout.Type, TypeLayoutUtility.CreateTypeInfo(layout.Type));
                    }
                }
            }
            if (expandPointers)
            {
                foreach (var pointerType in typeInfo.PointerTypes)
                {
                    if (pointerType != null && !items.ContainsKey(pointerType))
                    {
                        items.Add(pointerType, TypeLayoutUtility.CreateTypeInfo(pointerType));
                    }
                }
            }
        }

        private static void GenerateFile(List<TypeLayoutUtility.TypeInfo> typeInfos, List<string> versions, int hash, string outputPath)
        {
            var allFileLines = File.ReadAllLines(outputPath);

            List<(string Name, string ReplacementLines)> replacements = new List<(string Name, string replacementLines)>();

            for (var i = 0; i < typeInfos.Count; i++)
            {
                var typeInfo = typeInfos[i];
                var name = typeInfo.Type.Name + "Offsets";
                var membersBuilder = new StringBuilder();
                var isLastTypeInfo = i == typeInfos.Count-1;

                for (var j = 0; j < typeInfo.Fields.Length; j++)
                {
                    var fieldData = typeInfo.Fields[j];
                    var str = ConstantTemplate.Replace(MemberTypeToken, "int");
                    str = str.Replace(MemberNameToken, fieldData.CreateMemberName());
                    str = str.Replace(MemberValueToken, fieldData.Offset.ToString());

                    var isLast = j == typeInfo.Fields.Length - 1;
                    if (!isLast) str += Environment.NewLine + Indent2;

                    membersBuilder.Append(str);
                }

                var newLines = StructTemplate.Replace(MembersToken, membersBuilder.ToString());
                newLines = newLines.Replace(StructNameToken, name);

                replacements.Add((name, newLines));
            }

            var output = ReplaceAutoGeneratedRegion(replacements, versions, allFileLines);
            if (output != null)
            {
                CreateScriptAssetWithContent(outputPath, output);
                EditorPrefs.SetInt(SettingsKey, hash);
                //AssetDatabase.Refresh();
            }
        }

        private const string MembersToken = "#Member";
        private const string MemberNameToken = "#MemberName";
        private const string MemberTypeToken = "#MemberType";
        private const string MemberValueToken = "#MemberValue";
        private const string StructNameToken = "#StructName";
        private const string SettingsKey = "AutoGeneratedInternalOffsetsKey";
        private const string StartRegionShortToken = "#region";
        private const string StartRegionToken = "#region Auto-Generated Content";
        private const string EndRegionShortToken = "#endregion";
        private const string EndRegionToken = "#endregion Auto-Generated Content";
        private const string Indent1 = "        ";
        private const string Indent2 = "            ";

        private static readonly string StructTemplate =
        $@"        public struct {StructNameToken}
        {{           
            {MembersToken}
        }}";

        private static readonly string ConstantTemplate =
        $@"public const {MemberTypeToken} {MemberNameToken} = {MemberValueToken};";


        private static string ReplaceAutoGeneratedRegion(List<(string Name, string ReplacementLines)> replacements, List<string> versions, string[] fileLines)
        {
            var result = new StringBuilder();
            int i = 0, j = 0;

            for (; i < fileLines.Length; i++)
            {
                string line = fileLines[i];

                if (!line.TrimStart().StartsWith(StartRegionShortToken) || !line.Contains(StartRegionToken))
                {
                    result.AppendLine(line);
                    continue;
                }

                result.AppendLine(line);
                result.AppendLine();

                for (int k = 0; k < versions.Count; k++)
                {
                    result.AppendLine(Indent1 + versions[k]);
                }

                for (j = i; j < fileLines.Length; j++)
                {
                    line = fileLines[j];

                    if (line.TrimStart().StartsWith(EndRegionShortToken) && line.Contains(EndRegionToken))
                    {
                        break;
                    }
                }

                var endNotFound = j == fileLines.Length;
                if (endNotFound)
                {
                    Debug.LogError("The required #endregion tag was not found");
                    return default;
                }

                foreach (var replacement in replacements)
                {
                    result.AppendLine();
                    result.Append(replacement.ReplacementLines);
                    result.AppendLine();
                }
                break;
            }

            result.AppendLine();
            return result + string.Join(Environment.NewLine, fileLines.Slice(j, fileLines.Length));
        }

        /// <summary>
        /// Create a new script asset.
        /// UnityEditor.ProjectWindowUtil.CreateScriptAssetWithContent (2019.1)
        /// </summary>
        /// <param name="pathName">the path to where the new file should be created</param>
        /// <param name="templateContent">the text to put inside</param>
        /// <returns></returns>
        private static void CreateScriptAssetWithContent(string pathName, string templateContent)
        {
            templateContent = SetLineEndings(templateContent, EditorSettings.lineEndingsForNewScripts);
            string fullPath = Path.GetFullPath(pathName);
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding(true);
            File.WriteAllText(fullPath, templateContent, encoding);
            AssetDatabase.ImportAsset(pathName);
            AssetDatabase.LoadAssetAtPath(pathName, typeof(UnityEngine.Object));
        }

        public static T[] Slice<T>(this T[] arr, int indexFrom, int indexTo)
        {
            uint length = (uint)(indexTo - indexFrom);
            T[] result = new T[length];
            Array.Copy(arr, indexFrom, result, 0, length);
            return result;
        }

        /// <summary>
        /// Ensure correct OS specific line endings for saving file content.
        /// UnityEditor.ProjectWindowUtil.SetLineEndings (2019.1)
        /// </summary>
        /// <param name="content">a string to have line endings checked</param>
        /// <param name="lineEndingsMode">the type of line endings to use</param>
        /// <returns>a cleaned string</returns>
        private static string SetLineEndings(string content, LineEndingsMode lineEndingsMode)
        {
            string replacement;
            switch (lineEndingsMode)
            {
                case LineEndingsMode.OSNative:
                    replacement = Application.platform == RuntimePlatform.WindowsEditor ? "\r\n" : "\n";
                    break;
                case LineEndingsMode.Unix:
                    replacement = "\n";
                    break;
                case LineEndingsMode.Windows:
                    replacement = "\r\n";
                    break;
                default:
                    replacement = "\n";
                    break;
            }
            content = System.Text.RegularExpressions.Regex.Replace(content, "\\r\\n?|\\n", replacement);
            return content;
        }


        ///// <summary>
        ///// Hook that runs the enum generator whenever assets are saved.
        ///// </summary>
        //private class UpdateOnAssetModification : UnityEditor.AssetModificationProcessor
        //{
        //    public static string[] OnWillSaveAssets(string[] paths)
        //    {
        //        Update();
        //        return paths;
        //    }
        //}

        ///// <summary>
        ///// Hook that runs the enum generator whenever scripts are compiled.
        ///// </summary>
        //[UnityEditor.Callbacks.DidReloadScripts]
        //private static void UpdateOnScriptCompile()
        //{
        //    Update();
        //}

        /// <summary>
        /// Enables manually running the enum generator from the menus.
        /// </summary>
        [MenuItem("DOTS/Update Offsets File")]
        private static void UpdateOnMenuCommand()
        {
            Update(true);
        }

    }

    public static class TypeLayoutUtility
    {
        public static TypeInfo CreateTypeInfo<T>() where T : struct
        {
            return CreateTypeInfoBlittable(typeof(T));
        }

        public static TypeInfo CreateTypeInfo(Type type)
        {
            return CreateTypeInfoBlittable(type);
        }

        private static TypeInfo CreateTypeInfoBlittable(Type type)
        {
            var begin = 0;
            var end = 0;
            var hash = 0;

            var layouts = new List<Layout>();
            var fields = new List<FieldData>();
            var pointerTypes = new List<Type>();

            CreateLayoutRecurse(type, null, 0, layouts, fields, pointerTypes, ref begin, ref end, ref hash);

            if (begin != end)
            {
                layouts.Add(new Layout
                {
                    Offset = begin,
                    Count = end - begin,
                    Size = end - begin,
                    Aligned4 = false
                });
            }

            var layoutsArray = layouts.ToArray();

            for (var i = 0; i != layoutsArray.Length; i++)
            {
                if (layoutsArray[i].Count % 4 == 0 && layoutsArray[i].Offset % 4 == 0)
                {
                    layoutsArray[i].Count /= 4;
                    layoutsArray[i].Aligned4 = true;
                }
            }

            return new TypeInfo
            {
                Type = type,
                Hash = hash,
                Layouts = layoutsArray,
                Fields = fields.ToArray(),
                PointerTypes = pointerTypes.ToArray(),
            };
        }

        public struct Layout
        {
            public int Offset;
            public int Count;
            public bool Aligned4;
            public int Size;
            public FieldData[] Fields;
            public Type Type;

            public override string ToString()
            {
                return $"{Offset}: {Type.Name} Size: {Size}, Fields={Fields.Length}";
            }
        }

        public struct TypeInfo
        {
            public int Hash;
            public Layout[] Layouts;
            public FieldData[] Fields;
            public Type[] PointerTypes;
            public Type Type;

            public static TypeInfo Null => new TypeInfo();

        }

        public unsafe struct PointerSize
        {
            private void* pter;
        }

        public struct FieldData
        {
            public int Offset;
            public int Size;
            public FieldInfo Field;
            public Type ParentType;
            public FieldInfo ParentField;

            public string CreateTypeString() => ParentField != null ? GetCleanTypeName(ParentType) : GetCleanTypeName(Field.FieldType);

            public string CreateNameString() => ParentField != null ? $"{ParentField.Name}_{Field.Name}" : Field.Name;

            public string CreateMemberName() => $"_{Offset:D4}_{CreateTypeString().Replace("*", "Ptr")}_{CreateNameString()}_{Size:X}";

            public static string GetCleanTypeName(Type type)
            {
                if (type.IsGenericType)
                {
                    var simpleName = type.Name.Substring(0, type.Name.IndexOf('`'));
                    string genericTypeParams = string.Empty;
                    var args = !type.IsGenericTypeDefinition
                        ? type.GetGenericArguments()
                        : Type.EmptyTypes;

                    for (int i = 0; i < args.Length; i++)
                    {
                        if (i > 0) genericTypeParams += ",";
                        genericTypeParams += GetCleanTypeName(args[i]);
                    }
                    return string.Format("{0}_t{1}_", simpleName, genericTypeParams);
                }
                return type.Name;
            }

            public override string ToString() => CreateMemberName();
        }

        public static FixedBufferAttribute GetFixedBufferAttribute(FieldInfo field)
        {
            foreach (var attribute in field.GetCustomAttributes(typeof(FixedBufferAttribute)))
            {
                return (FixedBufferAttribute)attribute;
            }

            return null;
        }

        public static void CombineHash(ref int hash, params int[] values)
        {
            foreach (var value in values)
            {
                hash *= FNV_32_PRIME;
                hash ^= value;
            }
        }

        private static void CreateLayoutRecurse(Type type, FieldInfo parentField, int baseOffset, List<Layout> layouts, List<FieldData> fieldsOutput, List<Type> pointerTypes, ref int begin, ref int end, ref int typeHash)
        {
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            var fieldsWithOffset = new FieldData[fields.Length];
            for (int i = 0; i != fields.Length; i++)
            {
                fieldsWithOffset[i].Offset = UnsafeUtility.GetFieldOffset(fields[i]);
                fieldsWithOffset[i].Field = fields[i];
            }

            Array.Sort(fieldsWithOffset, (a, b) => a.Offset - b.Offset);

            for (var i = 0; i < fieldsWithOffset.Length; i++)
            {
                var sizeOf = 0;
                var fieldWithOffset = fieldsWithOffset[i];
                var field = fieldWithOffset.Field;
                var fixedBuffer = GetFixedBufferAttribute(field);

                if (fixedBuffer != null)
                {
                    var stride = UnsafeUtility.SizeOf(fixedBuffer.ElementType);
                    sizeOf = stride * fixedBuffer.Length;
                }
                else if (field.FieldType.IsPrimitive || field.FieldType.IsPointer || field.FieldType.IsClass || field.FieldType.IsEnum)
                {
                    if (field.FieldType.IsPointer)
                    {
                        sizeOf = UnsafeUtility.SizeOf<PointerSize>();

                        // Record discovered pointers so they can be expanded separately.
                        pointerTypes.Add(field.ReflectedType);
                    }
                    else if (field.FieldType.IsClass)
                    {
                        sizeOf = UnsafeUtility.SizeOf<PointerSize>();
                    }
                    else if (field.FieldType.IsEnum)
                    {
                        // Workaround IL2CPP bug
                        sizeOf = UnsafeUtility.SizeOf(field.FieldType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)[0].FieldType);
                    }
                    else
                    {
                        sizeOf = UnsafeUtility.SizeOf(field.FieldType);
                    }
                }
                else
                {
                    sizeOf = UnsafeUtility.SizeOf(field.FieldType);
                }
                fieldsWithOffset[i].Size = sizeOf;
            }

            for (var i = 0; i < fieldsWithOffset.Length; i++)
            {
                var fieldWithOffset = fieldsWithOffset[i];
                var field = fieldWithOffset.Field;
                var fixedBuffer = GetFixedBufferAttribute(field);
                var offset = baseOffset + fieldWithOffset.Offset;
                var size = fieldsWithOffset[i].Size;

                if (fixedBuffer != null)
                {
                    var stride = UnsafeUtility.SizeOf(fixedBuffer.ElementType);
                    for (int j = 0; j < fixedBuffer.Length; ++j)
                    {
                        CreateLayoutRecurse(fixedBuffer.ElementType, field, offset + j * stride, layouts, fieldsOutput, pointerTypes, ref begin, ref end, ref typeHash);
                    }
                }
                else if (field.FieldType.IsPrimitive || field.FieldType.IsPointer || field.FieldType.IsClass || field.FieldType.IsEnum)
                {
                    CombineHash(ref typeHash, offset, (int)Type.GetTypeCode(field.FieldType));

                    if (end != offset)
                    {
                        layouts.Add(new Layout
                        {
                            Type = type,
                            Offset = begin,
                            Count = end - begin,
                            Size = end - begin,
                            Aligned4 = false,
                            Fields = fieldsWithOffset
                        });
                        begin = offset;
                        end = offset + size;
                    }
                    else
                    {
                        end += size;
                    }

                    // A copy with absolute offset;
                    fieldWithOffset.Offset = offset;
                    fieldWithOffset.ParentType = type;
                    fieldWithOffset.ParentField = parentField;
                    fieldsOutput.Add(fieldWithOffset);
                }
                else
                {
                    CreateLayoutRecurse(field.FieldType, field, offset, layouts, fieldsOutput, pointerTypes, ref begin, ref end, ref typeHash);
                }
            }
        }

        public const int FNV_32_PRIME = 0x01000193;
    }

#endif



}