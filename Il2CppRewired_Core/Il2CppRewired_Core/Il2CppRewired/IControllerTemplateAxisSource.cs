using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x0200008D RID: 141
	public class IControllerTemplateAxisSource : Il2CppObjectBase
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x0006CD4C File Offset: 0x0006AF4C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateAxisSource()
		{
			Il2CppClassPointerStore<IControllerTemplateAxisSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateAxisSource");
			IControllerTemplateAxisSource.NativeMethodInfoPtr_get_splitAxis_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxisSource>.NativeClassPtr, 100666098);
			IControllerTemplateAxisSource.NativeMethodInfoPtr_get_fullTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxisSource>.NativeClassPtr, 100666099);
			IControllerTemplateAxisSource.NativeMethodInfoPtr_get_positiveTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxisSource>.NativeClassPtr, 100666100);
			IControllerTemplateAxisSource.NativeMethodInfoPtr_get_negativeTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxisSource>.NativeClassPtr, 100666101);
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0006CDC4 File Offset: 0x0006AFC4
		public unsafe virtual bool splitAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxisSource.NativeMethodInfoPtr_get_splitAxis_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0006CE0C File Offset: 0x0006B00C
		public unsafe virtual IControllerElementTarget fullTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxisSource.NativeMethodInfoPtr_get_fullTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x0006CE58 File Offset: 0x0006B058
		public unsafe virtual IControllerElementTarget positiveTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxisSource.NativeMethodInfoPtr_get_positiveTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0006CEA4 File Offset: 0x0006B0A4
		public unsafe virtual IControllerElementTarget negativeTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxisSource.NativeMethodInfoPtr_get_negativeTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000079AD File Offset: 0x00005BAD
		public IControllerTemplateAxisSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_get_splitAxis_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_get_fullTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeTarget_Public_Abstract_Virtual_New_get_IControllerElementTarget_0;
	}
}
