using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000085 RID: 133
	[Serializable]
	public class ControllerTemplateThumbStickMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x0006C2B8 File Offset: 0x0006A4B8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateThumbStickMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateThumbStickMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr);
			ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_axisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr, "eid_axisX");
			ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_axisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr, "eid_axisY");
			ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr, "eid_button");
			ControllerTemplateThumbStickMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr, 100666090);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0006C338 File Offset: 0x0006A538
		[CallerCount(0)]
		public unsafe ControllerTemplateThumbStickMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateThumbStickMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateThumbStickMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00007627 File Offset: 0x00005827
		public ControllerTemplateThumbStickMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0006C374 File Offset: 0x0006A574
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00007630 File Offset: 0x00005830
		public unsafe int eid_axisX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_axisX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_axisX)) = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0006C39C File Offset: 0x0006A59C
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x0000764B File Offset: 0x0000584B
		public unsafe int eid_axisY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_axisY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_axisY)) = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x00007666 File Offset: 0x00005866
		public unsafe int eid_button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_button);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateThumbStickMapping.NativeFieldInfoPtr_eid_button)) = value;
			}
		}

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisX;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisY;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeFieldInfoPtr_eid_button;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
