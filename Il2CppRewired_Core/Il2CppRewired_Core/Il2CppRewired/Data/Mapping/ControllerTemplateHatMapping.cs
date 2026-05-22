using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class ControllerTemplateHatMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x0006C7C4 File Offset: 0x0006A9C4
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateHatMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateHatMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr);
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_up");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_upRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_upRight");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_right");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_downRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_downRight");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_down");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_downLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_downLeft");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_left");
			ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_upLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, "eid_upLeft");
			ControllerTemplateHatMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr, 100666094);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0006C8A8 File Offset: 0x0006AAA8
		[CallerCount(0)]
		public unsafe ControllerTemplateHatMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateHatMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateHatMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000077AA File Offset: 0x000059AA
		public ControllerTemplateHatMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0006C8E4 File Offset: 0x0006AAE4
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x000077B3 File Offset: 0x000059B3
		public unsafe int eid_up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_up)) = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0006C90C File Offset: 0x0006AB0C
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x000077CE File Offset: 0x000059CE
		public unsafe int eid_upRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_upRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_upRight)) = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0006C934 File Offset: 0x0006AB34
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x000077E9 File Offset: 0x000059E9
		public unsafe int eid_right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_right);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_right)) = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0006C95C File Offset: 0x0006AB5C
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00007804 File Offset: 0x00005A04
		public unsafe int eid_downRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_downRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_downRight)) = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x0006C984 File Offset: 0x0006AB84
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x0000781F File Offset: 0x00005A1F
		public unsafe int eid_down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_down);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_down)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x0006C9AC File Offset: 0x0006ABAC
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x0000783A File Offset: 0x00005A3A
		public unsafe int eid_downLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_downLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_downLeft)) = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x0006C9D4 File Offset: 0x0006ABD4
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00007855 File Offset: 0x00005A55
		public unsafe int eid_left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_left);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_left)) = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0006C9FC File Offset: 0x0006ABFC
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00007870 File Offset: 0x00005A70
		public unsafe int eid_upLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_upLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateHatMapping.NativeFieldInfoPtr_eid_upLeft)) = value;
			}
		}

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr_eid_up;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr_eid_upRight;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeFieldInfoPtr_eid_right;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeFieldInfoPtr_eid_downRight;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeFieldInfoPtr_eid_down;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeFieldInfoPtr_eid_downLeft;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeFieldInfoPtr_eid_left;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr_eid_upLeft;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
