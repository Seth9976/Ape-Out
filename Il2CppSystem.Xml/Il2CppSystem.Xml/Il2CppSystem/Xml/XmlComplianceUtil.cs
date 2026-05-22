using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000095 RID: 149
	public static class XmlComplianceUtil : Object
	{
		// Token: 0x06000F3C RID: 3900 RVA: 0x00055824 File Offset: 0x00053A24
		// Note: this type is marked as 'beforefieldinit'.
		static XmlComplianceUtil()
		{
			Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlComplianceUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr);
			XmlComplianceUtil.NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100665718);
			XmlComplianceUtil.NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100665719);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0005587C File Offset: 0x00053A7C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 401071, RefRangeEnd = 401081, XrefRangeStart = 401052, XrefRangeEnd = 401071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NonCDataNormalize(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComplianceUtil.NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000558B8 File Offset: 0x00053AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401081, XrefRangeEnd = 401091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CDataNormalize(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComplianceUtil.NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00007279 File Offset: 0x00005479
		public XmlComplianceUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0;
	}
}
