using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000007 RID: 7
	public class CertificateHandler : Object
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00005770 File Offset: 0x00003970
		// Note: this type is marked as 'beforefieldinit'.
		static CertificateHandler()
		{
			Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "CertificateHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr);
			CertificateHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, "m_Ptr");
			CertificateHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663368);
			CertificateHandler.NativeMethodInfoPtr_ValidateCertificate_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663369);
			CertificateHandler.NativeMethodInfoPtr_ValidateCertificateNative_Internal_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663370);
			CertificateHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHandler>.NativeClassPtr, 100663371);
			CertificateHandler.CreateDelegateField = IL2CPP.ResolveICall<CertificateHandler.CreateDelegate>("UnityEngine.Networking.CertificateHandler::Create");
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005814 File Offset: 0x00003A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534852, XrefRangeEnd = 534856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005848 File Offset: 0x00003A48
		[CallerCount(0)]
		public unsafe virtual bool ValidateCertificate(Il2CppStructArray<byte> certificateData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificateData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CertificateHandler.NativeMethodInfoPtr_ValidateCertificate_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000058A0 File Offset: 0x00003AA0
		[CallerCount(0)]
		public unsafe bool ValidateCertificateNative(Il2CppStructArray<byte> certificateData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificateData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHandler.NativeMethodInfoPtr_ValidateCertificateNative_Internal_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000058F0 File Offset: 0x00003AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534856, XrefRangeEnd = 534859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000024C8 File Offset: 0x000006C8
		public CertificateHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005924 File Offset: 0x00003B24
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000024D1 File Offset: 0x000006D1
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000024EC File Offset: 0x000006EC
		public static IntPtr Create(CertificateHandler obj)
		{
			return CertificateHandler.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000594C File Offset: 0x00003B4C
		public ~CertificateHandler()
		{
			this.Dispose();
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificateNative_Internal_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly CertificateHandler.CreateDelegate CreateDelegateField;

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate IntPtr CreateDelegate(IntPtr obj);
	}
}
