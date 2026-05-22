using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x0200026F RID: 623
	public class StringObfucator : Object
	{
		// Token: 0x0600469B RID: 18075 RVA: 0x00107678 File Offset: 0x00105878
		// Note: this type is marked as 'beforefieldinit'.
		static StringObfucator()
		{
			Il2CppClassPointerStore<StringObfucator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "StringObfucator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr);
			StringObfucator.NativeFieldInfoPtr_StringObfuscatorPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, "StringObfuscatorPassword");
			StringObfucator.NativeMethodInfoPtr_Encode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, 100670446);
			StringObfucator.NativeMethodInfoPtr_Decode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, 100670447);
			StringObfucator.NativeMethodInfoPtr_ToBase64_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, 100670448);
			StringObfucator.NativeMethodInfoPtr_FromBase64_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, 100670449);
			StringObfucator.NativeMethodInfoPtr_XoREncode_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, 100670450);
			StringObfucator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr, 100670451);
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x00107734 File Offset: 0x00105934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115612, RefRangeEnd = 115613, XrefRangeStart = 115598, XrefRangeEnd = 115612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Encode(string NormalString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NormalString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringObfucator.NativeMethodInfoPtr_Encode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x00107770 File Offset: 0x00105970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115627, RefRangeEnd = 115628, XrefRangeStart = 115613, XrefRangeEnd = 115627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Decode(string ObfucatedString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ObfucatedString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringObfucator.NativeMethodInfoPtr_Decode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x001077AC File Offset: 0x001059AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115628, XrefRangeEnd = 115637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64(string regularString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(regularString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringObfucator.NativeMethodInfoPtr_ToBase64_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x001077E8 File Offset: 0x001059E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115637, XrefRangeEnd = 115646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromBase64(string base64string)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(base64string);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringObfucator.NativeMethodInfoPtr_FromBase64_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00107824 File Offset: 0x00105A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115658, RefRangeEnd = 115660, XrefRangeStart = 115646, XrefRangeEnd = 115658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XoREncode(string NormalString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(NormalString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringObfucator.NativeMethodInfoPtr_XoREncode_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00107860 File Offset: 0x00105A60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringObfucator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringObfucator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringObfucator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00029F32 File Offset: 0x00028132
		public StringObfucator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x0010789C File Offset: 0x00105A9C
		// (set) Token: 0x060046A4 RID: 18084 RVA: 0x00029F3B File Offset: 0x0002813B
		public unsafe static Il2CppStructArray<char> StringObfuscatorPassword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringObfucator.NativeFieldInfoPtr_StringObfuscatorPassword, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringObfucator.NativeFieldInfoPtr_StringObfuscatorPassword, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeFieldInfoPtr_StringObfuscatorPassword;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_String_String_0;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_String_String_0;

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64_Private_Static_String_String_0;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64_Private_Static_String_String_0;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeMethodInfoPtr_XoREncode_Private_Static_String_String_0;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
