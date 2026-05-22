using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000033 RID: 51
	public class IDtdParserAdapterV1 : Il2CppObjectBase
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0001E364 File Offset: 0x0001C564
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapterV1()
		{
			Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapterV1");
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663624);
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663625);
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663626);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
		public unsafe virtual bool V1CompatibilityMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001E410 File Offset: 0x0001C610
		public unsafe virtual bool Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001E458 File Offset: 0x0001C658
		public unsafe virtual bool Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000030A5 File Offset: 0x000012A5
		public IDtdParserAdapterV1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
