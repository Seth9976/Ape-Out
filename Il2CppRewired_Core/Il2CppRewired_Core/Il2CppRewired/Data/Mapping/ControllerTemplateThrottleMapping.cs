using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000088 RID: 136
	[Serializable]
	public class ControllerTemplateThrottleMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010DC RID: 4316 RVA: 0x0006C6CC File Offset: 0x0006A8CC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateThrottleMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateThrottleMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateThrottleMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateThrottleMapping>.NativeClassPtr);
			ControllerTemplateThrottleMapping.NativeFieldInfoPtr_eid_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateThrottleMapping>.NativeClassPtr, "eid_axis");
			ControllerTemplateThrottleMapping.NativeFieldInfoPtr_eid_minDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateThrottleMapping>.NativeClassPtr, "eid_minDetent");
			ControllerTemplateThrottleMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateThrottleMapping>.NativeClassPtr, 100666093);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0006C738 File Offset: 0x0006A938
		[CallerCount(0)]
		public unsafe ControllerTemplateThrottleMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateThrottleMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateThrottleMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0000776B File Offset: 0x0000596B
		public ControllerTemplateThrottleMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0006C774 File Offset: 0x0006A974
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00007774 File Offset: 0x00005974
		public unsafe int eid_axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThrottleMapping.NativeFieldInfoPtr_eid_axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThrottleMapping.NativeFieldInfoPtr_eid_axis)) = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0006C79C File Offset: 0x0006A99C
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0000778F File Offset: 0x0000598F
		public unsafe int eid_minDetent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThrottleMapping.NativeFieldInfoPtr_eid_minDetent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThrottleMapping.NativeFieldInfoPtr_eid_minDetent)) = value;
			}
		}

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeFieldInfoPtr_eid_axis;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeFieldInfoPtr_eid_minDetent;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
