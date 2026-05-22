using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CF RID: 463
	public class XmlSchemaSubstitutionGroup : XmlSchemaObject
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x000A9C58 File Offset: 0x000A7E58
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSubstitutionGroup()
		{
			Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSubstitutionGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr);
			XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_membersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, "membersList");
			XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_examplar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, "examplar");
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Members_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100668536);
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Examplar_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100668537);
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_set_Examplar_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100668538);
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100668539);
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x000A9D00 File Offset: 0x000A7F00
		public unsafe ArrayList Members
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Members_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000A9D40 File Offset: 0x000A7F40
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x000A9D80 File Offset: 0x000A7F80
		public unsafe XmlQualifiedName Examplar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Examplar_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_set_Examplar_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000A9DC4 File Offset: 0x000A7FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429297, RefRangeEnd = 429299, XrefRangeStart = 429289, XrefRangeEnd = 429297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSubstitutionGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00010009 File Offset: 0x0000E209
		public XmlSchemaSubstitutionGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000A9E00 File Offset: 0x000A8000
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00010012 File Offset: 0x0000E212
		public unsafe ArrayList membersList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_membersList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_membersList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x000A9E30 File Offset: 0x000A8030
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x00010031 File Offset: 0x0000E231
		public unsafe XmlQualifiedName examplar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_examplar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_examplar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr_membersList;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_examplar;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Internal_get_ArrayList_0;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_get_Examplar_Internal_get_XmlQualifiedName_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_set_Examplar_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
