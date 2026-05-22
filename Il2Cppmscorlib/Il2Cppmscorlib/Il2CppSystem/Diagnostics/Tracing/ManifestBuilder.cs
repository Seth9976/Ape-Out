using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Resources;
using Il2CppSystem.Text;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000523 RID: 1315
	public class ManifestBuilder : Object
	{
		// Token: 0x06004D69 RID: 19817 RVA: 0x00164348 File Offset: 0x00162548
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestBuilder()
		{
			Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ManifestBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr);
			ManifestBuilder.NativeFieldInfoPtr_opcodeTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "opcodeTab");
			ManifestBuilder.NativeFieldInfoPtr_taskTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "taskTab");
			ManifestBuilder.NativeFieldInfoPtr_keywordTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "keywordTab");
			ManifestBuilder.NativeFieldInfoPtr_mapsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "mapsTab");
			ManifestBuilder.NativeFieldInfoPtr_stringTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "stringTab");
			ManifestBuilder.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "sb");
			ManifestBuilder.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "events");
			ManifestBuilder.NativeFieldInfoPtr_templates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "templates");
			ManifestBuilder.NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "resources");
			ManifestBuilder.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "flags");
			ManifestBuilder.NativeFieldInfoPtr_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "errors");
			ManifestBuilder.NativeFieldInfoPtr_perEventByteArrayArgIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "perEventByteArrayArgIndices");
			ManifestBuilder.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "eventName");
			ManifestBuilder.NativeFieldInfoPtr_numParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "numParams");
			ManifestBuilder.NativeFieldInfoPtr_byteArrArgIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "byteArrArgIndices");
			ManifestBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Guid_String_ResourceManager_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674855);
			ManifestBuilder.NativeMethodInfoPtr_AddOpcode_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674856);
			ManifestBuilder.NativeMethodInfoPtr_AddTask_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674857);
			ManifestBuilder.NativeMethodInfoPtr_AddKeyword_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674858);
			ManifestBuilder.NativeMethodInfoPtr_StartEvent_Public_Void_String_EventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674859);
			ManifestBuilder.NativeMethodInfoPtr_AddEventParameter_Public_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674860);
			ManifestBuilder.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674861);
			ManifestBuilder.NativeMethodInfoPtr_CreateManifest_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674862);
			ManifestBuilder.NativeMethodInfoPtr_get_Errors_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674863);
			ManifestBuilder.NativeMethodInfoPtr_ManifestError_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674864);
			ManifestBuilder.NativeMethodInfoPtr_CreateManifestString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674865);
			ManifestBuilder.NativeMethodInfoPtr_WriteNameAndMessageAttribs_Private_Void_StringBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674866);
			ManifestBuilder.NativeMethodInfoPtr_WriteMessageAttrib_Private_Void_StringBuilder_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674867);
			ManifestBuilder.NativeMethodInfoPtr_GetLocalizedMessage_Internal_String_String_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674868);
			ManifestBuilder.NativeMethodInfoPtr_GetSupportedCultures_Private_Static_List_1_CultureInfo_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674869);
			ManifestBuilder.NativeMethodInfoPtr_GetLevelName_Private_Static_String_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674870);
			ManifestBuilder.NativeMethodInfoPtr_GetTaskName_Private_String_EventTask_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674871);
			ManifestBuilder.NativeMethodInfoPtr_GetOpcodeName_Private_String_EventOpcode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674872);
			ManifestBuilder.NativeMethodInfoPtr_GetKeywords_Private_String_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674873);
			ManifestBuilder.NativeMethodInfoPtr_GetTypeName_Private_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674874);
			ManifestBuilder.NativeMethodInfoPtr_UpdateStringBuilder_Private_Static_Void_byref_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674875);
			ManifestBuilder.NativeMethodInfoPtr_TranslateToManifestConvention_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674876);
			ManifestBuilder.NativeMethodInfoPtr_TranslateIndexToManifestConvention_Private_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674877);
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00164670 File Offset: 0x00162870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241783, RefRangeEnd = 241784, XrefRangeStart = 241683, XrefRangeEnd = 241783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestBuilder(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref providerGuid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dllName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resources);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Guid_String_ResourceManager_EventManifestOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x001646FC File Offset: 0x001628FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241784, XrefRangeEnd = 241824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOpcode(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddOpcode_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x0016474C File Offset: 0x0016294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241824, XrefRangeEnd = 241867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTask(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddTask_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x0016479C File Offset: 0x0016299C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241949, RefRangeEnd = 241950, XrefRangeStart = 241867, XrefRangeEnd = 241949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyword(string name, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddKeyword_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x001647EC File Offset: 0x001629EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242010, RefRangeEnd = 242011, XrefRangeStart = 241950, XrefRangeEnd = 242010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEvent(string eventName, EventAttribute eventAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_StartEvent_Public_Void_String_EventAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00164840 File Offset: 0x00162A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242112, RefRangeEnd = 242113, XrefRangeStart = 242011, XrefRangeEnd = 242112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventParameter(Type type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddEventParameter_Public_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00164894 File Offset: 0x00162A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242143, RefRangeEnd = 242144, XrefRangeStart = 242113, XrefRangeEnd = 242143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x001648C8 File Offset: 0x00162AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242147, RefRangeEnd = 242148, XrefRangeStart = 242144, XrefRangeEnd = 242147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> CreateManifest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_CreateManifest_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x00164908 File Offset: 0x00162B08
		public unsafe IList<string> Errors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_get_Errors_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00164948 File Offset: 0x00162B48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 242152, RefRangeEnd = 242157, XrefRangeStart = 242148, XrefRangeEnd = 242152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManifestError(string msg, bool runtimeCritical = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runtimeCritical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_ManifestError_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x00164998 File Offset: 0x00162B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242529, RefRangeEnd = 242530, XrefRangeStart = 242157, XrefRangeEnd = 242529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateManifestString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_CreateManifestString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x001649D0 File Offset: 0x00162BD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242538, RefRangeEnd = 242541, XrefRangeStart = 242530, XrefRangeEnd = 242538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_WriteNameAndMessageAttribs_Private_Void_StringBuilder_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00164A38 File Offset: 0x00162C38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242561, RefRangeEnd = 242564, XrefRangeStart = 242541, XrefRangeEnd = 242561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_WriteMessageAttrib_Private_Void_StringBuilder_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00164AB4 File Offset: 0x00162CB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242574, RefRangeEnd = 242575, XrefRangeStart = 242564, XrefRangeEnd = 242574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ci);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetLocalizedMessage_Internal_String_String_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00164B1C File Offset: 0x00162D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242602, RefRangeEnd = 242603, XrefRangeStart = 242575, XrefRangeEnd = 242602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CultureInfo> GetSupportedCultures(ResourceManager resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetSupportedCultures_Private_Static_List_1_CultureInfo_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CultureInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00164B60 File Offset: 0x00162D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242603, XrefRangeEnd = 242612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLevelName(EventLevel level)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetLevelName_Private_Static_String_EventLevel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x00164B98 File Offset: 0x00162D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242624, RefRangeEnd = 242625, XrefRangeStart = 242612, XrefRangeEnd = 242624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTaskName(EventTask task, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref task;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetTaskName_Private_String_EventTask_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00164BF0 File Offset: 0x00162DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242641, RefRangeEnd = 242642, XrefRangeStart = 242625, XrefRangeEnd = 242641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOpcodeName(EventOpcode opcode, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetOpcodeName_Private_String_EventOpcode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00164C48 File Offset: 0x00162E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242676, RefRangeEnd = 242677, XrefRangeStart = 242642, XrefRangeEnd = 242676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKeywords(ulong keywords, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keywords;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetKeywords_Private_String_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00164CA0 File Offset: 0x00162EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242710, RefRangeEnd = 242711, XrefRangeStart = 242677, XrefRangeEnd = 242710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetTypeName_Private_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00164CE8 File Offset: 0x00162EE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 242720, RefRangeEnd = 242725, XrefRangeStart = 242711, XrefRangeEnd = 242720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_UpdateStringBuilder_Private_Static_Void_byref_StringBuilder_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			stringBuilder = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00164D64 File Offset: 0x00162F64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242825, RefRangeEnd = 242827, XrefRangeStart = 242725, XrefRangeEnd = 242825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TranslateToManifestConvention(string eventMessage, string evtName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(evtName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_TranslateToManifestConvention_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00164DC0 File Offset: 0x00162FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242837, RefRangeEnd = 242838, XrefRangeStart = 242827, XrefRangeEnd = 242837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TranslateIndexToManifestConvention(int idx, string evtName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(evtName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_TranslateIndexToManifestConvention_Private_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		public ManifestBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06004D82 RID: 19842 RVA: 0x00164E1C File Offset: 0x0016301C
		// (set) Token: 0x06004D83 RID: 19843 RVA: 0x0001CDC5 File Offset: 0x0001AFC5
		public unsafe Dictionary<int, string> opcodeTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_opcodeTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_opcodeTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x00164E4C File Offset: 0x0016304C
		// (set) Token: 0x06004D85 RID: 19845 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		public unsafe Dictionary<int, string> taskTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_taskTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_taskTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x00164E7C File Offset: 0x0016307C
		// (set) Token: 0x06004D87 RID: 19847 RVA: 0x0001CE03 File Offset: 0x0001B003
		public unsafe Dictionary<ulong, string> keywordTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_keywordTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ulong, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_keywordTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x00164EAC File Offset: 0x001630AC
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x0001CE22 File Offset: 0x0001B022
		public unsafe Dictionary<string, Type> mapsTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_mapsTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_mapsTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004D8A RID: 19850 RVA: 0x00164EDC File Offset: 0x001630DC
		// (set) Token: 0x06004D8B RID: 19851 RVA: 0x0001CE41 File Offset: 0x0001B041
		public unsafe Dictionary<string, string> stringTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_stringTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_stringTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x00164F0C File Offset: 0x0016310C
		// (set) Token: 0x06004D8D RID: 19853 RVA: 0x0001CE60 File Offset: 0x0001B060
		public unsafe StringBuilder sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x00164F3C File Offset: 0x0016313C
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x0001CE7F File Offset: 0x0001B07F
		public unsafe StringBuilder events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x00164F6C File Offset: 0x0016316C
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0001CE9E File Offset: 0x0001B09E
		public unsafe StringBuilder templates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_templates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_templates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x00164F9C File Offset: 0x0016319C
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x0001CEBD File Offset: 0x0001B0BD
		public unsafe ResourceManager resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x00164FCC File Offset: 0x001631CC
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x0001CEDC File Offset: 0x0001B0DC
		public unsafe EventManifestOptions flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06004D96 RID: 19862 RVA: 0x00164FF4 File Offset: 0x001631F4
		// (set) Token: 0x06004D97 RID: 19863 RVA: 0x0001CEF7 File Offset: 0x0001B0F7
		public unsafe IList<string> errors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_errors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_errors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x00165024 File Offset: 0x00163224
		// (set) Token: 0x06004D99 RID: 19865 RVA: 0x0001CF16 File Offset: 0x0001B116
		public unsafe Dictionary<string, List<int>> perEventByteArrayArgIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_perEventByteArrayArgIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_perEventByteArrayArgIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x00165054 File Offset: 0x00163254
		// (set) Token: 0x06004D9B RID: 19867 RVA: 0x0001CF35 File Offset: 0x0001B135
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004D9C RID: 19868 RVA: 0x0016507C File Offset: 0x0016327C
		// (set) Token: 0x06004D9D RID: 19869 RVA: 0x0001CF54 File Offset: 0x0001B154
		public unsafe int numParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_numParams);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_numParams)) = value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06004D9E RID: 19870 RVA: 0x001650A4 File Offset: 0x001632A4
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x0001CF6F File Offset: 0x0001B16F
		public unsafe List<int> byteArrArgIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_byteArrArgIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_byteArrArgIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E7B RID: 15995
		private static readonly IntPtr NativeFieldInfoPtr_opcodeTab;

		// Token: 0x04003E7C RID: 15996
		private static readonly IntPtr NativeFieldInfoPtr_taskTab;

		// Token: 0x04003E7D RID: 15997
		private static readonly IntPtr NativeFieldInfoPtr_keywordTab;

		// Token: 0x04003E7E RID: 15998
		private static readonly IntPtr NativeFieldInfoPtr_mapsTab;

		// Token: 0x04003E7F RID: 15999
		private static readonly IntPtr NativeFieldInfoPtr_stringTab;

		// Token: 0x04003E80 RID: 16000
		private static readonly IntPtr NativeFieldInfoPtr_sb;

		// Token: 0x04003E81 RID: 16001
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04003E82 RID: 16002
		private static readonly IntPtr NativeFieldInfoPtr_templates;

		// Token: 0x04003E83 RID: 16003
		private static readonly IntPtr NativeFieldInfoPtr_resources;

		// Token: 0x04003E84 RID: 16004
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04003E85 RID: 16005
		private static readonly IntPtr NativeFieldInfoPtr_errors;

		// Token: 0x04003E86 RID: 16006
		private static readonly IntPtr NativeFieldInfoPtr_perEventByteArrayArgIndices;

		// Token: 0x04003E87 RID: 16007
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04003E88 RID: 16008
		private static readonly IntPtr NativeFieldInfoPtr_numParams;

		// Token: 0x04003E89 RID: 16009
		private static readonly IntPtr NativeFieldInfoPtr_byteArrArgIndices;

		// Token: 0x04003E8A RID: 16010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Guid_String_ResourceManager_EventManifestOptions_0;

		// Token: 0x04003E8B RID: 16011
		private static readonly IntPtr NativeMethodInfoPtr_AddOpcode_Public_Void_String_Int32_0;

		// Token: 0x04003E8C RID: 16012
		private static readonly IntPtr NativeMethodInfoPtr_AddTask_Public_Void_String_Int32_0;

		// Token: 0x04003E8D RID: 16013
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyword_Public_Void_String_UInt64_0;

		// Token: 0x04003E8E RID: 16014
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Void_String_EventAttribute_0;

		// Token: 0x04003E8F RID: 16015
		private static readonly IntPtr NativeMethodInfoPtr_AddEventParameter_Public_Void_Type_String_0;

		// Token: 0x04003E90 RID: 16016
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x04003E91 RID: 16017
		private static readonly IntPtr NativeMethodInfoPtr_CreateManifest_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003E92 RID: 16018
		private static readonly IntPtr NativeMethodInfoPtr_get_Errors_Public_get_IList_1_String_0;

		// Token: 0x04003E93 RID: 16019
		private static readonly IntPtr NativeMethodInfoPtr_ManifestError_Public_Void_String_Boolean_0;

		// Token: 0x04003E94 RID: 16020
		private static readonly IntPtr NativeMethodInfoPtr_CreateManifestString_Private_String_0;

		// Token: 0x04003E95 RID: 16021
		private static readonly IntPtr NativeMethodInfoPtr_WriteNameAndMessageAttribs_Private_Void_StringBuilder_String_String_0;

		// Token: 0x04003E96 RID: 16022
		private static readonly IntPtr NativeMethodInfoPtr_WriteMessageAttrib_Private_Void_StringBuilder_String_String_String_0;

		// Token: 0x04003E97 RID: 16023
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedMessage_Internal_String_String_CultureInfo_Boolean_0;

		// Token: 0x04003E98 RID: 16024
		private static readonly IntPtr NativeMethodInfoPtr_GetSupportedCultures_Private_Static_List_1_CultureInfo_ResourceManager_0;

		// Token: 0x04003E99 RID: 16025
		private static readonly IntPtr NativeMethodInfoPtr_GetLevelName_Private_Static_String_EventLevel_0;

		// Token: 0x04003E9A RID: 16026
		private static readonly IntPtr NativeMethodInfoPtr_GetTaskName_Private_String_EventTask_String_0;

		// Token: 0x04003E9B RID: 16027
		private static readonly IntPtr NativeMethodInfoPtr_GetOpcodeName_Private_String_EventOpcode_String_0;

		// Token: 0x04003E9C RID: 16028
		private static readonly IntPtr NativeMethodInfoPtr_GetKeywords_Private_String_UInt64_String_0;

		// Token: 0x04003E9D RID: 16029
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Private_String_Type_0;

		// Token: 0x04003E9E RID: 16030
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStringBuilder_Private_Static_Void_byref_StringBuilder_String_Int32_Int32_0;

		// Token: 0x04003E9F RID: 16031
		private static readonly IntPtr NativeMethodInfoPtr_TranslateToManifestConvention_Private_String_String_String_0;

		// Token: 0x04003EA0 RID: 16032
		private static readonly IntPtr NativeMethodInfoPtr_TranslateIndexToManifestConvention_Private_Int32_Int32_String_0;

		// Token: 0x0200068D RID: 1677
		[ObfuscatedName("System.Diagnostics.Tracing.ManifestBuilder+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x0600592E RID: 22830 RVA: 0x0018BFE4 File Offset: 0x0018A1E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr);
				ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, "stringBuilder");
				ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_eventMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, "eventMessage");
				ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_writtenSoFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, "writtenSoFar");
				ManifestBuilder.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, 100674878);
			}

			// Token: 0x0600592F RID: 22831 RVA: 0x0018C060 File Offset: 0x0018A260
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005930 RID: 22832 RVA: 0x000221B2 File Offset: 0x000203B2
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001718 RID: 5912
			// (get) Token: 0x06005931 RID: 22833 RVA: 0x0018C09C File Offset: 0x0018A29C
			// (set) Token: 0x06005932 RID: 22834 RVA: 0x000221BB File Offset: 0x000203BB
			public unsafe StringBuilder stringBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_stringBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001719 RID: 5913
			// (get) Token: 0x06005933 RID: 22835 RVA: 0x0018C0CC File Offset: 0x0018A2CC
			// (set) Token: 0x06005934 RID: 22836 RVA: 0x000221DA File Offset: 0x000203DA
			public unsafe string eventMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_eventMessage);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_eventMessage), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700171A RID: 5914
			// (get) Token: 0x06005935 RID: 22837 RVA: 0x0018C0F4 File Offset: 0x0018A2F4
			// (set) Token: 0x06005936 RID: 22838 RVA: 0x000221F9 File Offset: 0x000203F9
			public unsafe int writtenSoFar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_writtenSoFar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_writtenSoFar)) = value;
				}
			}

			// Token: 0x04004767 RID: 18279
			private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

			// Token: 0x04004768 RID: 18280
			private static readonly IntPtr NativeFieldInfoPtr_eventMessage;

			// Token: 0x04004769 RID: 18281
			private static readonly IntPtr NativeFieldInfoPtr_writtenSoFar;

			// Token: 0x0400476A RID: 18282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200068E RID: 1678
		[ObfuscatedName("System.Diagnostics.Tracing.ManifestBuilder+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : Object
		{
			// Token: 0x06005937 RID: 22839 RVA: 0x0018C11C File Offset: 0x0018A31C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr);
				ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, "i");
				ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, "CS$<>8__locals1");
				ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, 100674879);
				ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__TranslateToManifestConvention_b__0_Internal_Void_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, 100674880);
			}

			// Token: 0x06005938 RID: 22840 RVA: 0x0018C198 File Offset: 0x0018A398
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005939 RID: 22841 RVA: 0x0018C1D4 File Offset: 0x0018A3D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241681, XrefRangeEnd = 241683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TranslateToManifestConvention_b__0(char ch, string escape)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(escape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__TranslateToManifestConvention_b__0_Internal_Void_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600593A RID: 22842 RVA: 0x00022214 File Offset: 0x00020414
			public __c__DisplayClass22_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700171B RID: 5915
			// (get) Token: 0x0600593B RID: 22843 RVA: 0x0018C224 File Offset: 0x0018A424
			// (set) Token: 0x0600593C RID: 22844 RVA: 0x0002221D File Offset: 0x0002041D
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700171C RID: 5916
			// (get) Token: 0x0600593D RID: 22845 RVA: 0x0018C24C File Offset: 0x0018A44C
			// (set) Token: 0x0600593E RID: 22846 RVA: 0x00022238 File Offset: 0x00020438
			public unsafe ManifestBuilder.__c__DisplayClass22_0 field_Public___c__DisplayClass22_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManifestBuilder.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400476B RID: 18283
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400476C RID: 18284
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0;

			// Token: 0x0400476D RID: 18285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400476E RID: 18286
			private static readonly IntPtr NativeMethodInfoPtr__TranslateToManifestConvention_b__0_Internal_Void_Char_String_0;
		}
	}
}
