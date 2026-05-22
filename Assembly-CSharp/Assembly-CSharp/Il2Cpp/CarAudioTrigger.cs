using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000025 RID: 37
	public class CarAudioTrigger : MonoBehaviour
	{
		// Token: 0x06000471 RID: 1137 RVA: 0x00040FD4 File Offset: 0x0003F1D4
		// Note: this type is marked as 'beforefieldinit'.
		static CarAudioTrigger()
		{
			Il2CppClassPointerStore<CarAudioTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CarAudioTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarAudioTrigger>.NativeClassPtr);
			CarAudioTrigger.NativeFieldInfoPtr_PointSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarAudioTrigger>.NativeClassPtr, "PointSource");
			CarAudioTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarAudioTrigger>.NativeClassPtr, 100663638);
			CarAudioTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarAudioTrigger>.NativeClassPtr, 100663639);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00041040 File Offset: 0x0003F240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34895, XrefRangeEnd = 34896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarAudioTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00041084 File Offset: 0x0003F284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarAudioTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarAudioTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarAudioTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00004D3A File Offset: 0x00002F3A
		public CarAudioTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000410C0 File Offset: 0x0003F2C0
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00004D43 File Offset: 0x00002F43
		public unsafe SECTR_PointSource PointSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarAudioTrigger.NativeFieldInfoPtr_PointSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PointSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarAudioTrigger.NativeFieldInfoPtr_PointSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_PointSource;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
