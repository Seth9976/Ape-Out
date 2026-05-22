using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000032 RID: 50
	public class IDtdParserAdapterWithValidation : Il2CppObjectBase
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x0001E280 File Offset: 0x0001C480
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapterWithValidation()
		{
			Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapterWithValidation");
			IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr, 100663622);
			IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr, 100663623);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		public unsafe virtual bool DtdValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001E318 File Offset: 0x0001C518
		public unsafe virtual IValidationEventHandling ValidationEventHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000309C File Offset: 0x0000129C
		public IDtdParserAdapterWithValidation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0;
	}
}
