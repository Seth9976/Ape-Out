using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E0 RID: 224
	public class FloorScoreSpawner : MonoBehaviour
	{
		// Token: 0x0600199A RID: 6554 RVA: 0x0007C264 File Offset: 0x0007A464
		// Note: this type is marked as 'beforefieldinit'.
		static FloorScoreSpawner()
		{
			Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FloorScoreSpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr);
			FloorScoreSpawner.NativeFieldInfoPtr_texts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, "texts");
			FloorScoreSpawner.NativeFieldInfoPtr_playerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, "playerPos");
			FloorScoreSpawner.NativeFieldInfoPtr_collideWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, "collideWith");
			FloorScoreSpawner.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, "me");
			FloorScoreSpawner.NativeFieldInfoPtr_ind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, "ind");
			FloorScoreSpawner.NativeFieldInfoPtr_textRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, "textRend");
			FloorScoreSpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, 100665389);
			FloorScoreSpawner.NativeMethodInfoPtr_PostText_Public_Void_Int32_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, 100665390);
			FloorScoreSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr, 100665391);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0007C348 File Offset: 0x0007A548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59216, XrefRangeEnd = 59220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorScoreSpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0007C37C File Offset: 0x0007A57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59257, RefRangeEnd = 59258, XrefRangeStart = 59220, XrefRangeEnd = 59257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostText(int score, Vector2 origin, Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref score;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorScoreSpawner.NativeMethodInfoPtr_PostText_Public_Void_Int32_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0007C3D8 File Offset: 0x0007A5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorScoreSpawner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorScoreSpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorScoreSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000123E2 File Offset: 0x000105E2
		public FloorScoreSpawner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x0007C414 File Offset: 0x0007A614
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x000123EB File Offset: 0x000105EB
		public unsafe Il2CppReferenceArray<TextMesh> texts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_texts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_texts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0007C444 File Offset: 0x0007A644
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0001240A File Offset: 0x0001060A
		public unsafe Transform playerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_playerPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_playerPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x0007C474 File Offset: 0x0007A674
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x00012429 File Offset: 0x00010629
		public unsafe LayerMask collideWith
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_collideWith);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_collideWith)) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x0007C49C File Offset: 0x0007A69C
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x00012444 File Offset: 0x00010644
		public unsafe static FloorScoreSpawner me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FloorScoreSpawner.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloorScoreSpawner>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FloorScoreSpawner.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0007C4C4 File Offset: 0x0007A6C4
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x00012456 File Offset: 0x00010656
		public unsafe int ind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_ind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_ind)) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0007C4EC File Offset: 0x0007A6EC
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x00012471 File Offset: 0x00010671
		public unsafe MeshRenderer textRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_textRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorScoreSpawner.NativeFieldInfoPtr_textRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_texts;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_playerPos;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr_collideWith;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_ind;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeFieldInfoPtr_textRend;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_PostText_Public_Void_Int32_Vector2_Vector2_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
