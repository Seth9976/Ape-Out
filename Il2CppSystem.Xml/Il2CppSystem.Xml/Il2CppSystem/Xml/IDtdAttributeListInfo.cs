using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002C RID: 44
	public class IDtdAttributeListInfo : Il2CppObjectBase
	{
		// Token: 0x06000267 RID: 615 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdAttributeListInfo()
		{
			Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdAttributeListInfo");
			IDtdAttributeListInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663569);
			IDtdAttributeListInfo.NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663570);
			IDtdAttributeListInfo.NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663571);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001CD14 File Offset: 0x0001AF14
		public unsafe virtual bool HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeListInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		[CallerCount(0)]
		public unsafe virtual IDtdAttributeInfo LookupAttribute(string prefix, string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeListInfo.NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr3) : null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		[CallerCount(0)]
		public unsafe virtual IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeListInfo.NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr3) : null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00003066 File Offset: 0x00001266
		public IDtdAttributeListInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;
	}
}
