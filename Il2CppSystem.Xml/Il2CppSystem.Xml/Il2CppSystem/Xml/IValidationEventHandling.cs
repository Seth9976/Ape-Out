using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000035 RID: 53
	public class IValidationEventHandling : Il2CppObjectBase
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0001E670 File Offset: 0x0001C870
		// Note: this type is marked as 'beforefieldinit'.
		static IValidationEventHandling()
		{
			Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IValidationEventHandling");
			IValidationEventHandling.NativeMethodInfoPtr_get_EventHandler_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr, 100663631);
			IValidationEventHandling.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr, 100663632);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		public unsafe virtual Object EventHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidationEventHandling.NativeMethodInfoPtr_get_EventHandler_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001E70C File Offset: 0x0001C90C
		[CallerCount(0)]
		public unsafe virtual void SendEvent(Exception exception, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidationEventHandling.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000030DE File Offset: 0x000012DE
		public IValidationEventHandling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandler_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0;
	}
}
