using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E1 RID: 225
	public class FootprintEmitter : MonoBehaviour
	{
		// Token: 0x060019AB RID: 6571 RVA: 0x0007C51C File Offset: 0x0007A71C
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintEmitter()
		{
			Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FootprintEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr);
			FootprintEmitter.NativeFieldInfoPtr_emitterLeftFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, "emitterLeftFront");
			FootprintEmitter.NativeFieldInfoPtr_emitterRightFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, "emitterRightFront");
			FootprintEmitter.NativeFieldInfoPtr_emitterLeftBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, "emitterLeftBack");
			FootprintEmitter.NativeFieldInfoPtr_emitterRightBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, "emitterRightBack");
			FootprintEmitter.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, "param");
			FootprintEmitter.NativeFieldInfoPtr_textureSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, "textureSheet");
			FootprintEmitter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, 100665392);
			FootprintEmitter.NativeMethodInfoPtr_Footprint_Public_Void_Foot_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, 100665393);
			FootprintEmitter.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, 100665394);
			FootprintEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr, 100665395);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0007C614 File Offset: 0x0007A814
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintEmitter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0007C648 File Offset: 0x0007A848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59273, RefRangeEnd = 59274, XrefRangeStart = 59258, XrefRangeEnd = 59273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Footprint(FootprintEmitter.Foot footIndex, Vector2 worldPos, float angle, float bloodiness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref footIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bloodiness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintEmitter.NativeMethodInfoPtr_Footprint_Public_Void_Foot_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0007C6B0 File Offset: 0x0007A8B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 59291, RefRangeEnd = 59295, XrefRangeStart = 59274, XrefRangeEnd = 59291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintEmitter.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0007C6E4 File Offset: 0x0007A8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintEmitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintEmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00012490 File Offset: 0x00010690
		public FootprintEmitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x0007C720 File Offset: 0x0007A920
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x00012499 File Offset: 0x00010699
		public unsafe ParticleSystem emitterLeftFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterLeftFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterLeftFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x0007C750 File Offset: 0x0007A950
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x000124B8 File Offset: 0x000106B8
		public unsafe ParticleSystem emitterRightFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterRightFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterRightFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0007C780 File Offset: 0x0007A980
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x000124D7 File Offset: 0x000106D7
		public unsafe ParticleSystem emitterLeftBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterLeftBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterLeftBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x0007C7B0 File Offset: 0x0007A9B0
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x000124F6 File Offset: 0x000106F6
		public unsafe ParticleSystem emitterRightBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterRightBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_emitterRightBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x0007C7E0 File Offset: 0x0007A9E0
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00012515 File Offset: 0x00010715
		public unsafe ParticleSystem.EmitParams param
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_param);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_param)) = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0007C808 File Offset: 0x0007AA08
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00012530 File Offset: 0x00010730
		public ParticleSystem.TextureSheetAnimationModule textureSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_textureSheet);
				return new ParticleSystem.TextureSheetAnimationModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintEmitter.NativeFieldInfoPtr_textureSheet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr_emitterLeftFront;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeFieldInfoPtr_emitterRightFront;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr_emitterLeftBack;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_emitterRightBack;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_param;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeFieldInfoPtr_textureSheet;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_Footprint_Public_Void_Foot_Vector2_Single_Single_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FC RID: 764
		[OriginalName("Assembly-CSharp.dll", "", "Foot")]
		public enum Foot
		{
			// Token: 0x040033DC RID: 13276
			LeftFront,
			// Token: 0x040033DD RID: 13277
			RightFront,
			// Token: 0x040033DE RID: 13278
			LeftBack,
			// Token: 0x040033DF RID: 13279
			RightBack
		}
	}
}
