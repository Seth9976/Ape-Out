using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016D RID: 365
	public class NamespaceListV1Compat : NamespaceList
	{
		// Token: 0x06001ADE RID: 6878 RVA: 0x00084818 File Offset: 0x00082A18
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceListV1Compat()
		{
			Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceListV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr);
			NamespaceListV1Compat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr, 100667277);
			NamespaceListV1Compat.NativeMethodInfoPtr_Allows_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr, 100667278);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00084870 File Offset: 0x00082A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413547, XrefRangeEnd = 413548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceListV1Compat(string namespaces, string targetNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceListV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceListV1Compat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x000848D0 File Offset: 0x00082AD0
		[CallerCount(0)]
		public unsafe override bool Allows(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListV1Compat.NativeMethodInfoPtr_Allows_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0000B599 File Offset: 0x00009799
		public NamespaceListV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Virtual_Boolean_String_0;
	}
}
