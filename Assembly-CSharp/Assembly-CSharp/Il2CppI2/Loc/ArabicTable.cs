using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x02000266 RID: 614
	public class ArabicTable : Object
	{
		// Token: 0x0600464E RID: 17998 RVA: 0x001065B0 File Offset: 0x001047B0
		// Note: this type is marked as 'beforefieldinit'.
		static ArabicTable()
		{
			Il2CppClassPointerStore<ArabicTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ArabicTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr);
			ArabicTable.NativeFieldInfoPtr_mapList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr, "mapList");
			ArabicTable.NativeFieldInfoPtr_arabicMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr, "arabicMapper");
			ArabicTable.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr, 100670408);
			ArabicTable.NativeMethodInfoPtr_get_ArabicMapper_Internal_Static_get_ArabicTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr, 100670409);
			ArabicTable.NativeMethodInfoPtr_Convert_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr, 100670410);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00106644 File Offset: 0x00104844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114871, RefRangeEnd = 114873, XrefRangeStart = 114655, XrefRangeEnd = 114871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArabicTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArabicTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArabicTable.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x00106680 File Offset: 0x00104880
		public unsafe static ArabicTable ArabicMapper
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114873, XrefRangeEnd = 114879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArabicTable.NativeMethodInfoPtr_get_ArabicMapper_Internal_Static_get_ArabicTable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArabicTable>(intPtr3) : null;
			}
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x001066B4 File Offset: 0x001048B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114889, RefRangeEnd = 114890, XrefRangeStart = 114879, XrefRangeEnd = 114889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Convert(int toBeConverted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toBeConverted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArabicTable.NativeMethodInfoPtr_Convert_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00029DAE File Offset: 0x00027FAE
		public ArabicTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x00106700 File Offset: 0x00104900
		// (set) Token: 0x06004654 RID: 18004 RVA: 0x00029DB7 File Offset: 0x00027FB7
		public unsafe static List<ArabicMapping> mapList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArabicTable.NativeFieldInfoPtr_mapList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArabicMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArabicTable.NativeFieldInfoPtr_mapList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x00106728 File Offset: 0x00104928
		// (set) Token: 0x06004656 RID: 18006 RVA: 0x00029DC9 File Offset: 0x00027FC9
		public unsafe static ArabicTable arabicMapper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArabicTable.NativeFieldInfoPtr_arabicMapper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArabicTable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArabicTable.NativeFieldInfoPtr_arabicMapper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeFieldInfoPtr_mapList;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeFieldInfoPtr_arabicMapper;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeMethodInfoPtr_get_ArabicMapper_Internal_Static_get_ArabicTable_0;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Internal_Int32_Int32_0;
	}
}
