using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002E RID: 46
	public class IDtdDefaultAttributeInfo : Il2CppObjectBase
	{
		// Token: 0x06000275 RID: 629 RVA: 0x0001D0BC File Offset: 0x0001B2BC
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdDefaultAttributeInfo()
		{
			Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdDefaultAttributeInfo");
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663579);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663580);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663581);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663582);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0001D134 File Offset: 0x0001B334
		public unsafe virtual string DefaultValueExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001D178 File Offset: 0x0001B378
		public unsafe virtual Object DefaultValueTyped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
		public unsafe virtual int ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0001D20C File Offset: 0x0001B40C
		public unsafe virtual int ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00003078 File Offset: 0x00001278
		public IDtdDefaultAttributeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
