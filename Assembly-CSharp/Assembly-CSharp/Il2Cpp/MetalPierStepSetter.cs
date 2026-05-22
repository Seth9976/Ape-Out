using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000131 RID: 305
	public class MetalPierStepSetter : MonoBehaviour
	{
		// Token: 0x0600261E RID: 9758 RVA: 0x0009E164 File Offset: 0x0009C364
		// Note: this type is marked as 'beforefieldinit'.
		static MetalPierStepSetter()
		{
			Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MetalPierStepSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr);
			MetalPierStepSetter.NativeFieldInfoPtr_endTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr, "endTile");
			MetalPierStepSetter.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr, 100666331);
			MetalPierStepSetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr, 100666332);
			MetalPierStepSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr, 100666333);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0009E1E4 File Offset: 0x0009C3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74237, XrefRangeEnd = 74239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetalPierStepSetter.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0009E218 File Offset: 0x0009C418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74239, XrefRangeEnd = 74247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetalPierStepSetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0009E24C File Offset: 0x0009C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetalPierStepSetter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetalPierStepSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetalPierStepSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0001AAD1 File Offset: 0x00018CD1
		public MetalPierStepSetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x0009E288 File Offset: 0x0009C488
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x0001AADA File Offset: 0x00018CDA
		public unsafe bool endTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetalPierStepSetter.NativeFieldInfoPtr_endTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetalPierStepSetter.NativeFieldInfoPtr_endTile)) = value;
			}
		}

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeFieldInfoPtr_endTile;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
