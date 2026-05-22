using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000270 RID: 624
	public static class ScriptLocalization : Object
	{
		// Token: 0x060046A5 RID: 18085 RVA: 0x001078C4 File Offset: 0x00105AC4
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptLocalization()
		{
			Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ScriptLocalization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr);
			ScriptLocalization.NativeMethodInfoPtr_get_ON_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670453);
			ScriptLocalization.NativeMethodInfoPtr_get_OFF_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670454);
			ScriptLocalization.NativeMethodInfoPtr_get_WINDOWED_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670455);
			ScriptLocalization.NativeMethodInfoPtr_get_EXCLUSIVE_FULLSCREEN_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670456);
			ScriptLocalization.NativeMethodInfoPtr_get_FULLSCREEN_WINDOW_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670457);
			ScriptLocalization.NativeMethodInfoPtr_get_LOADING_SCORES_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670458);
			ScriptLocalization.NativeMethodInfoPtr_get_FAILED_TO_CONNECT_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670459);
			ScriptLocalization.NativeMethodInfoPtr_get_PRESS_KEY_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670460);
			ScriptLocalization.NativeMethodInfoPtr_get_SCORE_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670461);
			ScriptLocalization.NativeMethodInfoPtr_get_HIGH_SCORE_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670462);
			ScriptLocalization.NativeMethodInfoPtr_get_NEW_HIGH_SCORE_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, 100670463);
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x001079D0 File Offset: 0x00105BD0
		public unsafe static string ON
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 115678, RefRangeEnd = 115682, XrefRangeStart = 115672, XrefRangeEnd = 115678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_ON_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x001079FC File Offset: 0x00105BFC
		public unsafe static string OFF
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 115688, RefRangeEnd = 115691, XrefRangeStart = 115682, XrefRangeEnd = 115688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_OFF_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00107A28 File Offset: 0x00105C28
		public unsafe static string WINDOWED
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115697, RefRangeEnd = 115698, XrefRangeStart = 115691, XrefRangeEnd = 115697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_WINDOWED_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x00107A54 File Offset: 0x00105C54
		public unsafe static string EXCLUSIVE_FULLSCREEN
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115704, RefRangeEnd = 115705, XrefRangeStart = 115698, XrefRangeEnd = 115704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_EXCLUSIVE_FULLSCREEN_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x00107A80 File Offset: 0x00105C80
		public unsafe static string FULLSCREEN_WINDOW
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115711, RefRangeEnd = 115712, XrefRangeStart = 115705, XrefRangeEnd = 115711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_FULLSCREEN_WINDOW_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x00107AAC File Offset: 0x00105CAC
		public unsafe static string LOADING_SCORES
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115712, XrefRangeEnd = 115718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_LOADING_SCORES_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x00107AD8 File Offset: 0x00105CD8
		public unsafe static string FAILED_TO_CONNECT
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115718, XrefRangeEnd = 115724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_FAILED_TO_CONNECT_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060046AD RID: 18093 RVA: 0x00107B04 File Offset: 0x00105D04
		public unsafe static string PRESS_KEY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115724, XrefRangeEnd = 115730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_PRESS_KEY_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x00107B30 File Offset: 0x00105D30
		public unsafe static string SCORE
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115730, XrefRangeEnd = 115736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_SCORE_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x00107B5C File Offset: 0x00105D5C
		public unsafe static string HIGH_SCORE
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115736, XrefRangeEnd = 115742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_HIGH_SCORE_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x00107B88 File Offset: 0x00105D88
		public unsafe static string NEW_HIGH_SCORE
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115742, XrefRangeEnd = 115748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.NativeMethodInfoPtr_get_NEW_HIGH_SCORE_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x00029F4D File Offset: 0x0002814D
		public ScriptLocalization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeMethodInfoPtr_get_ON_Public_Static_get_String_0;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeMethodInfoPtr_get_OFF_Public_Static_get_String_0;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeMethodInfoPtr_get_WINDOWED_Public_Static_get_String_0;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeMethodInfoPtr_get_EXCLUSIVE_FULLSCREEN_Public_Static_get_String_0;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeMethodInfoPtr_get_FULLSCREEN_WINDOW_Public_Static_get_String_0;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeMethodInfoPtr_get_LOADING_SCORES_Public_Static_get_String_0;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeMethodInfoPtr_get_FAILED_TO_CONNECT_Public_Static_get_String_0;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeMethodInfoPtr_get_PRESS_KEY_Public_Static_get_String_0;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeMethodInfoPtr_get_SCORE_Public_Static_get_String_0;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeMethodInfoPtr_get_HIGH_SCORE_Public_Static_get_String_0;

		// Token: 0x04002C3B RID: 11323
		private static readonly IntPtr NativeMethodInfoPtr_get_NEW_HIGH_SCORE_Public_Static_get_String_0;

		// Token: 0x020003DF RID: 991
		public static class Menu : Object
		{
			// Token: 0x06005A9D RID: 23197 RVA: 0x00147424 File Offset: 0x00145624
			// Note: this type is marked as 'beforefieldinit'.
			static Menu()
			{
				Il2CppClassPointerStore<ScriptLocalization.Menu>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptLocalization>.NativeClassPtr, "Menu");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptLocalization.Menu>.NativeClassPtr);
				ScriptLocalization.Menu.NativeMethodInfoPtr_get_HARDER_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization.Menu>.NativeClassPtr, 100670464);
				ScriptLocalization.Menu.NativeMethodInfoPtr_get_SOFTER_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLocalization.Menu>.NativeClassPtr, 100670465);
			}

			// Token: 0x170020F9 RID: 8441
			// (get) Token: 0x06005A9E RID: 23198 RVA: 0x00147478 File Offset: 0x00145678
			public unsafe static string HARDER
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115660, XrefRangeEnd = 115666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.Menu.NativeMethodInfoPtr_get_HARDER_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170020FA RID: 8442
			// (get) Token: 0x06005A9F RID: 23199 RVA: 0x001474A4 File Offset: 0x001456A4
			public unsafe static string SOFTER
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115666, XrefRangeEnd = 115672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLocalization.Menu.NativeMethodInfoPtr_get_SOFTER_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005AA0 RID: 23200 RVA: 0x00033BF9 File Offset: 0x00031DF9
			public Menu(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003C2D RID: 15405
			private static readonly IntPtr NativeMethodInfoPtr_get_HARDER_Public_Static_get_String_0;

			// Token: 0x04003C2E RID: 15406
			private static readonly IntPtr NativeMethodInfoPtr_get_SOFTER_Public_Static_get_String_0;
		}
	}
}
