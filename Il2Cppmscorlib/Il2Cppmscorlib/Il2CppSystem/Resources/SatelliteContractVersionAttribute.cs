using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200018B RID: 395
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		// Token: 0x06001BA2 RID: 7074 RVA: 0x000A153C File Offset: 0x0009F73C
		// Note: this type is marked as 'beforefieldinit'.
		static SatelliteContractVersionAttribute()
		{
			Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "SatelliteContractVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr);
			SatelliteContractVersionAttribute.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, "_version");
			SatelliteContractVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, 100668010);
			SatelliteContractVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, 100668011);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000A15A8 File Offset: 0x0009F7A8
		[CallerCount(0)]
		public unsafe SatelliteContractVersionAttribute(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteContractVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000A15F4 File Offset: 0x0009F7F4
		public unsafe string Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteContractVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0000961F File Offset: 0x0000781F
		public SatelliteContractVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x000A162C File Offset: 0x0009F82C
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00009628 File Offset: 0x00007828
		public unsafe string _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatelliteContractVersionAttribute.NativeFieldInfoPtr__version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatelliteContractVersionAttribute.NativeFieldInfoPtr__version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;
	}
}
