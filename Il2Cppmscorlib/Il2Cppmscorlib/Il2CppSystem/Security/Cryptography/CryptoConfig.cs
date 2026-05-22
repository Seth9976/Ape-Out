using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000314 RID: 788
	public class CryptoConfig : Object
	{
		// Token: 0x06003421 RID: 13345 RVA: 0x00102710 File Offset: 0x00100910
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConfig()
		{
			Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr);
			CryptoConfig.NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671463);
			CryptoConfig.NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671464);
			CryptoConfig.NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671465);
			CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671466);
			CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671467);
			CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671468);
			CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671469);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x001027CC File Offset: 0x001009CC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 212160, RefRangeEnd = 212177, XrefRangeStart = 212131, XrefRangeEnd = 212160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeOID(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00102810 File Offset: 0x00100A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212184, RefRangeEnd = 212185, XrefRangeStart = 212177, XrefRangeEnd = 212184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeLongNumber(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x00102850 File Offset: 0x00100A50
		public unsafe static bool AllowOnlyFipsAlgorithms
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00102880 File Offset: 0x00100A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212185, XrefRangeEnd = 212186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x001028C4 File Offset: 0x00100AC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212344, RefRangeEnd = 212347, XrefRangeStart = 212186, XrefRangeEnd = 212344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00102928 File Offset: 0x00100B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212347, XrefRangeEnd = 212348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapNameToOID(string name, Object arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00102978 File Offset: 0x00100B78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212396, RefRangeEnd = 212399, XrefRangeStart = 212348, XrefRangeEnd = 212396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapNameToOID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000125DE File Offset: 0x000107DE
		public static Object CreateFromName(string name, params Object[] args)
		{
			return CryptoConfig.CreateFromName(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000125EC File Offset: 0x000107EC
		public CryptoConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeMethodInfoPtr_MapNameToOID_Internal_Static_String_String_Object_0;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0;
	}
}
