using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E2 RID: 226
	public class Forester : MonoBehaviour
	{
		// Token: 0x060019BD RID: 6589 RVA: 0x0007C838 File Offset: 0x0007AA38
		// Note: this type is marked as 'beforefieldinit'.
		static Forester()
		{
			Il2CppClassPointerStore<Forester>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Forester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Forester>.NativeClassPtr);
			Forester.NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "tree");
			Forester.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "defPos");
			Forester.NativeFieldInfoPtr_trees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "trees");
			Forester.NativeFieldInfoPtr_treeNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "treeNum");
			Forester.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "cam");
			Forester.NativeFieldInfoPtr_frameNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "frameNum");
			Forester.NativeFieldInfoPtr_conveyerWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "conveyerWidth");
			Forester.NativeFieldInfoPtr_above = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "above");
			Forester.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forester>.NativeClassPtr, "pos");
			Forester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forester>.NativeClassPtr, 100665396);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0007C930 File Offset: 0x0007AB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Forester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Forester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0001255E File Offset: 0x0001075E
		public Forester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0007C96C File Offset: 0x0007AB6C
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00012567 File Offset: 0x00010767
		public unsafe GameObject tree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_tree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_tree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0007C99C File Offset: 0x0007AB9C
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x00012586 File Offset: 0x00010786
		public unsafe Vector2 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0007C9C4 File Offset: 0x0007ABC4
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x000125A1 File Offset: 0x000107A1
		public unsafe Il2CppReferenceArray<GameObject> trees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_trees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_trees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0007C9F4 File Offset: 0x0007ABF4
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x000125C0 File Offset: 0x000107C0
		public unsafe int treeNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_treeNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_treeNum)) = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0007CA1C File Offset: 0x0007AC1C
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x000125DB File Offset: 0x000107DB
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0007CA4C File Offset: 0x0007AC4C
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x000125FA File Offset: 0x000107FA
		public unsafe int frameNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_frameNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_frameNum)) = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0007CA74 File Offset: 0x0007AC74
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00012615 File Offset: 0x00010815
		public unsafe float conveyerWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_conveyerWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_conveyerWidth)) = value;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0007CA9C File Offset: 0x0007AC9C
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00012630 File Offset: 0x00010830
		public unsafe bool above
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_above);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_above)) = value;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0007CAC4 File Offset: 0x0007ACC4
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0001264B File Offset: 0x0001084B
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forester.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeFieldInfoPtr_tree;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeFieldInfoPtr_trees;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeFieldInfoPtr_treeNum;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr_frameNum;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_conveyerWidth;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr_above;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
