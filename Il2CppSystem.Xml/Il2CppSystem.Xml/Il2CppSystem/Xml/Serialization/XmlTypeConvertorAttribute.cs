using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BF RID: 191
	public class XmlTypeConvertorAttribute : Attribute
	{
		// Token: 0x06001128 RID: 4392 RVA: 0x0005EBDC File Offset: 0x0005CDDC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeConvertorAttribute()
		{
			Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeConvertorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr);
			XmlTypeConvertorAttribute.NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr, "<Method>k__BackingField");
			XmlTypeConvertorAttribute.NativeMethodInfoPtr_get_Method_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr, 100666047);
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0005EC34 File Offset: 0x0005CE34
		public unsafe string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeConvertorAttribute.NativeMethodInfoPtr_get_Method_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00007981 File Offset: 0x00005B81
		public XmlTypeConvertorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0005EC6C File Offset: 0x0005CE6C
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000798A File Offset: 0x00005B8A
		public unsafe string _Method_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeConvertorAttribute.NativeFieldInfoPtr__Method_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeConvertorAttribute.NativeFieldInfoPtr__Method_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr__Method_k__BackingField;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_String_0;
	}
}
