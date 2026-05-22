using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CD RID: 205
	public class XmlCustomFormatter : Object
	{
		// Token: 0x06001206 RID: 4614 RVA: 0x000617F0 File Offset: 0x0005F9F0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCustomFormatter()
		{
			Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlCustomFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr);
			XmlCustomFormatter.NativeFieldInfoPtr_allTimeFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, "allTimeFormats");
			XmlCustomFormatter.NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666131);
			XmlCustomFormatter.NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666132);
			XmlCustomFormatter.NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666133);
			XmlCustomFormatter.NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666134);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00061884 File Offset: 0x0005FA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404908, XrefRangeEnd = 404956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromEnum(long value, Il2CppStringArray values, Il2CppStructArray<long> ids, string typeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000618F4 File Offset: 0x0005FAF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 404964, RefRangeEnd = 404966, XrefRangeStart = 404956, XrefRangeEnd = 404964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromXmlName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00061930 File Offset: 0x0005FB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 404974, RefRangeEnd = 404975, XrefRangeStart = 404966, XrefRangeEnd = 404974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromXmlNCName(string ncName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ncName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0006196C File Offset: 0x0005FB6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 405033, RefRangeEnd = 405036, XrefRangeStart = 404975, XrefRangeEnd = 405033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToXmlString(TypeData type, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00008087 File Offset: 0x00006287
		public XmlCustomFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000619BC File Offset: 0x0005FBBC
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x00008090 File Offset: 0x00006290
		public unsafe static Il2CppStringArray allTimeFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCustomFormatter.NativeFieldInfoPtr_allTimeFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCustomFormatter.NativeFieldInfoPtr_allTimeFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_allTimeFormats;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0;
	}
}
