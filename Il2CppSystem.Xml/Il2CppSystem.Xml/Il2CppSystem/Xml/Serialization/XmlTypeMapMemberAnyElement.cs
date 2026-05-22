using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EC RID: 236
	public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
	{
		// Token: 0x060013E9 RID: 5097 RVA: 0x000690F0 File Offset: 0x000672F0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberAnyElement()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAnyElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr);
			XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_IsElementDefined_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr, 100666380);
			XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_get_IsDefaultAny_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr, 100666381);
			XmlTypeMapMemberAnyElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr, 100666382);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0006915C File Offset: 0x0006735C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407571, RefRangeEnd = 407572, XrefRangeStart = 407554, XrefRangeEnd = 407571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementDefined(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_IsElementDefined_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x000691BC File Offset: 0x000673BC
		public unsafe bool IsDefaultAny
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407572, XrefRangeEnd = 407588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyElement.NativeMethodInfoPtr_get_IsDefaultAny_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000691F8 File Offset: 0x000673F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAnyElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAnyElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00008D5F File Offset: 0x00006F5F
		public XmlTypeMapMemberAnyElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_IsElementDefined_Public_Boolean_String_String_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultAny_Public_get_Boolean_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
