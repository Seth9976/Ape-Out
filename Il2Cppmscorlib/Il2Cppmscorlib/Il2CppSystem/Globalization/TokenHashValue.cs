using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000234 RID: 564
	public class TokenHashValue : Object
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x000CE568 File Offset: 0x000CC768
		// Note: this type is marked as 'beforefieldinit'.
		static TokenHashValue()
		{
			Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TokenHashValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr);
			TokenHashValue.NativeFieldInfoPtr_tokenString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenString");
			TokenHashValue.NativeFieldInfoPtr_tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenType");
			TokenHashValue.NativeFieldInfoPtr_tokenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenValue");
			TokenHashValue.NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, 100669622);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000CE5E8 File Offset: 0x000CC7E8
		[CallerCount(0)]
		public unsafe TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenHashValue.NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x0000CFC3 File Offset: 0x0000B1C3
		public TokenHashValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x000CE650 File Offset: 0x000CC850
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		public unsafe string tokenString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x000CE678 File Offset: 0x000CC878
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x0000CFEB File Offset: 0x0000B1EB
		public unsafe TokenType tokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenType)) = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x000CE6A0 File Offset: 0x000CC8A0
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x0000D006 File Offset: 0x0000B206
		public unsafe int tokenValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenValue)) = value;
			}
		}

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeFieldInfoPtr_tokenString;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeFieldInfoPtr_tokenType;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeFieldInfoPtr_tokenValue;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0;
	}
}
