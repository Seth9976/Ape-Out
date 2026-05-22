using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002C0 RID: 704
	[Serializable]
	public sealed class SecurityDocument : Object
	{
		// Token: 0x06002FE0 RID: 12256 RVA: 0x000F3044 File Offset: 0x000F1244
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityDocument()
		{
			Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr);
			SecurityDocument.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, "m_data");
			SecurityDocument.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670928);
			SecurityDocument.NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670929);
			SecurityDocument.NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670930);
			SecurityDocument.NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670931);
			SecurityDocument.NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670932);
			SecurityDocument.NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670933);
			SecurityDocument.NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670934);
			SecurityDocument.NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670935);
			SecurityDocument.NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670936);
			SecurityDocument.NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670937);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x000F3150 File Offset: 0x000F1350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207630, XrefRangeEnd = 207633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityDocument(int numData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x000F3198 File Offset: 0x000F1398
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 207637, RefRangeEnd = 207643, XrefRangeStart = 207633, XrefRangeEnd = 207637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuaranteeSize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x000F31D8 File Offset: 0x000F13D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207645, RefRangeEnd = 207648, XrefRangeStart = 207643, XrefRangeEnd = 207645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string str, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000F3228 File Offset: 0x000F1428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207659, RefRangeEnd = 207661, XrefRangeStart = 207648, XrefRangeEnd = 207659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendString(string str, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x000F3278 File Offset: 0x000F1478
		[CallerCount(0)]
		public unsafe static int EncodedStringSize(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x000F32BC File Offset: 0x000F14BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207682, RefRangeEnd = 207686, XrefRangeStart = 207661, XrefRangeEnd = 207682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(ref int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x000F3310 File Offset: 0x000F1510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207686, XrefRangeEnd = 207687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToken(byte b, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000F335C File Offset: 0x000F155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207687, XrefRangeEnd = 207688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetRootElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000F339C File Offset: 0x000F159C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207688, XrefRangeEnd = 207689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetElement(int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000F33F8 File Offset: 0x000F15F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 207702, RefRangeEnd = 207708, XrefRangeStart = 207689, XrefRangeEnd = 207702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement InternalGetElement(ref int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000108F7 File Offset: 0x0000EAF7
		public SecurityDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000F3454 File Offset: 0x000F1654
		// (set) Token: 0x06002FED RID: 12269 RVA: 0x00010900 File Offset: 0x0000EB00
		public unsafe Il2CppStructArray<byte> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityDocument.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityDocument.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0;
	}
}
