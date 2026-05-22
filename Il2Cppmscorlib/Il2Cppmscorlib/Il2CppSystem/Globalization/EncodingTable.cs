using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024E RID: 590
	public static class EncodingTable : Object
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x000D86C0 File Offset: 0x000D68C0
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingTable()
		{
			Il2CppClassPointerStore<EncodingTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EncodingTable");
			EncodingTable.NativeFieldInfoPtr_encodingDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "encodingDataPtr");
			EncodingTable.NativeFieldInfoPtr_codePageDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "codePageDataPtr");
			EncodingTable.NativeFieldInfoPtr_lastEncodingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "lastEncodingItem");
			EncodingTable.NativeFieldInfoPtr_hashByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByName");
			EncodingTable.NativeFieldInfoPtr_hashByCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByCodePage");
			EncodingTable.NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669964);
			EncodingTable.NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669965);
			EncodingTable.NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669966);
			EncodingTable.NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669968);
			EncodingTable.NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669969);
			EncodingTable.NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100669970);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000D87C4 File Offset: 0x000D69C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198599, XrefRangeEnd = 198603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumEncodingItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000D87F4 File Offset: 0x000D69F4
		[CallerCount(0)]
		public unsafe static InternalEncodingDataItem ENC(string name, ushort cp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InternalEncodingDataItem(intPtr);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000D8840 File Offset: 0x000D6A40
		[CallerCount(0)]
		public unsafe static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fcp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InternalCodePageDataItem(intPtr);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000D88A8 File Offset: 0x000D6AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198626, RefRangeEnd = 198628, XrefRangeStart = 198603, XrefRangeEnd = 198626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internalGetCodePageFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000D88EC File Offset: 0x000D6AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198628, XrefRangeEnd = 198639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCodePageFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000D8930 File Offset: 0x000D6B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198660, RefRangeEnd = 198661, XrefRangeStart = 198639, XrefRangeEnd = 198660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CodePageDataItem GetCodePageDataItem(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingTable.NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr3) : null;
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0000DDCF File Offset: 0x0000BFCF
		public EncodingTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x000D8970 File Offset: 0x000D6B70
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		public unsafe static Il2CppReferenceArray<InternalEncodingDataItem> encodingDataPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_encodingDataPtr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalEncodingDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_encodingDataPtr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000D8998 File Offset: 0x000D6B98
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x0000DDEA File Offset: 0x0000BFEA
		public unsafe static Il2CppReferenceArray<InternalCodePageDataItem> codePageDataPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_codePageDataPtr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalCodePageDataItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_codePageDataPtr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000D89C0 File Offset: 0x000D6BC0
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		public unsafe static int lastEncodingItem
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_lastEncodingItem, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_lastEncodingItem, (void*)(&value));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000D89DC File Offset: 0x000D6BDC
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x0000DE0A File Offset: 0x0000C00A
		public unsafe static Hashtable hashByName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_hashByName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_hashByName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000D8A04 File Offset: 0x000D6C04
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x0000DE1C File Offset: 0x0000C01C
		public unsafe static Hashtable hashByCodePage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingTable.NativeFieldInfoPtr_hashByCodePage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingTable.NativeFieldInfoPtr_hashByCodePage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeFieldInfoPtr_encodingDataPtr;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeFieldInfoPtr_codePageDataPtr;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeFieldInfoPtr_lastEncodingItem;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeFieldInfoPtr_hashByName;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeFieldInfoPtr_hashByCodePage;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0;
	}
}
