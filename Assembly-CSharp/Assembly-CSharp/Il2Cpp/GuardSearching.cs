using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000100 RID: 256
	public class GuardSearching : GuardMode
	{
		// Token: 0x06001DC4 RID: 7620 RVA: 0x00087FD4 File Offset: 0x000861D4
		// Note: this type is marked as 'beforefieldinit'.
		static GuardSearching()
		{
			Il2CppClassPointerStore<GuardSearching>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardSearching");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr);
			GuardSearching.NativeFieldInfoPtr_searchGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr, "searchGrid");
			GuardSearching.NativeFieldInfoPtr_searchTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr, "searchTimer");
			GuardSearching.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_SearchGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr, 100665701);
			GuardSearching.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr, 100665702);
			GuardSearching.NativeMethodInfoPtr_SearchDest_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr, 100665703);
			GuardSearching.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr, 100665704);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0008807C File Offset: 0x0008627C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64678, RefRangeEnd = 64680, XrefRangeStart = 64678, XrefRangeEnd = 64678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardSearching(GuardState st, float mSpd, float rRate, SearchGrid sGrid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardSearching>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardSearching.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_SearchGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x000880F8 File Offset: 0x000862F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64680, XrefRangeEnd = 64686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardSearching.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00088134 File Offset: 0x00086334
		[CallerCount(0)]
		public unsafe Vector2 SearchDest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardSearching.NativeMethodInfoPtr_SearchDest_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00088170 File Offset: 0x00086370
		[CallerCount(0)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardSearching.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00014D84 File Offset: 0x00012F84
		public GuardSearching(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000881AC File Offset: 0x000863AC
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00014D8D File Offset: 0x00012F8D
		public unsafe SearchGrid searchGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSearching.NativeFieldInfoPtr_searchGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSearching.NativeFieldInfoPtr_searchGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000881DC File Offset: 0x000863DC
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x00014DAC File Offset: 0x00012FAC
		public unsafe int searchTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSearching.NativeFieldInfoPtr_searchTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSearching.NativeFieldInfoPtr_searchTimer)) = value;
			}
		}

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_searchGrid;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_searchTimer;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_SearchGrid_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_SearchDest_Public_Vector2_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;
	}
}
