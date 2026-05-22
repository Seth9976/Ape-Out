using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x0200025D RID: 605
	public class HindiFixer : Object
	{
		// Token: 0x06004604 RID: 17924 RVA: 0x00105594 File Offset: 0x00103794
		// Note: this type is marked as 'beforefieldinit'.
		static HindiFixer()
		{
			Il2CppClassPointerStore<HindiFixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "HindiFixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HindiFixer>.NativeClassPtr);
			HindiFixer.NativeMethodInfoPtr_Fix_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HindiFixer>.NativeClassPtr, 100670367);
			HindiFixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HindiFixer>.NativeClassPtr, 100670368);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x001055EC File Offset: 0x001037EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114269, RefRangeEnd = 114270, XrefRangeStart = 114241, XrefRangeEnd = 114269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Fix(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HindiFixer.NativeMethodInfoPtr_Fix_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00105628 File Offset: 0x00103828
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HindiFixer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HindiFixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HindiFixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00029BFD File Offset: 0x00027DFD
		public HindiFixer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr_Fix_Internal_Static_String_String_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D7 RID: 983
		[ObfuscatedName("I2.Loc.HindiFixer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005A7B RID: 23163 RVA: 0x00146EDC File Offset: 0x001450DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HindiFixer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr);
				HindiFixer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr, "<>9");
				HindiFixer.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr, "<>9__0_0");
				HindiFixer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr, 100670370);
				HindiFixer.__c.NativeMethodInfoPtr__Fix_b__0_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr, 100670371);
			}

			// Token: 0x06005A7C RID: 23164 RVA: 0x00146F58 File Offset: 0x00145158
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HindiFixer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HindiFixer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A7D RID: 23165 RVA: 0x00146F94 File Offset: 0x00145194
			[CallerCount(0)]
			public unsafe bool _Fix_b__0_0(char x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HindiFixer.__c.NativeMethodInfoPtr__Fix_b__0_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A7E RID: 23166 RVA: 0x00033AED File Offset: 0x00031CED
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020F1 RID: 8433
			// (get) Token: 0x06005A7F RID: 23167 RVA: 0x00146FE0 File Offset: 0x001451E0
			// (set) Token: 0x06005A80 RID: 23168 RVA: 0x00033AF6 File Offset: 0x00031CF6
			public unsafe static HindiFixer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HindiFixer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HindiFixer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HindiFixer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020F2 RID: 8434
			// (get) Token: 0x06005A81 RID: 23169 RVA: 0x00147008 File Offset: 0x00145208
			// (set) Token: 0x06005A82 RID: 23170 RVA: 0x00033B08 File Offset: 0x00031D08
			public unsafe static Func<char, bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HindiFixer.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HindiFixer.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C1D RID: 15389
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003C1E RID: 15390
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04003C1F RID: 15391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C20 RID: 15392
			private static readonly IntPtr NativeMethodInfoPtr__Fix_b__0_0_Internal_Boolean_Char_0;
		}
	}
}
