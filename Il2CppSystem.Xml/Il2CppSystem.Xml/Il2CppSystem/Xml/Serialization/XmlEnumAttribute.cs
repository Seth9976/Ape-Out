using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D0 RID: 208
	public class XmlEnumAttribute : Attribute
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x00062050 File Offset: 0x00060250
		// Note: this type is marked as 'beforefieldinit'.
		static XmlEnumAttribute()
		{
			Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlEnumAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr);
			XmlEnumAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr, "name");
			XmlEnumAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr, 100666149);
			XmlEnumAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr, 100666150);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000620BC File Offset: 0x000602BC
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEnumAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEnumAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00062108 File Offset: 0x00060308
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEnumAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00008181 File Offset: 0x00006381
		public XmlEnumAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00062140 File Offset: 0x00060340
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0000818A File Offset: 0x0000638A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEnumAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEnumAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
	}
}
