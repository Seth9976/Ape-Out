using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000087 RID: 135
	[Serializable]
	public class ControllerTemplateStickMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x0006C598 File Offset: 0x0006A798
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateStickMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateStickMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr);
			ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr, "eid_axisX");
			ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr, "eid_axisY");
			ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr, "eid_axisZ");
			ControllerTemplateStickMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr, 100666092);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0006C618 File Offset: 0x0006A818
		[CallerCount(0)]
		public unsafe ControllerTemplateStickMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateStickMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateStickMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00007711 File Offset: 0x00005911
		public ControllerTemplateStickMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0006C654 File Offset: 0x0006A854
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x0000771A File Offset: 0x0000591A
		public unsafe int eid_axisX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisX)) = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0006C67C File Offset: 0x0006A87C
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00007735 File Offset: 0x00005935
		public unsafe int eid_axisY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisY)) = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0006C6A4 File Offset: 0x0006A8A4
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00007750 File Offset: 0x00005950
		public unsafe int eid_axisZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateStickMapping.NativeFieldInfoPtr_eid_axisZ)) = value;
			}
		}

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisX;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisY;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisZ;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
