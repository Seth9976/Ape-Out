using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000115 RID: 277
	public class LabEndForestMaker : MonoBehaviour
	{
		// Token: 0x060020A6 RID: 8358 RVA: 0x0008F9FC File Offset: 0x0008DBFC
		// Note: this type is marked as 'beforefieldinit'.
		static LabEndForestMaker()
		{
			Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LabEndForestMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr);
			LabEndForestMaker.NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr, "tree");
			LabEndForestMaker.NativeFieldInfoPtr_treeNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr, "treeNum");
			LabEndForestMaker.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr, "width");
			LabEndForestMaker.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr, "height");
			LabEndForestMaker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr, 100665889);
			LabEndForestMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr, 100665890);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0008FAA4 File Offset: 0x0008DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67902, XrefRangeEnd = 67913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabEndForestMaker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0008FAD8 File Offset: 0x0008DCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabEndForestMaker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabEndForestMaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabEndForestMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00016CFD File Offset: 0x00014EFD
		public LabEndForestMaker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0008FB14 File Offset: 0x0008DD14
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x00016D06 File Offset: 0x00014F06
		public unsafe GameObject tree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_tree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_tree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0008FB44 File Offset: 0x0008DD44
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x00016D25 File Offset: 0x00014F25
		public unsafe int treeNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_treeNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_treeNum)) = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0008FB6C File Offset: 0x0008DD6C
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x00016D40 File Offset: 0x00014F40
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0008FB94 File Offset: 0x0008DD94
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x00016D5B File Offset: 0x00014F5B
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabEndForestMaker.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeFieldInfoPtr_tree;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeFieldInfoPtr_treeNum;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
