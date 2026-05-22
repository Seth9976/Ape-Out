using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200007E RID: 126
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x06001063 RID: 4195 RVA: 0x00063DA8 File Offset: 0x00061FA8
		// Note: this type is marked as 'beforefieldinit'.
		static BlinkingLight()
		{
			Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BlinkingLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr);
			BlinkingLight.NativeFieldInfoPtr_tim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "tim");
			BlinkingLight.NativeFieldInfoPtr_spr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "spr");
			BlinkingLight.NativeFieldInfoPtr_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "rate");
			BlinkingLight.NativeFieldInfoPtr_blinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "blinkTime");
			BlinkingLight.NativeFieldInfoPtr_col1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "col1");
			BlinkingLight.NativeFieldInfoPtr_col2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "col2");
			BlinkingLight.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100664673);
			BlinkingLight.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100664674);
			BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100664675);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00063E8C File Offset: 0x0006208C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48153, XrefRangeEnd = 48158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00063EC0 File Offset: 0x000620C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48158, XrefRangeEnd = 48160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00063EF4 File Offset: 0x000620F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48160, XrefRangeEnd = 48163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlinkingLight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0000C236 File Offset: 0x0000A436
		public BlinkingLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00063F30 File Offset: 0x00062130
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x0000C23F File Offset: 0x0000A43F
		public unsafe int tim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_tim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_tim)) = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00063F58 File Offset: 0x00062158
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x0000C25A File Offset: 0x0000A45A
		public unsafe SpriteRenderer spr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_spr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_spr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00063F88 File Offset: 0x00062188
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x0000C279 File Offset: 0x0000A479
		public unsafe int rate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_rate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_rate)) = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00063FB0 File Offset: 0x000621B0
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x0000C294 File Offset: 0x0000A494
		public unsafe int blinkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkTime)) = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00063FD8 File Offset: 0x000621D8
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x0000C2AF File Offset: 0x0000A4AF
		public unsafe Color col1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_col1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_col1)) = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00064000 File Offset: 0x00062200
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x0000C2CA File Offset: 0x0000A4CA
		public unsafe Color col2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_col2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_col2)) = value;
			}
		}

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_tim;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_spr;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr_rate;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr_blinkTime;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_col1;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_col2;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
