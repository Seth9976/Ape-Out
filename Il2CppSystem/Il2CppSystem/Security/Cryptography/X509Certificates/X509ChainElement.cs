using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BB RID: 187
	public class X509ChainElement : Object
	{
		// Token: 0x06000A25 RID: 2597 RVA: 0x00036428 File Offset: 0x00034628
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElement()
		{
			Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr);
			X509ChainElement.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "certificate");
			X509ChainElement.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "info");
			X509ChainElement.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100664733);
			X509ChainElement.NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100664734);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000364A8 File Offset: 0x000346A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374414, XrefRangeEnd = 374416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElement(X509Certificate2 certificate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000364F4 File Offset: 0x000346F4
		public unsafe X509Certificate2 Certificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0000610C File Offset: 0x0000430C
		public X509ChainElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00036534 File Offset: 0x00034734
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00006115 File Offset: 0x00004315
		public unsafe X509Certificate2 certificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_certificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00036564 File Offset: 0x00034764
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00006134 File Offset: 0x00004334
		public unsafe string info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_info);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_info), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_certificate;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0;
	}
}
