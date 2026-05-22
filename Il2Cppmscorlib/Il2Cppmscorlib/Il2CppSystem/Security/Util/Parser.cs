using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002C8 RID: 712
	public sealed class Parser : Object
	{
		// Token: 0x0600304C RID: 12364 RVA: 0x000F4B38 File Offset: 0x000F2D38
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr__doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "_doc");
			Parser.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "_t");
			Parser.NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670996);
			Parser.NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670997);
			Parser.NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670998);
			Parser.NativeMethodInfoPtr_ParseContents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670999);
			Parser.NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100671000);
			Parser.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100671001);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000F4C08 File Offset: 0x000F2E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208152, XrefRangeEnd = 208153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetTopElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000F4C48 File Offset: 0x000F2E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208197, RefRangeEnd = 208198, XrefRangeStart = 208153, XrefRangeEnd = 208197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRequiredSizes(TokenizerStream stream, ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000F4C98 File Offset: 0x000F2E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208220, RefRangeEnd = 208221, XrefRangeStart = 208198, XrefRangeEnd = 208220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DetermineFormat(TokenizerStream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000F4CE8 File Offset: 0x000F2EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208270, RefRangeEnd = 208271, XrefRangeStart = 208221, XrefRangeEnd = 208270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ParseContents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000F4D1C File Offset: 0x000F2F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208277, RefRangeEnd = 208278, XrefRangeStart = 208271, XrefRangeEnd = 208277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(Tokenizer t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000F4D68 File Offset: 0x000F2F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208287, RefRangeEnd = 208289, XrefRangeStart = 208278, XrefRangeEnd = 208287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(string input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x00010AF8 File Offset: 0x0000ECF8
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x000F4DB4 File Offset: 0x000F2FB4
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x00010B01 File Offset: 0x0000ED01
		public unsafe SecurityDocument _doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x000F4DE4 File Offset: 0x000F2FE4
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x00010B20 File Offset: 0x0000ED20
		public unsafe Tokenizer _t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeFieldInfoPtr__doc;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeFieldInfoPtr__t;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0;

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeMethodInfoPtr_ParseContents_Private_Void_0;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;
	}
}
