using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.PS4.Internal
{
	// Token: 0x0200017F RID: 383
	public class ControllerInformation : Object
	{
		// Token: 0x060028A6 RID: 10406 RVA: 0x000CD864 File Offset: 0x000CBA64
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerInformation()
		{
			Il2CppClassPointerStore<ControllerInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4.Internal", "ControllerInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerInformation>.NativeClassPtr);
			ControllerInformation.NativeFieldInfoPtr_padControllerInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInformation>.NativeClassPtr, "padControllerInformation");
			ControllerInformation.NativeFieldInfoPtr_padDeviceClassExtendedInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInformation>.NativeClassPtr, "padDeviceClassExtendedInformation");
			ControllerInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerInformation>.NativeClassPtr, 100673186);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000CD8D0 File Offset: 0x000CBAD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x0000FA34 File Offset: 0x0000DC34
		public ControllerInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000CD90C File Offset: 0x000CBB0C
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0000FA3D File Offset: 0x0000DC3D
		public unsafe PadControllerInformation padControllerInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerInformation.NativeFieldInfoPtr_padControllerInformation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerInformation.NativeFieldInfoPtr_padControllerInformation)) = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000CD934 File Offset: 0x000CBB34
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x0000FA58 File Offset: 0x0000DC58
		public unsafe PadDeviceClassExtendedInformation padDeviceClassExtendedInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerInformation.NativeFieldInfoPtr_padDeviceClassExtendedInformation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerInformation.NativeFieldInfoPtr_padDeviceClassExtendedInformation)) = value;
			}
		}

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeFieldInfoPtr_padControllerInformation;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeFieldInfoPtr_padDeviceClassExtendedInformation;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
