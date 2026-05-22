using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000041 RID: 65
	public sealed class RegistryKey : MarshalByRefObject
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x00032E74 File Offset: 0x00031074
		// Note: this type is marked as 'beforefieldinit'.
		static RegistryKey()
		{
			Il2CppClassPointerStore<RegistryKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "RegistryKey");
			RegistryKey.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "handle");
			RegistryKey.NativeFieldInfoPtr_safe_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "safe_handle");
			RegistryKey.NativeFieldInfoPtr_hive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "hive");
			RegistryKey.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "qname");
			RegistryKey.NativeFieldInfoPtr_isRemoteRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "isRemoteRoot");
			RegistryKey.NativeFieldInfoPtr_isWritable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "isWritable");
			RegistryKey.NativeFieldInfoPtr_RegistryApi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "RegistryApi");
			RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663905);
			RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663906);
			RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663907);
			RegistryKey.NativeMethodInfoPtr_IsEquals_Internal_Static_Boolean_RegistryKey_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663908);
			RegistryKey.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663909);
			RegistryKey.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663910);
			RegistryKey.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663911);
			RegistryKey.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663912);
			RegistryKey.NativeMethodInfoPtr_get_Handle_Public_get_SafeRegistryHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663913);
			RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663914);
			RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663915);
			RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663916);
			RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663917);
			RegistryKey.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663918);
			RegistryKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663919);
			RegistryKey.NativeMethodInfoPtr_get_IsRoot_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663920);
			RegistryKey.NativeMethodInfoPtr_get_Hive_Internal_get_RegistryHive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663921);
			RegistryKey.NativeMethodInfoPtr_get_InternalHandle_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663922);
			RegistryKey.NativeMethodInfoPtr_AssertKeyStillValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663923);
			RegistryKey.NativeMethodInfoPtr_AssertKeyNameLength_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663924);
			RegistryKey.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663925);
			RegistryKey.NativeMethodInfoPtr_CreateMarkedForDeletionException_Internal_Static_IOException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663926);
			RegistryKey.NativeMethodInfoPtr_GetHiveName_Private_Static_String_RegistryHive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663927);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000330F4 File Offset: 0x000312F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137333, XrefRangeEnd = 137334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(RegistryHive hiveId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hiveId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0003313C File Offset: 0x0003133C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137363, RefRangeEnd = 137364, XrefRangeStart = 137334, XrefRangeEnd = 137363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hiveId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remoteRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000331A0 File Offset: 0x000313A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137364, RefRangeEnd = 137368, XrefRangeStart = 137364, XrefRangeEnd = 137364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(Object data, string keyName, bool writable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0003320C File Offset: 0x0003140C
		[CallerCount(0)]
		public unsafe static bool IsEquals(RegistryKey a, RegistryKey b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_IsEquals_Internal_Static_Boolean_RegistryKey_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00033260 File Offset: 0x00031460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137368, XrefRangeEnd = 137373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00033294 File Offset: 0x00031494
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000332CC File Offset: 0x000314CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137373, XrefRangeEnd = 137380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00033300 File Offset: 0x00031500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137392, RefRangeEnd = 137393, XrefRangeStart = 137380, XrefRangeEnd = 137392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00033334 File Offset: 0x00031534
		public unsafe SafeRegistryHandle Handle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137405, RefRangeEnd = 137406, XrefRangeStart = 137393, XrefRangeEnd = 137405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_Handle_Public_get_SafeRegistryHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeRegistryHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00033374 File Offset: 0x00031574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137406, XrefRangeEnd = 137407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey OpenSubKey(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000333C4 File Offset: 0x000315C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137414, RefRangeEnd = 137419, XrefRangeStart = 137407, XrefRangeEnd = 137414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey OpenSubKey(string name, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00033424 File Offset: 0x00031624
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 137426, RefRangeEnd = 137432, XrefRangeStart = 137419, XrefRangeEnd = 137426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00033474 File Offset: 0x00031674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137432, XrefRangeEnd = 137439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, Object defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000334D8 File Offset: 0x000316D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137439, XrefRangeEnd = 137454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetSubKeyNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00033518 File Offset: 0x00031718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137454, XrefRangeEnd = 137469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00033550 File Offset: 0x00031750
		public unsafe bool IsRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_IsRoot_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0003358C File Offset: 0x0003178C
		public unsafe RegistryHive Hive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137469, XrefRangeEnd = 137471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_Hive_Internal_get_RegistryHive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000335C8 File Offset: 0x000317C8
		public unsafe Object InternalHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_InternalHandle_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00033608 File Offset: 0x00031808
		[CallerCount(0)]
		public unsafe void AssertKeyStillValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_AssertKeyStillValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0003363C File Offset: 0x0003183C
		[CallerCount(0)]
		public unsafe void AssertKeyNameLength(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_AssertKeyNameLength_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00033680 File Offset: 0x00031880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137477, RefRangeEnd = 137478, XrefRangeStart = 137471, XrefRangeEnd = 137477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000336BC File Offset: 0x000318BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137484, RefRangeEnd = 137486, XrefRangeStart = 137478, XrefRangeEnd = 137484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOException CreateMarkedForDeletionException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CreateMarkedForDeletionException_Internal_Static_IOException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOException>(intPtr3) : null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000336F0 File Offset: 0x000318F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137486, XrefRangeEnd = 137494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHiveName(RegistryHive hive)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetHiveName_Private_Static_String_RegistryHive_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003B65 File Offset: 0x00001D65
		public RegistryKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00033728 File Offset: 0x00031928
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003B6E File Offset: 0x00001D6E
		public unsafe Object handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00033758 File Offset: 0x00031958
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003B8D File Offset: 0x00001D8D
		public unsafe SafeRegistryHandle safe_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_safe_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeRegistryHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_safe_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00033788 File Offset: 0x00031988
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003BAC File Offset: 0x00001DAC
		public unsafe Object hive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_hive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_hive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000337B8 File Offset: 0x000319B8
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003BCB File Offset: 0x00001DCB
		public unsafe string qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_qname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_qname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000337E0 File Offset: 0x000319E0
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003BEA File Offset: 0x00001DEA
		public unsafe bool isRemoteRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isRemoteRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isRemoteRoot)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00033808 File Offset: 0x00031A08
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003C05 File Offset: 0x00001E05
		public unsafe bool isWritable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isWritable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isWritable)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00033830 File Offset: 0x00031A30
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003C20 File Offset: 0x00001E20
		public unsafe static IRegistryApi RegistryApi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_RegistryApi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRegistryApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_RegistryApi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_safe_handle;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_hive;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_isRemoteRoot;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_isWritable;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_RegistryApi;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_IntPtr_Boolean_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_String_Boolean_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_IsEquals_Internal_Static_Boolean_RegistryKey_RegistryKey_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_SafeRegistryHandle_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Object_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRoot_Internal_get_Boolean_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_get_Hive_Internal_get_RegistryHive_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalHandle_Internal_get_Object_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_AssertKeyStillValid_Private_Void_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_AssertKeyNameLength_Private_Void_String_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarkedForDeletionException_Internal_Static_IOException_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_GetHiveName_Private_Static_String_RegistryHive_0;
	}
}
