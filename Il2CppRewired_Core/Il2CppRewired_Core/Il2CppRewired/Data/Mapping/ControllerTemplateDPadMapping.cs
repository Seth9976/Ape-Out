using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000086 RID: 134
	[Serializable]
	public class ControllerTemplateDPadMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010C6 RID: 4294 RVA: 0x0006C3EC File Offset: 0x0006A5EC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateDPadMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateDPadMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr);
			ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr, "eid_up");
			ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr, "eid_right");
			ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr, "eid_down");
			ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr, "eid_left");
			ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr, "eid_press");
			ControllerTemplateDPadMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr, 100666091);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0006C494 File Offset: 0x0006A694
		[CallerCount(0)]
		public unsafe ControllerTemplateDPadMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateDPadMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateDPadMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00007681 File Offset: 0x00005881
		public ControllerTemplateDPadMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0006C4D0 File Offset: 0x0006A6D0
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0000768A File Offset: 0x0000588A
		public unsafe int eid_up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_up)) = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0006C4F8 File Offset: 0x0006A6F8
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x000076A5 File Offset: 0x000058A5
		public unsafe int eid_right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_right);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_right)) = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0006C520 File Offset: 0x0006A720
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x000076C0 File Offset: 0x000058C0
		public unsafe int eid_down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_down);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_down)) = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0006C548 File Offset: 0x0006A748
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x000076DB File Offset: 0x000058DB
		public unsafe int eid_left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_left);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_left)) = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0006C570 File Offset: 0x0006A770
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x000076F6 File Offset: 0x000058F6
		public unsafe int eid_press
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_press);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateDPadMapping.NativeFieldInfoPtr_eid_press)) = value;
			}
		}

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeFieldInfoPtr_eid_up;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeFieldInfoPtr_eid_right;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeFieldInfoPtr_eid_down;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_eid_left;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_eid_press;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
