using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200019D RID: 413
	public class SortingLayerExposed : MonoBehaviour
	{
		// Token: 0x06002FFC RID: 12284 RVA: 0x000B880C File Offset: 0x000B6A0C
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayerExposed()
		{
			Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SortingLayerExposed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr);
			SortingLayerExposed.NativeFieldInfoPtr_sortingLayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr, "sortingLayerName");
			SortingLayerExposed.NativeFieldInfoPtr_sortingLayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr, "sortingLayerId");
			SortingLayerExposed.NativeFieldInfoPtr_sortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr, "sortingOrder");
			SortingLayerExposed.NativeMethodInfoPtr_ChangeShit_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr, 100667049);
			SortingLayerExposed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr, 100667050);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000B88A0 File Offset: 0x000B6AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83915, XrefRangeEnd = 83929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeShit(string name, int order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerExposed.NativeMethodInfoPtr_ChangeShit_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000B88F0 File Offset: 0x000B6AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingLayerExposed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerExposed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x000210CA File Offset: 0x0001F2CA
		public SortingLayerExposed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x000B892C File Offset: 0x000B6B2C
		// (set) Token: 0x06003001 RID: 12289 RVA: 0x000210D3 File Offset: 0x0001F2D3
		public unsafe string sortingLayerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortingLayerExposed.NativeFieldInfoPtr_sortingLayerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortingLayerExposed.NativeFieldInfoPtr_sortingLayerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x000B8954 File Offset: 0x000B6B54
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x000210F2 File Offset: 0x0001F2F2
		public unsafe int sortingLayerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortingLayerExposed.NativeFieldInfoPtr_sortingLayerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortingLayerExposed.NativeFieldInfoPtr_sortingLayerId)) = value;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000B897C File Offset: 0x000B6B7C
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x0002110D File Offset: 0x0001F30D
		public unsafe int sortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortingLayerExposed.NativeFieldInfoPtr_sortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortingLayerExposed.NativeFieldInfoPtr_sortingOrder)) = value;
			}
		}

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_sortingLayerName;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_sortingLayerId;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_sortingOrder;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_ChangeShit_Public_Void_String_Int32_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
