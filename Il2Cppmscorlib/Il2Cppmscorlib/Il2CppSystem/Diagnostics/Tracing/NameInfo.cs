using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D2 RID: 1234
	public sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>
	{
		// Token: 0x060049C5 RID: 18885 RVA: 0x001551D0 File Offset: 0x001533D0
		// Note: this type is marked as 'beforefieldinit'.
		static NameInfo()
		{
			Il2CppClassPointerStore<NameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameInfo>.NativeClassPtr);
			NameInfo.NativeFieldInfoPtr_lastIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "lastIdentity");
			NameInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "name");
			NameInfo.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "tags");
			NameInfo.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "identity");
			NameInfo.NativeFieldInfoPtr_nameMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "nameMetadata");
			NameInfo.NativeMethodInfoPtr_ReserveEventIDsBelow_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100674319);
			NameInfo.NativeMethodInfoPtr__ctor_Public_Void_String_EventTags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100674320);
			NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100674321);
			NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_String_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100674322);
			NameInfo.NativeMethodInfoPtr_Compare_Private_Int32_String_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100674323);
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x001552C8 File Offset: 0x001534C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233793, XrefRangeEnd = 233801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReserveEventIDsBelow(int eventId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_ReserveEventIDsBelow_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x001552FC File Offset: 0x001534FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233810, RefRangeEnd = 233811, XrefRangeStart = 233801, XrefRangeEnd = 233810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo(string name, EventTags tags, int typeMetadataSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeMetadataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr__ctor_Public_Void_String_EventTags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00155364 File Offset: 0x00153564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233811, XrefRangeEnd = 233815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(NameInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x001553B4 File Offset: 0x001535B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233815, XrefRangeEnd = 233818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(KeyValuePair<string, EventTags> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_String_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00155408 File Offset: 0x00153608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233822, RefRangeEnd = 233823, XrefRangeStart = 233818, XrefRangeEnd = 233822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string otherName, EventTags otherTags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(otherName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref otherTags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Compare_Private_Int32_String_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x0001BA2D File Offset: 0x00019C2D
		public NameInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x060049CC RID: 18892 RVA: 0x00155464 File Offset: 0x00153664
		// (set) Token: 0x060049CD RID: 18893 RVA: 0x0001BA36 File Offset: 0x00019C36
		public unsafe static int lastIdentity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NameInfo.NativeFieldInfoPtr_lastIdentity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameInfo.NativeFieldInfoPtr_lastIdentity, (void*)(&value));
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x060049CE RID: 18894 RVA: 0x00155480 File Offset: 0x00153680
		// (set) Token: 0x060049CF RID: 18895 RVA: 0x0001BA44 File Offset: 0x00019C44
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x060049D0 RID: 18896 RVA: 0x001554A8 File Offset: 0x001536A8
		// (set) Token: 0x060049D1 RID: 18897 RVA: 0x0001BA63 File Offset: 0x00019C63
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x001554D0 File Offset: 0x001536D0
		// (set) Token: 0x060049D3 RID: 18899 RVA: 0x0001BA7E File Offset: 0x00019C7E
		public unsafe int identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_identity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_identity)) = value;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x001554F8 File Offset: 0x001536F8
		// (set) Token: 0x060049D5 RID: 18901 RVA: 0x0001BA99 File Offset: 0x00019C99
		public unsafe Il2CppStructArray<byte> nameMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_nameMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_nameMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeFieldInfoPtr_lastIdentity;

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeFieldInfoPtr_nameMetadata;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeMethodInfoPtr_ReserveEventIDsBelow_Internal_Static_Void_Int32_0;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EventTags_Int32_0;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_NameInfo_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_String_EventTags_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Int32_String_EventTags_0;
	}
}
