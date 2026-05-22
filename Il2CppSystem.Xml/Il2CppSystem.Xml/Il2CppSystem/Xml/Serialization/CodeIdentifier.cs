using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.CSharp;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BA RID: 186
	public class CodeIdentifier : Object
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x0005E280 File Offset: 0x0005C480
		// Note: this type is marked as 'beforefieldinit'.
		static CodeIdentifier()
		{
			Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "CodeIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr);
			CodeIdentifier.NativeFieldInfoPtr_csharp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, "csharp");
			CodeIdentifier.NativeMethodInfoPtr_MakePascal_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666025);
			CodeIdentifier.NativeMethodInfoPtr_MakeValid_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666026);
			CodeIdentifier.NativeMethodInfoPtr_IsValidStart_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666027);
			CodeIdentifier.NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeIdentifier>.NativeClassPtr, 100666028);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0005E314 File Offset: 0x0005C514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403483, XrefRangeEnd = 403492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakePascal(string identifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_MakePascal_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0005E350 File Offset: 0x0005C550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403511, RefRangeEnd = 403512, XrefRangeStart = 403492, XrefRangeEnd = 403511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeValid(string identifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_MakeValid_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0005E38C File Offset: 0x0005C58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403516, RefRangeEnd = 403517, XrefRangeStart = 403512, XrefRangeEnd = 403516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidStart(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_IsValidStart_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0005E3CC File Offset: 0x0005C5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403521, RefRangeEnd = 403522, XrefRangeStart = 403517, XrefRangeEnd = 403521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeIdentifier.NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000078DC File Offset: 0x00005ADC
		public CodeIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0005E40C File Offset: 0x0005C60C
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x000078E5 File Offset: 0x00005AE5
		public unsafe static CodeDomProvider csharp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CodeIdentifier.NativeFieldInfoPtr_csharp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodeDomProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodeIdentifier.NativeFieldInfoPtr_csharp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeFieldInfoPtr_csharp;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_MakePascal_Public_Static_String_String_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_MakeValid_Public_Static_String_String_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_IsValidStart_Private_Static_Boolean_Char_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Char_0;
	}
}
