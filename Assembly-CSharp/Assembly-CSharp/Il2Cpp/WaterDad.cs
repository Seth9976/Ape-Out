using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001D2 RID: 466
	public class WaterDad : MonoBehaviour
	{
		// Token: 0x06003299 RID: 12953 RVA: 0x000BF454 File Offset: 0x000BD654
		// Note: this type is marked as 'beforefieldinit'.
		static WaterDad()
		{
			Il2CppClassPointerStore<WaterDad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaterDad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterDad>.NativeClassPtr);
			WaterDad.NativeFieldInfoPtr_waterMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "waterMat");
			WaterDad.NativeFieldInfoPtr_paramount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "paramount");
			WaterDad.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "offset");
			WaterDad.NativeFieldInfoPtr_v4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "v4");
			WaterDad.NativeFieldInfoPtr_blip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "blip");
			WaterDad.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "frame");
			WaterDad.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, "defPos");
			WaterDad.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, 100667234);
			WaterDad.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, 100667235);
			WaterDad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterDad>.NativeClassPtr, 100667236);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000BF54C File Offset: 0x000BD74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85896, XrefRangeEnd = 85917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterDad.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000BF580 File Offset: 0x000BD780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85917, XrefRangeEnd = 85951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterDad.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000BF5B4 File Offset: 0x000BD7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterDad()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterDad>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterDad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x00022A8C File Offset: 0x00020C8C
		public WaterDad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x000BF5F0 File Offset: 0x000BD7F0
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x00022A95 File Offset: 0x00020C95
		public unsafe Material waterMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_waterMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_waterMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x000BF620 File Offset: 0x000BD820
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x00022AB4 File Offset: 0x00020CB4
		public unsafe float paramount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_paramount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_paramount)) = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x000BF648 File Offset: 0x000BD848
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x00022ACF File Offset: 0x00020CCF
		public unsafe Vector4 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000BF670 File Offset: 0x000BD870
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x00022AEA File Offset: 0x00020CEA
		public unsafe Vector4 v4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_v4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_v4)) = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x000BF698 File Offset: 0x000BD898
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x00022B05 File Offset: 0x00020D05
		public unsafe int blip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_blip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_blip)) = value;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000BF6C0 File Offset: 0x000BD8C0
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x00022B20 File Offset: 0x00020D20
		public unsafe int frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_frame)) = value;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x000BF6E8 File Offset: 0x000BD8E8
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x00022B3B File Offset: 0x00020D3B
		public unsafe Vector3 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterDad.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeFieldInfoPtr_waterMat;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeFieldInfoPtr_paramount;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeFieldInfoPtr_v4;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeFieldInfoPtr_blip;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeFieldInfoPtr_frame;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
