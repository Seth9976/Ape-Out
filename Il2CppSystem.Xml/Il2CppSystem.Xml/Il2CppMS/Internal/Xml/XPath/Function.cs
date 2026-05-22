using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath
{
	// Token: 0x02000008 RID: 8
	public class Function : AstNode
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00014DDC File Offset: 0x00012FDC
		// Note: this type is marked as 'beforefieldinit'.
		static Function()
		{
			Il2CppClassPointerStore<Function>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Function");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Function>.NativeClassPtr);
			Function.NativeFieldInfoPtr_functionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "functionType");
			Function.NativeFieldInfoPtr_argumentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "argumentList");
			Function.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "name");
			Function.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "prefix");
			Function.NativeFieldInfoPtr_ReturnTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "ReturnTypes");
			Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100663320);
			Function.NativeMethodInfoPtr__ctor_Public_Void_String_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100663321);
			Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100663322);
			Function.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100663323);
			Function.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00014ED4 File Offset: 0x000130D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388792, XrefRangeEnd = 388796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(Function.FunctionType ftype, ArrayList argumentList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ftype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00014F30 File Offset: 0x00013130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388796, XrefRangeEnd = 388800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(string prefix, string name, ArrayList argumentList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Public_Void_String_String_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00014FA0 File Offset: 0x000131A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388805, RefRangeEnd = 388807, XrefRangeStart = 388800, XrefRangeEnd = 388805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(Function.FunctionType ftype, AstNode arg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ftype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00014FFC File Offset: 0x000131FC
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Function.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00015044 File Offset: 0x00013244
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388807, XrefRangeEnd = 388811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Function.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002220 File Offset: 0x00000420
		public Function(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0001508C File Offset: 0x0001328C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002229 File Offset: 0x00000429
		public unsafe Function.FunctionType functionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_functionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_functionType)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000150B4 File Offset: 0x000132B4
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe ArrayList argumentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_argumentList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_argumentList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000150E4 File Offset: 0x000132E4
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002263 File Offset: 0x00000463
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0001510C File Offset: 0x0001330C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002282 File Offset: 0x00000482
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00015134 File Offset: 0x00013334
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000022A1 File Offset: 0x000004A1
		public unsafe static Il2CppStructArray<XPathResultType> ReturnTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Function.NativeFieldInfoPtr_ReturnTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Function.NativeFieldInfoPtr_ReturnTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_functionType;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_argumentList;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_ReturnTypes;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FunctionType_ArrayList_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_ArrayList_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

		// Token: 0x020001F3 RID: 499
		[OriginalName("System.Xml.dll", "", "FunctionType")]
		public enum FunctionType
		{
			// Token: 0x04001FBE RID: 8126
			FuncLast,
			// Token: 0x04001FBF RID: 8127
			FuncPosition,
			// Token: 0x04001FC0 RID: 8128
			FuncCount,
			// Token: 0x04001FC1 RID: 8129
			FuncID,
			// Token: 0x04001FC2 RID: 8130
			FuncLocalName,
			// Token: 0x04001FC3 RID: 8131
			FuncNameSpaceUri,
			// Token: 0x04001FC4 RID: 8132
			FuncName,
			// Token: 0x04001FC5 RID: 8133
			FuncString,
			// Token: 0x04001FC6 RID: 8134
			FuncBoolean,
			// Token: 0x04001FC7 RID: 8135
			FuncNumber,
			// Token: 0x04001FC8 RID: 8136
			FuncTrue,
			// Token: 0x04001FC9 RID: 8137
			FuncFalse,
			// Token: 0x04001FCA RID: 8138
			FuncNot,
			// Token: 0x04001FCB RID: 8139
			FuncConcat,
			// Token: 0x04001FCC RID: 8140
			FuncStartsWith,
			// Token: 0x04001FCD RID: 8141
			FuncContains,
			// Token: 0x04001FCE RID: 8142
			FuncSubstringBefore,
			// Token: 0x04001FCF RID: 8143
			FuncSubstringAfter,
			// Token: 0x04001FD0 RID: 8144
			FuncSubstring,
			// Token: 0x04001FD1 RID: 8145
			FuncStringLength,
			// Token: 0x04001FD2 RID: 8146
			FuncNormalize,
			// Token: 0x04001FD3 RID: 8147
			FuncTranslate,
			// Token: 0x04001FD4 RID: 8148
			FuncLang,
			// Token: 0x04001FD5 RID: 8149
			FuncSum,
			// Token: 0x04001FD6 RID: 8150
			FuncFloor,
			// Token: 0x04001FD7 RID: 8151
			FuncCeiling,
			// Token: 0x04001FD8 RID: 8152
			FuncRound,
			// Token: 0x04001FD9 RID: 8153
			FuncUserDefined
		}
	}
}
