using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002B RID: 43
	public class IDtdInfo : Il2CppObjectBase
	{
		// Token: 0x0600025F RID: 607 RVA: 0x0001CA24 File Offset: 0x0001AC24
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdInfo()
		{
			Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdInfo");
			IDtdInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663563);
			IDtdInfo.NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663564);
			IDtdInfo.NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663565);
			IDtdInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663566);
			IDtdInfo.NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663567);
			IDtdInfo.NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663568);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
		public unsafe virtual XmlQualifiedName Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0001CB10 File Offset: 0x0001AD10
		public unsafe virtual string InternalDtdSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001CB54 File Offset: 0x0001AD54
		public unsafe virtual bool HasDefaultAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		public unsafe virtual bool HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		[CallerCount(0)]
		public unsafe virtual IDtdAttributeListInfo LookupAttributeList(string prefix, string localName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeListInfo>(intPtr3) : null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001CC54 File Offset: 0x0001AE54
		[CallerCount(0)]
		public unsafe virtual IDtdEntityInfo LookupEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000305D File Offset: 0x0000125D
		public IDtdInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0;
	}
}
