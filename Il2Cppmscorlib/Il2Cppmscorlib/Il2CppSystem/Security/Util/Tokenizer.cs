using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002C9 RID: 713
	public sealed class Tokenizer : Object
	{
		// Token: 0x06003058 RID: 12376 RVA: 0x000F4E14 File Offset: 0x000F3014
		// Note: this type is marked as 'beforefieldinit'.
		static Tokenizer()
		{
			Il2CppClassPointerStore<Tokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Tokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr);
			Tokenizer.NativeFieldInfoPtr_LineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "LineNo");
			Tokenizer.NativeFieldInfoPtr__inProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inProcessingTag");
			Tokenizer.NativeFieldInfoPtr__inBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inBytes");
			Tokenizer.NativeFieldInfoPtr__inChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inChars");
			Tokenizer.NativeFieldInfoPtr__inString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inString");
			Tokenizer.NativeFieldInfoPtr__inIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inIndex");
			Tokenizer.NativeFieldInfoPtr__inSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSize");
			Tokenizer.NativeFieldInfoPtr__inSavedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSavedCharacter");
			Tokenizer.NativeFieldInfoPtr__inTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenSource");
			Tokenizer.NativeFieldInfoPtr__inTokenReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenReader");
			Tokenizer.NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_maker");
			Tokenizer.NativeFieldInfoPtr__searchStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_searchStrings");
			Tokenizer.NativeFieldInfoPtr__replaceStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_replaceStrings");
			Tokenizer.NativeFieldInfoPtr__inNestedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedIndex");
			Tokenizer.NativeFieldInfoPtr__inNestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedSize");
			Tokenizer.NativeFieldInfoPtr__inNestedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedString");
			Tokenizer.NativeMethodInfoPtr_BasicInitialization_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100671002);
			Tokenizer.NativeMethodInfoPtr_Recycle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100671003);
			Tokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100671004);
			Tokenizer.NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100671005);
			Tokenizer.NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100671006);
			Tokenizer.NativeMethodInfoPtr_GetStringToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100671007);
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x000F4FFC File Offset: 0x000F31FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208307, XrefRangeEnd = 208311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BasicInitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_BasicInitialization_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x000F5030 File Offset: 0x000F3230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208311, XrefRangeEnd = 208315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_Recycle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000F5064 File Offset: 0x000F3264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208315, XrefRangeEnd = 208319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tokenizer(string input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x000F50B0 File Offset: 0x000F32B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208325, RefRangeEnd = 208326, XrefRangeStart = 208319, XrefRangeEnd = 208325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFormat(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x000F50F4 File Offset: 0x000F32F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208347, RefRangeEnd = 208350, XrefRangeStart = 208326, XrefRangeEnd = 208347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endAfterKet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000F5154 File Offset: 0x000F3354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208350, XrefRangeEnd = 208352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_GetStringToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00010B3F File Offset: 0x0000ED3F
		public Tokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x000F518C File Offset: 0x000F338C
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x00010B48 File Offset: 0x0000ED48
		public unsafe int LineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr_LineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr_LineNo)) = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x000F51B4 File Offset: 0x000F33B4
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00010B63 File Offset: 0x0000ED63
		public unsafe int _inProcessingTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inProcessingTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inProcessingTag)) = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000F51DC File Offset: 0x000F33DC
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00010B7E File Offset: 0x0000ED7E
		public unsafe Il2CppStructArray<byte> _inBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x000F520C File Offset: 0x000F340C
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x00010B9D File Offset: 0x0000ED9D
		public unsafe Il2CppStructArray<char> _inChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x000F523C File Offset: 0x000F343C
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x00010BBC File Offset: 0x0000EDBC
		public unsafe string _inString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x000F5264 File Offset: 0x000F3464
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x00010BDB File Offset: 0x0000EDDB
		public unsafe int _inIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inIndex)) = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x000F528C File Offset: 0x000F348C
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x00010BF6 File Offset: 0x0000EDF6
		public unsafe int _inSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSize)) = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x000F52B4 File Offset: 0x000F34B4
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x00010C11 File Offset: 0x0000EE11
		public unsafe int _inSavedCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSavedCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSavedCharacter)) = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x000F52DC File Offset: 0x000F34DC
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x00010C2C File Offset: 0x0000EE2C
		public unsafe Tokenizer.TokenSource _inTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenSource)) = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x000F5304 File Offset: 0x000F3504
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x00010C47 File Offset: 0x0000EE47
		public unsafe Tokenizer.ITokenReader _inTokenReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.ITokenReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x000F5334 File Offset: 0x000F3534
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x00010C66 File Offset: 0x0000EE66
		public unsafe Tokenizer.StringMaker _maker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__maker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__maker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x000F5364 File Offset: 0x000F3564
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x00010C85 File Offset: 0x0000EE85
		public unsafe Il2CppStringArray _searchStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__searchStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__searchStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x000F5394 File Offset: 0x000F3594
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		public unsafe Il2CppStringArray _replaceStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__replaceStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__replaceStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x000F53C4 File Offset: 0x000F35C4
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x00010CC3 File Offset: 0x0000EEC3
		public unsafe int _inNestedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedIndex)) = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x000F53EC File Offset: 0x000F35EC
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x00010CDE File Offset: 0x0000EEDE
		public unsafe int _inNestedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedSize)) = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x000F5414 File Offset: 0x000F3614
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x00010CF9 File Offset: 0x0000EEF9
		public unsafe string _inNestedString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeFieldInfoPtr_LineNo;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeFieldInfoPtr__inProcessingTag;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeFieldInfoPtr__inBytes;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeFieldInfoPtr__inChars;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeFieldInfoPtr__inString;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeFieldInfoPtr__inIndex;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeFieldInfoPtr__inSize;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeFieldInfoPtr__inSavedCharacter;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeFieldInfoPtr__inTokenSource;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeFieldInfoPtr__inTokenReader;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeFieldInfoPtr__maker;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeFieldInfoPtr__searchStrings;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeFieldInfoPtr__replaceStrings;

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeFieldInfoPtr__inNestedIndex;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeFieldInfoPtr__inNestedSize;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeFieldInfoPtr__inNestedString;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeMethodInfoPtr_BasicInitialization_Internal_Void_0;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeMethodInfoPtr_Recycle_Public_Void_0;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeMethodInfoPtr_GetStringToken_Private_String_0;

		// Token: 0x02000622 RID: 1570
		[OriginalName("mscorlib.dll", "", "TokenSource")]
		public enum TokenSource
		{
			// Token: 0x040044E9 RID: 17641
			UnicodeByteArray,
			// Token: 0x040044EA RID: 17642
			UTF8ByteArray,
			// Token: 0x040044EB RID: 17643
			ASCIIByteArray,
			// Token: 0x040044EC RID: 17644
			CharArray,
			// Token: 0x040044ED RID: 17645
			String,
			// Token: 0x040044EE RID: 17646
			NestedStrings,
			// Token: 0x040044EF RID: 17647
			Other
		}

		// Token: 0x02000623 RID: 1571
		[Serializable]
		public sealed class StringMaker : Object
		{
			// Token: 0x06005557 RID: 21847 RVA: 0x0017E738 File Offset: 0x0017C938
			// Note: this type is marked as 'beforefieldinit'.
			static StringMaker()
			{
				Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StringMaker");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr);
				Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "aStrings");
				Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "cStringsMax");
				Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "cStringsUsed");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outStringBuilder");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outChars");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outIndex");
				Tokenizer.StringMaker.NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100671008);
				Tokenizer.StringMaker.NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100671009);
				Tokenizer.StringMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100671010);
				Tokenizer.StringMaker.NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100671011);
				Tokenizer.StringMaker.NativeMethodInfoPtr_MakeString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100671012);
			}

			// Token: 0x06005558 RID: 21848 RVA: 0x0017E840 File Offset: 0x0017CA40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208289, RefRangeEnd = 208290, XrefRangeStart = 208289, XrefRangeEnd = 208289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint HashString(string str)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005559 RID: 21849 RVA: 0x0017E884 File Offset: 0x0017CA84
			[CallerCount(0)]
			public unsafe static uint HashCharArray(Il2CppStructArray<char> a, int l)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600555A RID: 21850 RVA: 0x0017E8D4 File Offset: 0x0017CAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208290, XrefRangeEnd = 208296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringMaker()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600555B RID: 21851 RVA: 0x0017E910 File Offset: 0x0017CB10
			[CallerCount(0)]
			public unsafe bool CompareStringAndChars(string str, Il2CppStructArray<char> a, int l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600555C RID: 21852 RVA: 0x0017E980 File Offset: 0x0017CB80
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 208304, RefRangeEnd = 208307, XrefRangeStart = 208296, XrefRangeEnd = 208304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string MakeString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_MakeString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600555D RID: 21853 RVA: 0x000204F2 File Offset: 0x0001E6F2
			public StringMaker(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015E7 RID: 5607
			// (get) Token: 0x0600555E RID: 21854 RVA: 0x0017E9B8 File Offset: 0x0017CBB8
			// (set) Token: 0x0600555F RID: 21855 RVA: 0x000204FB File Offset: 0x0001E6FB
			public unsafe Il2CppStringArray aStrings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015E8 RID: 5608
			// (get) Token: 0x06005560 RID: 21856 RVA: 0x0017E9E8 File Offset: 0x0017CBE8
			// (set) Token: 0x06005561 RID: 21857 RVA: 0x0002051A File Offset: 0x0001E71A
			public unsafe uint cStringsMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax)) = value;
				}
			}

			// Token: 0x170015E9 RID: 5609
			// (get) Token: 0x06005562 RID: 21858 RVA: 0x0017EA10 File Offset: 0x0017CC10
			// (set) Token: 0x06005563 RID: 21859 RVA: 0x00020535 File Offset: 0x0001E735
			public unsafe uint cStringsUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed)) = value;
				}
			}

			// Token: 0x170015EA RID: 5610
			// (get) Token: 0x06005564 RID: 21860 RVA: 0x0017EA38 File Offset: 0x0017CC38
			// (set) Token: 0x06005565 RID: 21861 RVA: 0x00020550 File Offset: 0x0001E750
			public unsafe StringBuilder _outStringBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EB RID: 5611
			// (get) Token: 0x06005566 RID: 21862 RVA: 0x0017EA68 File Offset: 0x0017CC68
			// (set) Token: 0x06005567 RID: 21863 RVA: 0x0002056F File Offset: 0x0001E76F
			public unsafe Il2CppStructArray<char> _outChars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outChars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outChars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EC RID: 5612
			// (get) Token: 0x06005568 RID: 21864 RVA: 0x0017EA98 File Offset: 0x0017CC98
			// (set) Token: 0x06005569 RID: 21865 RVA: 0x0002058E File Offset: 0x0001E78E
			public unsafe int _outIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex)) = value;
				}
			}

			// Token: 0x040044F0 RID: 17648
			private static readonly IntPtr NativeFieldInfoPtr_aStrings;

			// Token: 0x040044F1 RID: 17649
			private static readonly IntPtr NativeFieldInfoPtr_cStringsMax;

			// Token: 0x040044F2 RID: 17650
			private static readonly IntPtr NativeFieldInfoPtr_cStringsUsed;

			// Token: 0x040044F3 RID: 17651
			private static readonly IntPtr NativeFieldInfoPtr__outStringBuilder;

			// Token: 0x040044F4 RID: 17652
			private static readonly IntPtr NativeFieldInfoPtr__outChars;

			// Token: 0x040044F5 RID: 17653
			private static readonly IntPtr NativeFieldInfoPtr__outIndex;

			// Token: 0x040044F6 RID: 17654
			private static readonly IntPtr NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0;

			// Token: 0x040044F7 RID: 17655
			private static readonly IntPtr NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x040044F8 RID: 17656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044F9 RID: 17657
			private static readonly IntPtr NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x040044FA RID: 17658
			private static readonly IntPtr NativeMethodInfoPtr_MakeString_Public_String_0;
		}

		// Token: 0x02000624 RID: 1572
		public class ITokenReader : Il2CppObjectBase
		{
			// Token: 0x0600556A RID: 21866 RVA: 0x000205A9 File Offset: 0x0001E7A9
			// Note: this type is marked as 'beforefieldinit'.
			static ITokenReader()
			{
				Il2CppClassPointerStore<Tokenizer.ITokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "ITokenReader");
				Tokenizer.ITokenReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.ITokenReader>.NativeClassPtr, 100671013);
			}

			// Token: 0x0600556B RID: 21867 RVA: 0x0017EAC0 File Offset: 0x0017CCC0
			[CallerCount(0)]
			public unsafe virtual int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tokenizer.ITokenReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600556C RID: 21868 RVA: 0x000205D3 File Offset: 0x0001E7D3
			public ITokenReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040044FB RID: 17659
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0;
		}

		// Token: 0x02000625 RID: 1573
		public class StreamTokenReader : Object
		{
			// Token: 0x0600556D RID: 21869 RVA: 0x0017EB08 File Offset: 0x0017CD08
			// Note: this type is marked as 'beforefieldinit'.
			static StreamTokenReader()
			{
				Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StreamTokenReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr);
				Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, "_in");
				Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, "_numCharRead");
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100671014);
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100671015);
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100671016);
			}

			// Token: 0x0600556E RID: 21870 RVA: 0x0017EB98 File Offset: 0x0017CD98
			[CallerCount(0)]
			public unsafe StreamTokenReader(StreamReader input)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StreamTokenReader.NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600556F RID: 21871 RVA: 0x0017EBE4 File Offset: 0x0017CDE4
			[CallerCount(0)]
			public unsafe virtual int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tokenizer.StreamTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015EF RID: 5615
			// (get) Token: 0x06005570 RID: 21872 RVA: 0x0017EC2C File Offset: 0x0017CE2C
			public unsafe int NumCharEncountered
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StreamTokenReader.NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005571 RID: 21873 RVA: 0x000205DC File Offset: 0x0001E7DC
			public StreamTokenReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015ED RID: 5613
			// (get) Token: 0x06005572 RID: 21874 RVA: 0x0017EC68 File Offset: 0x0017CE68
			// (set) Token: 0x06005573 RID: 21875 RVA: 0x000205E5 File Offset: 0x0001E7E5
			public unsafe StreamReader _in
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EE RID: 5614
			// (get) Token: 0x06005574 RID: 21876 RVA: 0x0017EC98 File Offset: 0x0017CE98
			// (set) Token: 0x06005575 RID: 21877 RVA: 0x00020604 File Offset: 0x0001E804
			public unsafe int _numCharRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead)) = value;
				}
			}

			// Token: 0x040044FC RID: 17660
			private static readonly IntPtr NativeFieldInfoPtr__in;

			// Token: 0x040044FD RID: 17661
			private static readonly IntPtr NativeFieldInfoPtr__numCharRead;

			// Token: 0x040044FE RID: 17662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0;

			// Token: 0x040044FF RID: 17663
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

			// Token: 0x04004500 RID: 17664
			private static readonly IntPtr NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0;
		}
	}
}
