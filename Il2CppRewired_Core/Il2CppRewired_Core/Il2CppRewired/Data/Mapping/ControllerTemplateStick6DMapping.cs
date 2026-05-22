using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x0200008B RID: 139
	[Serializable]
	public class ControllerTemplateStick6DMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x0006CB1C File Offset: 0x0006AD1C
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateStick6DMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateStick6DMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr);
			ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, "eid_positionX");
			ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, "eid_positionY");
			ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, "eid_positionZ");
			ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, "eid_rotationX");
			ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, "eid_rotationY");
			ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, "eid_rotationZ");
			ControllerTemplateStick6DMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr, 100666096);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0006CBD8 File Offset: 0x0006ADD8
		[CallerCount(0)]
		public unsafe ControllerTemplateStick6DMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateStick6DMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateStick6DMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000078CA File Offset: 0x00005ACA
		public ControllerTemplateStick6DMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0006CC14 File Offset: 0x0006AE14
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x000078D3 File Offset: 0x00005AD3
		public unsafe int eid_positionX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionX)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0006CC3C File Offset: 0x0006AE3C
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x000078EE File Offset: 0x00005AEE
		public unsafe int eid_positionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionY)) = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0006CC64 File Offset: 0x0006AE64
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00007909 File Offset: 0x00005B09
		public unsafe int eid_positionZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_positionZ)) = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0006CC8C File Offset: 0x0006AE8C
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x00007924 File Offset: 0x00005B24
		public unsafe int eid_rotationX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationX)) = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0006CCB4 File Offset: 0x0006AEB4
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x0000793F File Offset: 0x00005B3F
		public unsafe int eid_rotationY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationY)) = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0006CCDC File Offset: 0x0006AEDC
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x0000795A File Offset: 0x00005B5A
		public unsafe int eid_rotationZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStick6DMapping.NativeFieldInfoPtr_eid_rotationZ)) = value;
			}
		}

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeFieldInfoPtr_eid_positionX;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeFieldInfoPtr_eid_positionY;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeFieldInfoPtr_eid_positionZ;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeFieldInfoPtr_eid_rotationX;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr_eid_rotationY;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeFieldInfoPtr_eid_rotationZ;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
