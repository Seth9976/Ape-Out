using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D9 RID: 217
	public class FlameLightSkirt : MonoBehaviour
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x0007AE20 File Offset: 0x00079020
		// Note: this type is marked as 'beforefieldinit'.
		static FlameLightSkirt()
		{
			Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlameLightSkirt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr);
			FlameLightSkirt.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, "mesher");
			FlameLightSkirt.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, "pts");
			FlameLightSkirt.NativeFieldInfoPtr_blip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, "blip");
			FlameLightSkirt.NativeFieldInfoPtr_fireInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, "fireInstance");
			FlameLightSkirt.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, "myPos");
			FlameLightSkirt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, 100665357);
			FlameLightSkirt.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, 100665358);
			FlameLightSkirt.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, 100665359);
			FlameLightSkirt.NativeMethodInfoPtr_MakeMesh_Public_Void_MeshFilter_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, 100665360);
			FlameLightSkirt.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, 100665361);
			FlameLightSkirt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr, 100665362);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0007AF2C File Offset: 0x0007912C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58628, XrefRangeEnd = 58629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameLightSkirt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0007AF60 File Offset: 0x00079160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58629, XrefRangeEnd = 58646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameLightSkirt.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0007AF94 File Offset: 0x00079194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58646, XrefRangeEnd = 58650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameLightSkirt.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0007AFC8 File Offset: 0x000791C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58700, RefRangeEnd = 58701, XrefRangeStart = 58650, XrefRangeEnd = 58700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeMesh(MeshFilter msh, int ptNum, float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameLightSkirt.NativeMethodInfoPtr_MakeMesh_Public_Void_MeshFilter_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0007B028 File Offset: 0x00079228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58701, XrefRangeEnd = 58718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameLightSkirt.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0007B05C File Offset: 0x0007925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlameLightSkirt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlameLightSkirt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameLightSkirt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00011F7A File Offset: 0x0001017A
		public FlameLightSkirt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0007B098 File Offset: 0x00079298
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00011F83 File Offset: 0x00010183
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0007B0C8 File Offset: 0x000792C8
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00011FA2 File Offset: 0x000101A2
		public unsafe Il2CppStructArray<Vector3> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0007B0F8 File Offset: 0x000792F8
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00011FC1 File Offset: 0x000101C1
		public unsafe int blip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_blip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_blip)) = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0007B120 File Offset: 0x00079320
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00011FDC File Offset: 0x000101DC
		public SECTR_AudioCueInstance fireInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_fireInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_fireInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0007B150 File Offset: 0x00079350
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0001200A File Offset: 0x0001020A
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameLightSkirt.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeFieldInfoPtr_blip;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeFieldInfoPtr_fireInstance;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_MakeMesh_Public_Void_MeshFilter_Int32_Single_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
