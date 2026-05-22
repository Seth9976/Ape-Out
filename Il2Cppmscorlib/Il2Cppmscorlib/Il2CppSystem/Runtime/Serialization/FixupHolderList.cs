using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000337 RID: 823
	[Serializable]
	public class FixupHolderList : Object
	{
		// Token: 0x06003627 RID: 13863 RVA: 0x0010A3C8 File Offset: 0x001085C8
		// Note: this type is marked as 'beforefieldinit'.
		static FixupHolderList()
		{
			Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolderList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr);
			FixupHolderList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, "m_values");
			FixupHolderList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, "m_count");
			FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671731);
			FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671732);
			FixupHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671733);
			FixupHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671734);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0010A470 File Offset: 0x00108670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214242, XrefRangeEnd = 214245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolderList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x0010A4AC File Offset: 0x001086AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214245, XrefRangeEnd = 214248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolderList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x0010A4F4 File Offset: 0x001086F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214248, XrefRangeEnd = 214254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(FixupHolder fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixupHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0010A544 File Offset: 0x00108744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214260, RefRangeEnd = 214261, XrefRangeStart = 214254, XrefRangeEnd = 214260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0001327B File Offset: 0x0001147B
		public FixupHolderList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x0010A578 File Offset: 0x00108778
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x00013284 File Offset: 0x00011484
		public unsafe Il2CppReferenceArray<FixupHolder> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FixupHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x0010A5A8 File Offset: 0x001087A8
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x000132A3 File Offset: 0x000114A3
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;
	}
}
