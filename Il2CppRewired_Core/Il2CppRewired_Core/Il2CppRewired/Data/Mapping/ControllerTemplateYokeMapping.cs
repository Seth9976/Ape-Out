using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x0200008A RID: 138
	[Serializable]
	public class ControllerTemplateYokeMapping : ControllerTemplateSpecialElementMapping
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x0006CA24 File Offset: 0x0006AC24
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateYokeMapping()
		{
			Il2CppClassPointerStore<ControllerTemplateYokeMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerTemplateYokeMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateYokeMapping>.NativeClassPtr);
			ControllerTemplateYokeMapping.NativeFieldInfoPtr_eid_axisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateYokeMapping>.NativeClassPtr, "eid_axisX");
			ControllerTemplateYokeMapping.NativeFieldInfoPtr_eid_axisZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateYokeMapping>.NativeClassPtr, "eid_axisZ");
			ControllerTemplateYokeMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateYokeMapping>.NativeClassPtr, 100666095);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0006CA90 File Offset: 0x0006AC90
		[CallerCount(0)]
		public unsafe ControllerTemplateYokeMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateYokeMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateYokeMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0000788B File Offset: 0x00005A8B
		public ControllerTemplateYokeMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0006CACC File Offset: 0x0006ACCC
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00007894 File Offset: 0x00005A94
		public unsafe int eid_axisX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateYokeMapping.NativeFieldInfoPtr_eid_axisX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateYokeMapping.NativeFieldInfoPtr_eid_axisX)) = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0006CAF4 File Offset: 0x0006ACF4
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x000078AF File Offset: 0x00005AAF
		public unsafe int eid_axisZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateYokeMapping.NativeFieldInfoPtr_eid_axisZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateYokeMapping.NativeFieldInfoPtr_eid_axisZ)) = value;
			}
		}

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisX;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeFieldInfoPtr_eid_axisZ;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
