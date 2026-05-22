using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000187 RID: 391
	public sealed class ResourceReader : Object
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x0009FBCC File Offset: 0x0009DDCC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceReader()
		{
			Il2CppClassPointerStore<ResourceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr);
			ResourceReader.NativeFieldInfoPtr__store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_store");
			ResourceReader.NativeFieldInfoPtr__resCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_resCache");
			ResourceReader.NativeFieldInfoPtr__nameSectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameSectionOffset");
			ResourceReader.NativeFieldInfoPtr__dataSectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_dataSectionOffset");
			ResourceReader.NativeFieldInfoPtr__nameHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameHashes");
			ResourceReader.NativeFieldInfoPtr__nameHashesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameHashesPtr");
			ResourceReader.NativeFieldInfoPtr__namePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_namePositions");
			ResourceReader.NativeFieldInfoPtr__namePositionsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_namePositionsPtr");
			ResourceReader.NativeFieldInfoPtr__typeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_typeTable");
			ResourceReader.NativeFieldInfoPtr__typeNamePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_typeNamePositions");
			ResourceReader.NativeFieldInfoPtr__objFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_objFormatter");
			ResourceReader.NativeFieldInfoPtr__numResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_numResources");
			ResourceReader.NativeFieldInfoPtr__ums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_ums");
			ResourceReader.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_version");
			ResourceReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667950);
			ResourceReader.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667951);
			ResourceReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667952);
			ResourceReader.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667953);
			ResourceReader.NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667954);
			ResourceReader.NativeMethodInfoPtr_SkipString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667955);
			ResourceReader.NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667956);
			ResourceReader.NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667957);
			ResourceReader.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667958);
			ResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667959);
			ResourceReader.NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667960);
			ResourceReader.NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667961);
			ResourceReader.NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667962);
			ResourceReader.NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667963);
			ResourceReader.NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667964);
			ResourceReader.NativeMethodInfoPtr_LoadString_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667965);
			ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667966);
			ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667967);
			ResourceReader.NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667968);
			ResourceReader.NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667969);
			ResourceReader.NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667970);
			ResourceReader.NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667971);
			ResourceReader.NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667972);
			ResourceReader.NativeMethodInfoPtr_ReadResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667973);
			ResourceReader.NativeMethodInfoPtr__ReadResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667974);
			ResourceReader.NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667975);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0009FF1C File Offset: 0x0009E11C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185558, RefRangeEnd = 185560, XrefRangeStart = 185549, XrefRangeEnd = 185558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0009FF7C File Offset: 0x0009E17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185560, XrefRangeEnd = 185561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0009FFB0 File Offset: 0x0009E1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0009FFE4 File Offset: 0x0009E1E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185562, RefRangeEnd = 185565, XrefRangeStart = 185561, XrefRangeEnd = 185562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000A0024 File Offset: 0x0009E224
		[CallerCount(0)]
		public unsafe static int ReadUnalignedI4(int* p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000A0060 File Offset: 0x0009E260
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185574, RefRangeEnd = 185577, XrefRangeStart = 185565, XrefRangeEnd = 185574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_SkipString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000A0094 File Offset: 0x0009E294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185577, RefRangeEnd = 185579, XrefRangeStart = 185577, XrefRangeEnd = 185577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNameHash(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000A00E0 File Offset: 0x0009E2E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185580, RefRangeEnd = 185583, XrefRangeStart = 185579, XrefRangeEnd = 185580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNamePosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x000A012C File Offset: 0x0009E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185583, XrefRangeEnd = 185587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x000A016C File Offset: 0x0009E36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x000A01AC File Offset: 0x0009E3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185587, XrefRangeEnd = 185590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceReader.ResourceEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000A01EC File Offset: 0x0009E3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185605, RefRangeEnd = 185606, XrefRangeStart = 185590, XrefRangeEnd = 185605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPosForResource(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000A023C File Offset: 0x0009E43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185618, RefRangeEnd = 185619, XrefRangeStart = 185606, XrefRangeEnd = 185618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareStringEqualsName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000A028C File Offset: 0x0009E48C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185640, RefRangeEnd = 185643, XrefRangeStart = 185619, XrefRangeEnd = 185640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AllocateStringForNameIndex(int index, out int dataOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000A02E0 File Offset: 0x0009E4E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185651, RefRangeEnd = 185653, XrefRangeStart = 185643, XrefRangeEnd = 185651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueForNameIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000A032C File Offset: 0x0009E52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185662, RefRangeEnd = 185663, XrefRangeStart = 185653, XrefRangeEnd = 185662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LoadString(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadString_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000A0370 File Offset: 0x0009E570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185663, XrefRangeEnd = 185664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObject(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x000A03BC File Offset: 0x0009E5BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185668, RefRangeEnd = 185669, XrefRangeStart = 185664, XrefRangeEnd = 185668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObject(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000A0418 File Offset: 0x0009E618
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185670, RefRangeEnd = 185674, XrefRangeStart = 185669, XrefRangeEnd = 185670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObjectV1(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x000A0464 File Offset: 0x0009E664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185769, RefRangeEnd = 185770, XrefRangeStart = 185674, XrefRangeEnd = 185769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _LoadObjectV1(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x000A04B0 File Offset: 0x0009E6B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 185771, RefRangeEnd = 185776, XrefRangeStart = 185770, XrefRangeEnd = 185771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x000A050C File Offset: 0x0009E70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185799, RefRangeEnd = 185800, XrefRangeStart = 185776, XrefRangeEnd = 185799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000A0568 File Offset: 0x0009E768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185806, RefRangeEnd = 185807, XrefRangeStart = 185800, XrefRangeEnd = 185806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DeserializeObject(int typeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000A05B4 File Offset: 0x0009E7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185812, RefRangeEnd = 185813, XrefRangeStart = 185807, XrefRangeEnd = 185812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_ReadResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000A05E8 File Offset: 0x0009E7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185846, RefRangeEnd = 185847, XrefRangeStart = 185813, XrefRangeEnd = 185846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ReadResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__ReadResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000A061C File Offset: 0x0009E81C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185863, RefRangeEnd = 185866, XrefRangeStart = 185847, XrefRangeEnd = 185863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType FindType(int typeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00009387 File Offset: 0x00007587
		public ResourceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x000A0668 File Offset: 0x0009E868
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x00009390 File Offset: 0x00007590
		public unsafe BinaryReader _store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x000A0698 File Offset: 0x0009E898
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x000093AF File Offset: 0x000075AF
		public unsafe Dictionary<string, ResourceLocator> _resCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__resCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__resCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x000A06C8 File Offset: 0x0009E8C8
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x000093CE File Offset: 0x000075CE
		public unsafe long _nameSectionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameSectionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameSectionOffset)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000A06F0 File Offset: 0x0009E8F0
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x000093E9 File Offset: 0x000075E9
		public unsafe long _dataSectionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__dataSectionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__dataSectionOffset)) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x000A0718 File Offset: 0x0009E918
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x00009404 File Offset: 0x00007604
		public unsafe Il2CppStructArray<int> _nameHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x000A0748 File Offset: 0x0009E948
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x00009423 File Offset: 0x00007623
		public unsafe int* _nameHashesPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashesPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashesPtr)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x000A076C File Offset: 0x0009E96C
		// (set) Token: 0x06001B65 RID: 7013 RVA: 0x0000943E File Offset: 0x0000763E
		public unsafe Il2CppStructArray<int> _namePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x000A079C File Offset: 0x0009E99C
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0000945D File Offset: 0x0000765D
		public unsafe int* _namePositionsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositionsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositionsPtr)) = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x00009478 File Offset: 0x00007678
		public unsafe Il2CppReferenceArray<RuntimeType> _typeTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000A07F0 File Offset: 0x0009E9F0
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x00009497 File Offset: 0x00007697
		public unsafe Il2CppStructArray<int> _typeNamePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeNamePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeNamePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x000A0820 File Offset: 0x0009EA20
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x000094B6 File Offset: 0x000076B6
		public unsafe BinaryFormatter _objFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__objFormatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__objFormatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x000A0850 File Offset: 0x0009EA50
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x000094D5 File Offset: 0x000076D5
		public unsafe int _numResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__numResources);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__numResources)) = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x000A0878 File Offset: 0x0009EA78
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x000094F0 File Offset: 0x000076F0
		public unsafe UnmanagedMemoryStream _ums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__ums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnmanagedMemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__ums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000A08A8 File Offset: 0x0009EAA8
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0000950F File Offset: 0x0000770F
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeFieldInfoPtr__store;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeFieldInfoPtr__resCache;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeFieldInfoPtr__nameSectionOffset;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeFieldInfoPtr__dataSectionOffset;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeFieldInfoPtr__nameHashes;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeFieldInfoPtr__nameHashesPtr;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeFieldInfoPtr__namePositions;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr__namePositionsPtr;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeFieldInfoPtr__typeTable;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeFieldInfoPtr__typeNamePositions;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeFieldInfoPtr__objFormatter;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeFieldInfoPtr__numResources;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeFieldInfoPtr__ums;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_SkipString_Private_Void_0;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_LoadString_Internal_String_Int32_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_ReadResources_Private_Void_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr__ReadResources_Private_Void_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0;

		// Token: 0x020005C3 RID: 1475
		public sealed class ResourceEnumerator : Object
		{
			// Token: 0x0600528C RID: 21132 RVA: 0x00174E34 File Offset: 0x00173034
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceEnumerator()
			{
				Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "ResourceEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr);
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_reader");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_currentIsValid");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_currentName");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_dataPosition");
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667976);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667977);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667978);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667979);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667980);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667981);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667982);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667983);
			}

			// Token: 0x0600528D RID: 21133 RVA: 0x00174F50 File Offset: 0x00173150
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 185480, RefRangeEnd = 185482, XrefRangeStart = 185480, XrefRangeEnd = 185480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceEnumerator(ResourceReader reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600528E RID: 21134 RVA: 0x00174F9C File Offset: 0x0017319C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001536 RID: 5430
			// (get) Token: 0x0600528F RID: 21135 RVA: 0x00174FD8 File Offset: 0x001731D8
			public unsafe Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185482, XrefRangeEnd = 185505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001537 RID: 5431
			// (get) Token: 0x06005290 RID: 21136 RVA: 0x00175018 File Offset: 0x00173218
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185505, XrefRangeEnd = 185509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001538 RID: 5432
			// (get) Token: 0x06005291 RID: 21137 RVA: 0x00175058 File Offset: 0x00173258
			public unsafe int DataPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001539 RID: 5433
			// (get) Token: 0x06005292 RID: 21138 RVA: 0x00175094 File Offset: 0x00173294
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 185525, RefRangeEnd = 185526, XrefRangeStart = 185509, XrefRangeEnd = 185525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x1700153A RID: 5434
			// (get) Token: 0x06005293 RID: 21139 RVA: 0x001750CC File Offset: 0x001732CC
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185526, XrefRangeEnd = 185549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005294 RID: 21140 RVA: 0x0017510C File Offset: 0x0017330C
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005295 RID: 21141 RVA: 0x0001F0AE File Offset: 0x0001D2AE
			public ResourceEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001532 RID: 5426
			// (get) Token: 0x06005296 RID: 21142 RVA: 0x00175140 File Offset: 0x00173340
			// (set) Token: 0x06005297 RID: 21143 RVA: 0x0001F0B7 File Offset: 0x0001D2B7
			public unsafe ResourceReader _reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001533 RID: 5427
			// (get) Token: 0x06005298 RID: 21144 RVA: 0x00175170 File Offset: 0x00173370
			// (set) Token: 0x06005299 RID: 21145 RVA: 0x0001F0D6 File Offset: 0x0001D2D6
			public unsafe bool _currentIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid)) = value;
				}
			}

			// Token: 0x17001534 RID: 5428
			// (get) Token: 0x0600529A RID: 21146 RVA: 0x00175198 File Offset: 0x00173398
			// (set) Token: 0x0600529B RID: 21147 RVA: 0x0001F0F1 File Offset: 0x0001D2F1
			public unsafe int _currentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName)) = value;
				}
			}

			// Token: 0x17001535 RID: 5429
			// (get) Token: 0x0600529C RID: 21148 RVA: 0x001751C0 File Offset: 0x001733C0
			// (set) Token: 0x0600529D RID: 21149 RVA: 0x0001F10C File Offset: 0x0001D30C
			public unsafe int _dataPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition)) = value;
				}
			}

			// Token: 0x04004300 RID: 17152
			private static readonly IntPtr NativeFieldInfoPtr__reader;

			// Token: 0x04004301 RID: 17153
			private static readonly IntPtr NativeFieldInfoPtr__currentIsValid;

			// Token: 0x04004302 RID: 17154
			private static readonly IntPtr NativeFieldInfoPtr__currentName;

			// Token: 0x04004303 RID: 17155
			private static readonly IntPtr NativeFieldInfoPtr__dataPosition;

			// Token: 0x04004304 RID: 17156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0;

			// Token: 0x04004305 RID: 17157
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004306 RID: 17158
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004307 RID: 17159
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004308 RID: 17160
			private static readonly IntPtr NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0;

			// Token: 0x04004309 RID: 17161
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x0400430A RID: 17162
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400430B RID: 17163
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}
	}
}
