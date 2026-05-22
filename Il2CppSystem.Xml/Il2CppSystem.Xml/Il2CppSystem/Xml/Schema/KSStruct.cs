using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000103 RID: 259
	public class KSStruct : Object
	{
		// Token: 0x06001595 RID: 5525 RVA: 0x0006F3FC File Offset: 0x0006D5FC
		// Note: this type is marked as 'beforefieldinit'.
		static KSStruct()
		{
			Il2CppClassPointerStore<KSStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "KSStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KSStruct>.NativeClassPtr);
			KSStruct.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, "depth");
			KSStruct.NativeFieldInfoPtr_ks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, "ks");
			KSStruct.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, "fields");
			KSStruct.NativeMethodInfoPtr__ctor_Public_Void_KeySequence_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, 100666567);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0006F47C File Offset: 0x0006D67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409093, XrefRangeEnd = 409096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KSStruct(KeySequence ks, int dim)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KSStruct>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ks);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KSStruct.NativeMethodInfoPtr__ctor_Public_Void_KeySequence_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00009A47 File Offset: 0x00007C47
		public KSStruct(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0006F4D8 File Offset: 0x0006D6D8
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x00009A50 File Offset: 0x00007C50
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0006F500 File Offset: 0x0006D700
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00009A6B File Offset: 0x00007C6B
		public unsafe KeySequence ks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_ks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeySequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_ks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0006F530 File Offset: 0x0006D730
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x00009A8A File Offset: 0x00007C8A
		public unsafe Il2CppReferenceArray<LocatedActiveAxis> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocatedActiveAxis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr_ks;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeySequence_Int32_0;
	}
}
