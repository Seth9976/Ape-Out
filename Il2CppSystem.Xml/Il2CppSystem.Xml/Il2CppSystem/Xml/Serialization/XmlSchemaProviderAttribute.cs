using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DB RID: 219
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		// Token: 0x060012AB RID: 4779 RVA: 0x00063E84 File Offset: 0x00062084
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaProviderAttribute()
		{
			Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSchemaProviderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr);
			XmlSchemaProviderAttribute.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, "_methodName");
			XmlSchemaProviderAttribute.NativeFieldInfoPtr__isAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, "_isAny");
			XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_MethodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, 100666207);
			XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_IsAny_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, 100666208);
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00063F04 File Offset: 0x00062104
		public unsafe string MethodName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_MethodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00063F3C File Offset: 0x0006213C
		public unsafe bool IsAny
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_IsAny_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0000857A File Offset: 0x0000677A
		public XmlSchemaProviderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00063F78 File Offset: 0x00062178
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x00008583 File Offset: 0x00006783
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00063FA0 File Offset: 0x000621A0
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x000085A2 File Offset: 0x000067A2
		public unsafe bool _isAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__isAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__isAny)) = value;
			}
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr__isAny;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_get_String_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAny_Public_get_Boolean_0;
	}
}
